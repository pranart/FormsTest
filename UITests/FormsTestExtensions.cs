using System;
using Xamarin.UITest;
using Xamarin.UITest.iOS;

namespace FormsTest.Extension
{
    public static class FormsTestExtensions
    {
        public static void FormsTest(this IApp app, string method, object argument = null)
        {
            if (app is iOSApp)
            {
                if (argument == null)
                {
                    argument = "";
                }
                app.Invoke($"{method}:", argument);
            }
            else
            {
                app.Invoke(method, argument);
            }
        }
        public static string FormsPropertyGet(this IApp app, object argument = null)
        {
            if (app is iOSApp)
            {
                if (argument == null)
                {
                    argument = "";
                }
                return app.Invoke($"FormsPropertyGet:", argument).ToString();
            }
            else
            {
                return app.Invoke("FormsPropertyGet", argument).ToString();
            }
        }

    }
}
