using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class SettingGameForm : Form
    {
        public SettingGameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Speed speed = Speed.Medium;
            Mode mode = Mode.Classic;

            if (rdModern.Checked) mode = Mode.Modern;
            if (rdFastSpeed.Checked) speed = Speed.Fast;
            else if (rdLowSpeed.Checked) speed = Speed.Low;

            if (mode == Mode.Classic) new ClassicGameForm(speed).ShowDialog();
            else new ModernGameForm(speed).ShowDialog();
        }
    }
}
