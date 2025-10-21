using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationInsightsStandardWebTest
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestRequestHeader")]
    public class ApplicationInsightsStandardWebTestRequestHeader : azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestRequestHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#name ApplicationInsightsStandardWebTest#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#value ApplicationInsightsStandardWebTest#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
