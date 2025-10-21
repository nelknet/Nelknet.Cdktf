using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    [JsiiInterface(nativeType: typeof(IApiManagementSignUp), fullyQualifiedName: "azurerm.apiManagement.ApiManagementSignUp")]
    public interface IApiManagementSignUp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#enabled ApiManagement#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>terms_of_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#terms_of_service ApiManagement#terms_of_service}
        /// </remarks>
        [JsiiProperty(name: "termsOfService", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSignUpTermsOfService\"}")]
        azurerm.ApiManagement.IApiManagementSignUpTermsOfService TermsOfService
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementSignUp), fullyQualifiedName: "azurerm.apiManagement.ApiManagementSignUp")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagement.IApiManagementSignUp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#enabled ApiManagement#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>terms_of_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#terms_of_service ApiManagement#terms_of_service}
            /// </remarks>
            [JsiiProperty(name: "termsOfService", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSignUpTermsOfService\"}")]
            public azurerm.ApiManagement.IApiManagementSignUpTermsOfService TermsOfService
            {
                get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementSignUpTermsOfService>()!;
            }
        }
    }
}
