using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksMemcachedLayer
{
    [JsiiInterface(nativeType: typeof(IOpsworksMemcachedLayerLoadBasedAutoScaling), fullyQualifiedName: "aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScaling")]
    public interface IOpsworksMemcachedLayerLoadBasedAutoScaling
    {
        /// <summary>downscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#downscaling OpsworksMemcachedLayer#downscaling}
        /// </remarks>
        [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingDownscaling? Downscaling
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#enable OpsworksMemcachedLayer#enable}.</summary>
        [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enable
        {
            get
            {
                return null;
            }
        }

        /// <summary>upscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#upscaling OpsworksMemcachedLayer#upscaling}
        /// </remarks>
        [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingUpscaling? Upscaling
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksMemcachedLayerLoadBasedAutoScaling), fullyQualifiedName: "aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScaling")]
        internal sealed class _Proxy : DeputyBase, aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScaling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>downscaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#downscaling OpsworksMemcachedLayer#downscaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
            public aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingDownscaling? Downscaling
            {
                get => GetInstanceProperty<aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingDownscaling?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#enable OpsworksMemcachedLayer#enable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>upscaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#upscaling OpsworksMemcachedLayer#upscaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
            public aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingUpscaling? Upscaling
            {
                get => GetInstanceProperty<aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingUpscaling?>();
            }
        }
    }
}
