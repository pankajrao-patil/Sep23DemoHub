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

namespace EF_CodeFirst_WPFDemo
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddPatient_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DonorContext dbCon = new DonorContext("server=.;Integrated Security=true;database=Sep23Db");
                
                //Init Patient Object
                Patient p1 = new Patient();
                p1.PatientNo = 101;
                p1.Name = "Alok";
                p1.City = "Munnar";

                //Adding Data to Table               
                dbCon.Patients.Add(p1);

                //Commit Changes
                dbCon.SaveChanges();
               System.Windows.Forms.MessageBox.Show("Patient Details Added");

            }
            catch(Exception e1)
            {
                System.Windows.Forms.MessageBox.Show(e1.Message);
            }
        }
    }
}
