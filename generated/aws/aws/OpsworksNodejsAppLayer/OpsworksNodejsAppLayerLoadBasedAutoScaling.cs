using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksNodejsAppLayer
{
    [JsiiByValue(fqn: "aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScaling")]
    public class OpsworksNodejsAppLayerLoadBasedAutoScaling : aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScaling
    {
        /// <summary>downscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#downscaling OpsworksNodejsAppLayer#downscaling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
        public aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingDownscaling? Downscaling
        {
            get;
            set;
        }

        private object? _enable;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#enable OpsworksNodejsAppLayer#enable}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#upscaling OpsworksNodejsAppLayer#upscaling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
        public aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling? Upscaling
        {
            get;
            set;
        }
    }
}
