using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TicTacToe
{
	/// <summary>
	/// Summary description for GameForm.
	/// </summary>
	public class GameForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label game_turn_lbl;
		private System.Windows.Forms.Button end_game_btn;
		private System.Windows.Forms.PictureBox game_board;
		private ImageButton imgbtn_0_0;
		private ImageButton imgbtn_0_1;
		private ImageButton imgbtn_0_2;
		private ImageButton imgbtn_1_0;
		private ImageButton imgbtn_1_1;
		private ImageButton imgbtn_1_2;
		private ImageButton imgbtn_2_0;
		private ImageButton imgbtn_2_1;
		private ImageButton imgbtn_2_2;
		private System.Windows.Forms.PictureBox pb_gameboard;
		private System.Windows.Forms.PictureBox pb_o;
		private System.Windows.Forms.PictureBox pb_x;
		private System.Windows.Forms.PictureBox pb_blank;
		private System.Windows.Forms.Label playerx_score_lbl;
		private System.Windows.Forms.Label playero_score_lbl;
		private System.Windows.Forms.Label label1;

		public char [,] game_matrix = new char[3,3];
		public char turn = 'x';
		public int score_x = 0;
		public int score_o = 0;
		public bool gameover = false;
		public int game_type = Form1.game_type;
	
		public GameForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			System.Resources.ResourceManager res = new System.Resources.ResourceManager(typeof(GameForm));

			//Create all image buttons
			imgbtn_0_0 = new ImageButton();
			imgbtn_0_0.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_0_0.Location = new Point(100, 10);
			imgbtn_0_0.Size = new Size(48, 48);
			//Hook up into click event
			imgbtn_0_0.Click+=new EventHandler(click_0_0);
			this.Controls.Add(imgbtn_0_0);

			imgbtn_0_1 = new ImageButton();
			imgbtn_0_1.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_0_1.Location = new Point(168, 10);
			imgbtn_0_1.Size = new Size(48, 48);
			//Hook up into click event
			imgbtn_0_1.Click+=new EventHandler(click_0_1);
			this.Controls.Add(imgbtn_0_1);

			imgbtn_0_2 = new ImageButton();
			imgbtn_0_2.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_0_2.Location = new Point(236, 10);
			imgbtn_0_2.Size = new Size(48, 48);
			//Hook up into click event
			imgbtn_0_2.Click+=new EventHandler(click_0_2);
			this.Controls.Add(imgbtn_0_2);

			imgbtn_1_0 = new ImageButton();
			imgbtn_1_0.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_1_0.Location = new Point(100, 78);
			imgbtn_1_0.Size = new Size(48, 48);
			//Hook up into click event
			imgbtn_1_0.Click+=new EventHandler(click_1_0);
			this.Controls.Add(imgbtn_1_0);

			imgbtn_1_1 = new ImageButton();
			imgbtn_1_1.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_1_1.Location = new Point(168, 78);
			imgbtn_1_1.Size = new Size(48, 48);
			//Hook up into click event
			imgbtn_1_1.Click+=new EventHandler(click_1_1);
			this.Controls.Add(imgbtn_1_1);

			imgbtn_1_2 = new ImageButton();
			imgbtn_1_2.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_1_2.Location = new Point(236, 78);
			imgbtn_1_2.Size = new Size(48, 48);
			//Hook up into click event
			imgbtn_1_2.Click+=new EventHandler(click_1_2);
			this.Controls.Add(imgbtn_1_2);

			imgbtn_2_0 = new ImageButton();
			imgbtn_2_0.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_2_0.Location = new Point(100, 146);
			imgbtn_2_0.Size = new Size(48, 48);
			//Hook up into click event
			imgbtn_2_0.Click+=new EventHandler(click_2_0);
			this.Controls.Add(imgbtn_2_0);

			imgbtn_2_1 = new ImageButton();
			imgbtn_2_1.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_2_1.Location = new Point(168, 146);
			imgbtn_2_1.Size = new Size(48, 48);
			//Hook up into click event
			imgbtn_2_1.Click+=new EventHandler(click_2_1);
			this.Controls.Add(imgbtn_2_1);

			imgbtn_2_2 = new ImageButton();
			imgbtn_2_2.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_2_2.Location = new Point(236, 146);
			imgbtn_2_2.Size = new Size(48, 48);
			//Hook up into click event
			imgbtn_2_2.Click+=new EventHandler(click_2_2);
			this.Controls.Add(imgbtn_2_2);

			//Create game picturebox
			this.game_board = new System.Windows.Forms.PictureBox();
			this.game_board.Image = ((System.Drawing.Image)(res.GetObject("pb_gameboard.Image")));
			this.game_board.Location = new System.Drawing.Point(88, 0);
			this.game_board.Size = new System.Drawing.Size(208, 208);
			this.Controls.Add(this.game_board);

			start_game();
			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(GameForm));
			this.game_turn_lbl = new System.Windows.Forms.Label();
			this.end_game_btn = new System.Windows.Forms.Button();
			this.pb_gameboard = new System.Windows.Forms.PictureBox();
			this.pb_o = new System.Windows.Forms.PictureBox();
			this.pb_x = new System.Windows.Forms.PictureBox();
			this.pb_blank = new System.Windows.Forms.PictureBox();
			this.playerx_score_lbl = new System.Windows.Forms.Label();
			this.playero_score_lbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			// 
			// game_turn_lbl
			// 
			this.game_turn_lbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular);
			this.game_turn_lbl.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(233)), ((System.Byte)(232)), ((System.Byte)(232)));
			this.game_turn_lbl.Location = new System.Drawing.Point(400, 96);
			this.game_turn_lbl.Size = new System.Drawing.Size(200, 32);
			this.game_turn_lbl.Text = "Turn: Player \'X\'";
			// 
			// end_game_btn
			// 
			this.end_game_btn.Location = new System.Drawing.Point(400, 144);
			this.end_game_btn.Size = new System.Drawing.Size(200, 56);
			this.end_game_btn.Text = "Exit Game";
			this.end_game_btn.Click += new System.EventHandler(this.end_game_btn_Click);
			// 
			// pb_gameboard
			// 
			this.pb_gameboard.Image = ((System.Drawing.Image)(resources.GetObject("pb_gameboard.Image")));
			this.pb_gameboard.Location = new System.Drawing.Point(24, 176);
			this.pb_gameboard.Size = new System.Drawing.Size(48, 48);
			this.pb_gameboard.Visible = false;
			// 
			// pb_o
			// 
			this.pb_o.Image = ((System.Drawing.Image)(resources.GetObject("pb_o.Image")));
			this.pb_o.Location = new System.Drawing.Point(88, 176);
			this.pb_o.Size = new System.Drawing.Size(48, 48);
			this.pb_o.Visible = false;
			// 
			// pb_x
			// 
			this.pb_x.Image = ((System.Drawing.Image)(resources.GetObject("pb_x.Image")));
			this.pb_x.Location = new System.Drawing.Point(152, 176);
			this.pb_x.Size = new System.Drawing.Size(48, 48);
			this.pb_x.Visible = false;
			// 
			// pb_blank
			// 
			this.pb_blank.Image = ((System.Drawing.Image)(resources.GetObject("pb_blank.Image")));
			this.pb_blank.Location = new System.Drawing.Point(216, 176);
			this.pb_blank.Size = new System.Drawing.Size(48, 48);
			this.pb_blank.Visible = false;
			// 
			// playerx_score_lbl
			// 
			this.playerx_score_lbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular);
			this.playerx_score_lbl.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(233)), ((System.Byte)(232)), ((System.Byte)(232)));
			this.playerx_score_lbl.Location = new System.Drawing.Point(400, 32);
			this.playerx_score_lbl.Text = "Player X: 0";
			// 
			// playero_score_lbl
			// 
			this.playero_score_lbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular);
			this.playero_score_lbl.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(233)), ((System.Byte)(232)), ((System.Byte)(232)));
			this.playero_score_lbl.Location = new System.Drawing.Point(400, 56);
			this.playero_score_lbl.Text = "Player O: 0";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(233)), ((System.Byte)(232)), ((System.Byte)(232)));
			this.label1.Location = new System.Drawing.Point(400, 8);
			this.label1.Text = "SCORE";
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			// 
			// GameForm
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(10)), ((System.Byte)(78)), ((System.Byte)(100)));
			this.ClientSize = new System.Drawing.Size(640, 240);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pb_blank);
			this.Controls.Add(this.pb_x);
			this.Controls.Add(this.pb_o);
			this.Controls.Add(this.pb_gameboard);
			this.Controls.Add(this.end_game_btn);
			this.Controls.Add(this.game_turn_lbl);
			this.Controls.Add(this.playerx_score_lbl);
			this.Controls.Add(this.playero_score_lbl);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Text = "Tic Tac Toe";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

		}
		#endregion

		private void end_game_btn_Click(object sender, System.EventArgs e)
		{
			Form1.Form1Instance.Show();
			this.Close();
		}

		private void start_game()
		{
			//Zero out game matrix
			for(int i = 0; i < 9; i++)
			{
				int row = i / 3;
				int column = i % 3;
				game_matrix[row, column] = 'b';
			}

			//Zero out board
			System.Resources.ResourceManager res = new System.Resources.ResourceManager(typeof(GameForm));
			imgbtn_0_0.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_0_1.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_0_2.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_1_0.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_1_1.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_1_2.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_2_0.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_2_1.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_2_2.Image = ((System.Drawing.Image)(res.GetObject("pb_blank.Image")));
			imgbtn_0_0.Refresh();
			imgbtn_0_1.Refresh();
			imgbtn_0_2.Refresh();
			imgbtn_1_0.Refresh();
			imgbtn_1_1.Refresh();
			imgbtn_1_2.Refresh();
			imgbtn_2_0.Refresh();
			imgbtn_2_1.Refresh();
			imgbtn_2_2.Refresh();

			//Fresh out variables
			turn = 'x';
			gameover = false;
			game_turn_lbl.Text = "Turn: Player 'X'";

			//Update score
			playerx_score_lbl.Text = "Player X: " + score_x.ToString();
			playerx_score_lbl.Refresh();
			playero_score_lbl.Text = "Player O: " + score_o.ToString();
			playero_score_lbl.Refresh();
		}

		private char check_game()
		{
			//Verify if we have a champion
			//Horizontal lines
			if ((game_matrix[0,0] == game_matrix[0,1]) && (game_matrix[0,1] == game_matrix[0,2]))
				if (game_matrix[0,0] != 'b') return game_matrix[0,0];
			if ((game_matrix[1,0] == game_matrix[1,1]) && (game_matrix[1,1] == game_matrix[1,2])) 
				if (game_matrix[1,0] != 'b') return game_matrix[1,0];
			if ((game_matrix[2,0] == game_matrix[2,1]) && (game_matrix[2,1] == game_matrix[2,2])) 
				if (game_matrix[2,0] != 'b') return game_matrix[2,0];
			//Vertical lines
			if ((game_matrix[0,0] == game_matrix[1,0]) && (game_matrix[1,0] == game_matrix[2,0])) 
				if (game_matrix[0,0] != 'b') return game_matrix[0,0];
			if ((game_matrix[0,1] == game_matrix[1,1]) && (game_matrix[1,1] == game_matrix[2,1])) 
				if (game_matrix[0,1] != 'b') return game_matrix[0,1];
			if ((game_matrix[0,2] == game_matrix[1,2]) && (game_matrix[1,2] == game_matrix[2,2])) 
				if (game_matrix[0,2] != 'b') return game_matrix[0,2];
			//Crossed lines
			if ((game_matrix[0,0] == game_matrix[1,1]) && (game_matrix[1,1] == game_matrix[2,2])) 
				if (game_matrix[0,0] != 'b') return game_matrix[0,0];
			if ((game_matrix[0,2] == game_matrix[1,1]) && (game_matrix[1,1] == game_matrix[2,0])) 
				if (game_matrix[0,2] != 'b') return game_matrix[0,2];

			//Verify if matrix is full
			bool matrix_full = true;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (game_matrix[i,j] == 'b')
					{
						matrix_full = false;
						break;
					}
				}
			}
			if (matrix_full) return 'd';

			//Game is still going...
			return 'b';
		}

		private void game_status()
		{
			char game_check = check_game();
			string message = "";
			if (game_check == 'x')
			{
				//Refresh everyone
				imgbtn_0_0.Refresh();
				imgbtn_0_1.Refresh();
				imgbtn_0_2.Refresh();
				imgbtn_1_0.Refresh();
				imgbtn_1_1.Refresh();
				imgbtn_1_2.Refresh();
				imgbtn_2_0.Refresh();
				imgbtn_2_1.Refresh();
				imgbtn_2_2.Refresh();

				score_x++;
				message = "Player 'X' won! Start a new game?";
			}
			else if (game_check == 'o')
			{
				//Refresh everyone
				imgbtn_0_0.Refresh();
				imgbtn_0_1.Refresh();
				imgbtn_0_2.Refresh();
				imgbtn_1_0.Refresh();
				imgbtn_1_1.Refresh();
				imgbtn_1_2.Refresh();
				imgbtn_2_0.Refresh();
				imgbtn_2_1.Refresh();
				imgbtn_2_2.Refresh();

				score_o++;
				message = "Player 'O' won! Start a new game?";
			}
			else if (game_check == 'd')
			{
				message = "It was a draw! Start a new game?";
			}

			//If game has ended
			if (game_check != 'b')
			{
				gameover = true;
				DialogResult result = MessageBox.Show(message, "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
				if(result == DialogResult.Yes)
				{
					start_game();
				}
				else
				{
					Form1.Form1Instance.Show();
					this.Close();
				}
			}
		}

		private void cpu_play()
		{
			game_status();
			Random r = new Random();
			bool found_position = false;
			while (!found_position)
			{
				int pos = r.Next(0,8);
				if (game_matrix[(pos/3),(pos%3)] == 'b')
				{
					game_matrix[(pos/3),(pos%3)] = 'o';
					
					//Debug
					//MessageBox.Show("Position played = " + pos.ToString() + "\r\nMatrix[ " + (pos/3).ToString() + "," + (pos%3).ToString() + "]");

					//Turn the right picture
					System.Resources.ResourceManager res = new System.Resources.ResourceManager(typeof(GameForm));
					if ((pos/3 == 0) && (pos%3 == 0)) imgbtn_0_0.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					if ((pos/3 == 0) && (pos%3 == 1)) imgbtn_0_1.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					if ((pos/3 == 0) && (pos%3 == 2)) imgbtn_0_2.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					if ((pos/3 == 1) && (pos%3 == 0)) imgbtn_1_0.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					if ((pos/3 == 1) && (pos%3 == 1)) imgbtn_1_1.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					if ((pos/3 == 1) && (pos%3 == 2)) imgbtn_1_2.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					if ((pos/3 == 2) && (pos%3 == 0)) imgbtn_2_0.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					if ((pos/3 == 2) && (pos%3 == 1)) imgbtn_2_1.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					if ((pos/3 == 2) && (pos%3 == 2)) imgbtn_2_2.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					//Refresh everyone
					imgbtn_0_0.Refresh();
					imgbtn_0_1.Refresh();
					imgbtn_0_2.Refresh();
					imgbtn_1_0.Refresh();
					imgbtn_1_1.Refresh();
					imgbtn_1_2.Refresh();
					imgbtn_2_0.Refresh();
					imgbtn_2_1.Refresh();
					imgbtn_2_2.Refresh();

					turn = 'x';
					found_position = true;
					game_turn_lbl.Text = "Turn: Player 'X'";
				}
			}
		}

		private void click_0_0(object sender, System.EventArgs e)
		{
			if (!gameover && game_matrix[0,0] == 'b')
			{
				System.Resources.ResourceManager res = new System.Resources.ResourceManager(typeof(GameForm));
				if (turn == 'x')
				{
					imgbtn_0_0.Image = ((System.Drawing.Image)(res.GetObject("pb_x.Image")));
					game_matrix[0,0] = 'x';
					turn = 'o';
					game_turn_lbl.Text = "Turn: Player 'O'";
					if (game_type == 1) //computer should play
					{
						cpu_play();
					}
				}
				else
				{
					imgbtn_0_0.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					game_matrix[0,0] = 'o';
					turn = 'x';
					game_turn_lbl.Text = "Turn: Player 'X'";
				}
				game_status();
			}
		}

		private void click_0_1(object sender, System.EventArgs e)
		{
			if (!gameover && game_matrix[0,1] == 'b')
			{
				System.Resources.ResourceManager res = new System.Resources.ResourceManager(typeof(GameForm));
				if (turn == 'x')
				{
					imgbtn_0_1.Image = ((System.Drawing.Image)(res.GetObject("pb_x.Image")));
					game_matrix[0,1] = 'x';
					turn = 'o';
					game_turn_lbl.Text = "Turn: Player 'O'";
					if (game_type == 1) //computer should play
					{
						cpu_play();
					}
				}
				else
				{
					imgbtn_0_1.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					game_matrix[0,1] = 'o';
					turn = 'x';
					game_turn_lbl.Text = "Turn: Player 'X'";
				}
				game_status();
			}
		}

		private void click_0_2(object sender, System.EventArgs e)
		{
			if (!gameover && game_matrix[0,2] == 'b')
			{
				System.Resources.ResourceManager res = new System.Resources.ResourceManager(typeof(GameForm));
				if (turn == 'x')
				{
					imgbtn_0_2.Image = ((System.Drawing.Image)(res.GetObject("pb_x.Image")));
					game_matrix[0,2] = 'x';
					turn = 'o';
					game_turn_lbl.Text = "Turn: Player 'O'";
					if (game_type == 1) //computer should play
					{
						cpu_play();
					}
				}
				else
				{
					imgbtn_0_2.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					game_matrix[0,2] = 'o';
					turn = 'x';
					game_turn_lbl.Text = "Turn: Player 'X'";
				}
				game_status();
			}
		}

		private void click_1_0(object sender, System.EventArgs e)
		{
			if (!gameover && game_matrix[1,0] == 'b')
			{
				System.Resources.ResourceManager res = new System.Resources.ResourceManager(typeof(GameForm));
				if (turn == 'x')
				{
					imgbtn_1_0.Image = ((System.Drawing.Image)(res.GetObject("pb_x.Image")));
					game_matrix[1,0] = 'x';
					turn = 'o';
					game_turn_lbl.Text = "Turn: Player 'O'";
					if (game_type == 1) //computer should play
					{
						cpu_play();
					}
				}
				else
				{
					imgbtn_1_0.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					game_matrix[1,0] = 'o';
					turn = 'x';
					game_turn_lbl.Text = "Turn: Player 'X'";
				}
				game_status();
			}
		}

		private void click_1_1(object sender, System.EventArgs e)
		{
			if (!gameover && game_matrix[1,1] == 'b')
			{
				System.Resources.ResourceManager res = new System.Resources.ResourceManager(typeof(GameForm));
				if (turn == 'x')
				{
					imgbtn_1_1.Image = ((System.Drawing.Image)(res.GetObject("pb_x.Image")));
					game_matrix[1,1] = 'x';
					turn = 'o';
					game_turn_lbl.Text = "Turn: Player 'O'";
					if (game_type == 1) //computer should play
					{
						cpu_play();
					}
				}
				else
				{
					imgbtn_1_1.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					game_matrix[1,1] = 'o';
					turn = 'x';
					game_turn_lbl.Text = "Turn: Player 'X'";
				}
				game_status();
			}
		}

		private void click_1_2(object sender, System.EventArgs e)
		{
			if (!gameover && game_matrix[1,2] == 'b')
			{
				System.Resources.ResourceManager res = new System.Resources.ResourceManager(typeof(GameForm));
				if (turn == 'x')
				{
					imgbtn_1_2.Image = ((System.Drawing.Image)(res.GetObject("pb_x.Image")));
					game_matrix[1,2] = 'x';
					turn = 'o';
					game_turn_lbl.Text = "Turn: Player 'O'";
					if (game_type == 1) //computer should play
					{
						cpu_play();
					}
				}
				else
				{
					imgbtn_1_2.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					game_matrix[1,2] = 'o';
					turn = 'x';
					game_turn_lbl.Text = "Turn: Player 'X'";
				}
				game_status();
			}
		}

		private void click_2_0(object sender, System.EventArgs e)
		{
			if (!gameover && game_matrix[2,0] == 'b')
			{
				System.Resources.ResourceManager res = new System.Resources.ResourceManager(typeof(GameForm));
				if (turn == 'x')
				{
					imgbtn_2_0.Image = ((System.Drawing.Image)(res.GetObject("pb_x.Image")));
					game_matrix[2,0] = 'x';
					turn = 'o';
					game_turn_lbl.Text = "Turn: Player 'O'";
					if (game_type == 1) //computer should play
					{
						cpu_play();
					}
				}
				else
				{
					imgbtn_2_0.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					game_matrix[2,0] = 'o';
					turn = 'x';
					game_turn_lbl.Text = "Turn: Player 'X'";
				}
				game_status();
			}
		}

		private void click_2_1(object sender, System.EventArgs e)
		{
			if (!gameover && game_matrix[2,1] == 'b')
			{
				System.Resources.ResourceManager res = new System.Resources.ResourceManager(typeof(GameForm));
				if (turn == 'x')
				{
					imgbtn_2_1.Image = ((System.Drawing.Image)(res.GetObject("pb_x.Image")));
					game_matrix[2,1] = 'x';
					turn = 'o';
					game_turn_lbl.Text = "Turn: Player 'O'";
					if (game_type == 1) //computer should play
					{
						cpu_play();
					}
				}
				else
				{
					imgbtn_2_1.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					game_matrix[2,1] = 'o';
					turn = 'x';
					game_turn_lbl.Text = "Turn: Player 'X'";
				}
				game_status();
			}
		}

		private void click_2_2(object sender, System.EventArgs e)
		{
			if (!gameover && game_matrix[2,2] == 'b')
			{
				System.Resources.ResourceManager res = new System.Resources.ResourceManager(typeof(GameForm));
				if (turn == 'x')
				{
					imgbtn_2_2.Image = ((System.Drawing.Image)(res.GetObject("pb_x.Image")));
					game_matrix[2,2] = 'x';
					turn = 'o';
					game_turn_lbl.Text = "Turn: Player 'O'";
					if (game_type == 1) //computer should play
					{
						cpu_play();
					}
				}
				else
				{
					imgbtn_2_2.Image = ((System.Drawing.Image)(res.GetObject("pb_o.Image")));
					game_matrix[2,2] = 'o';
					turn = 'x';
					game_turn_lbl.Text = "Turn: Player 'X'";
				}
				game_status();
			}
		}

	}
}
