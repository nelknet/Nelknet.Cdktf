using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesApiManagement), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesApiManagement")]
    public interface IAzurermProviderFeaturesApiManagement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_delete_on_destroy AzurermProvider#purge_soft_delete_on_destroy}.</summary>
        [JsiiProperty(name: "purgeSoftDeleteOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PurgeSoftDeleteOnDestroy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recover_soft_deleted AzurermProvider#recover_soft_deleted}.</summary>
        [JsiiProperty(name: "recoverSoftDeleted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecoverSoftDeleted
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesApiManagement), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesApiManagement")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesApiManagement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_delete_on_destroy AzurermProvider#purge_soft_delete_on_destroy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "purgeSoftDeleteOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PurgeSoftDeleteOnDestroy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recover_soft_deleted AzurermProvider#recover_soft_deleted}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recoverSoftDeleted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RecoverSoftDeleted
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
