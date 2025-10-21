using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PolicySetDefinition
{
    [JsiiInterface(nativeType: typeof(IPolicySetDefinitionPolicyDefinitionReference), fullyQualifiedName: "azurerm.policySetDefinition.PolicySetDefinitionPolicyDefinitionReference")]
    public interface IPolicySetDefinitionPolicyDefinitionReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#policy_definition_id PolicySetDefinition#policy_definition_id}.</summary>
        [JsiiProperty(name: "policyDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyDefinitionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#parameter_values PolicySetDefinition#parameter_values}.</summary>
        [JsiiProperty(name: "parameterValues", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParameterValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#policy_group_names PolicySetDefinition#policy_group_names}.</summary>
        [JsiiProperty(name: "policyGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PolicyGroupNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#reference_id PolicySetDefinition#reference_id}.</summary>
        [JsiiProperty(name: "referenceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReferenceId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPolicySetDefinitionPolicyDefinitionReference), fullyQualifiedName: "azurerm.policySetDefinition.PolicySetDefinitionPolicyDefinitionReference")]
        internal sealed class _Proxy : DeputyBase, azurerm.PolicySetDefinition.IPolicySetDefinitionPolicyDefinitionReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#policy_definition_id PolicySetDefinition#policy_definition_id}.</summary>
            [JsiiProperty(name: "policyDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyDefinitionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#parameter_values PolicySetDefinition#parameter_values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameterValues", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParameterValues
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#policy_group_names PolicySetDefinition#policy_group_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PolicyGroupNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#reference_id PolicySetDefinition#reference_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "referenceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReferenceId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
