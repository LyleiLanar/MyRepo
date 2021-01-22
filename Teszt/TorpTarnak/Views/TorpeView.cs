using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teszt;

namespace TorpTarnak.Views
{
    public class TorpeView
    {
        public Torpe Torpe { get; set; }
        public TorpeView(Torpe torpe)
        {
            Torpe = torpe;
        }

        public List<Control> Controls()
        {
            List<Control> controls = new List<Control>();
            


            return controls;

        }



    }
}
