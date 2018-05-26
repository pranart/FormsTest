using System;
using Xamarin.Forms;

namespace FormsTest
{
    #if DEBUG
    public class ProgressBar : Xamarin.Forms.ProgressBar, IPropertyGet
    {
        public ProgressBar()
        {
            DependencyService.Get<IFormsTest>()?.AddFeature(new FeaturePair(GetAutomationId, GetProperty));
        }
        public string GetAutomationId()
        {
            return AutomationId;
        }
        public IPropertyGet GetProperty()
        {
            return this;
        }
        public string Get(string propertyName)
        {
            switch (propertyName)
            {
                //ELEMENT
                case nameof(ClassId):
                    return ClassId.ToString();
                case nameof(AutomationId):
                    return AutomationId.ToString();
                case nameof(Id):
                    return Id.ToString();
                case nameof(StyleId):
                    return StyleId.ToString();
                //VISUAL ELEMENT
                case nameof(AnchorX):
                    return AnchorX.ToString();
                case nameof(AnchorY):
                    return AnchorY.ToString();
                case nameof(BackgroundColor):
                    return BackgroundColor.ToHex();
                case nameof(Width):
                    return this.Width.ToString();
                case nameof(Height):
                    return this.Height.ToString();
                case nameof(IsEnabled):
                    return IsEnabled.ToString();
                case nameof(WidthRequest):
                    return this.WidthRequest.ToString();
                case nameof(HeightRequest):
                    return this.HeightRequest.ToString();
                case nameof(IsFocused):
                    return IsFocused.ToString();
                case nameof(IsVisible):
                    return IsVisible.ToString();
                case nameof(InputTransparent):
                    return InputTransparent.ToString();
                case nameof(X):
                    return this.X.ToString();
                case nameof(Y):
                    return this.Y.ToString();
                case nameof(Opacity):
                    return this.Opacity.ToString();
                case nameof(TranslationX):
                    return this.TranslationX.ToString();
                case nameof(TranslationY):
                    return this.TranslationY.ToString();
                case nameof(Rotation):
                    return this.Rotation.ToString();
                case nameof(RotationX):
                    return this.RotationX.ToString();
                case nameof(RotationY):
                    return this.RotationY.ToString();
                case nameof(Scale):
                    return this.Scale.ToString();
                //VIEW
                case nameof(Margin):
                    return this.Margin.ToString();
                case nameof(VerticalOptions):
                    return this.VerticalOptions.ToString();
                case nameof(HorizontalOptions):
                    return this.HorizontalOptions.ToString();

                //PROGRESSBAR
                case nameof(Progress):
                    return this.Progress.ToString();

                default:
                    return string.Empty;

            }
        }
    }
#else
    public class ProgressBar : Xamarin.Forms.ProgressBar
    {
    }
#endif
}
