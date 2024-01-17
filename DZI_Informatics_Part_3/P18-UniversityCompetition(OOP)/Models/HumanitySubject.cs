using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_UniversityCompetition_OOP_.Models
{
    public class HumanitySubject : Subject
    {
        public HumanitySubject(int id, string name) : base(id, name, 1.15)
        {
        }
    }
}
