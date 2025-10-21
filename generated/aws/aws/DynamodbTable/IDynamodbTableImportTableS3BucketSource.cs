using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableImportTableS3BucketSource), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableImportTableS3BucketSource")]
    public interface IDynamodbTableImportTableS3BucketSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#bucket DynamodbTable#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#bucket_owner DynamodbTable#bucket_owner}.</summary>
        [JsiiProperty(name: "bucketOwner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketOwner
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#key_prefix DynamodbTable#key_prefix}.</summary>
        [JsiiProperty(name: "keyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableImportTableS3BucketSource), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableImportTableS3BucketSource")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbTable.IDynamodbTableImportTableS3BucketSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#bucket DynamodbTable#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#bucket_owner DynamodbTable#bucket_owner}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucketOwner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketOwner
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#key_prefix DynamodbTable#key_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
