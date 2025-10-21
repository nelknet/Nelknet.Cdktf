using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3AccessPoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3AccessPoint.S3AccessPointVpcConfiguration")]
    public class S3AccessPointVpcConfiguration : aws.S3AccessPoint.IS3AccessPointVpcConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_access_point#vpc_id S3AccessPoint#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcId
        {
            get;
            set;
        }
    }
}
