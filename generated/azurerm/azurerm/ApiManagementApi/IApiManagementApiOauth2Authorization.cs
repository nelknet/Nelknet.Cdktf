using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApi
{
    [JsiiInterface(nativeType: typeof(IApiManagementApiOauth2Authorization), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiOauth2Authorization")]
    public interface IApiManagementApiOauth2Authorization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#authorization_server_name ApiManagementApi#authorization_server_name}.</summary>
        [JsiiProperty(name: "authorizationServerName", typeJson: "{\"primitive\":\"string\"}")]
        string AuthorizationServerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#scope ApiManagementApi#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scope
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementApiOauth2Authorization), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiOauth2Authorization")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementApi.IApiManagementApiOauth2Authorization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#authorization_server_name ApiManagementApi#authorization_server_name}.</summary>
            [JsiiProperty(name: "authorizationServerName", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthorizationServerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#scope ApiManagementApi#scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scope
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
