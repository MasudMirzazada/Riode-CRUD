using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<FinalProject.Models.Product> Products { get; set; }
    }
}
