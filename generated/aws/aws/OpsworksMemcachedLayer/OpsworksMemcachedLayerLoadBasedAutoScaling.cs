using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksMemcachedLayer
{
    [JsiiByValue(fqn: "aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScaling")]
    public class OpsworksMemcachedLayerLoadBasedAutoScaling : aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScaling
    {
        /// <summary>downscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#downscaling OpsworksMemcachedLayer#downscaling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
        public aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingDownscaling? Downscaling
        {
            get;
            set;
        }

        private object? _enable;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#enable OpsworksMemcachedLayer#enable}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#upscaling OpsworksMemcachedLayer#upscaling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
        public aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingUpscaling? Upscaling
        {
            get;
            set;
        }
    }
}
