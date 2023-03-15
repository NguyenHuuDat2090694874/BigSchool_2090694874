using BigSchool_2090694874.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool_2090694874.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Palce { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        [ValidTime]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        { return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}