using _20110431_TangTamNhu_FinalProject.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _20110431_TangTamNhu_FinalProject
{

    //tao class nay de reuse neu can thiet
    public class Class_banco
    {
        #region Board

        #region property
        private Panel panel_banco { get; set; }

        private List<Class_player> player;
        #endregion

        #region constructor
        //tao constructor voi panel la tham so chuyen vao
        public Class_banco(Panel chessboard)
        {
            this.panel_banco = chessboard;
            this.player = new List<Class_player>();
        }

        #endregion

        #region method
        //tao ban co 20 x 15
        public void boardOfChess()
        {
            //tao 1 button ban dau luu size de tao button moi
            Button button = new Button()
            { Width = 0, Location = new Point(0, 0) }; //set vi tri cho button cu

            for (int i = 0; i < Class_control.chess_board_height; i++)
            {

                for (int j = 0; j < Class_control.chess_board_width; j++)
                {
                    //tao 1 button moi co size giong button cu
                    Button button_new = new Button()
                    {
                        Width = Class_control.chess_width,
                        Height = Class_control.chess_height,
                        Location = new Point(button.Location.X + button.Width, button.Location.Y), //vi tri cua button moi
                        BackgroundImageLayout = ImageLayout.Stretch,
                    };
                    button_new.Click += button_new_Click; //gan su kien de hien thi hinh anh xo trong button

                    //dua vao panel ban co
                    panel_banco.Controls.Add(button_new); //them button vua tao vao panel qua phuong thuc Control
                                                          //sau moi lan add bbutton moi thi luu button cu lai de su dung
                    button = button_new;
                }

                button.Location = new Point(0, button.Location.Y + Class_control.chess_height); //kich thuoc cua dong moi
                                                                                                //set lai button cu
                button.Width = 0;
                button.Height = 0;
            }
            #endregion

        }
        #endregion

        #region Button 
        private void button_new_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Source\\IMG\\x.png");
        }

        #endregion


    }
}

