using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dynamodbTable.DynamodbTableImportTable")]
    public class DynamodbTableImportTable : aws.DynamodbTable.IDynamodbTableImportTable
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#input_format DynamodbTable#input_format}.</summary>
        [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}")]
        public string InputFormat
        {
            get;
            set;
        }

        /// <summary>s3_bucket_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#s3_bucket_source DynamodbTable#s3_bucket_source}
        /// </remarks>
        [JsiiProperty(name: "s3BucketSource", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableS3BucketSource\"}")]
        public aws.DynamodbTable.IDynamodbTableImportTableS3BucketSource S3BucketSource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#input_compression_type DynamodbTable#input_compression_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputCompressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputCompressionType
        {
            get;
            set;
        }

        /// <summary>input_format_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#input_format_options DynamodbTable#input_format_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputFormatOptions", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableInputFormatOptions\"}", isOptional: true)]
        public aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptions? InputFormatOptions
        {
            get;
            set;
        }
    }
}
