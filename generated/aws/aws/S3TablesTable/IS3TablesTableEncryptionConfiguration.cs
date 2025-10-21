using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableEncryptionConfiguration), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableEncryptionConfiguration")]
    public interface IS3TablesTableEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#kms_key_arn S3TablesTable#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#sse_algorithm S3TablesTable#sse_algorithm}.</summary>
        [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SseAlgorithm
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableEncryptionConfiguration), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTable.IS3TablesTableEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#kms_key_arn S3TablesTable#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#sse_algorithm S3TablesTable#sse_algorithm}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SseAlgorithm
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
