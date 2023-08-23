using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradebook_stud
{
    public class stud_sub
    {

        Student _stud;

        public Student Stud
        {
            get { return _stud; }
            set { _stud = value; }
        }
        List<Subject> sub = new List<Subject>();

        public List<Subject> Sub
        {
            get { return sub; }
            set { sub = value; }
        }
        public int total()
        {
            int sum = 0;
            foreach(Subject s in Sub)
            {
                sum += s.Mark;
            }
            return sum;
        }

        public string printsubject()
        {
            string str = "";
            foreach(Subject s in Sub)
            {
                str += s;
            }
            return str;
        }

        public override string ToString()
        {
            string s = "";
            s += Stud.ToString();
            s += "\n";
            s += printsubject()+"\n";
            s += "Total-";
            s += total();
            return s;
        }
       
    }
}
