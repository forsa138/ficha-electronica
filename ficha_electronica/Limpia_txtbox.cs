using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ficha_electronica
{
    class Limpia_txtbox
    {
        public void LimpiarCampos(Control control)
        {
            foreach( var txt in control.Controls)
            {
                if(txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                
            }
        }
    }
}
