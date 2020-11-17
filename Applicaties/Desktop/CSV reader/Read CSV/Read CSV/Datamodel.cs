using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_CSV
{
    class MedicalDataModel
    {
        public int ID { get; set; }
        public int Aantal { get; set; }
        public int GewichtMG { get; set; }
        public string Datumontvangen { get; set; }
        public string Uiterstedatum { get; set; }
        public string Name { get; set; }
    }
}
