using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigRule
{
    [JsiiInterface(nativeType: typeof(IConfigConfigRuleSource), fullyQualifiedName: "aws.configConfigRule.ConfigConfigRuleSource")]
    public interface IConfigConfigRuleSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#owner ConfigConfigRule#owner}.</summary>
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        string Owner
        {
            get;
        }

        /// <summary>custom_policy_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#custom_policy_details ConfigConfigRule#custom_policy_details}
        /// </remarks>
        [JsiiProperty(name: "customPolicyDetails", typeJson: "{\"fqn\":\"aws.configConfigRule.ConfigConfigRuleSourceCustomPolicyDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ConfigConfigRule.IConfigConfigRuleSourceCustomPolicyDetails? CustomPolicyDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_detail block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#source_detail ConfigConfigRule#source_detail}
        /// </remarks>
        [JsiiProperty(name: "sourceDetail", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.configConfigRule.ConfigConfigRuleSourceSourceDetail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceDetail
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#source_identifier ConfigConfigRule#source_identifier}.</summary>
        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConfigRuleSource), fullyQualifiedName: "aws.configConfigRule.ConfigConfigRuleSource")]
        internal sealed class _Proxy : DeputyBase, aws.ConfigConfigRule.IConfigConfigRuleSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#owner ConfigConfigRule#owner}.</summary>
            [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
            public string Owner
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>custom_policy_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#custom_policy_details ConfigConfigRule#custom_policy_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customPolicyDetails", typeJson: "{\"fqn\":\"aws.configConfigRule.ConfigConfigRuleSourceCustomPolicyDetails\"}", isOptional: true)]
            public aws.ConfigConfigRule.IConfigConfigRuleSourceCustomPolicyDetails? CustomPolicyDetails
            {
                get => GetInstanceProperty<aws.ConfigConfigRule.IConfigConfigRuleSourceCustomPolicyDetails?>();
            }

            /// <summary>source_detail block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#source_detail ConfigConfigRule#source_detail}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceDetail", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.configConfigRule.ConfigConfigRuleSourceSourceDetail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SourceDetail
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#source_identifier ConfigConfigRule#source_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceIdentifier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
