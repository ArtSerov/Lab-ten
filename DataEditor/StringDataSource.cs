using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Serialization;

namespace WpfApp3
{
    public class Student
    {
        public Student() { }
        public Student(string name, string surname, string direction, int course)
        {
            this.Name = name;
            this.Surname = surname;
            this.Direction = direction;
            this.Course = course;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Direction { get; set; }
        public int Course { get; set; }
    }

    [Serializable]
    public class StringDataSource
    {
        public ObservableCollection<Student> data = new ObservableCollection<Student>();
    }
}
