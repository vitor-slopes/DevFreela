using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devfreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core1", "Minha descrição de projeto1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core2", "Minha descrição de projeto2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core3", "Minha descrição de projeto3", 1, 1, 30000)

            };

            Users = new List<User>
            {
                new User("Vitor", "emai@vitor.com",new DateTime(1985, 6, 1)),
                new User("Rafael", "emai@rafael.com",new DateTime(1981, 2, 17)),
                new User("Lucia", "emai@lucia.com",new DateTime(1954, 3, 22))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }
        public List<Project> Projects { get; private set; }
        public List<User> Users{ get; private set; }
        public List<Skill> Skills { get; private set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
