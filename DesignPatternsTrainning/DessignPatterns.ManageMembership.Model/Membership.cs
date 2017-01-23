using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DessignPatterns.ManageMembership.Utils;
namespace DessignPatterns.ManageMembership.Model
{
    public class Membership
    {
        public PackageDue Package { get; set; }
        public MemberStatus MemberStatus { get; set; }

    }
}
