using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class skillsLab : IIntern
    {

        private string Name { get; set; }
        private int Id { get; set; }
        private string NameId => $"SkillsLab-{Name}:{Id}";
       
        
        public skillsLab(string name,int id)
        {
            Name = name;
            Id = id;
        }
        
        public string Getname()
        {
            return NameId;
        }
    }
}
