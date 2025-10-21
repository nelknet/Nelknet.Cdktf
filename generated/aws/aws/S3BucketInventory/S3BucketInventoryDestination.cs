using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketInventory
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketInventory.S3BucketInventoryDestination")]
    public class S3BucketInventoryDestination : aws.S3BucketInventory.IS3BucketInventoryDestination
    {
        /// <summary>bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#bucket S3BucketInventory#bucket}
        /// </remarks>
        [JsiiProperty(name: "bucket", typeJson: "{\"fqn\":\"aws.s3BucketInventory.S3BucketInventoryDestinationBucket\"}")]
        public aws.S3BucketInventory.IS3BucketInventoryDestinationBucket Bucket
        {
            get;
            set;
        }
    }
}
