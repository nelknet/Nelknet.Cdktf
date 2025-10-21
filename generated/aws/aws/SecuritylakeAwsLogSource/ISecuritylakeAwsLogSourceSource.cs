using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeAwsLogSource
{
    [JsiiInterface(nativeType: typeof(ISecuritylakeAwsLogSourceSource), fullyQualifiedName: "aws.securitylakeAwsLogSource.SecuritylakeAwsLogSourceSource")]
    public interface ISecuritylakeAwsLogSourceSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_aws_log_source#regions SecuritylakeAwsLogSource#regions}.</summary>
        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Regions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_aws_log_source#source_name SecuritylakeAwsLogSource#source_name}.</summary>
        [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}")]
        string SourceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_aws_log_source#accounts SecuritylakeAwsLogSource#accounts}.</summary>
        [JsiiProperty(name: "accounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Accounts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_aws_log_source#source_version SecuritylakeAwsLogSource#source_version}.</summary>
        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecuritylakeAwsLogSourceSource), fullyQualifiedName: "aws.securitylakeAwsLogSource.SecuritylakeAwsLogSourceSource")]
        internal sealed class _Proxy : DeputyBase, aws.SecuritylakeAwsLogSource.ISecuritylakeAwsLogSourceSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_aws_log_source#regions SecuritylakeAwsLogSource#regions}.</summary>
            [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Regions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_aws_log_source#source_name SecuritylakeAwsLogSource#source_name}.</summary>
            [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_aws_log_source#accounts SecuritylakeAwsLogSource#accounts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Accounts
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_aws_log_source#source_version SecuritylakeAwsLogSource#source_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
