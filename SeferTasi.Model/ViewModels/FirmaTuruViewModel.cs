using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.Model.ViewModels
{
    public class FirmaTuruViewModel
    {
        public string FirmaTuru { get; set; }
        public string MinimumTeslimSuresi { get; set; }
        public override string ToString()
        {
            return FirmaTuru;
        }
    }
}
