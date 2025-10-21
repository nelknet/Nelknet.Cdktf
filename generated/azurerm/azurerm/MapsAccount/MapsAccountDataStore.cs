using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MapsAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mapsAccount.MapsAccountDataStore")]
    public class MapsAccountDataStore : azurerm.MapsAccount.IMapsAccountDataStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#unique_name MapsAccount#unique_name}.</summary>
        [JsiiProperty(name: "uniqueName", typeJson: "{\"primitive\":\"string\"}")]
        public string UniqueName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#storage_account_id MapsAccount#storage_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountId
        {
            get;
            set;
        }
    }
}
