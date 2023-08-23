using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradebook_stud
{
    public class Subject
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        int _mark;
        public int Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        char _grade;

        public char Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }


        public char setGrad()
        {
                char a =' ';
                if(Mark>90 && Mark<100)
                {
                    a='O';
                }
                else if(Mark>80 && Mark<90)
                {
                    a='A';
                }
                else if(Mark>70 && Mark<80)
                {
                    a='B';
                }
                else if (Mark > 35 && Mark < 70)
                {
                    a = 'C';
                }
                else if(Mark<35)
                {
                    a = 'F';
                }
                return a;
        }
        public Subject(string name,int mark)
        {
            this.Name = name;
            this.Mark = mark;
            this.Grade = setGrad();
        }
        public override string ToString()
        {
            return string.Format("Subject-Name:{0} Mark:{1} Grade:{2}  \n",Name,Mark,Grade);
        }
    }
}
