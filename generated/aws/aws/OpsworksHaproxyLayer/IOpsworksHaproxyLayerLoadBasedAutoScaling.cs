using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksHaproxyLayer
{
    [JsiiInterface(nativeType: typeof(IOpsworksHaproxyLayerLoadBasedAutoScaling), fullyQualifiedName: "aws.opsworksHaproxyLayer.OpsworksHaproxyLayerLoadBasedAutoScaling")]
    public interface IOpsworksHaproxyLayerLoadBasedAutoScaling
    {
        /// <summary>downscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#downscaling OpsworksHaproxyLayer#downscaling}
        /// </remarks>
        [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksHaproxyLayer.OpsworksHaproxyLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpsworksHaproxyLayer.IOpsworksHaproxyLayerLoadBasedAutoScalingDownscaling? Downscaling
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#enable OpsworksHaproxyLayer#enable}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#upscaling OpsworksHaproxyLayer#upscaling}
        /// </remarks>
        [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksHaproxyLayer.OpsworksHaproxyLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpsworksHaproxyLayer.IOpsworksHaproxyLayerLoadBasedAutoScalingUpscaling? Upscaling
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksHaproxyLayerLoadBasedAutoScaling), fullyQualifiedName: "aws.opsworksHaproxyLayer.OpsworksHaproxyLayerLoadBasedAutoScaling")]
        internal sealed class _Proxy : DeputyBase, aws.OpsworksHaproxyLayer.IOpsworksHaproxyLayerLoadBasedAutoScaling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>downscaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#downscaling OpsworksHaproxyLayer#downscaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksHaproxyLayer.OpsworksHaproxyLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
            public aws.OpsworksHaproxyLayer.IOpsworksHaproxyLayerLoadBasedAutoScalingDownscaling? Downscaling
            {
                get => GetInstanceProperty<aws.OpsworksHaproxyLayer.IOpsworksHaproxyLayerLoadBasedAutoScalingDownscaling?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#enable OpsworksHaproxyLayer#enable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>upscaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#upscaling OpsworksHaproxyLayer#upscaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksHaproxyLayer.OpsworksHaproxyLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
            public aws.OpsworksHaproxyLayer.IOpsworksHaproxyLayerLoadBasedAutoScalingUpscaling? Upscaling
            {
                get => GetInstanceProperty<aws.OpsworksHaproxyLayer.IOpsworksHaproxyLayerLoadBasedAutoScalingUpscaling?>();
            }
        }
    }
}
