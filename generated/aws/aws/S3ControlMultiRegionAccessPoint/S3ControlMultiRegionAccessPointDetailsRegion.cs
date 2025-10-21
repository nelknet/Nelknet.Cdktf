using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlMultiRegionAccessPoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsRegion")]
    public class S3ControlMultiRegionAccessPointDetailsRegion : aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetailsRegion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point#bucket S3ControlMultiRegionAccessPoint#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point#bucket_account_id S3ControlMultiRegionAccessPoint#bucket_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketAccountId
        {
            get;
            set;
        }
    }
}
