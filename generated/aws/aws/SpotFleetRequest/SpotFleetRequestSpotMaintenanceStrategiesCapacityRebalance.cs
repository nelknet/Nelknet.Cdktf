using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotFleetRequest
{
    [JsiiByValue(fqn: "aws.spotFleetRequest.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance")]
    public class SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance : aws.SpotFleetRequest.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#replacement_strategy SpotFleetRequest#replacement_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replacementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplacementStrategy
        {
            get;
            set;
        }
    }
}
