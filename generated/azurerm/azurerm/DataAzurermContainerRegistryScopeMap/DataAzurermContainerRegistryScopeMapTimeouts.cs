using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerRegistryScopeMap
{
    [JsiiByValue(fqn: "azurerm.dataAzurermContainerRegistryScopeMap.DataAzurermContainerRegistryScopeMapTimeouts")]
    public class DataAzurermContainerRegistryScopeMapTimeouts : azurerm.DataAzurermContainerRegistryScopeMap.IDataAzurermContainerRegistryScopeMapTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_scope_map#read DataAzurermContainerRegistryScopeMap#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
