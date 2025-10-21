using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2Fleet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2Fleet.Ec2FleetTargetCapacitySpecification")]
    public class Ec2FleetTargetCapacitySpecification : aws.Ec2Fleet.IEc2FleetTargetCapacitySpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#default_target_capacity_type Ec2Fleet#default_target_capacity_type}.</summary>
        [JsiiProperty(name: "defaultTargetCapacityType", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultTargetCapacityType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#total_target_capacity Ec2Fleet#total_target_capacity}.</summary>
        [JsiiProperty(name: "totalTargetCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public double TotalTargetCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#on_demand_target_capacity Ec2Fleet#on_demand_target_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onDemandTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OnDemandTargetCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#spot_target_capacity Ec2Fleet#spot_target_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spotTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SpotTargetCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#target_capacity_unit_type Ec2Fleet#target_capacity_unit_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetCapacityUnitType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetCapacityUnitType
        {
            get;
            set;
        }
    }
}
