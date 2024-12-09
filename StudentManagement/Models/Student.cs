﻿using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

    }
}
