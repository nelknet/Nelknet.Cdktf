using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedApplicationDefinition
{
    [JsiiByValue(fqn: "azurerm.dataAzurermManagedApplicationDefinition.DataAzurermManagedApplicationDefinitionTimeouts")]
    public class DataAzurermManagedApplicationDefinitionTimeouts : azurerm.DataAzurermManagedApplicationDefinition.IDataAzurermManagedApplicationDefinitionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_application_definition#read DataAzurermManagedApplicationDefinition#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
