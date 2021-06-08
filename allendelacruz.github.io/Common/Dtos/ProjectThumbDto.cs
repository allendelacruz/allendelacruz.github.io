using allendelacruz.github.io.Common.Models;
using System.Collections.Generic;

namespace allendelacruz.github.io.Common.Dtos
{
    public class ProjectThumbDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<TechStack> TechStacks { get; }

        public ProjectThumbDto()
            => TechStacks = new List<TechStack>();

        //private ProjectThumbDto(TechStack techStack)
        //    => TechStacks.Add(techStack);

        //public static ProjectThumbDto AddTechStack(TechStack techStack)
        //    => new ProjectThumbDto(techStack);
    }
}
