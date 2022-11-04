using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20110431_TangTamNhu_FinalProject
{
    //tao class nay de chua cac bien can su dung
    public class Class_control
    {
        #region board chess
        //so luong button
        public static int chess_width = 30; //do rong cua button, 'static' de class khac goi thong qua ten class
        public static int chess_height = 30; //do cao cua button
            //set do rong do cao so luong button trong ban co
        public static int chess_board_width = 2;
        public static int chess_board_height = 2;
        #endregion

        #region language
        public static bool English = true;
        public static bool VietNam = true;

        #endregion

    }
}
