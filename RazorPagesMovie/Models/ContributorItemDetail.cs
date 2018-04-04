using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class ContributorItemDetail
    {
        public List<Connection> connections;
        public string contributorId;
        public List<Property> dimensions;
        public string itemChangeId;
        public int insulationThickness;
        public string insulationType;
        public int linerThickness;
        public string linerType;
        public Location location;
        public ModelChange modelChange;
        public List<Property> pricing;
        public List<Property> properties;
               
    }
}
