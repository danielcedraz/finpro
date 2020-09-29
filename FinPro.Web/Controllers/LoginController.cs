using System;
using System.Collections.Generic;
using FinanciamentoProjetos.Domain.DTO;
using FinanciamentoProjetos.Domain.Entities;
using FinanciamentoProjetos.Domain.Services;
using FinanciamentoProjetos.Domain.Services.Authentication;
using FinanciamentoProjetos.Infra;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinPro.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration Configuration { get; }
        private IUserService userService;

        public LoginController(IConfiguration configuration, IUserService UserService)
        {
            Configuration = configuration;
            userService = UserService;
        }

        [HttpPost]
        [Route("Authenticate")]
        [AllowAnonymous]
        public ActionResult<UserDTO> Authenticate([FromBody] UserDTO User)
        {
            try
            {
                var user = userService.LoginUser(User.Email, CriptographicService.EncriptPassword(User.Password));

                if (user == null)
                    throw new Exception("Usuário ou senha incorretos.");

                User.Token = TokenService.GenerateToken(user, Configuration["AppSettings:ServerSecret"]);

                return User;
            } catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        [Route("StateList")]
        [AllowAnonymous]
        public ActionResult<List<State>> StateList()
        {
            try
            {
                var states = userService.StateList();

                return states;
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        [Route("Register")]
        [AllowAnonymous]
        public ActionResult<UserRegisterDTO> Register(UserRegisterDTO UserRegister)
        {
            try
            {
                var newUser = new User()
                {
                    UserName = UserRegister.UserName,
                    LastName = UserRegister.LastName,
                    Email = UserRegister.Email,
                    Password = CriptographicService.EncriptPassword(UserRegister.Password),
                    CPF = Convert.ToInt64(UserRegister.CPF.Replace(".","").Replace("-","")),
                    CompanyName = UserRegister.CompanyName,
                    CNPJ = Convert.ToInt64(UserRegister.CNPJ.Replace(".", "").Replace("-", "").Replace("/","")),
                    CEP = Convert.ToInt32(UserRegister.CEP.Replace(".", "").Replace("-", "")),
                    Address = UserRegister.Address,
                    AddressNumber = UserRegister.AddressNumber,
                    AddressComplement = UserRegister.AddressComplement,
                    IdAddressState = UserRegister.AddressState.UF,
                    AddressCity = UserRegister.AddressCity,
                    PhoneNumber = Convert.ToInt64(UserRegister.PhoneNumber.Replace(" ", "").Replace("-", "")),
                };

                var user = userService.RegisterUser(newUser);


                UserRegister.Id = user.Id;

                return UserRegister;
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
