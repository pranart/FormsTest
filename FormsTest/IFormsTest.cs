using System;
namespace FormsTest
{
    public interface IFormsTest
    {
        void AddFeature(FeaturePair pair);
        FeaturePair FindFeature(string AutomationId);

        string GetProperty(string AutomationIdDotProperty);

        void PushPage(string automationId);
        void PopPage(string automationId);
    }
}
