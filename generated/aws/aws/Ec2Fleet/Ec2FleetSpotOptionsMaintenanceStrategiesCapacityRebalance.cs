using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2Fleet
{
    [JsiiByValue(fqn: "aws.ec2Fleet.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance")]
    public class Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance : aws.Ec2Fleet.IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#replacement_strategy Ec2Fleet#replacement_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replacementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplacementStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#termination_delay Ec2Fleet#termination_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "terminationDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TerminationDelay
        {
            get;
            set;
        }
    }
}
