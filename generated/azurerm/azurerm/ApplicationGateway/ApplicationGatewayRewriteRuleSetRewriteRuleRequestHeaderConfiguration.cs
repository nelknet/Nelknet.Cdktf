using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfiguration")]
    public class ApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfiguration : azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#header_name ApplicationGateway#header_name}.</summary>
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
        public string HeaderName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#header_value ApplicationGateway#header_value}.</summary>
        [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}")]
        public string HeaderValue
        {
            get;
            set;
        }
    }
}
