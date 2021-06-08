using allendelacruz.github.io.Common.Enums;
using allendelacruz.github.io.Common.Models;
using System.Collections.Generic;
using System.Linq;

namespace allendelacruz.github.io.Common.Repositories
{
    public class TechStackRepository
    {
        private ICollection<TechStack> TechStacks()
        {
            return new List<TechStack>()
            {
                new TechStack { Id = TechStackEnum.HTML, Name = "HTML" },
                new TechStack { Id = TechStackEnum.JavaScript, Name = "JavaScript" },
                new TechStack { Id = TechStackEnum.CSS, Name = "CSS" },
                new TechStack { Id = TechStackEnum.CSharp, Name = "C#" },
                new TechStack { Id = TechStackEnum.ASPNET_WebForms, Name = "ASP.NET (WebForms)" },
                new TechStack { Id = TechStackEnum.ASPNET_MVC, Name = "ASP.NET (MVC)" },
                new TechStack { Id = TechStackEnum.ASPNET_Blazor_WASM, Name = "ASP.NET (Blazor WASM)" },
                new TechStack { Id = TechStackEnum.ASPNET_WebAPI, Name = "ASP.NET (WebAPI)" },
                new TechStack { Id = TechStackEnum.ASPNET_SignalR, Name = "ASP.NET (SignalR)" },
                new TechStack { Id = TechStackEnum.EntityFramework, Name = "Entity Framework" },
                new TechStack { Id = TechStackEnum.XamarinForms, Name = "Xamarin.Forms" },
                new TechStack { Id = TechStackEnum.SQL, Name = "SQL" },
                new TechStack { Id = TechStackEnum.SQLite, Name = "SQLite" },
                new TechStack { Id = TechStackEnum.PWA, Name = "PWA" },
                new TechStack { Id = TechStackEnum.CleanArchitecture, Name = "Clean Architecture" },
                new TechStack { Id = TechStackEnum.CQRS, Name = "CQRS" },
                new TechStack { Id = TechStackEnum.RepositoryPattern, Name = "Repository Pattern" },
                new TechStack { Id = TechStackEnum.UnitTest, Name = "Unit Test" },
                new TechStack { Id = TechStackEnum.MVVM, Name = "MVVM" }
            };
        }

        public IEnumerable<TechStack> GetTechStacks()
            => TechStacks().ToList();

        public TechStack GetTechStack(TechStackEnum id)
            => TechStacks().SingleOrDefault(x => x.Id == id);
    }
}
