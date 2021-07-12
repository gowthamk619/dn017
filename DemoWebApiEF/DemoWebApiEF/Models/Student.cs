using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoWebApiEF.Models
{
    public class Student
    {
        [Key]
        public int StudentId
        {
            get;
            set;
        }
        public string StudentName
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string Course
        {
            get;
            set;
        }
    }
}