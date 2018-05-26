using System;
using Xamarin.Forms;

namespace FormsTest
{
#if DEBUG
    public class Button : Xamarin.Forms.Button
    {
        public Button()
        {
            DependencyService.Get<IFormsTest>()?.AddFeature(new FeaturePair(GetAutomationId, GetProperty));
        }
        public string GetAutomationId()
        {
            return AutomationId;
        }
        public IPropertyGet GetProperty()
        {
            return (FormsTest.IPropertyGet)this;
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

                //BUTTON
                case nameof(BorderColor):
                    return BorderColor.ToHex();
    #pragma warning disable CS0618 // Type or member is obsolete
                case nameof(BorderRadius):
                    return BorderRadius.ToString();
    #pragma warning restore CS0618 // Type or member is obsolete
                case nameof(BorderWidth):
                    return BorderWidth.ToString();
                case nameof(CornerRadius):
                    return CornerRadius.ToString();
                case nameof(CommandParameter):
                    return CommandParameter.ToString();
                case nameof(FontAttributes):
                    return FontAttributes.ToString();
                case nameof(FontFamily):
                    return FontFamily;
                case nameof(FontSize):
                    return FontSize.ToString();
                case nameof(TextColor):
                    return TextColor.ToHex();
                case nameof(Text):
                    return Text;

                default:
                    return string.Empty;

            }
        }
    }
#else
    public class Button : Xamarin.Forms.Button
    {
    }
#endif
}
