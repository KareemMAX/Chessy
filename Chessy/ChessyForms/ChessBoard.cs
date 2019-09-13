using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessyForms
{
    public partial class ChessBoard : UserControl
    {
        private int _rows = 8;
        /// <summary>
        /// Sets or gets the board dimensions in blocks.
        /// </summary>
        [DisplayName("Rows"), Category("Board Size"),
            Description("Sets the board dimensions in blocks."), Browsable(true), DefaultValue(8)]
        public int rows { get { return _rows; } set { _rows = value; } }

        private int _cols = 8;
        /// <summary>
        /// Sets or gets the board dimensions in blocks.
        /// </summary>
        [DisplayName("Columns"), Category("Board Size"),
            Description("Sets the board dimensions in blocks."), Browsable(true), DefaultValue(8)]
        public int cols { get { return _cols; } set { _cols = value; } }

        public ChessBoard()
        {
            InitializeComponent();
            tmp_height = Height;
            tmp_width = Width;
        }

        int tmp_height;
        int tmp_width;
        private void ChessBoard_SizeChanged(object sender, EventArgs e)
        {
            if (Width != tmp_width)
                Height = Width;
            else
                Width = Height;

            tmp_height = Height;
            tmp_width = Width;
        }
    }

}


