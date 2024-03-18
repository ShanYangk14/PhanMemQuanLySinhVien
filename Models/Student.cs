﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySinhVien.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; }

        public string Major { get; set; }
        public ICollection<Grades> Grades { get; set; }
    }
}
