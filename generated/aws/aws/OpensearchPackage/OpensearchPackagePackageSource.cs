using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchPackage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opensearchPackage.OpensearchPackagePackageSource")]
    public class OpensearchPackagePackageSource : aws.OpensearchPackage.IOpensearchPackagePackageSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package#s3_bucket_name OpensearchPackage#s3_bucket_name}.</summary>
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string S3BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package#s3_key OpensearchPackage#s3_key}.</summary>
        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Key
        {
            get;
            set;
        }
    }
}
