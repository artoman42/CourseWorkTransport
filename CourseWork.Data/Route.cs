using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CourseWork.Data
{
    public class Route : Base<Route>
    {
      
        public Route () : base() { }
        public Route(bool fl) : base(fl) { }
        public string Name {get;set;}
        
        [JsonIgnore]
        public List<Sharing> Sharings
        {
            get
            {
                return Sharing.Items.Values.Where(sh => sh.Route == this).ToList();
            }
        }
        [JsonIgnore]
        public List<Station> Stations
        {
            get
            {
                return Sharing.Items.Values.Where(sh => sh.Route == this).Select(sh=>sh.Station).ToList();
            }
        }
        
        [JsonIgnore]
        public List<Transport> ListTransports
        {
            get { return Transport.Items.Values.Where(lt => lt.Route == this).ToList(); }
        }
        
        public override string ToString()
        {
            return Name;
        }
    }
}
