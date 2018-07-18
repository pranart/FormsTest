using System;
namespace FormsTest
{
    public class FeaturePair
    {
        public Func<string> GetAutomationId;
        public Func<IPropertyGet> GetProperty;
        public string PageName { get; set; }

        public FeaturePair(Func<string> getAutomationId,Func<IPropertyGet> getProperty)
        {
            GetAutomationId = getAutomationId;
            GetProperty = getProperty;
        }
    }
}
