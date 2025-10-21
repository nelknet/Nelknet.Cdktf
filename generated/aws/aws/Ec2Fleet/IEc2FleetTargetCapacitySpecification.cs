using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2Fleet
{
    [JsiiInterface(nativeType: typeof(IEc2FleetTargetCapacitySpecification), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetTargetCapacitySpecification")]
    public interface IEc2FleetTargetCapacitySpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#default_target_capacity_type Ec2Fleet#default_target_capacity_type}.</summary>
        [JsiiProperty(name: "defaultTargetCapacityType", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultTargetCapacityType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#total_target_capacity Ec2Fleet#total_target_capacity}.</summary>
        [JsiiProperty(name: "totalTargetCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double TotalTargetCapacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#on_demand_target_capacity Ec2Fleet#on_demand_target_capacity}.</summary>
        [JsiiProperty(name: "onDemandTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OnDemandTargetCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#spot_target_capacity Ec2Fleet#spot_target_capacity}.</summary>
        [JsiiProperty(name: "spotTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SpotTargetCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#target_capacity_unit_type Ec2Fleet#target_capacity_unit_type}.</summary>
        [JsiiProperty(name: "targetCapacityUnitType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetCapacityUnitType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetTargetCapacitySpecification), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetTargetCapacitySpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2Fleet.IEc2FleetTargetCapacitySpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#default_target_capacity_type Ec2Fleet#default_target_capacity_type}.</summary>
            [JsiiProperty(name: "defaultTargetCapacityType", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultTargetCapacityType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#total_target_capacity Ec2Fleet#total_target_capacity}.</summary>
            [JsiiProperty(name: "totalTargetCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double TotalTargetCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#on_demand_target_capacity Ec2Fleet#on_demand_target_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onDemandTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OnDemandTargetCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#spot_target_capacity Ec2Fleet#spot_target_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spotTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SpotTargetCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#target_capacity_unit_type Ec2Fleet#target_capacity_unit_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetCapacityUnitType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetCapacityUnitType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
