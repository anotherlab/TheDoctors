using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheDoctors.Resources
{
    // Define the default content property
    [ContentProperty("Text")]
    public class TranslateUpperExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return null;

            return DoctorResource.ResourceManager.GetString(Text, DoctorResource.Culture).ToUpper();
        }

    }
}
