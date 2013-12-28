using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace molarmasscalc
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            infobox.Text = "This program is open-source and free. If you had to pay money for this program, I would suggest trying to get your money back.\r\n\r\n"+
                "Programmer: Holden Lewis.\r\nLanguage: C# - All rights reserved.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
