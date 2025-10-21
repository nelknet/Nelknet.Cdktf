using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigRule
{
    [JsiiInterface(nativeType: typeof(IConfigConfigRuleSourceCustomPolicyDetails), fullyQualifiedName: "aws.configConfigRule.ConfigConfigRuleSourceCustomPolicyDetails")]
    public interface IConfigConfigRuleSourceCustomPolicyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#policy_runtime ConfigConfigRule#policy_runtime}.</summary>
        [JsiiProperty(name: "policyRuntime", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyRuntime
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#policy_text ConfigConfigRule#policy_text}.</summary>
        [JsiiProperty(name: "policyText", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyText
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#enable_debug_log_delivery ConfigConfigRule#enable_debug_log_delivery}.</summary>
        [JsiiProperty(name: "enableDebugLogDelivery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableDebugLogDelivery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConfigRuleSourceCustomPolicyDetails), fullyQualifiedName: "aws.configConfigRule.ConfigConfigRuleSourceCustomPolicyDetails")]
        internal sealed class _Proxy : DeputyBase, aws.ConfigConfigRule.IConfigConfigRuleSourceCustomPolicyDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#policy_runtime ConfigConfigRule#policy_runtime}.</summary>
            [JsiiProperty(name: "policyRuntime", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyRuntime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#policy_text ConfigConfigRule#policy_text}.</summary>
            [JsiiProperty(name: "policyText", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyText
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#enable_debug_log_delivery ConfigConfigRule#enable_debug_log_delivery}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableDebugLogDelivery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableDebugLogDelivery
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
