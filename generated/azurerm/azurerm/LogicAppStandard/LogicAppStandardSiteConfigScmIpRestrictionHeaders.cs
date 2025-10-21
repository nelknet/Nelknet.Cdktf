using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppStandard
{
    [JsiiByValue(fqn: "azurerm.logicAppStandard.LogicAppStandardSiteConfigScmIpRestrictionHeaders")]
    public class LogicAppStandardSiteConfigScmIpRestrictionHeaders : azurerm.LogicAppStandard.ILogicAppStandardSiteConfigScmIpRestrictionHeaders
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#x_azure_fdid LogicAppStandard#x_azure_fdid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "xAzureFdid", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? XAzureFdid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#x_fd_health_probe LogicAppStandard#x_fd_health_probe}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "xFdHealthProbe", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? XFdHealthProbe
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#x_forwarded_for LogicAppStandard#x_forwarded_for}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "xForwardedFor", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? XForwardedFor
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#x_forwarded_host LogicAppStandard#x_forwarded_host}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "xForwardedHost", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? XForwardedHost
        {
            get;
            set;
        }
    }
}
