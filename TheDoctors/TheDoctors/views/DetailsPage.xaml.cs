using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using TheDoctors.Data;
using TheDoctors.Resources;
using Xamarin.Forms;
using TheDoctors;

namespace TheDoctors.views
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(DoctorActor doctor)
        {
            // On the iPhone, we just want to show the previous page title. The default would have 
            // included the current page title and it would have looked messy
            Title = Device.OnPlatform("", DoctorResource.DetailsTitle, DoctorResource.DetailsTitle);

            BindingContext = doctor;

            InitializeComponent();
        }
    }
}
