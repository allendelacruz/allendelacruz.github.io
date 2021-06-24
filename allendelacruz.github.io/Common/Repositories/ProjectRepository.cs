using allendelacruz.github.io.Common.Enums;
using allendelacruz.github.io.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace allendelacruz.github.io.Common.Repositories
{
    public class ProjectRepository
    {
        private TechStackRepository techStackRepository = new TechStackRepository();

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

            projectThumbs.Add(new Project
            {
                Id = "messaging",
                Title = "Messaging",
                Description = "A real-time messaging web app."
            });

            projectThumbs.Add(new Project
            {
                Id = "teller-mobile",
                Title = "Teller (Mobile)",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc quam urna."
            });

            projectThumbs.Add(new Project
            {
                Id = "teller-pwa",
                Title = "Teller (PWA)",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc quam urna."
            });

            projectThumbs.Add(new Project
            {
                Id = "skyark",
                Title = "SkyArk",
                Description = "A web-based documentation system."
            });

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
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.EntityFramework));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQLite));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.PWA));
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
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.EntityFramework));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQL));
                }
                else if (project.Id.Equals("messaging", StringComparison.OrdinalIgnoreCase))
                {
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.HTML));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.JavaScript));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSS));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSharp));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ASPNET_WebForms));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.ASPNET_SignalR));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQL));
                }
                else if (project.Id.Equals("teller-mobile", StringComparison.OrdinalIgnoreCase))
                {
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.CSharp));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.XamarinForms));
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.EntityFramework));
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
                    project.TechStacks.Add(techStackRepository.GetTechStack(TechStackEnum.SQL));
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