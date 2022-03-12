using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeinerMorales
{
    public class ValMone : PublicMoneda
    {
        public override int MONEDA { get; set; }
        public ValMone(int MONEDA)

        {
            this.MONEDA = MONEDA;
        }

        public ValMone()
        {

        }
    }
}