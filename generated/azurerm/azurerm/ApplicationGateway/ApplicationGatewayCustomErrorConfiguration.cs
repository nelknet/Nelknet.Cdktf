using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationGateway.ApplicationGatewayCustomErrorConfiguration")]
    public class ApplicationGatewayCustomErrorConfiguration : azurerm.ApplicationGateway.IApplicationGatewayCustomErrorConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#custom_error_page_url ApplicationGateway#custom_error_page_url}.</summary>
        [JsiiProperty(name: "customErrorPageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string CustomErrorPageUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#status_code ApplicationGateway#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}")]
        public string StatusCode
        {
            get;
            set;
        }
    }
}
