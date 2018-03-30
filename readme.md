# FormTest Status
## Usage

use FormsTest.Page instead of Page
use FormsTest.xControl instead of Xamarin.Forms.xControl

```xml
<?xml version="1.0" encoding="utf-8"?>
<ft:Page
    xmlns="http://xamarin.com/schemas/2014/forms" 
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml" 
    xmlns:ft="clr-namespace:FormsTest;assembly=FormsTest" 
    x:Class="FormsTestSample.FormsTestPage">
	<ft:Label 
        AutomationId="FtLabel" 
        Text="Welcome to Xamarin Forms!" 
        VerticalOptions="Center" 
        HorizontalOptions="Center" />
</ft:Page>
```

in UITest you can read any property of Controls
```csharp
        [Test]
        public void TestFormsLabelTextColorProperty()
        {
            app.WaitForElement("FtLabel");
            string isVisible = app.FormsPropertyGet("FtLabel.IsVisible");
            string x = app.FormsPropertyGet("FtLabel.X");
                     
        }
```

other details please see sample project.

## View 
View that FormTest currently supported


View  | Status
------|------
ActivityIndicator | Done
BoxView | Done
Button | Done
DatePicker | Done
Editor | Done
Entry | Done
Image | Done
Label | Done
ListView | Semi-Done
Page | Semi-Done
Picker | Done
ProgressBar | Done
SearchBar | Done
Slider | Done
Stepper | Done
Switch | Done
TableView | Semi-Done
TimePicker | Done
WebView | Done
