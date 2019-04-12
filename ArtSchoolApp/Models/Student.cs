using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ArtSchoolApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        [StringLength(50)]
        [Required]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string LastName { get; set; }
        [StringLength(50)]
        [Required]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [StringLength(100)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        // navigation property-- hold oter entities that are related to this entity - Enrollments property of student entity
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
