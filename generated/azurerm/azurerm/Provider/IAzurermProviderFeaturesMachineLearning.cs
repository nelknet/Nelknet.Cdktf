using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesMachineLearning), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesMachineLearning")]
    public interface IAzurermProviderFeaturesMachineLearning
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_deleted_workspace_on_destroy AzurermProvider#purge_soft_deleted_workspace_on_destroy}.</summary>
        [JsiiProperty(name: "purgeSoftDeletedWorkspaceOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PurgeSoftDeletedWorkspaceOnDestroy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesMachineLearning), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesMachineLearning")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesMachineLearning
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_deleted_workspace_on_destroy AzurermProvider#purge_soft_deleted_workspace_on_destroy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "purgeSoftDeletedWorkspaceOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PurgeSoftDeletedWorkspaceOnDestroy
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
