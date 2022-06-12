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
  public partial class Result : Form
  {
    public Result()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) //메인화면으로 돌아가기
    {
      Point parentPoint = this.Location;
      Program.main.StartPosition = FormStartPosition.Manual;
      Program.main.Location = new Point(parentPoint.X, parentPoint.Y);
      Program.main.Show();
      Program.result.Hide();
    }

    private void Form8_FormClosing(object sender, FormClosingEventArgs e)
    {
      DialogResult dr = MessageBox.Show("프로그램을 종료하시겠습니까?", "알림", MessageBoxButtons.OKCancel);
      if(dr == DialogResult.OK)
      {
        Application.ExitThread();
        Environment.Exit(0);
      }
      else
      {
        e.Cancel = true;
      }
    }
  }
}
