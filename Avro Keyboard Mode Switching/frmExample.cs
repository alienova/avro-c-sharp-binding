using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OmicronLab;

namespace Avro_Keyboard_Mode_Switching
{
    public partial class frmExample : Form
    {
        public frmExample()
        {
            InitializeComponent();
        }

        private void txtNameEnglish_Enter(object sender, EventArgs e)
        {
            AvroKeyboard.toEnglish();
        }

        private void txtNameBangla_Enter(object sender, EventArgs e)
        {
            AvroKeyboard.toBangla();
        }
    }
}
