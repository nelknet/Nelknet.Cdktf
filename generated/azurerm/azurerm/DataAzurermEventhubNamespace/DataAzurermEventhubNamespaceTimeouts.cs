using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventhubNamespace
{
    [JsiiByValue(fqn: "azurerm.dataAzurermEventhubNamespace.DataAzurermEventhubNamespaceTimeouts")]
    public class DataAzurermEventhubNamespaceTimeouts : azurerm.DataAzurermEventhubNamespace.IDataAzurermEventhubNamespaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_namespace#read DataAzurermEventhubNamespace#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
