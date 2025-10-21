using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceProviderRegistration
{
    [JsiiInterface(nativeType: typeof(IResourceProviderRegistrationFeature), fullyQualifiedName: "azurerm.resourceProviderRegistration.ResourceProviderRegistrationFeature")]
    public interface IResourceProviderRegistrationFeature
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_provider_registration#name ResourceProviderRegistration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_provider_registration#registered ResourceProviderRegistration#registered}.</summary>
        [JsiiProperty(name: "registered", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Registered
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceProviderRegistrationFeature), fullyQualifiedName: "azurerm.resourceProviderRegistration.ResourceProviderRegistrationFeature")]
        internal sealed class _Proxy : DeputyBase, azurerm.ResourceProviderRegistration.IResourceProviderRegistrationFeature
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_provider_registration#name ResourceProviderRegistration#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_provider_registration#registered ResourceProviderRegistration#registered}.</summary>
            [JsiiProperty(name: "registered", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Registered
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
