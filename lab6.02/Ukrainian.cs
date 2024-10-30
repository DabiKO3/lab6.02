using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6._02
{
   
        public class Ukrainian : IPerson
        {
            public void PrintCountryName()
            {
                MessageBox.Show("Україна");
            }

            public void Speak()
            {
                MessageBox.Show("Привіт! Як справи?");
            }
        }
}
