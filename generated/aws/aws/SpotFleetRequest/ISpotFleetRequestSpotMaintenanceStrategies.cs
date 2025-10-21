using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotFleetRequest
{
    [JsiiInterface(nativeType: typeof(ISpotFleetRequestSpotMaintenanceStrategies), fullyQualifiedName: "aws.spotFleetRequest.SpotFleetRequestSpotMaintenanceStrategies")]
    public interface ISpotFleetRequestSpotMaintenanceStrategies
    {
        /// <summary>capacity_rebalance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#capacity_rebalance SpotFleetRequest#capacity_rebalance}
        /// </remarks>
        [JsiiProperty(name: "capacityRebalance", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SpotFleetRequest.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance? CapacityRebalance
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotFleetRequestSpotMaintenanceStrategies), fullyQualifiedName: "aws.spotFleetRequest.SpotFleetRequestSpotMaintenanceStrategies")]
        internal sealed class _Proxy : DeputyBase, aws.SpotFleetRequest.ISpotFleetRequestSpotMaintenanceStrategies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>capacity_rebalance block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#capacity_rebalance SpotFleetRequest#capacity_rebalance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacityRebalance", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance\"}", isOptional: true)]
            public aws.SpotFleetRequest.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance? CapacityRebalance
            {
                get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance?>();
            }
        }
    }
}
