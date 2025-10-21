using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesTemplateDeployment), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesTemplateDeployment")]
    public interface IAzurermProviderFeaturesTemplateDeployment
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#delete_nested_items_during_deletion AzurermProvider#delete_nested_items_during_deletion}.</summary>
        [JsiiProperty(name: "deleteNestedItemsDuringDeletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object DeleteNestedItemsDuringDeletion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesTemplateDeployment), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesTemplateDeployment")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesTemplateDeployment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#delete_nested_items_during_deletion AzurermProvider#delete_nested_items_during_deletion}.</summary>
            [JsiiProperty(name: "deleteNestedItemsDuringDeletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object DeleteNestedItemsDuringDeletion
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
