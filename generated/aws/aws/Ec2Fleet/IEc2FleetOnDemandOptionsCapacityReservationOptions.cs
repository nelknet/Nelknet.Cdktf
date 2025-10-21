using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2Fleet
{
    [JsiiInterface(nativeType: typeof(IEc2FleetOnDemandOptionsCapacityReservationOptions), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetOnDemandOptionsCapacityReservationOptions")]
    public interface IEc2FleetOnDemandOptionsCapacityReservationOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#usage_strategy Ec2Fleet#usage_strategy}.</summary>
        [JsiiProperty(name: "usageStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsageStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetOnDemandOptionsCapacityReservationOptions), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetOnDemandOptionsCapacityReservationOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2Fleet.IEc2FleetOnDemandOptionsCapacityReservationOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#usage_strategy Ec2Fleet#usage_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usageStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsageStrategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
