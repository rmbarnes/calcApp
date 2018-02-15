using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace calcApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

      
        private void txtWidth_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void txtHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            widthString = txtWidth.Text;
            heightString = txtHeight.Text;

            if ((widthString == "") || (heightString == ""))
            {
                ErrorDisplay();
                return;
            }
           
            width = double.Parse(widthString);
            height = double.Parse(heightString);


            if ((width > 0 && width < 40) && (height > 0 && height < 40))
            {
                woodLength = 2 * (width + height) * 3.25;
                glassArea = 2 * (width * height);
                txtWoodLength.Text = woodLength.ToString();
                txtGlassArea.Text = glassArea.ToString();
                txtWidthOutput.Text = width.ToString();
                txtHeightOutput.Text = height.ToString();

                txtHeightOutput.Visibility = Visibility.Visible;
                txtWidthOutput.Visibility = Visibility.Visible;
                txtWoodLength.Visibility = Visibility.Visible;
                txtGlassArea.Visibility = Visibility.Visible;
                txtWarning.Visibility = Visibility.Collapsed;
                dateBox.Visibility = Visibility.Visible;
            }
            else
            {
                ErrorDisplay();
            }
        }

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {            
            txtQuantity.Text = "Quantity: " + mySlider.Value.ToString();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        public void ErrorDisplay()
        {
            txtHeightOutput.Visibility = Visibility.Collapsed;
            txtWidthOutput.Visibility = Visibility.Collapsed;
            txtWarning.Visibility = Visibility.Visible;
            txtWoodLength.Visibility = Visibility.Collapsed;
            txtGlassArea.Visibility = Visibility.Collapsed;
            dateBox.Visibility = Visibility.Collapsed;
        }
    }
}
