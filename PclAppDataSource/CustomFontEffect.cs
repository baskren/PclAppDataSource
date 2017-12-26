using System;
using Xamarin.Forms;

namespace PclAppDataSource
{
    class CustomFontEffect : RoutingEffect
    {
        protected CustomFontEffect() : base("NetStandardDataSource.CustomFontEffect")
        {
        }

        static public void ApplyTo(Xamarin.Forms.Label label)
        {
            var effect = new CustomFontEffect();
            label.Effects.Add(effect);
        }

    }
}
