using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/*using System.Text.Json;
using System.Text.Json.Serialization;*/

namespace CourseWork.Data
{
    public class Sharing : Base<Sharing>
    {
      
        public Sharing() : base() { }
        public Sharing(Route r, Station s, bool fl) : base(fl)
        {
            Route = r;
            Station = s;
        }
        public Guid _routeId;
        [JsonIgnore]
        public Route Route
        {
            get { return Route.Items[_routeId]; }
            set { _routeId = value.Id; }
        }
        public Guid _stationId;
        [JsonIgnore]
        public Station Station
        {
            get { return Station.Items[_stationId]; }
            set { _stationId = value.Id; }
        }

      
    }
}
