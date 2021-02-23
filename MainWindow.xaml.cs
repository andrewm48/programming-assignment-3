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

namespace Programing_assignment_2
{
    /// Here is programming assignment 2 and its functions 
    /// click clear button to clear the canvas, the change to blue button to change brush to blue, the reset brush to change brush back to original, and the change brush button to change size of the brush 
   
    public partial class MainWindow : Window
    {
       
            public MainWindow()
            {

                InitializeComponent();

            }
        
            
        
        //clears the canvas 
        private void clear_button_Click(object sender, RoutedEventArgs e)
        {
            can.Strokes.Clear();
        }
        //changes brush to blue and increses the brush size 
        private void blue_Click(object sender, RoutedEventArgs e)
        {

            can.EditingMode = InkCanvasEditingMode.Ink;
            can.DefaultDrawingAttributes.Color = Colors.Blue;
            can.DefaultDrawingAttributes.Height = 5;

        }
        //changes brush back to default 
        private void reset_brush_Click(object sender, RoutedEventArgs e)
        {
            can.EditingMode = InkCanvasEditingMode.Ink;
            can.DefaultDrawingAttributes.Color = Colors.Black;
            can.DefaultDrawingAttributes.Height = 2;
        }
        //changes the brush size to 10 
        private void Ssize_Click(object sender, RoutedEventArgs e)
        {
            can.DefaultDrawingAttributes.Height = 10;
        }
    }
}
