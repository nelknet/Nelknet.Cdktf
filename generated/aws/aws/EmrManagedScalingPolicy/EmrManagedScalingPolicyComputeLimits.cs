using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrManagedScalingPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrManagedScalingPolicy.EmrManagedScalingPolicyComputeLimits")]
    public class EmrManagedScalingPolicyComputeLimits : aws.EmrManagedScalingPolicy.IEmrManagedScalingPolicyComputeLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#maximum_capacity_units EmrManagedScalingPolicy#maximum_capacity_units}.</summary>
        [JsiiProperty(name: "maximumCapacityUnits", typeJson: "{\"primitive\":\"number\"}")]
        public double MaximumCapacityUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#minimum_capacity_units EmrManagedScalingPolicy#minimum_capacity_units}.</summary>
        [JsiiProperty(name: "minimumCapacityUnits", typeJson: "{\"primitive\":\"number\"}")]
        public double MinimumCapacityUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#unit_type EmrManagedScalingPolicy#unit_type}.</summary>
        [JsiiProperty(name: "unitType", typeJson: "{\"primitive\":\"string\"}")]
        public string UnitType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#maximum_core_capacity_units EmrManagedScalingPolicy#maximum_core_capacity_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumCoreCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumCoreCapacityUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#maximum_ondemand_capacity_units EmrManagedScalingPolicy#maximum_ondemand_capacity_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumOndemandCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumOndemandCapacityUnits
        {
            get;
            set;
        }
    }
}
