using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTableBucket
{
    [JsiiByValue(fqn: "aws.s3TablesTableBucket.S3TablesTableBucketEncryptionConfiguration")]
    public class S3TablesTableBucketEncryptionConfiguration : aws.S3TablesTableBucket.IS3TablesTableBucketEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#kms_key_arn S3TablesTableBucket#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#sse_algorithm S3TablesTableBucket#sse_algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SseAlgorithm
        {
            get;
            set;
        }
    }
}
