using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationS3
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationS3S3Config), fullyQualifiedName: "aws.datasyncLocationS3.DatasyncLocationS3S3Config")]
    public interface IDatasyncLocationS3S3Config
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_s3#bucket_access_role_arn DatasyncLocationS3#bucket_access_role_arn}.</summary>
        [JsiiProperty(name: "bucketAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string BucketAccessRoleArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationS3S3Config), fullyQualifiedName: "aws.datasyncLocationS3.DatasyncLocationS3S3Config")]
        internal sealed class _Proxy : DeputyBase, aws.DatasyncLocationS3.IDatasyncLocationS3S3Config
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_s3#bucket_access_role_arn DatasyncLocationS3#bucket_access_role_arn}.</summary>
            [JsiiProperty(name: "bucketAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketAccessRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
