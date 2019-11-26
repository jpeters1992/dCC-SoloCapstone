using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Awarness.Models
{
    public class Incident
    {
        [Key]
        public int IncidentReferenceNumber { get; set; }

        [Display(Name = "Time of Incident")]
        [DataType(DataType.Time)]
        public int IncidentTime { get; set; }

        [Display(Name = "Date of Incident")]
        [DataType(DataType.Date)]
        public int IncidentDate { get; set; }

        [Display(Name = "Type of Incident")]
        public string IncidentType { get; set; }

        [Display(Name = "Location of Incident")]
        public int IncidentLocation { get; set; }

        [Display(Name = "Additional Details of Incident")]
        public string AdditionalDetails { get; set; }
    }
}