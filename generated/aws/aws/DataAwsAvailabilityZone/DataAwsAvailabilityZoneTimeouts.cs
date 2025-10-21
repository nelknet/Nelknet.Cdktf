using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAvailabilityZone
{
    [JsiiByValue(fqn: "aws.dataAwsAvailabilityZone.DataAwsAvailabilityZoneTimeouts")]
    public class DataAwsAvailabilityZoneTimeouts : aws.DataAwsAvailabilityZone.IDataAwsAvailabilityZoneTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zone#read DataAwsAvailabilityZone#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
