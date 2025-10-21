using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.springCloudConnection.SpringCloudConnectionSecretStore")]
    public class SpringCloudConnectionSecretStore : azurerm.SpringCloudConnection.ISpringCloudConnectionSecretStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection#key_vault_id SpringCloudConnection#key_vault_id}.</summary>
        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultId
        {
            get;
            set;
        }
    }
}
