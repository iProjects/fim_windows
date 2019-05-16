/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 09/07/2018
 * Time: 23:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
using System.Windows.Forms;

namespace nyax
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false); 
			Application.Run(new MainForm());
		}
		
		
	}
}
