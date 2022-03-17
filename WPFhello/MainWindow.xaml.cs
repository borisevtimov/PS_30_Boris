using StudentInfoSystem;
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

namespace WPFhello
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearForms();
        }

        private void btnPopulateModel_Click(object sender, RoutedEventArgs e)
        {
            PopulateForm();
        }

        private void btnDeactivateControls_Click(object sender, RoutedEventArgs e)
        {
            DeactivateControls();
        }

        private void btnActivateControls_Click(object sender, RoutedEventArgs e)
        {
            ActivateControls();
        }

        private void ClearForms() 
        {
            foreach (var item in PersonalData.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }
            }

            foreach (var item in StudentInformation.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }
            }
        }

        private void PopulateForm() 
        {
            StudentData studentData = new StudentData();
            Student? student = studentData.TestStudents?.FirstOrDefault();

            foreach (var item in PersonalData.Children)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).Name.Equals("txtFirstName"))
                    {
                        ((TextBox)item).Text = student?.FirstName;
                    }
                    else if (((TextBox)item).Name.Equals("txtMiddleName"))
                    {
                        ((TextBox)item).Text = student?.MiddleName;
                    }
                    else if (((TextBox)item).Name.Equals("txtLastName"))
                    {
                        ((TextBox)item).Text = student?.LastName;
                    }
                }
            }

            foreach (var item in StudentInformation.Children)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).Name.Equals("txtFaculty"))
                    {
                        ((TextBox)item).Text = student?.Faculty;
                    }
                    else if (((TextBox)item).Name.Equals("txtSpeciality"))
                    {
                        ((TextBox)item).Text = student?.Speciality;
                    }
                    else if (((TextBox)item).Name.Equals("txtDegree"))
                    {
                        ((TextBox)item).Text = student?.Degree.ToString();
                    }
                    else if (((TextBox)item).Name.Equals("txtFacultyNumber"))
                    {
                        ((TextBox)item).Text = student?.FacultyNumber;
                    }
                    else if (((TextBox)item).Name.Equals("txtStatus"))
                    {
                        ((TextBox)item).Text = student?.Status.ToString();
                    }
                    else if (((TextBox)item).Name.Equals("txtCourse"))
                    {
                        ((TextBox)item).Text = student?.Course.ToString();
                    }
                    else if (((TextBox)item).Name.Equals("txtStream"))
                    {
                        ((TextBox)item).Text = student?.Stream.ToString();
                    }
                    else if (((TextBox)item).Name.Equals("txtGroup"))
                    {
                        ((TextBox)item).Text = student?.Group.ToString();
                    }
                }
            }
        }

        private void DeactivateControls() 
        {
            foreach (var item in PersonalData.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }

            foreach (var item in StudentInformation.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }
        }

        private void ActivateControls() 
        {
            foreach (var item in PersonalData.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }

            foreach (var item in StudentInformation.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }
        }
    }
}
