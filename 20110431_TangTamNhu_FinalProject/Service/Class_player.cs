using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110431_TangTamNhu_FinalProject.Service
{
    public class Class_player
    {
        #region fields
        private string name;
        private Image mark;
        #endregion

        #region properties
        public string Name { get { return name; } set { name = value; } }
        public Image Mark { get { return mark; } set { mark = value; } }
        #endregion

        #region constructor
        public Class_player (string name, Image mark)
        {
            this.name = name;
            this.mark = mark;
        }
        #endregion

    }
}
