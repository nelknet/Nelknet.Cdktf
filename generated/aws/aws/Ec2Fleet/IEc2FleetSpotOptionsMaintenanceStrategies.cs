using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2Fleet
{
    [JsiiInterface(nativeType: typeof(IEc2FleetSpotOptionsMaintenanceStrategies), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetSpotOptionsMaintenanceStrategies")]
    public interface IEc2FleetSpotOptionsMaintenanceStrategies
    {
        /// <summary>capacity_rebalance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#capacity_rebalance Ec2Fleet#capacity_rebalance}
        /// </remarks>
        [JsiiProperty(name: "capacityRebalance", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2Fleet.IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance? CapacityRebalance
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetSpotOptionsMaintenanceStrategies), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetSpotOptionsMaintenanceStrategies")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2Fleet.IEc2FleetSpotOptionsMaintenanceStrategies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>capacity_rebalance block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#capacity_rebalance Ec2Fleet#capacity_rebalance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacityRebalance", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance\"}", isOptional: true)]
            public aws.Ec2Fleet.IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance? CapacityRebalance
            {
                get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance?>();
            }
        }
    }
}
