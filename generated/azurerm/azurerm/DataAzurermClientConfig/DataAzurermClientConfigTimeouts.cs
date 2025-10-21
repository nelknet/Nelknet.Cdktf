using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermClientConfig
{
    [JsiiByValue(fqn: "azurerm.dataAzurermClientConfig.DataAzurermClientConfigTimeouts")]
    public class DataAzurermClientConfigTimeouts : azurerm.DataAzurermClientConfig.IDataAzurermClientConfigTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/client_config#read DataAzurermClientConfig#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
