using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPolicySetDefinition
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPolicySetDefinition.DataAzurermPolicySetDefinitionTimeouts")]
    public class DataAzurermPolicySetDefinitionTimeouts : azurerm.DataAzurermPolicySetDefinition.IDataAzurermPolicySetDefinitionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_set_definition#read DataAzurermPolicySetDefinition#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
