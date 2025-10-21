using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerRegistryCacheRule
{
    [JsiiByValue(fqn: "azurerm.dataAzurermContainerRegistryCacheRule.DataAzurermContainerRegistryCacheRuleTimeouts")]
    public class DataAzurermContainerRegistryCacheRuleTimeouts : azurerm.DataAzurermContainerRegistryCacheRule.IDataAzurermContainerRegistryCacheRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_cache_rule#read DataAzurermContainerRegistryCacheRule#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
