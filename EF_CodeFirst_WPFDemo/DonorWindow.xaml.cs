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
using System.Windows.Shapes;

namespace EF_CodeFirst_WPFDemo
{
    /// <summary>
    /// Interaction logic for DonorWindow.xaml
    /// </summary>
    public partial class DonorWindow : Window
    {
        public DonorWindow()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            DonorContext dc = new DonorContext("server=.;Integrated Security=true;database=Sep23db");
            Donor d1 = new Donor();
            d1.DonorID = Int32.Parse(txtDonorID.Text);
            d1.Name = txtName.Text;
            d1.BloodGrp = txtBldGroup.Text;
            d1.City = txtCity.Text;


            dc.Donors.Add(d1);
            dc.SaveChanges();
            System.Windows.Forms.MessageBox.Show("Donor Details Recorded..");
            ResetTextBoxes();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            DonorContext dc = new DonorContext("server=.;Integrated Security=true;database=Sep23db");
            int id = Int32.Parse(txtDonorID.Text);
            Donor myDonor = dc.Donors.Find(id);
            myDonor.City = txtCity.Text;           
            
            dc.SaveChanges();

            System.Windows.Forms.MessageBox.Show("Donor Details Updated..");
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            DonorContext dc = new DonorContext("server=.;Integrated Security=true;database=Sep23db");
            int id = Int32.Parse(txtDonorID.Text);
            Donor myDonor = dc.Donors.Find(id);

            //Assigning Object Data to UI Controls
            if (myDonor != null)
            {
               
                txtName.Text = myDonor.Name;
                txtBldGroup.Text = myDonor.BloodGrp;
                txtCity.Text = myDonor.City;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No Record Found...");
            }

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            DonorContext dc = new DonorContext("server=.;Integrated Security=true;database=Sep23db");
            int id = Int32.Parse(txtDonorID.Text);
            Donor myDonor = dc.Donors.Find(id);


            if (myDonor != null)
            {
                dc.Donors.Remove(myDonor);
                dc.SaveChanges();
                System.Windows.Forms.MessageBox.Show("Record Deleted ..");
                ResetTextBoxes();
            }
        }
        public void ResetTextBoxes()
        {
           
            foreach (Control item in grid1.Children)
            {
                if (item.GetType() == typeof(TextBox))
                    ((TextBox)item).Text = String.Empty;
            }
        }
    }
}
