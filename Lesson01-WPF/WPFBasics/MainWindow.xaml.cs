using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace WPFBasics
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

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"The description is: { this.DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            // clearing all the checkboxes on pressing the reset button
            //this.WeldCheckbox.IsChecked = this.AssemblyCheckbox.IsChecked = this.PlasmaCheckbox.IsChecked = this.LaserCheckbox.IsChecked = this.PurchaseCheckbox.IsChecked = this.LatheCheckbox.IsChecked = this.DrillCheckbox.IsChecked =
            //    this.FoldCheckbox.IsChecked = this.RollCheckbox.IsChecked = this.SawCheckbox.IsChecked = false;
        }
        private void Select_LdifFile_1_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            dialog.Filters.Add(new CommonFileDialogFilter("Text files", "*.txt"));
            dialog.Filters.Add(new CommonFileDialogFilter("All files", "*.*"));

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                LdifFile_1.Text = dialog.FileName;
        }
        private void Select_LdifFile_2_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            dialog.Filters.Add(new CommonFileDialogFilter("Text files", "*.txt"));
            dialog.Filters.Add(new CommonFileDialogFilter("All files", "*.*"));

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                LdifFile_2.Text = dialog.FileName;
        }
        private void Select_OutPutFolder_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                OutPutFolder.Text = dialog.FileName;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            //this.LengthText.Text += ((CheckBox)sender).Content.ToString();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // check if we have init the text box dont want to set its value before init it
            //if (this.NoteText == null)
            //    return;
            //// convert sender object to comboBox
            //var combo = (ComboBox)sender;
            //// cast comboBix to item so we can get the selected item
            //var value = (ComboBoxItem)combo.SelectedValue;

            //// now convert the selected item to string and display in text box
            //this.NoteText.Text = (string)value.Content;
        }

        private void SupplierNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            //this.MassText.Text = this.SupplierNameText.Text;
        }
    }
}