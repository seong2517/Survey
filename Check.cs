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
  public partial class Check : Form
  {
    public Check()
    {
      InitializeComponent();
    }

    private void tP1_PrevBtn_Click(object sender, EventArgs e) // 정보창으로 이동
    {
      this.tabControl1.SelectedIndex = 0;
    }

    private void tP1_NextBtn_Click(object sender, EventArgs e) // 2 -> 3페이지 이동
    {
      this.tabControl1.SelectedIndex = 2;
    }

    private void tP2_NextBtn_Click(object sender, EventArgs e) // 3 -> 4페이지 이동
    {
      this.tabControl1.SelectedIndex = 4;
      axWindowsMediaPlayer1.Ctlcontrols.stop();
    }

    private void tP2_PrevBtn_Click(object sender, EventArgs e) // 3 -> 2페이지 이동
    {
      this.tabControl1.SelectedIndex = 2;
    }

    private void tP3_NextBtn_Click(object sender, EventArgs e) // 4 -> 5페이지 이동
    {
      this.tabControl1.SelectedIndex = 5;
    }

    private void tP3_PrevBtn_Click(object sender, EventArgs e) // 4 -> 3페이지 이동 추후 3으로 수정
    {
      this.tabControl1.SelectedIndex = 2;
    }

    private void tP4_NextBtn_Click(object sender, EventArgs e) // 제출버튼 클릭
    {
      DialogResult dr = MessageBox.Show("             제출하시겠습니까?\n    (제출 이후에 수정은 불가합니다!)", "알림", MessageBoxButtons.YesNo);
      if (dr == DialogResult.Yes)
      {
        Point parentPoint = this.Location;
        Program.result.StartPosition = FormStartPosition.Manual;
        Program.result.Location = new Point(parentPoint.X, parentPoint.Y);
        Program.result.Show();
        Program.check.Hide();
      }
      else
      {

      }
    }

    private void tP4_PrevBtn_Click(object sender, EventArgs e) // 5 -> 4페이지 이동
    {
      this.tabControl1.SelectedIndex = 4;
    }

    private void radioButton4_CheckedChanged(object sender, EventArgs e) // 2번답 아니오 클릭 시
    {
      groupBox3.Enabled = false;
      groupBox4.Enabled = false;
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e) // 2번답 네 클릭 시
    {
      groupBox3.Enabled = true;
      groupBox4.Enabled = true;
    }

    private void gp5_Btn1_Click(object sender, EventArgs e) // 동영상 재생버튼 클릭
    {
      axWindowsMediaPlayer1.URL = "corona.mp4";
      axWindowsMediaPlayer1.Ctlcontrols.play();
    }

    private void groupBox5_Enter(object sender, EventArgs e) // 동영상 진입 시 일단 정지
    {
      axWindowsMediaPlayer1.Ctlcontrols.stop();
    }

    private void Survey_FormClosing(object sender, FormClosingEventArgs e) // 프로그램 종료시
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

    private void Info_Click(object sender, EventArgs e)
    {
      if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
      {
        MessageBox.Show("전부 클릭해주세요.", "알림", MessageBoxButtons.OK);
      }
      else
      {
        this.tabControl1.SelectedIndex = 1;
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedIndex = 1;
    }

    private void button1_Click(object sender, EventArgs e) //추후3으로 수정
    {
      this.tabControl1.SelectedIndex = 4;
    }
  }
}
