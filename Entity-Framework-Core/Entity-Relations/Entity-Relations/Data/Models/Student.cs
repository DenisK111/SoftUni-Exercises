﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        public Student()
        {
            HomeworkSubmissions = new HashSet<Homework>();
            CourseEnrollments = new HashSet<StudentCourse>();
        }

        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        [Column(TypeName = "CHAR(10)")]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime RegisteredOn { get; set; }

        public DateTime? Birthday { get; set; }

        public virtual ICollection<Homework> HomeworkSubmissions { get; set; }
        public virtual ICollection<StudentCourse> CourseEnrollments { get; set; }
    }
}
