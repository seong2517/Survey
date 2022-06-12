using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey
{
  public partial class Code : Form
  {
    public Code()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) //다음
    {
      SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Me\PG\VS File\Survey\bin\Debug\Data.mdf;Integrated Security=True;Connect Timeout=30");
      SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from CODE where PW='" + textBox1.Text + "'", con);
      DataTable newTable = new DataTable();
      sda.Fill(newTable);
      if (newTable.Rows[0][0].ToString() == "1")
      {
        Point parentPoint = this.Location;
        Program.check.StartPosition = FormStartPosition.Manual;
        Program.check.Location = new Point(parentPoint.X, parentPoint.Y);
        Program.check.Show();
        Program.code.Hide();
      }
      else
      {
        MessageBox.Show("정확한 코드를 입력해주세요.");
      }
    }

    private void button2_Click(object sender, EventArgs e) //메인화면으로
    {
      Point parentPoint = this.Location;
      Program.main.StartPosition = FormStartPosition.Manual;
      Program.main.Location = new Point(parentPoint.X, parentPoint.Y);
      Program.main.Show();
      Program.code.Hide();
    }

    private void Form2_FormClosing(object sender, FormClosingEventArgs e)
    {
      DialogResult dr = MessageBox.Show("프로그램을 종료하시겠습니까?", "알림", MessageBoxButtons.OKCancel);
      if (dr == DialogResult.OK)
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
