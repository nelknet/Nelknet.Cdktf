using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    [JsiiByValue(fqn: "aws.emrCluster.EmrClusterCoreInstanceFleet")]
    public class EmrClusterCoreInstanceFleet : aws.EmrCluster.IEmrClusterCoreInstanceFleet
    {
        private object? _instanceTypeConfigs;

        /// <summary>instance_type_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#instance_type_configs EmrCluster#instance_type_configs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceFleetInstanceTypeConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InstanceTypeConfigs
        {
            get => _instanceTypeConfigs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.EmrCluster.IEmrClusterCoreInstanceFleetInstanceTypeConfigs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterCoreInstanceFleetInstanceTypeConfigs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _instanceTypeConfigs = value;
            }
        }

        /// <summary>launch_specifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#launch_specifications EmrCluster#launch_specifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "launchSpecifications", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecifications\"}", isOptional: true)]
        public aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecifications? LaunchSpecifications
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#name EmrCluster#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#target_on_demand_capacity EmrCluster#target_on_demand_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetOnDemandCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetOnDemandCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#target_spot_capacity EmrCluster#target_spot_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetSpotCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetSpotCapacity
        {
            get;
            set;
        }
    }
}
