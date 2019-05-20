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
using Version2_Rock_App.View;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Version2_Rock_App.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class tour : Page
    {
        public tour()
        {
            this.InitializeComponent();
        }

        private void KnapTour_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(tour));
        }
        private void KnapForside_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));

        }
        private void knapArtefakter_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Artefakter));
        }
    }
}
