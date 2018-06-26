using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vegaAPI.Controllers.Resources
{
    public class MakeResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelResources> Models { get; set; }
        public MakeResource()
        {
            Models = new Collection<ModelResources>();
        }
    }
}