using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Connection
    {
        public ConnectedTo connectedTo;
        public ConnectionDirection connectionDirection;
        public int connectionID;
        public ConnectionOtherDirection connectedOtherDirection;
        public int diameter;
        public string discipline;
        public int flow;
        public int height;
        public int inset;
        public Boolean isConnected;
        public Location location;
        public List<Property> properties;
        public string shape;
        public int slope;
        public string system;
        public int width;
    }
}
