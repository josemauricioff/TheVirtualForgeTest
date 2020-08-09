using Microsoft.AspNetCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicalog.MVC.Models
{
    public abstract class BaseModel
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}
