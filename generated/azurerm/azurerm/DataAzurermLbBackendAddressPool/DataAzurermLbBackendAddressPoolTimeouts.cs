using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLbBackendAddressPool
{
    [JsiiByValue(fqn: "azurerm.dataAzurermLbBackendAddressPool.DataAzurermLbBackendAddressPoolTimeouts")]
    public class DataAzurermLbBackendAddressPoolTimeouts : azurerm.DataAzurermLbBackendAddressPool.IDataAzurermLbBackendAddressPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_backend_address_pool#read DataAzurermLbBackendAddressPool#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
