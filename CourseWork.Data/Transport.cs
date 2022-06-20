using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CourseWork.Data
{
    public class Transport : Base<Transport>
    {
      
        public Transport() : base() { }
        public Transport(bool fl) : base(fl) { }
        
        public string Name { get; set; }

        public  Guid _RouteId;
        public Guid _TransportTypeId;
        
        [JsonIgnore]
        public Route Route
        {
            get { return Route.Items[_RouteId]; }
            set { _RouteId = value.Id; }
        }
        [JsonIgnore]
        public TransportType TransportType
        {
            get { return TransportType.Items[_TransportTypeId]; }
            set { _TransportTypeId = value.Id; }
        }
       
        public override string ToString()
        {
            return Name;
        }
    }
}
