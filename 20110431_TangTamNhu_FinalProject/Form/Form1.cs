using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110431_TangTamNhu_FinalProject
{
    public partial class Form_playgame : Form
    {
        #region properties
        Class_banco chessBoard;
        #endregion
        public Form_playgame()
        {
            InitializeComponent();
            //tao doi tuong
            chessBoard = new Class_banco(panel);
            chessBoard.boardOfChess();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Class_control.English == true)
                MessageBox.Show("You can choose 1 of 2 game modes:\n\n-Player Vs Player\n\n-Player Vs Computer\n\nAfter entering the full player name and pressing the OK button.\n\nYou will be returned to the main screen\n\nYou need to press the START button to start chess!!");
            else if (Class_control.VietNam == true)
                MessageBox.Show("Bạn có thể lựa chọn 1 trong 2 chế độ chơi:\n\n-Player vs Player\n\n-Player vs Computer\n\nSau khi nhập đầy đủ tên người chơi và nhấn nút OK.\n\nBạn sẽ được quay lại màn hình chính\n\nBạn cần nhấn vào nút START để bắt đầu đánh cờ!!");

        }
    }
}
