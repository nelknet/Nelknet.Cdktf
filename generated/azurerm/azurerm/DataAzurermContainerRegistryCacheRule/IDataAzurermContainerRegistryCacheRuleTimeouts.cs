using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerRegistryCacheRule
{
    [JsiiInterface(nativeType: typeof(IDataAzurermContainerRegistryCacheRuleTimeouts), fullyQualifiedName: "azurerm.dataAzurermContainerRegistryCacheRule.DataAzurermContainerRegistryCacheRuleTimeouts")]
    public interface IDataAzurermContainerRegistryCacheRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_cache_rule#read DataAzurermContainerRegistryCacheRule#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermContainerRegistryCacheRuleTimeouts), fullyQualifiedName: "azurerm.dataAzurermContainerRegistryCacheRule.DataAzurermContainerRegistryCacheRuleTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermContainerRegistryCacheRule.IDataAzurermContainerRegistryCacheRuleTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_cache_rule#read DataAzurermContainerRegistryCacheRule#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
