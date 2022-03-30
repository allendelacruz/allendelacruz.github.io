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
                new TechStack { Id = TechStackEnum.ASPNET_Blazor_Server, Name = "ASP.NET (Blazor Server)" },
                new TechStack { Id = TechStackEnum.ASPNET_Blazor_WASM, Name = "ASP.NET (Blazor WASM)" },
                new TechStack { Id = TechStackEnum.ASPNET_SignalR, Name = "ASP.NET (SignalR)" },
                new TechStack { Id = TechStackEnum.ASPNET_WebAPI, Name = "ASP.NET (WebAPI)" },
                new TechStack { Id = TechStackEnum.ASPNET_WebService, Name = "ASP.NET (WebService)" },
                new TechStack { Id = TechStackEnum.ASPNET_WebHandler, Name = "ASP.NET (WebHandler)" },
                new TechStack { Id = TechStackEnum.ADO_NET, Name = "ADO.NET" },
                new TechStack { Id = TechStackEnum.EntityFramework_CodeFirst, Name = "Entity Framework (Code First)" },
                new TechStack { Id = TechStackEnum.EntityFramework_DatabaseFirst, Name = "Entity Framework (Database First)" },
                new TechStack { Id = TechStackEnum.XamarinForms, Name = "Xamarin.Forms" },
                new TechStack { Id = TechStackEnum.SQLServer, Name = "SQL Server" },
                new TechStack { Id = TechStackEnum.SQLite, Name = "SQLite" },
                new TechStack { Id = TechStackEnum.IndexedDB, Name = "IndexedDB" },
                new TechStack { Id = TechStackEnum.PWA, Name = "PWA" },
                new TechStack { Id = TechStackEnum.CleanArchitecture, Name = "Clean Architecture" },
                new TechStack { Id = TechStackEnum.CQRS, Name = "CQRS" },
                new TechStack { Id = TechStackEnum.RepositoryPattern, Name = "Repository Pattern" },
                new TechStack { Id = TechStackEnum.UnitTest, Name = "Unit Test" },
                new TechStack { Id = TechStackEnum.MVVM, Name = "MVVM" },
                new TechStack { Id = TechStackEnum.SQLServer_StoredProcedure, Name = "SQL Server (Stored Procedure)" },
                new TechStack { Id = TechStackEnum.AWS_EC2, Name = "AWS (EC2)" },
                new TechStack { Id = TechStackEnum.AWS_RDS, Name = "AWS (RDS)" },
                new TechStack { Id = TechStackEnum.RingCentral_SMS_API, Name = "Ring Central (SMS API)" },
                new TechStack { Id = TechStackEnum.Twilio_SMS_API, Name = "Twilio (SMS API)" }
            };
        }

        public IEnumerable<TechStack> GetTechStacks()
            => TechStacks().ToList();

        public TechStack GetTechStack(TechStackEnum id)
            => TechStacks().SingleOrDefault(x => x.Id == id);
    }
}
