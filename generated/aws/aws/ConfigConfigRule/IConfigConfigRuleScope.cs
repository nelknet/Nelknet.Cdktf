using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigRule
{
    [JsiiInterface(nativeType: typeof(IConfigConfigRuleScope), fullyQualifiedName: "aws.configConfigRule.ConfigConfigRuleScope")]
    public interface IConfigConfigRuleScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#compliance_resource_id ConfigConfigRule#compliance_resource_id}.</summary>
        [JsiiProperty(name: "complianceResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComplianceResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#compliance_resource_types ConfigConfigRule#compliance_resource_types}.</summary>
        [JsiiProperty(name: "complianceResourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ComplianceResourceTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#tag_key ConfigConfigRule#tag_key}.</summary>
        [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TagKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#tag_value ConfigConfigRule#tag_value}.</summary>
        [JsiiProperty(name: "tagValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TagValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConfigRuleScope), fullyQualifiedName: "aws.configConfigRule.ConfigConfigRuleScope")]
        internal sealed class _Proxy : DeputyBase, aws.ConfigConfigRule.IConfigConfigRuleScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#compliance_resource_id ConfigConfigRule#compliance_resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "complianceResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComplianceResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#compliance_resource_types ConfigConfigRule#compliance_resource_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "complianceResourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ComplianceResourceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#tag_key ConfigConfigRule#tag_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TagKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#tag_value ConfigConfigRule#tag_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TagValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
