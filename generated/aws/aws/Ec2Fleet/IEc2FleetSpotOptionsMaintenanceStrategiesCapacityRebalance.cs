using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2Fleet
{
    [JsiiInterface(nativeType: typeof(IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance")]
    public interface IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#replacement_strategy Ec2Fleet#replacement_strategy}.</summary>
        [JsiiProperty(name: "replacementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplacementStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#termination_delay Ec2Fleet#termination_delay}.</summary>
        [JsiiProperty(name: "terminationDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TerminationDelay
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2Fleet.IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#replacement_strategy Ec2Fleet#replacement_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replacementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplacementStrategy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#termination_delay Ec2Fleet#termination_delay}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "terminationDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TerminationDelay
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
