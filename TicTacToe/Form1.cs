using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace TicTacToe
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menu_file_exit;
		private System.Windows.Forms.MenuItem menu_file_start1p;
		private System.Windows.Forms.MenuItem menu_file_start2p;
		private System.Windows.Forms.PictureBox main_menu_img;
		
		public static Form1 Form1Instance;
		public static int game_type;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//

			//Everyone eveywhere in the app should know me as Form1.Form1Instance
			Form1Instance = this;

			InitializeComponent();
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menu_file_start1p = new System.Windows.Forms.MenuItem();
			this.menu_file_start2p = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menu_file_exit = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.main_menu_img = new System.Windows.Forms.PictureBox();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItem1);
			this.mainMenu1.MenuItems.Add(this.menuItem6);
			// 
			// menuItem1
			// 
			this.menuItem1.MenuItems.Add(this.menu_file_start1p);
			this.menuItem1.MenuItems.Add(this.menu_file_start2p);
			this.menuItem1.MenuItems.Add(this.menuItem4);
			this.menuItem1.MenuItems.Add(this.menu_file_exit);
			this.menuItem1.Text = "File";
			// 
			// menu_file_start1p
			// 
			this.menu_file_start1p.Text = "Start 1P Game";
			this.menu_file_start1p.Click += new System.EventHandler(this.menu_file_start1p_Click);
			// 
			// menu_file_start2p
			// 
			this.menu_file_start2p.Text = "Start 2P Game";
			this.menu_file_start2p.Click += new System.EventHandler(this.menu_file_start2p_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Text = "-";
			// 
			// menu_file_exit
			// 
			this.menu_file_exit.Text = "Exit";
			this.menu_file_exit.Click += new System.EventHandler(this.menu_file_exit_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.MenuItems.Add(this.menuItem7);
			this.menuItem6.Text = "TicTacToe";
			// 
			// menuItem7
			// 
			this.menuItem7.Text = "About";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// main_menu_img
			// 
			this.main_menu_img.Image = ((System.Drawing.Image)(resources.GetObject("main_menu_img.Image")));
			this.main_menu_img.Location = new System.Drawing.Point(40, 8);
			this.main_menu_img.Size = new System.Drawing.Size(552, 224);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			// 
			// Form1
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(10)), ((System.Byte)(78)), ((System.Byte)(100)));
			this.ClientSize = new System.Drawing.Size(640, 263);
			this.Controls.Add(this.main_menu_img);
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.Text = "Tic Tac Toe";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void menu_file_exit_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void menu_file_start1p_Click(object sender, System.EventArgs e)
		{
			game_type = 1;
			GameForm game_form = new GameForm();
			game_form.Show();
			this.Hide();
			//this.Close();
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Tic Tac Toe v1.0\r\nBy Thiago Alves\r\nMany thanks to HPC:Factor forum for support and motivation!", "About");
		}

		private void menu_file_start2p_Click(object sender, System.EventArgs e)
		{
			game_type = 2;
			GameForm game_form = new GameForm();
			game_form.Show();
			this.Hide();
		}
	}
}
