using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CourseWork.Data
{
    public class Station : Base<Station>
    {
        public Station(): base() { }
        public Station(bool fl) : base(fl) { }
        public string Name { get; set; }
        public string Time { get; set; }

        [JsonIgnore]
        
        public List<Sharing> Sharings
        {
            get
            {
                return Sharing.Items.Values.Where(sh => sh.Station == this).ToList();
            }
        }
        [JsonIgnore]
        public List<Route> Routes
        {
            get
            {
                return Sharing.Items.Values.Where(sh => sh.Station == this).Select(sh => sh.Route).ToList();
            }
        }
        public override string ToString()
        {
            return Name + "  " + Time;
        }
    }
}
