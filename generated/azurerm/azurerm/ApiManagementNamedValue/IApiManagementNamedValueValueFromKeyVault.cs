using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementNamedValue
{
    [JsiiInterface(nativeType: typeof(IApiManagementNamedValueValueFromKeyVault), fullyQualifiedName: "azurerm.apiManagementNamedValue.ApiManagementNamedValueValueFromKeyVault")]
    public interface IApiManagementNamedValueValueFromKeyVault
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#secret_id ApiManagementNamedValue#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        string SecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#identity_client_id ApiManagementNamedValue#identity_client_id}.</summary>
        [JsiiProperty(name: "identityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentityClientId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementNamedValueValueFromKeyVault), fullyQualifiedName: "azurerm.apiManagementNamedValue.ApiManagementNamedValueValueFromKeyVault")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementNamedValue.IApiManagementNamedValueValueFromKeyVault
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#secret_id ApiManagementNamedValue#secret_id}.</summary>
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#identity_client_id ApiManagementNamedValue#identity_client_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentityClientId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
