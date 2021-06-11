using System.Collections.Generic;

namespace allendelacruz.github.io.Common.Models
{
    public class Project
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<TechStack> TechStacks { get; set; }

        public Project()
            => TechStacks = new List<TechStack>();
    }
}
