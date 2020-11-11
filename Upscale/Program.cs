using System;
using System.Windows.Forms;

namespace Upscale
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002A7E File Offset: 0x00000C7E
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
