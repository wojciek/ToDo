using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.API.Models
{
    public class Todo
    { 
        public Guid ID { get; set; }
        public string title { get; set; }
    }
}
