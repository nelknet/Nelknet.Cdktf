using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiByValue(fqn: "aws.s3TablesTable.S3TablesTableEncryptionConfiguration")]
    public class S3TablesTableEncryptionConfiguration : aws.S3TablesTable.IS3TablesTableEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#kms_key_arn S3TablesTable#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#sse_algorithm S3TablesTable#sse_algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SseAlgorithm
        {
            get;
            set;
        }
    }
}
