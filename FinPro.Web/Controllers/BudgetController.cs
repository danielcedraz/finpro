using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FinanciamentoProjetos.Domain.DTO;
using FinanciamentoProjetos.Domain.Entities;
using FinanciamentoProjetos.Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinPro.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        private readonly IHttpContextAccessor _accessor;
        private IBudgetService _budgetService;
        private IUserService _userService;
        public BudgetController(IHttpContextAccessor accessor, IBudgetService BudgetService, IUserService UserService)
        {
            _accessor = accessor;
            _budgetService = BudgetService;
            _userService = UserService;
        }

        [HttpPost]
        [Route("List")]
        [Authorize]
        public ActionResult<List<BudgetDTO>> List()
        {
            try
            {
                var email = _accessor.HttpContext.User.Claims.Where(c => c.Type == ClaimTypes.Email).FirstOrDefault().Value;
                var user = _userService.FindUserByEmail(email);
                var lista = _budgetService
                    .BudgetList(user.Id)
                    .Select(b => new BudgetDTO()
                    {
                        Id = b.Id,
                        DateTime = b.DateTime,
                        FullStackAmount = b.FullStackAmount,
                        DesignerAmount = b.DesignerAmount,
                        ScrumMasterAmount = b.ScrumMasterAmount,
                        ProjectOwnerAmount = b.ProjectOwnerAmount,
                        DurationDays = b.DurationDays,
                        Value = b.Value,
                        Customer = new UserDTO()
                        {
                            Id = b.Customer.Id,
                            Email = b.Customer.Email,
                            Name = b.Customer.UserName
                        }
                    })
                    .ToList();

                return lista;
            } catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
