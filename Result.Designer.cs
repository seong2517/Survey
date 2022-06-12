namespace Survey
{
  partial class Result
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(195, 165);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(420, 32);
      this.label1.TabIndex = 0;
      this.label1.Text = "설문조사에 참여해주셔서 감사합니다.";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.button1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button1.Location = new System.Drawing.Point(285, 280);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(230, 48);
      this.button1.TabIndex = 1;
      this.button1.Text = "메인화면으로 돌아가기";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(-7, -35);
      this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(809, 133);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 4;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(-7, 373);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(809, 133);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      // 
      // Result
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(800, 481);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Result";
      this.Text = "UserForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}