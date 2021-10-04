using System;
using System.ComponentModel.DataAnnotations;

namespace demoMVC.Models
{
    public class Student
    {
        [Key]
        public int MaSV { get; set; }
        public string  HoTen { get; set; }

        
    }
}