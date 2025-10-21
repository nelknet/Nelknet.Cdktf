using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSshPublicKey
{
    [JsiiByValue(fqn: "azurerm.dataAzurermSshPublicKey.DataAzurermSshPublicKeyTimeouts")]
    public class DataAzurermSshPublicKeyTimeouts : azurerm.DataAzurermSshPublicKey.IDataAzurermSshPublicKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ssh_public_key#read DataAzurermSshPublicKey#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
