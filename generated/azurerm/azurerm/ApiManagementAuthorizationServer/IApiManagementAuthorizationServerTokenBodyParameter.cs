using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementAuthorizationServer
{
    [JsiiInterface(nativeType: typeof(IApiManagementAuthorizationServerTokenBodyParameter), fullyQualifiedName: "azurerm.apiManagementAuthorizationServer.ApiManagementAuthorizationServerTokenBodyParameter")]
    public interface IApiManagementAuthorizationServerTokenBodyParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#name ApiManagementAuthorizationServer#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#value ApiManagementAuthorizationServer#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementAuthorizationServerTokenBodyParameter), fullyQualifiedName: "azurerm.apiManagementAuthorizationServer.ApiManagementAuthorizationServerTokenBodyParameter")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementAuthorizationServer.IApiManagementAuthorizationServerTokenBodyParameter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#name ApiManagementAuthorizationServer#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#value ApiManagementAuthorizationServer#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
