using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesManagedDisk), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesManagedDisk")]
    public interface IAzurermProviderFeaturesManagedDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#expand_without_downtime AzurermProvider#expand_without_downtime}.</summary>
        [JsiiProperty(name: "expandWithoutDowntime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExpandWithoutDowntime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesManagedDisk), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesManagedDisk")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesManagedDisk
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#expand_without_downtime AzurermProvider#expand_without_downtime}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expandWithoutDowntime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ExpandWithoutDowntime
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
