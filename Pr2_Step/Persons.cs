using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2_Step
{
    class Persons
    {
        public int id { set; get; }
        public string surname { set; get; }
        public string name { set; get; }
        public string lastname { set; get; }
        public DateTime date_of_birdth { set; get; }

        public Persons(int id, string surname, string name, string lastname, DateTime date)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.date_of_birdth = date;
        }
    }
}
