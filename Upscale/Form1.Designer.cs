namespace Upscale
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000024D4 File Offset: 0x000006D4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000250C File Offset: 0x0000070C
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.comboBox2 = new global::System.Windows.Forms.ComboBox();
			this.comboBox3 = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(217, 110);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(109, 42);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start Upscale\r\n for Here!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.Location = new global::System.Drawing.Point(12, 126);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(84, 26);
			this.button2.TabIndex = 1;
			this.button2.Text = "Select a Video";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(69, 25);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(59, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new global::System.Drawing.Point(138, 25);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new global::System.Drawing.Size(83, 21);
			this.comboBox2.TabIndex = 4;
			this.comboBox2.SelectedIndexChanged += new global::System.EventHandler(this.comboBox2_SelectedIndexChanged);
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new global::System.Drawing.Point(11, 25);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new global::System.Drawing.Size(45, 21);
			this.comboBox3.TabIndex = 5;
			this.comboBox3.SelectedIndexChanged += new global::System.EventHandler(this.comboBox3_SelectedIndexChanged);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Constantia", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label1.Location = new global::System.Drawing.Point(8, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(47, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Quality";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Constantia", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label2.Location = new global::System.Drawing.Point(77, 9);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(39, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Codec";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Constantia", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label3.Location = new global::System.Drawing.Point(147, 9);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(65, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Resulation";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			base.ClientSize = new global::System.Drawing.Size(338, 164);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.comboBox3);
			base.Controls.Add(this.comboBox2);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Form1";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000008 RID: 8
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.ComboBox comboBox2;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.ComboBox comboBox3;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label3;
	}
}
