using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chessy
{
    /// <summary>
    /// Interaction logic for ChessBoard.xaml
    /// </summary>
    public partial class ChessBoard : UserControl
    {
        private int cols = 8;

        public int rows
        {
            get { return (int)GetValue(rowsProperty); }
            set { SetValue(rowsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for rows.
        public static readonly DependencyProperty rowsProperty =
            DependencyProperty.Register("Rows", typeof(int), typeof(ChessBoard), new PropertyMetadata(8));



        public ChessBoard()
        {
            InitializeComponent();
            Height = Width;
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Height = Width;
        }
    }
}
