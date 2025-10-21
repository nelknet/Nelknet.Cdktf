using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksPhpAppLayer
{
    [JsiiInterface(nativeType: typeof(IOpsworksPhpAppLayerLoadBasedAutoScaling), fullyQualifiedName: "aws.opsworksPhpAppLayer.OpsworksPhpAppLayerLoadBasedAutoScaling")]
    public interface IOpsworksPhpAppLayerLoadBasedAutoScaling
    {
        /// <summary>downscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#downscaling OpsworksPhpAppLayer#downscaling}
        /// </remarks>
        [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksPhpAppLayer.OpsworksPhpAppLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpsworksPhpAppLayer.IOpsworksPhpAppLayerLoadBasedAutoScalingDownscaling? Downscaling
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#enable OpsworksPhpAppLayer#enable}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#upscaling OpsworksPhpAppLayer#upscaling}
        /// </remarks>
        [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksPhpAppLayer.OpsworksPhpAppLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpsworksPhpAppLayer.IOpsworksPhpAppLayerLoadBasedAutoScalingUpscaling? Upscaling
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksPhpAppLayerLoadBasedAutoScaling), fullyQualifiedName: "aws.opsworksPhpAppLayer.OpsworksPhpAppLayerLoadBasedAutoScaling")]
        internal sealed class _Proxy : DeputyBase, aws.OpsworksPhpAppLayer.IOpsworksPhpAppLayerLoadBasedAutoScaling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>downscaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#downscaling OpsworksPhpAppLayer#downscaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksPhpAppLayer.OpsworksPhpAppLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
            public aws.OpsworksPhpAppLayer.IOpsworksPhpAppLayerLoadBasedAutoScalingDownscaling? Downscaling
            {
                get => GetInstanceProperty<aws.OpsworksPhpAppLayer.IOpsworksPhpAppLayerLoadBasedAutoScalingDownscaling?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#enable OpsworksPhpAppLayer#enable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>upscaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#upscaling OpsworksPhpAppLayer#upscaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksPhpAppLayer.OpsworksPhpAppLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
            public aws.OpsworksPhpAppLayer.IOpsworksPhpAppLayerLoadBasedAutoScalingUpscaling? Upscaling
            {
                get => GetInstanceProperty<aws.OpsworksPhpAppLayer.IOpsworksPhpAppLayerLoadBasedAutoScalingUpscaling?>();
            }
        }
    }
}
