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

namespace FileReadExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            //everytime you have a try statement you need to have a catch statement
            try {
                System.IO.StreamReader sr = new System.IO.StreamReader("BirthdayList.txt");
                lblOutput.Content = "";
            
                while (!sr.EndOfStream)
                {
                    lblOutput.Content += sr.ReadLine() + Environment.NewLine;
                }
            } //end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch
        

        
        

        }

        private void btnReadFile2_Click(object sender, RoutedEventArgs e)
        {
            //everytime you have a try statement you need to have a catch statement
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("bl2.txt");
                lblOutput.Content = "";
                string output = "";
                while (!sr.EndOfStream)
                {
                    string fullName = sr.ReadLine();
                    string[] names =
                    fullName.Split(new char[] { ',' });
                    output += names[1] + Environment.NewLine;
                }//end while
                lblOutput.Content = output;
                {
                    lblOutput.Content += sr.ReadLine() + Environment.NewLine;
                    sr.Close();
                }
            } //end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch
        }
    }
}
