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

        List<Album> albumList = new List<Album>();

        public MainWindow()
        {
            InitializeComponent();
            Preload();

            rtbDisplay.Text = "";

            for(int i = 0; i < albumList.Count; i++)
            {
                Album currentAlbum = albumList[i];

                rtbDisplay.Text += currentAlbum._artistName + " : " + currentAlbum._title + "\n";
            }

            #region Earlier Notes
            // Album 
            // Declaring the Type - Give it a name - Equals - new keyword - Type()

            // Instanced Object
            // new keyword - Album();
            // Constructor now takes album name and artist
            //Album juansChoice = new Album("Thriller", "Michael Jackson");
            //Album kirasChoice = new Album();

            //juansChoice._title = "Thriller";
            //juansChoice._artistName = "Michael Jackson";
            //kirasChoice.title = "Bad";
            //kirasChoice.artistName="Michael Jackson";

            // Object name.fieldName
            //rtbDisplay.Text = juansChoice._title;

            #endregion
        } // MainWindow()

        public void Preload()
        {
            Album jaunsChoice = new Album("Thriller", "Michael Jackson");

            albumList.Add(jaunsChoice);

            albumList.Add(new Album("Egg", "The Garden")); // Adding new albums with a shortcut
            albumList.Add(new Album("Beautiful", "Teena Marie"));
            albumList.Add(new Album("Supernatural", "Santana" ));
            albumList.Add(new Album("Milagro", "Santana"));
            albumList.Add(new Album("Butter", "BTS"));
        }

    } // class
     
} // namespace
