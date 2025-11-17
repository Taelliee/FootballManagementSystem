using FootballManager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Country Country { get; set; }
    }
}
