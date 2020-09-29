using FinanciamentoProjetos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace FinanciamentoProjetos.Infra
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Budget> Budget { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var states = LerArquivoJson<State[]>(".\\PrimaryData\\State.json");

            modelBuilder.Entity<State>().HasData(states);

            base.OnModelCreating(modelBuilder);
        }

        private static T LerArquivoJson<T>(string arquivo)
        {
            using (StreamReader r = new StreamReader(arquivo, Encoding.UTF8))
            {
                string json = r.ReadToEnd();
                var jsonObject = (T)JsonConvert.DeserializeObject(json, typeof(T));

                return jsonObject;
            }
        }
    }
}
