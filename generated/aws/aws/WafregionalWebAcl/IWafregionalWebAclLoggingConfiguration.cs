using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafregionalWebAcl
{
    [JsiiInterface(nativeType: typeof(IWafregionalWebAclLoggingConfiguration), fullyQualifiedName: "aws.wafregionalWebAcl.WafregionalWebAclLoggingConfiguration")]
    public interface IWafregionalWebAclLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#log_destination WafregionalWebAcl#log_destination}.</summary>
        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
        string LogDestination
        {
            get;
        }

        /// <summary>redacted_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#redacted_fields WafregionalWebAcl#redacted_fields}
        /// </remarks>
        [JsiiProperty(name: "redactedFields", typeJson: "{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfigurationRedactedFields? RedactedFields
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalWebAclLoggingConfiguration), fullyQualifiedName: "aws.wafregionalWebAcl.WafregionalWebAclLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#log_destination WafregionalWebAcl#log_destination}.</summary>
            [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
            public string LogDestination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>redacted_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#redacted_fields WafregionalWebAcl#redacted_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redactedFields", typeJson: "{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
            public aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfigurationRedactedFields? RedactedFields
            {
                get => GetInstanceProperty<aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfigurationRedactedFields?>();
            }
        }
    }
}
