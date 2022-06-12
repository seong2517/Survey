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
  public partial class Login : Form
  {
    public Login()
    {
      InitializeComponent();
    }

    private void Login_FormClosing(object sender, FormClosingEventArgs e)
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

    private void button1_Click(object sender, EventArgs e)
    {
      SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Me\PG\VS File\Survey\bin\Debug\Data.mdf;Integrated Security=True;Connect Timeout=30");
      SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from LOGIN where ID='"+ textBox1.Text+"' and PASSWORD='"+ textBox2.Text+"'", con);
      DataTable newTable = new DataTable();
      sda.Fill(newTable);
      if (newTable.Rows[0][0].ToString() == "1")
      {
        Point parentPoint = this.Location;
        Program.chart.StartPosition = FormStartPosition.Manual;
        Program.chart.Location = new Point(parentPoint.X, parentPoint.Y);
        Program.chart.Show();
        Program.login.Hide();
      }
      else
      {
        MessageBox.Show("아이디와 비밀번호를 확인해주세요.");
      }
    }
  }
}
