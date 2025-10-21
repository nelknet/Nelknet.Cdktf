using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketInventory
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketInventory.S3BucketInventorySchedule")]
    public class S3BucketInventorySchedule : aws.S3BucketInventory.IS3BucketInventorySchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#frequency S3BucketInventory#frequency}.</summary>
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
        public string Frequency
        {
            get;
            set;
        }
    }
}
