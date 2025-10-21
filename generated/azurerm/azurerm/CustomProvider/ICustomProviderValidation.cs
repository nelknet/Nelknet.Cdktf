using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CustomProvider
{
    [JsiiInterface(nativeType: typeof(ICustomProviderValidation), fullyQualifiedName: "azurerm.customProvider.CustomProviderValidation")]
    public interface ICustomProviderValidation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#specification CustomProvider#specification}.</summary>
        [JsiiProperty(name: "specification", typeJson: "{\"primitive\":\"string\"}")]
        string Specification
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomProviderValidation), fullyQualifiedName: "azurerm.customProvider.CustomProviderValidation")]
        internal sealed class _Proxy : DeputyBase, azurerm.CustomProvider.ICustomProviderValidation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#specification CustomProvider#specification}.</summary>
            [JsiiProperty(name: "specification", typeJson: "{\"primitive\":\"string\"}")]
            public string Specification
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
