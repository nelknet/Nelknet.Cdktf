using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotFleetRequest
{
    [JsiiInterface(nativeType: typeof(ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance), fullyQualifiedName: "aws.spotFleetRequest.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance")]
    public interface ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#replacement_strategy SpotFleetRequest#replacement_strategy}.</summary>
        [JsiiProperty(name: "replacementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplacementStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance), fullyQualifiedName: "aws.spotFleetRequest.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance")]
        internal sealed class _Proxy : DeputyBase, aws.SpotFleetRequest.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#replacement_strategy SpotFleetRequest#replacement_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replacementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplacementStrategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
