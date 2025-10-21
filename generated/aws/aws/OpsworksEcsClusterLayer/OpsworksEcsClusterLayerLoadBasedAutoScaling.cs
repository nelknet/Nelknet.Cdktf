using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksEcsClusterLayer
{
    [JsiiByValue(fqn: "aws.opsworksEcsClusterLayer.OpsworksEcsClusterLayerLoadBasedAutoScaling")]
    public class OpsworksEcsClusterLayerLoadBasedAutoScaling : aws.OpsworksEcsClusterLayer.IOpsworksEcsClusterLayerLoadBasedAutoScaling
    {
        /// <summary>downscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#downscaling OpsworksEcsClusterLayer#downscaling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksEcsClusterLayer.OpsworksEcsClusterLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
        public aws.OpsworksEcsClusterLayer.IOpsworksEcsClusterLayerLoadBasedAutoScalingDownscaling? Downscaling
        {
            get;
            set;
        }

        private object? _enable;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#enable OpsworksEcsClusterLayer#enable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enable
        {
            get => _enable;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enable = value;
            }
        }

        /// <summary>upscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ecs_cluster_layer#upscaling OpsworksEcsClusterLayer#upscaling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksEcsClusterLayer.OpsworksEcsClusterLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
        public aws.OpsworksEcsClusterLayer.IOpsworksEcsClusterLayerLoadBasedAutoScalingUpscaling? Upscaling
        {
            get;
            set;
        }
    }
}
