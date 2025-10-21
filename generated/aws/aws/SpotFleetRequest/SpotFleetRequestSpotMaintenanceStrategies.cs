using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotFleetRequest
{
    [JsiiByValue(fqn: "aws.spotFleetRequest.SpotFleetRequestSpotMaintenanceStrategies")]
    public class SpotFleetRequestSpotMaintenanceStrategies : aws.SpotFleetRequest.ISpotFleetRequestSpotMaintenanceStrategies
    {
        /// <summary>capacity_rebalance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#capacity_rebalance SpotFleetRequest#capacity_rebalance}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capacityRebalance", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance\"}", isOptional: true)]
        public aws.SpotFleetRequest.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance? CapacityRebalance
        {
            get;
            set;
        }
    }
}
