using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PolicySetDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.policySetDefinition.PolicySetDefinitionPolicyDefinitionReference")]
    public class PolicySetDefinitionPolicyDefinitionReference : azurerm.PolicySetDefinition.IPolicySetDefinitionPolicyDefinitionReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#policy_definition_id PolicySetDefinition#policy_definition_id}.</summary>
        [JsiiProperty(name: "policyDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
        public string PolicyDefinitionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#parameter_values PolicySetDefinition#parameter_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameterValues", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParameterValues
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#policy_group_names PolicySetDefinition#policy_group_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PolicyGroupNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#reference_id PolicySetDefinition#reference_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "referenceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReferenceId
        {
            get;
            set;
        }
    }
}
