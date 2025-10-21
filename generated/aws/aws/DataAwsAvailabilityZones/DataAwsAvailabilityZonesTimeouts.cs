using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAvailabilityZones
{
    [JsiiByValue(fqn: "aws.dataAwsAvailabilityZones.DataAwsAvailabilityZonesTimeouts")]
    public class DataAwsAvailabilityZonesTimeouts : aws.DataAwsAvailabilityZones.IDataAwsAvailabilityZonesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zones#read DataAwsAvailabilityZones#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
