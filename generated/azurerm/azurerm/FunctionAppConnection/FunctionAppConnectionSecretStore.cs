using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.functionAppConnection.FunctionAppConnectionSecretStore")]
    public class FunctionAppConnectionSecretStore : azurerm.FunctionAppConnection.IFunctionAppConnectionSecretStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection#key_vault_id FunctionAppConnection#key_vault_id}.</summary>
        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultId
        {
            get;
            set;
        }
    }
}
