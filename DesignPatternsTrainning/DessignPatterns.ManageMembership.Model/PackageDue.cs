using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DessignPatterns.ManageMembership.Utils;
namespace DessignPatterns.ManageMembership.Model
{

    public class PackageDue
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
        public TermLength TermLength { get; set; }



    }
}
