using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using K_PBL_test1.Models;

namespace K_PBL_test1.Models
{
    public class AcceptableCenterViewModel
    {
        public IEnumerable<Center> Centers { get; set; }
        public IEnumerable<AcceptableLevel> AcceptableLevels { get; set; }
    }
}
