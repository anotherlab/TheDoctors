using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheDoctors.Resources
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return null;

            return LocalizationResources.ResourceManager.GetString(Text, LocalizationResources.Culture);
        }

    }
}
