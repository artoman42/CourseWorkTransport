using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace CourseWork.Data
{
    public class Base<T> where T : Base<T>
    {
        
        public static Dictionary<Guid, T> Items = new Dictionary<Guid, T>();

        
        public Guid Id { get; set; }

        
        public Base()
        {
           
        }
        
        public Base(bool fl)
        {
            Id = Guid.NewGuid();
            Items.Add(Id, (T)this);
        }

        public static void Serialiaze(string k)
        {
            string str = JsonConvert.SerializeObject(Items);
           File.WriteAllText($@"D:\KPI\Курсач 1 курс\CourseWork.Data\json\{k}.json", str);
        }
    }
}
