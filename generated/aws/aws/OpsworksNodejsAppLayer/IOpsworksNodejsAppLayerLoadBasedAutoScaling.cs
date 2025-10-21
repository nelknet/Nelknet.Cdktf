using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksNodejsAppLayer
{
    [JsiiInterface(nativeType: typeof(IOpsworksNodejsAppLayerLoadBasedAutoScaling), fullyQualifiedName: "aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScaling")]
    public interface IOpsworksNodejsAppLayerLoadBasedAutoScaling
    {
        /// <summary>downscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#downscaling OpsworksNodejsAppLayer#downscaling}
        /// </remarks>
        [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingDownscaling? Downscaling
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#enable OpsworksNodejsAppLayer#enable}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#upscaling OpsworksNodejsAppLayer#upscaling}
        /// </remarks>
        [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling? Upscaling
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksNodejsAppLayerLoadBasedAutoScaling), fullyQualifiedName: "aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScaling")]
        internal sealed class _Proxy : DeputyBase, aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScaling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>downscaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#downscaling OpsworksNodejsAppLayer#downscaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
            public aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingDownscaling? Downscaling
            {
                get => GetInstanceProperty<aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingDownscaling?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#enable OpsworksNodejsAppLayer#enable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>upscaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#upscaling OpsworksNodejsAppLayer#upscaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
            public aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling? Upscaling
            {
                get => GetInstanceProperty<aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling?>();
            }
        }
    }
}
