using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrManagedScalingPolicy
{
    [JsiiInterface(nativeType: typeof(IEmrManagedScalingPolicyComputeLimits), fullyQualifiedName: "aws.emrManagedScalingPolicy.EmrManagedScalingPolicyComputeLimits")]
    public interface IEmrManagedScalingPolicyComputeLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#maximum_capacity_units EmrManagedScalingPolicy#maximum_capacity_units}.</summary>
        [JsiiProperty(name: "maximumCapacityUnits", typeJson: "{\"primitive\":\"number\"}")]
        double MaximumCapacityUnits
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#minimum_capacity_units EmrManagedScalingPolicy#minimum_capacity_units}.</summary>
        [JsiiProperty(name: "minimumCapacityUnits", typeJson: "{\"primitive\":\"number\"}")]
        double MinimumCapacityUnits
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#unit_type EmrManagedScalingPolicy#unit_type}.</summary>
        [JsiiProperty(name: "unitType", typeJson: "{\"primitive\":\"string\"}")]
        string UnitType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#maximum_core_capacity_units EmrManagedScalingPolicy#maximum_core_capacity_units}.</summary>
        [JsiiProperty(name: "maximumCoreCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumCoreCapacityUnits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#maximum_ondemand_capacity_units EmrManagedScalingPolicy#maximum_ondemand_capacity_units}.</summary>
        [JsiiProperty(name: "maximumOndemandCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumOndemandCapacityUnits
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrManagedScalingPolicyComputeLimits), fullyQualifiedName: "aws.emrManagedScalingPolicy.EmrManagedScalingPolicyComputeLimits")]
        internal sealed class _Proxy : DeputyBase, aws.EmrManagedScalingPolicy.IEmrManagedScalingPolicyComputeLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#maximum_capacity_units EmrManagedScalingPolicy#maximum_capacity_units}.</summary>
            [JsiiProperty(name: "maximumCapacityUnits", typeJson: "{\"primitive\":\"number\"}")]
            public double MaximumCapacityUnits
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#minimum_capacity_units EmrManagedScalingPolicy#minimum_capacity_units}.</summary>
            [JsiiProperty(name: "minimumCapacityUnits", typeJson: "{\"primitive\":\"number\"}")]
            public double MinimumCapacityUnits
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#unit_type EmrManagedScalingPolicy#unit_type}.</summary>
            [JsiiProperty(name: "unitType", typeJson: "{\"primitive\":\"string\"}")]
            public string UnitType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#maximum_core_capacity_units EmrManagedScalingPolicy#maximum_core_capacity_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumCoreCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumCoreCapacityUnits
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#maximum_ondemand_capacity_units EmrManagedScalingPolicy#maximum_ondemand_capacity_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumOndemandCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumOndemandCapacityUnits
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
