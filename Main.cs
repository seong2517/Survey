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
      Program.code.StartPosition = FormStartPosition.Manual;
      Program.code.Location = new Point(parentPoint.X, parentPoint.Y);
      Program.code.Show();
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

    private void button1_Click(object sender, EventArgs e) // 관리자 모드 진입
    {
      Point parentPoint = this.Location;
      Program.login.StartPosition = FormStartPosition.Manual;
      Program.login.Location = new Point(parentPoint.X, parentPoint.Y);
      Program.login.Show();
      Program.main.Hide();
    }
  }
}