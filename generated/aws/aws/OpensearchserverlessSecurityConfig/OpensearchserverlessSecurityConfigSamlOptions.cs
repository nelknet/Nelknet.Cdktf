using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchserverlessSecurityConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opensearchserverlessSecurityConfig.OpensearchserverlessSecurityConfigSamlOptions")]
    public class OpensearchserverlessSecurityConfigSamlOptions : aws.OpensearchserverlessSecurityConfig.IOpensearchserverlessSecurityConfigSamlOptions
    {
        /// <summary>The XML IdP metadata file generated from your identity provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_security_config#metadata OpensearchserverlessSecurityConfig#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}")]
        public string Metadata
        {
            get;
            set;
        }

        /// <summary>Group attribute for this SAML integration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_security_config#group_attribute OpensearchserverlessSecurityConfig#group_attribute}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groupAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupAttribute
        {
            get;
            set;
        }

        /// <summary>Session timeout, in minutes. Minimum is 5 minutes and maximum is 720 minutes (12 hours). Default is 60 minutes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_security_config#session_timeout OpensearchserverlessSecurityConfig#session_timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sessionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SessionTimeout
        {
            get;
            set;
        }

        /// <summary>User attribute for this SAML integration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_security_config#user_attribute OpensearchserverlessSecurityConfig#user_attribute}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAttribute
        {
            get;
            set;
        }
    }
}
