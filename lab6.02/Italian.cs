using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6._02
{
    public class Italian : IPerson
    {
        public void PrintCountryName()
        {
            MessageBox.Show("Italy");
        }

        public void Speak()
        {
            MessageBox.Show("Ciao! Come stai?");
        }
    }
}
