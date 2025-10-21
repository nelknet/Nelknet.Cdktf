using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafregionalWebAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafregionalWebAcl.WafregionalWebAclLoggingConfiguration")]
    public class WafregionalWebAclLoggingConfiguration : aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#log_destination WafregionalWebAcl#log_destination}.</summary>
        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
        public string LogDestination
        {
            get;
            set;
        }

        /// <summary>redacted_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#redacted_fields WafregionalWebAcl#redacted_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redactedFields", typeJson: "{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
        public aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfigurationRedactedFields? RedactedFields
        {
            get;
            set;
        }
    }
}
