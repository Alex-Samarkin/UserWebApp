using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserWebApp
{
    public class User
    {
        public int Id { get; set; } = 0;
        public string SurName { get; set; } = "";
        public string Name { get; set; } = "";
        public string Middlename { get; set; } = "";
        public int Age { get; set; }=18;
        public string Address1 { get; set; } = "";
        public string Address2 { get; set; } = "";

    }
}
