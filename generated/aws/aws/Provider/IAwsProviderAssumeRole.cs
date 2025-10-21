using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Provider
{
    [JsiiInterface(nativeType: typeof(IAwsProviderAssumeRole), fullyQualifiedName: "aws.provider.AwsProviderAssumeRole")]
    public interface IAwsProviderAssumeRole
    {
        /// <summary>The duration, between 15 minutes and 12 hours, of the role session.</summary>
        /// <remarks>
        /// Valid time units are ns, us (or µs), ms, s, h, or m.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#duration AwsProvider#duration}
        /// </remarks>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Duration
        {
            get
            {
                return null;
            }
        }

        /// <summary>A unique identifier that might be required when you assume a role in another account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#external_id AwsProvider#external_id}
        /// </remarks>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalId
        {
            get
            {
                return null;
            }
        }

        /// <summary>IAM Policy JSON describing further restricting permissions for the IAM Role being assumed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#policy AwsProvider#policy}
        /// </remarks>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Policy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Amazon Resource Names (ARNs) of IAM Policies describing further restricting permissions for the IAM Role being assumed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#policy_arns AwsProvider#policy_arns}
        /// </remarks>
        [JsiiProperty(name: "policyArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PolicyArns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Amazon Resource Name (ARN) of an IAM Role to assume prior to making API calls.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#role_arn AwsProvider#role_arn}
        /// </remarks>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>An identifier for the assumed role session.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#session_name AwsProvider#session_name}
        /// </remarks>
        [JsiiProperty(name: "sessionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SessionName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Source identity specified by the principal assuming the role.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#source_identity AwsProvider#source_identity}
        /// </remarks>
        [JsiiProperty(name: "sourceIdentity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceIdentity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Assume role session tags.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#tags AwsProvider#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Assume role session tag keys to pass to any subsequent sessions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#transitive_tag_keys AwsProvider#transitive_tag_keys}
        /// </remarks>
        [JsiiProperty(name: "transitiveTagKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TransitiveTagKeys
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAwsProviderAssumeRole), fullyQualifiedName: "aws.provider.AwsProviderAssumeRole")]
        internal sealed class _Proxy : DeputyBase, aws.Provider.IAwsProviderAssumeRole
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A unique identifier that might be required when you assume a role in another account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#external_id AwsProvider#external_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>IAM Policy JSON describing further restricting permissions for the IAM Role being assumed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#policy AwsProvider#policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Policy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Amazon Resource Names (ARNs) of IAM Policies describing further restricting permissions for the IAM Role being assumed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#policy_arns AwsProvider#policy_arns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "policyArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PolicyArns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Amazon Resource Name (ARN) of an IAM Role to assume prior to making API calls.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#role_arn AwsProvider#role_arn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>An identifier for the assumed role session.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#session_name AwsProvider#session_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SessionName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Source identity specified by the principal assuming the role.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#source_identity AwsProvider#source_identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceIdentity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceIdentity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Assume role session tags.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#tags AwsProvider#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Assume role session tag keys to pass to any subsequent sessions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#transitive_tag_keys AwsProvider#transitive_tag_keys}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transitiveTagKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TransitiveTagKeys
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
