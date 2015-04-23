using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BrookfieldMidwivesApp.Models
{
    public class ContactModels
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}