using MVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM
{
    public partial class MainPage : ContentPage
    {

        public Person CurrentPerson
        {
            get; set;
        }

        public MainPage()
        {
            InitializeComponent();
            LoadData();

            BindingContext = CurrentPerson;

            /*txtName.BindingContext = CurrentPerson;
            txtName.SetBinding(Entry.TextProperty, "Name");*/

            /*Binding personBinding = new Binding();
            personBinding.Source = CurrentPerson;
            personBinding.Path = "Name";
            txtName.SetBinding(Entry.TextProperty, personBinding);
            Binding personBinding2 = new Binding();
            personBinding2.Source = CurrentPerson;
            personBinding2.Path = "Phone";
            txtPohone.SetBinding(Entry.TextProperty, personBinding2);
            Binding personBinding3 = new Binding();
            personBinding3.Source = CurrentPerson;
            personBinding3.Path = "Address";
            txtAddress.SetBinding(Entry.TextProperty, personBinding3);*/           
        }

        private void LoadData()
        {
            
            CurrentPerson = new Person
            {
                Name = "Rodrigo",
                Phone = "78956",
                Address = "San Salvador"
            };


             /*
            txtName.Text = CurrentPerson.Name;
            txtPohone.Text = CurrentPerson.Phone;
            txtAddress.Text = CurrentPerson.Address;*/
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Saving","Saving data","OK");

            CurrentPerson.Name = "Efrain";
            CurrentPerson.Phone = "456789";
            CurrentPerson.Address = "Kansas";

        }
    }
}
