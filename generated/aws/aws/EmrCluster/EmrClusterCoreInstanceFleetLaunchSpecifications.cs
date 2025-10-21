using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    [JsiiByValue(fqn: "aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecifications")]
    public class EmrClusterCoreInstanceFleetLaunchSpecifications : aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecifications
    {
        private object? _onDemandSpecification;

        /// <summary>on_demand_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#on_demand_specification EmrCluster#on_demand_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OnDemandSpecification
        {
            get => _onDemandSpecification;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _onDemandSpecification = value;
            }
        }

        private object? _spotSpecification;

        /// <summary>spot_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#spot_specification EmrCluster#spot_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spotSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SpotSpecification
        {
            get => _spotSpecification;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _spotSpecification = value;
            }
        }
    }
}
