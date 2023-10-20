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

namespace Prog_122_L10_DataClass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Album 
            // Declaring the Type - Give it a name - Equals - new keyword - Type()

            // Instanced Object
            // new keyword - Album();
            Album juansChoice = new Album();
            Album kirasChoice = new Album();

            juansChoice.title = "Thriller";
            juansChoice.artistName = "Michael Jackson";
            kirasChoice.title = "Bad";
            kirasChoice.artistName="Michael Jackson";

            // Object name.fieldName
            rtbDisplay.Text = kirasChoice.title;


        } // MainWindow()

    } // class
     
} // namespace
