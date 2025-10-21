using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksStaticWebLayer
{
    [JsiiByValue(fqn: "aws.opsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScaling")]
    public class OpsworksStaticWebLayerLoadBasedAutoScaling : aws.OpsworksStaticWebLayer.IOpsworksStaticWebLayerLoadBasedAutoScaling
    {
        /// <summary>downscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_static_web_layer#downscaling OpsworksStaticWebLayer#downscaling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
        public aws.OpsworksStaticWebLayer.IOpsworksStaticWebLayerLoadBasedAutoScalingDownscaling? Downscaling
        {
            get;
            set;
        }

        private object? _enable;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_static_web_layer#enable OpsworksStaticWebLayer#enable}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_static_web_layer#upscaling OpsworksStaticWebLayer#upscaling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
        public aws.OpsworksStaticWebLayer.IOpsworksStaticWebLayerLoadBasedAutoScalingUpscaling? Upscaling
        {
            get;
            set;
        }
    }
}
