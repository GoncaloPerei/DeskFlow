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

namespace DeskFlow.Views.Technician
{
    /// <summary>
    /// Interaction logic for TechnicianProfileControl.xaml
    /// </summary>
    public partial class TechnicianProfileControl : UserControl
    {
        private Models.Technician _currentTech;

        public TechnicianProfileControl()
        {
            InitializeComponent();

            _currentTech = App.loggedUser as Models.Technician;

            loadData();
        }

        private void loadData()
        {
            if (_currentTech == null) return;

            txtTechName.Text = _currentTech.Name;
            txtTechEmail.Text = _currentTech.Email;
            txtTechSpecialization.Text = _currentTech.Specialization;
        }

        private void btnSaveTech_Click(object sender, RoutedEventArgs e)
        {
            if (_currentTech == null) return;

            TechnicianHelper tH = new TechnicianHelper();

            _currentTech.Name = txtTechName.Text.Trim();
            _currentTech.Email = txtTechEmail.Text.Trim();
            _currentTech.Specialization = txtTechSpecialization.Text.Trim();

            tH.Update(_currentTech);

            MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            loadData();
        }
    }
}
