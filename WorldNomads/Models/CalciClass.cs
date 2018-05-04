using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorldNomads.Models
{
    public class CalciClass
    {
        public int num { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Enter only a Valid Number")]
        public int inpNum { get; set; }
        public bool successCritera { get; set; }
    }
}