using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Upscale
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		private void Form1_Load(object sender, EventArgs e)
		{
			this.comboBox1.Items.Add("Nvidia");
			this.comboBox1.Items.Add("AMD");
			this.comboBox1.Items.Add("x264");
			this.comboBox2.Items.Add("7680x4320 (8K)");
			this.comboBox2.Items.Add("3840x2160 (4K)");
			this.comboBox2.Items.Add("2560x1440");
			this.comboBox2.Items.Add("1920x1080");
			this.comboBox2.Items.Add("1280x720");
			this.comboBox3.Items.Add("5");
			this.comboBox3.Items.Add("12");
			this.comboBox3.Items.Add("22");
			this.comboBox3.Items.Add("30");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002180 File Offset: 0x00000380
		public static void baslatma()
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = string.Concat(new string[]
			{
				"/K ffmpeg  -i ",
				Form1.dosyaadi,
				" -vf scale=",
				Form1.cozunurluk,
				"x",
				Form1.cozunurluk1,
				":flags=neighbor -preset fast -c:v ",
				Form1.secim,
				" -qmin ",
				Form1.q,
				" -qmax ",
				Form1.q,
				" -2pass 1 -c:a:0 copy -b:a 384k Converted_",
				Form1.dosyaadi
			});
			process.Start();
			process.WaitForExit();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002240 File Offset: 0x00000440
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = Form1.dosyayolu == null;
			if (flag)
			{
				MessageBox.Show("Select a Video");
			}
			else
			{
				bool flag2 = Form1.secim == null;
				if (flag2)
				{
					MessageBox.Show("Set a Codec");
				}
				else
				{
					bool flag3 = Form1.cozunurluk == null;
					if (flag3)
					{
						MessageBox.Show("Set a Resolution");
					}
					else
					{
						bool flag4 = Form1.q == null;
						if (flag4)
						{
							MessageBox.Show("Set a Q");
						}
						else
						{
							Form1.baslatma();
						}
					}
				}
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000022C4 File Offset: 0x000004C4
		public static void dosyaacma()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "MP4 Video File | *.mp4";
			openFileDialog.ShowDialog();
			Form1.dosyayolu = openFileDialog.FileName;
			Form1.dosyaadi = openFileDialog.SafeFileName;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002301 File Offset: 0x00000501
		private void button2_Click(object sender, EventArgs e)
		{
			Form1.dosyaacma();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000230C File Offset: 0x0000050C
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.comboBox1.SelectedIndex == 0;
			if (flag)
			{
				Form1.secim = "h264_nvenc";
			}
			bool flag2 = this.comboBox1.SelectedIndex == 1;
			if (flag2)
			{
				Form1.secim = "h264_amf";
			}
			bool flag3 = this.comboBox1.SelectedIndex == 2;
			if (flag3)
			{
				Form1.secim = "libx264";
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002374 File Offset: 0x00000574
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.comboBox2.SelectedIndex == 0;
			if (flag)
			{
				Form1.cozunurluk = "7680";
				Form1.cozunurluk1 = "4320";
			}
			bool flag2 = this.comboBox2.SelectedIndex == 1;
			if (flag2)
			{
				Form1.cozunurluk = "3840";
				Form1.cozunurluk1 = "2160";
			}
			bool flag3 = this.comboBox2.SelectedIndex == 2;
			if (flag3)
			{
				Form1.cozunurluk = "2560";
				Form1.cozunurluk1 = "1440";
			}
			bool flag4 = this.comboBox2.SelectedIndex == 3;
			if (flag4)
			{
				Form1.cozunurluk = "1920";
				Form1.cozunurluk1 = "1080";
			}
			bool flag5 = this.comboBox2.SelectedIndex == 4;
			if (flag5)
			{
				Form1.cozunurluk = "1280";
				Form1.cozunurluk1 = "720";
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000244C File Offset: 0x0000064C
		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.comboBox3.SelectedIndex == 0;
			if (flag)
			{
				Form1.q = "5";
			}
			bool flag2 = this.comboBox3.SelectedIndex == 1;
			if (flag2)
			{
				Form1.q = "12";
			}
			bool flag3 = this.comboBox3.SelectedIndex == 2;
			if (flag3)
			{
				Form1.q = "22";
			}
			bool flag4 = this.comboBox3.SelectedIndex == 3;
			if (flag4)
			{
				Form1.q = "30";
			}
		}

		// Token: 0x04000001 RID: 1
		public static string dosyayolu;

		// Token: 0x04000002 RID: 2
		public static string dosyaadi;

		// Token: 0x04000003 RID: 3
		public static string a;

		// Token: 0x04000004 RID: 4
		public static string cozunurluk;

		// Token: 0x04000005 RID: 5
		public static string cozunurluk1;

		// Token: 0x04000006 RID: 6
		public static string secim;

		// Token: 0x04000007 RID: 7
		public static string q;
	}
}
