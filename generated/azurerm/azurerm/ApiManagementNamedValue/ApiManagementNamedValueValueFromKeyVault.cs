using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementNamedValue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementNamedValue.ApiManagementNamedValueValueFromKeyVault")]
    public class ApiManagementNamedValueValueFromKeyVault : azurerm.ApiManagementNamedValue.IApiManagementNamedValueValueFromKeyVault
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#secret_id ApiManagementNamedValue#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#identity_client_id ApiManagementNamedValue#identity_client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityClientId
        {
            get;
            set;
        }
    }
}
