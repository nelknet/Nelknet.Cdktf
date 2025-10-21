using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableImportTable), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableImportTable")]
    public interface IDynamodbTableImportTable
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#input_format DynamodbTable#input_format}.</summary>
        [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}")]
        string InputFormat
        {
            get;
        }

        /// <summary>s3_bucket_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#s3_bucket_source DynamodbTable#s3_bucket_source}
        /// </remarks>
        [JsiiProperty(name: "s3BucketSource", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableS3BucketSource\"}")]
        aws.DynamodbTable.IDynamodbTableImportTableS3BucketSource S3BucketSource
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#input_compression_type DynamodbTable#input_compression_type}.</summary>
        [JsiiProperty(name: "inputCompressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputCompressionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>input_format_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#input_format_options DynamodbTable#input_format_options}
        /// </remarks>
        [JsiiProperty(name: "inputFormatOptions", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableInputFormatOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptions? InputFormatOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableImportTable), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableImportTable")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbTable.IDynamodbTableImportTable
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#input_format DynamodbTable#input_format}.</summary>
            [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string InputFormat
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>s3_bucket_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#s3_bucket_source DynamodbTable#s3_bucket_source}
            /// </remarks>
            [JsiiProperty(name: "s3BucketSource", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableS3BucketSource\"}")]
            public aws.DynamodbTable.IDynamodbTableImportTableS3BucketSource S3BucketSource
            {
                get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTableImportTableS3BucketSource>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#input_compression_type DynamodbTable#input_compression_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputCompressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputCompressionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>input_format_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#input_format_options DynamodbTable#input_format_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputFormatOptions", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableInputFormatOptions\"}", isOptional: true)]
            public aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptions? InputFormatOptions
            {
                get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptions?>();
            }
        }
    }
}
