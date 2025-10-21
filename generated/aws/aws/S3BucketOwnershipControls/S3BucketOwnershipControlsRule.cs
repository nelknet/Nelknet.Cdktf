using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketOwnershipControls
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketOwnershipControls.S3BucketOwnershipControlsRule")]
    public class S3BucketOwnershipControlsRule : aws.S3BucketOwnershipControls.IS3BucketOwnershipControlsRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_ownership_controls#object_ownership S3BucketOwnershipControls#object_ownership}.</summary>
        [JsiiProperty(name: "objectOwnership", typeJson: "{\"primitive\":\"string\"}")]
        public string ObjectOwnership
        {
            get;
            set;
        }
    }
}
