using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasPumpAppCSharp
{
    public partial class boardPinCode : UserControl
    {
        public event EventHandler<ButtonValue> TapPinCode;
        public boardPinCode()
        {
            InitializeComponent();
        }

        private void ButtonPinBoard_Click(object sender, EventArgs e)
        {
            if (TapPinCode != null)
                TapPinCode(this, new ButtonValue { buttonText = ((Button)sender).Text });
        }

        public class ButtonValue : EventArgs
        {
            public string buttonText { get; set; }
        }
    }
}
