using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

    private void button2_Click(object sender, EventArgs e)
    {
      Point parentPoint = this.Location;
      Program.check.StartPosition = FormStartPosition.Manual;
      Program.check.Location = new Point(parentPoint.X, parentPoint.Y);
      Program.check.Show();
      Program.main.Hide();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      DialogResult dr = MessageBox.Show("프로그램을 종료하시겠습니까?", "알림", MessageBoxButtons.OKCancel);
      if (dr == DialogResult.OK)
      {
        
      }
      else
      {
        e.Cancel = true;
      }
    }
  }
}