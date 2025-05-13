using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myth_Weaver.Classes
{
    public class WorldEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; } 
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public List<string> Tags { get; set; } = new List<string>();


    }

    public class Article : WorldEntity
    {
        public string Content { get; set; }
        public List<Guid> RelatedArticles { get; set; } = new List<Guid>();
        public Guid? CategoryID { get; set; }
    }

    public class Character : WorldEntity
    {
        public string Backstory { get; set; }
        public List<Guid> Relationships { get; set; } = new List<Guid>();
        public Guid? LocationID { get; set; }
        public Guid? Stats { get; set; }
    }

    public class TimelineEvent : WorldEntity
    {
        public List<Guid>? PriorEvents { get; set; }
        public List<Guid>? RelatedWorldEntities {  get; set; }
        public Guid Category {  get; set; }
        public String Content { get; set; }

    }
}
