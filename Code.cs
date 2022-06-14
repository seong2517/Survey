using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Survey
{
  public partial class Code : Form
  {
    string _server = "172.23.16.1";
    int _port = 3306;
    string _database = "code_schema";
    string _id = "root";
    string _pw = "";
    string _connectionAddress = "";

    public Code()
    {
      InitializeComponent();

      _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
    }

    private void button1_Click(object sender, EventArgs e) //다음
    {
      try
      {
        MySqlConnection MyConn = new MySqlConnection(_connectionAddress);
        MySqlCommand SelectCommand = new MySqlCommand("select * from code_table where code ='" + this.textBox1.Text + "'", MyConn);
        MySqlDataReader myReader;
        MyConn.Open();
        myReader = SelectCommand.ExecuteReader();
        int count = 0;

        while (myReader.Read())
        {
          count = count + 1;
        }
        if (count == 1) // DB값과 일치할경우 진입
        {
          Point parentPoint = this.Location;
          Program.check.StartPosition = FormStartPosition.Manual;
          Program.check.Location = new Point(parentPoint.X, parentPoint.Y);
          Program.check.Show();
          Program.code.Hide();
        }
        else // DB값과 불일치할경우 진입불가
        {
          MessageBox.Show("정확한 코드를 입력해주세요.");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
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
