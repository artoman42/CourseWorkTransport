using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CourseWork.Data
{
    public class TransportType : Base<TransportType>
    {
        
        public TransportType() : base() { }
        public TransportType(bool fl) : base(fl) { }
       
       
        public string Name{get;set;}
        public string Info { get; set; }
        
        [JsonIgnore]
        public List<Transport> Transports
        {
            get { return Transport.Items.Values.Where(lt => lt.TransportType == this).ToList(); }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
