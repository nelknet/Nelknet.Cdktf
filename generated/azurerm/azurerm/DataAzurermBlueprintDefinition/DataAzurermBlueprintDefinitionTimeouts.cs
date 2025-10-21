using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBlueprintDefinition
{
    [JsiiByValue(fqn: "azurerm.dataAzurermBlueprintDefinition.DataAzurermBlueprintDefinitionTimeouts")]
    public class DataAzurermBlueprintDefinitionTimeouts : azurerm.DataAzurermBlueprintDefinition.IDataAzurermBlueprintDefinitionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/blueprint_definition#read DataAzurermBlueprintDefinition#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
