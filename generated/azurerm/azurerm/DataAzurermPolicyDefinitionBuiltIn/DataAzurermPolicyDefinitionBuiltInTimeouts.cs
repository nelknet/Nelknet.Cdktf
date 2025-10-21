using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPolicyDefinitionBuiltIn
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPolicyDefinitionBuiltIn.DataAzurermPolicyDefinitionBuiltInTimeouts")]
    public class DataAzurermPolicyDefinitionBuiltInTimeouts : azurerm.DataAzurermPolicyDefinitionBuiltIn.IDataAzurermPolicyDefinitionBuiltInTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition_built_in#read DataAzurermPolicyDefinitionBuiltIn#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
