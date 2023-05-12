using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity05 : ContentPage
    {
        List<Contacts> contacts;


        public activity05()
        {
            InitializeComponent();

            SetupData();
            listView.ItemsSource = contacts;
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(listView.SelectedItem != null) 
            {
                var detailPage = new DetailPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }


        void SetupData()
        {
            contacts = new List<Contacts>();

            contacts.Add(new Contacts
            {
                Name = "Merwil Varona",
                Age = 23,
                Occupation="CEO",
                Country="Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Juan Miguel Morales",
                Age = 27,
                Occupation = "loverboi",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Harvey Specter",
                Age = 99,
                Occupation = "Lawyer",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Walter White",
                Age = 45,
                Occupation = "Chemist",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Ragnar Lothbrok",
                Age = 51,
                Occupation = "King",
                Country = "Philippines"
            });
        }
    }
}