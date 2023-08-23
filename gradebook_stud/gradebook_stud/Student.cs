using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradebook_stud
{
    public class Student
    {
        int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Student(int id,string name,int age)
        {
            this._id = id;
            this._name = name;
            this._age = age;
        }

        public override string ToString()
        {
            return String.Format("Student Id:{0}\nStudend Name:{1}\nStudent Age:{2}\n",Id,Name,Age);
        }
    }
}
