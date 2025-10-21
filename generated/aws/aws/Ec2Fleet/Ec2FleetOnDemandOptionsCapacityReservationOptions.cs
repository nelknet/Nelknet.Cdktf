using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2Fleet
{
    [JsiiByValue(fqn: "aws.ec2Fleet.Ec2FleetOnDemandOptionsCapacityReservationOptions")]
    public class Ec2FleetOnDemandOptionsCapacityReservationOptions : aws.Ec2Fleet.IEc2FleetOnDemandOptionsCapacityReservationOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#usage_strategy Ec2Fleet#usage_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usageStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsageStrategy
        {
            get;
            set;
        }
    }
}
