using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApplicationGateway
{
    [JsiiByValue(fqn: "azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayTimeouts")]
    public class DataAzurermApplicationGatewayTimeouts : azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_gateway#read DataAzurermApplicationGateway#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
