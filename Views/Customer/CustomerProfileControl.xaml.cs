using DeskFlow.Helpers;
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

namespace DeskFlow.Views.Customer
{
    /// <summary>
    /// Interaction logic for CustomerProfileControl.xaml
    /// </summary>
    public partial class CustomerProfileControl : UserControl
    {

        private Models.Customer _currentCustomer;

        public CustomerProfileControl()
        {
            InitializeComponent();

            _currentCustomer = App.loggedUser as Models.Customer;

            loadData();
        }

        private void loadData()
        {
            if (_currentCustomer == null) return;

            txtProfileName.Text = _currentCustomer.Name;
            txtProfileEmail.Text = _currentCustomer.Email;
            txtProfileCompany.Text = _currentCustomer.CompanyName;
            txtProfileNif.Text = _currentCustomer.Nif;
        }

        private void btnEditSave_Click(object sender, RoutedEventArgs e)
        {
            if (_currentCustomer == null) return;

            PersonHelper cH = new PersonHelper();

            _currentCustomer.Name = txtProfileName.Text.Trim();
            _currentCustomer.Email = txtProfileEmail.Text.Trim();
            _currentCustomer.CompanyName = txtProfileCompany.Text.Trim();
            _currentCustomer.Nif = txtProfileNif.Text.Trim();

            cH.Update(_currentCustomer);

            MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
