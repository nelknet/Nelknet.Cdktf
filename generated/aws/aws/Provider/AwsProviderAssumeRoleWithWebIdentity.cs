using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Provider
{
    [JsiiByValue(fqn: "aws.provider.AwsProviderAssumeRoleWithWebIdentity")]
    public class AwsProviderAssumeRoleWithWebIdentity : aws.Provider.IAwsProviderAssumeRoleWithWebIdentity
    {
        /// <summary>The duration, between 15 minutes and 12 hours, of the role session.</summary>
        /// <remarks>
        /// Valid time units are ns, us (or µs), ms, s, h, or m.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#duration AwsProvider#duration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Duration
        {
            get;
            set;
        }

        /// <summary>IAM Policy JSON describing further restricting permissions for the IAM Role being assumed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#policy AwsProvider#policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Policy
        {
            get;
            set;
        }

        /// <summary>Amazon Resource Names (ARNs) of IAM Policies describing further restricting permissions for the IAM Role being assumed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#policy_arns AwsProvider#policy_arns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "policyArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PolicyArns
        {
            get;
            set;
        }

        /// <summary>Amazon Resource Name (ARN) of an IAM Role to assume prior to making API calls.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#role_arn AwsProvider#role_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoleArn
        {
            get;
            set;
        }

        /// <summary>An identifier for the assumed role session.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#session_name AwsProvider#session_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sessionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SessionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#web_identity_token AwsProvider#web_identity_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "webIdentityToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WebIdentityToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#web_identity_token_file AwsProvider#web_identity_token_file}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "webIdentityTokenFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WebIdentityTokenFile
        {
            get;
            set;
        }
    }
}
