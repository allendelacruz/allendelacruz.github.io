using allendelacruz.github.io.Common.Enums;
using allendelacruz.github.io.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace allendelacruz.github.io.Common.Repositories
{
    public class ProjectRepository
    {
        private TechStackRepository techStackRepository = new();

        private ICollection<Project> Projects()
        {
            var projectThumbs = new List<Project>();

            projectThumbs.Add(new Project
            {
                Id = "movie-explorer",
                Title = "Movie Explorer",
                Description = "Movie management for PC and external storage."
            });

            projectThumbs.Add(new Project
            {
                Id = "notehub",
                Title = "NoteHub",
                Description = "A note taking web app."
            });

            //projectThumbs.Add(new Project
            //{
            //    Id = "messaging",
            //    Title = "Messaging",
            //    Description = "A real-time messaging web app."
            //});

            //projectThumbs.Add(new Project
            //{
            //    Id = "teller-mobile",
            //    Title = "Teller (Mobile)",
            //    Description = "A mobile app for encode transactions, monitor their progress, and organize their workday."
            //});

            //projectThumbs.Add(new Project
            //{
            //    Id = "teller-pwa",
            //    Title = "Teller (PWA)",
            //    Description = "A progressive web app for encode transactions, monitor their progress, and organize their workday."
            //});

            //projectThumbs.Add(new Project
            //{
            //    Id = "skyark",
            //    Title = "SkyArk",
            //    Description = "A web-based documentation system."
            //});

            projectThumbs.Add(new Project
            {
                Id = "garage-crm",
                Title = "Garage CRM",
                Description = "POS style auto repair shop."
            });

            //projectThumbs.Add(new Project
            //{
            //    Id = "orion",
            //    Title = "Orion",
            //    Description = "Recruitment and hotel management system."
            //});

            //projectThumbs.Add(new Project
            //{
            //    Id = "hfms",
            //    Title = "HFMS",
            //    Description = "Dental, Donation and Fund management web application."
            //});

            foreach (var project in projectThumbs)
            {
                if (project.Id.Equals("movie-explorer", StringComparison.OrdinalIgnoreCase))
                {
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.HTML));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.JavaScript));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSS));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSharp));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ASPNET_Blazor_WASM));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ASPNET_WebAPI));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.XamarinForms));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.EntityFramework_CodeFirst));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQLite));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.RepositoryPattern));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.MVVM));
                }
                else if (project.Id.Equals("notehub", StringComparison.OrdinalIgnoreCase))
                {
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.HTML));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.JavaScript));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSS));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSharp));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ASPNET_WebAPI));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.EntityFramework_CodeFirst));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQLServer));
                }
                else if (project.Id.Equals("messaging", StringComparison.OrdinalIgnoreCase))
                {
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.HTML));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.JavaScript));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSS));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSharp));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ASPNET_WebForms));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ASPNET_SignalR));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ASPNET_WebService));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ASPNET_WebHandler));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ADO_NET));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQLServer));
                }
                else if (project.Id.Equals("teller-mobile", StringComparison.OrdinalIgnoreCase))
                {
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSharp));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.XamarinForms));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.EntityFramework_CodeFirst));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQLite));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.RepositoryPattern));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CQRS));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.MVVM));
                }
                else if (project.Id.Equals("teller-pwa", StringComparison.OrdinalIgnoreCase))
                {
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.HTML));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.JavaScript));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSS));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSharp));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ASPNET_Blazor_WASM));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.IndexedDB));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.PWA));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CleanArchitecture));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CQRS));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.UnitTest));
                }
                else if (project.Id.Equals("skyark", StringComparison.OrdinalIgnoreCase))
                {
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.HTML));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.JavaScript));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSS));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSharp));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ASPNET_WebForms));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ADO_NET));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQLServer));
                }
                else if (project.Id.Equals("garage-crm", StringComparison.OrdinalIgnoreCase))
                {
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.HTML));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.JavaScript));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSS));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSharp));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ASPNET_Blazor_Server));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ADO_NET));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQLServer));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQLServer_StoredProcedure));
                }
                else if (project.Id.Equals("orion", StringComparison.OrdinalIgnoreCase))
                {
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.HTML));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.JavaScript));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSS));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSharp));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ASPNET_Blazor_Server));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.EntityFramework_DatabaseFirst));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQLServer));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQLServer_StoredProcedure));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.RingCentral_SMS_API));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.Twilio_SMS_API));
                }
                else if (project.Id.Equals("hfms", StringComparison.OrdinalIgnoreCase))
                {
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.HTML));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.JavaScript));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSS));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSharp));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ASPNET_Blazor_Server));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.EntityFramework_DatabaseFirst));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQLServer));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQLServer_StoredProcedure));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.Twilio_SMS_API));
                }
            }

            return projectThumbs;
        }

        public IEnumerable<Project> GetProjects()
            => Projects().ToList();

        public Project GetProject(string id)
            => Projects().SingleOrDefault(x => x.Id == id);
    }
}