using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAIN.Dashboard
{
    class HistoricalWorkout
    {
        public string Description { get; set; }
        public string Date { get; set; }
        public string Delta { get; set; }
        public bool IsCustom { get; set; }
        public string DeltaDescription { get; set; }
    }
}
