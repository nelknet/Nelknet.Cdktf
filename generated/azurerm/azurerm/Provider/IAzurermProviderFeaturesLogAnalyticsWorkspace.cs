using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesLogAnalyticsWorkspace), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesLogAnalyticsWorkspace")]
    public interface IAzurermProviderFeaturesLogAnalyticsWorkspace
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#permanently_delete_on_destroy AzurermProvider#permanently_delete_on_destroy}.</summary>
        [JsiiProperty(name: "permanentlyDeleteOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PermanentlyDeleteOnDestroy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesLogAnalyticsWorkspace), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesLogAnalyticsWorkspace")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesLogAnalyticsWorkspace
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#permanently_delete_on_destroy AzurermProvider#permanently_delete_on_destroy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "permanentlyDeleteOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PermanentlyDeleteOnDestroy
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
