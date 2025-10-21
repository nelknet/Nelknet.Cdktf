using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.appServiceConnection.AppServiceConnectionSecretStore")]
    public class AppServiceConnectionSecretStore : azurerm.AppServiceConnection.IAppServiceConnectionSecretStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection#key_vault_id AppServiceConnection#key_vault_id}.</summary>
        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultId
        {
            get;
            set;
        }
    }
}
