﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        [StringLength(50,MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string LastName { get; set; }

        [Required]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName => LastName + ", " + FirstMidName;
       /* {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }*/

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}