using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationInsightsWorkbook
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationInsightsWorkbook.ApplicationInsightsWorkbookIdentity")]
    public class ApplicationInsightsWorkbookIdentity : azurerm.ApplicationInsightsWorkbook.IApplicationInsightsWorkbookIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#type ApplicationInsightsWorkbook#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#identity_ids ApplicationInsightsWorkbook#identity_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IdentityIds
        {
            get;
            set;
        }
    }
}
