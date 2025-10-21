using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigRule
{
    [JsiiInterface(nativeType: typeof(IConfigConfigRuleSourceSourceDetail), fullyQualifiedName: "aws.configConfigRule.ConfigConfigRuleSourceSourceDetail")]
    public interface IConfigConfigRuleSourceSourceDetail
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#event_source ConfigConfigRule#event_source}.</summary>
        [JsiiProperty(name: "eventSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#maximum_execution_frequency ConfigConfigRule#maximum_execution_frequency}.</summary>
        [JsiiProperty(name: "maximumExecutionFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumExecutionFrequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#message_type ConfigConfigRule#message_type}.</summary>
        [JsiiProperty(name: "messageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConfigRuleSourceSourceDetail), fullyQualifiedName: "aws.configConfigRule.ConfigConfigRuleSourceSourceDetail")]
        internal sealed class _Proxy : DeputyBase, aws.ConfigConfigRule.IConfigConfigRuleSourceSourceDetail
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#event_source ConfigConfigRule#event_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventSource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#maximum_execution_frequency ConfigConfigRule#maximum_execution_frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumExecutionFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumExecutionFrequency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#message_type ConfigConfigRule#message_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
