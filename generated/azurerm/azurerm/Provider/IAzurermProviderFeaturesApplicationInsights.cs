using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesApplicationInsights), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesApplicationInsights")]
    public interface IAzurermProviderFeaturesApplicationInsights
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#disable_generated_rule AzurermProvider#disable_generated_rule}.</summary>
        [JsiiProperty(name: "disableGeneratedRule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableGeneratedRule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesApplicationInsights), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesApplicationInsights")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesApplicationInsights
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#disable_generated_rule AzurermProvider#disable_generated_rule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableGeneratedRule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DisableGeneratedRule
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
