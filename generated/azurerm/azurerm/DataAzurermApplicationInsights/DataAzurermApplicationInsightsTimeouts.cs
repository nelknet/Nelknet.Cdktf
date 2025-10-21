using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApplicationInsights
{
    [JsiiByValue(fqn: "azurerm.dataAzurermApplicationInsights.DataAzurermApplicationInsightsTimeouts")]
    public class DataAzurermApplicationInsightsTimeouts : azurerm.DataAzurermApplicationInsights.IDataAzurermApplicationInsightsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_insights#read DataAzurermApplicationInsights#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
