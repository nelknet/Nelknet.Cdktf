using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafWebAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafWebAcl.WafWebAclLoggingConfiguration")]
    public class WafWebAclLoggingConfiguration : aws.WafWebAcl.IWafWebAclLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl#log_destination WafWebAcl#log_destination}.</summary>
        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
        public string LogDestination
        {
            get;
            set;
        }

        /// <summary>redacted_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl#redacted_fields WafWebAcl#redacted_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redactedFields", typeJson: "{\"fqn\":\"aws.wafWebAcl.WafWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
        public aws.WafWebAcl.IWafWebAclLoggingConfigurationRedactedFields? RedactedFields
        {
            get;
            set;
        }
    }
}
