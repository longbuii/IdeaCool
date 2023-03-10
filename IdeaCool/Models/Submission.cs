using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IdeaCool.Models
{
    public class Submission
    {
        //Create to variable for Submission
        // You need to create the SubmissionControler.

        [Key]
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Deadline1 { get; set; }
        [Required]
        public DateTime Deadline2 { get; set; }


    }
}