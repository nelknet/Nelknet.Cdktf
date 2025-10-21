using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappPool
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetappPool.DataAzurermNetappPoolTimeouts")]
    public class DataAzurermNetappPoolTimeouts : azurerm.DataAzurermNetappPool.IDataAzurermNetappPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_pool#read DataAzurermNetappPool#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
