using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2Fleet
{
    [JsiiInterface(nativeType: typeof(IEc2FleetOnDemandOptions), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetOnDemandOptions")]
    public interface IEc2FleetOnDemandOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#allocation_strategy Ec2Fleet#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllocationStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>capacity_reservation_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#capacity_reservation_options Ec2Fleet#capacity_reservation_options}
        /// </remarks>
        [JsiiProperty(name: "capacityReservationOptions", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetOnDemandOptionsCapacityReservationOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2Fleet.IEc2FleetOnDemandOptionsCapacityReservationOptions? CapacityReservationOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#max_total_price Ec2Fleet#max_total_price}.</summary>
        [JsiiProperty(name: "maxTotalPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxTotalPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#min_target_capacity Ec2Fleet#min_target_capacity}.</summary>
        [JsiiProperty(name: "minTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinTargetCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#single_availability_zone Ec2Fleet#single_availability_zone}.</summary>
        [JsiiProperty(name: "singleAvailabilityZone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SingleAvailabilityZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#single_instance_type Ec2Fleet#single_instance_type}.</summary>
        [JsiiProperty(name: "singleInstanceType", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SingleInstanceType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetOnDemandOptions), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetOnDemandOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2Fleet.IEc2FleetOnDemandOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#allocation_strategy Ec2Fleet#allocation_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllocationStrategy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>capacity_reservation_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#capacity_reservation_options Ec2Fleet#capacity_reservation_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationOptions", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetOnDemandOptionsCapacityReservationOptions\"}", isOptional: true)]
            public aws.Ec2Fleet.IEc2FleetOnDemandOptionsCapacityReservationOptions? CapacityReservationOptions
            {
                get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetOnDemandOptionsCapacityReservationOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#max_total_price Ec2Fleet#max_total_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxTotalPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxTotalPrice
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#min_target_capacity Ec2Fleet#min_target_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinTargetCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#single_availability_zone Ec2Fleet#single_availability_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "singleAvailabilityZone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SingleAvailabilityZone
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#single_instance_type Ec2Fleet#single_instance_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "singleInstanceType", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SingleInstanceType
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
