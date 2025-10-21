using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    [JsiiInterface(nativeType: typeof(ISecurityhubAutomationRuleActionsFindingFieldsUpdate), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdate")]
    public interface ISecurityhubAutomationRuleActionsFindingFieldsUpdate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#confidence SecurityhubAutomationRule#confidence}.</summary>
        [JsiiProperty(name: "confidence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Confidence
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#criticality SecurityhubAutomationRule#criticality}.</summary>
        [JsiiProperty(name: "criticality", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Criticality
        {
            get
            {
                return null;
            }
        }

        /// <summary>note block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#note SecurityhubAutomationRule#note}
        /// </remarks>
        [JsiiProperty(name: "note", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateNote\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Note
        {
            get
            {
                return null;
            }
        }

        /// <summary>related_findings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#related_findings SecurityhubAutomationRule#related_findings}
        /// </remarks>
        [JsiiProperty(name: "relatedFindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateRelatedFindings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RelatedFindings
        {
            get
            {
                return null;
            }
        }

        /// <summary>severity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#severity SecurityhubAutomationRule#severity}
        /// </remarks>
        [JsiiProperty(name: "severity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateSeverity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Severity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#types SecurityhubAutomationRule#types}.</summary>
        [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Types
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#user_defined_fields SecurityhubAutomationRule#user_defined_fields}.</summary>
        [JsiiProperty(name: "userDefinedFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? UserDefinedFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#verification_state SecurityhubAutomationRule#verification_state}.</summary>
        [JsiiProperty(name: "verificationState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VerificationState
        {
            get
            {
                return null;
            }
        }

        /// <summary>workflow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#workflow SecurityhubAutomationRule#workflow}
        /// </remarks>
        [JsiiProperty(name: "workflow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateWorkflow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Workflow
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubAutomationRuleActionsFindingFieldsUpdate), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdate")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleActionsFindingFieldsUpdate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#confidence SecurityhubAutomationRule#confidence}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "confidence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Confidence
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#criticality SecurityhubAutomationRule#criticality}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "criticality", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Criticality
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>note block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#note SecurityhubAutomationRule#note}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "note", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateNote\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Note
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>related_findings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#related_findings SecurityhubAutomationRule#related_findings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "relatedFindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateRelatedFindings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RelatedFindings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>severity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#severity SecurityhubAutomationRule#severity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "severity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateSeverity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Severity
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#types SecurityhubAutomationRule#types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Types
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#user_defined_fields SecurityhubAutomationRule#user_defined_fields}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userDefinedFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? UserDefinedFields
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#verification_state SecurityhubAutomationRule#verification_state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verificationState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VerificationState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>workflow block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#workflow SecurityhubAutomationRule#workflow}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workflow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdateWorkflow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Workflow
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
