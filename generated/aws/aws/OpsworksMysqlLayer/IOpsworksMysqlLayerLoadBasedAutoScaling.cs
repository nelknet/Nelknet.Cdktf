using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksMysqlLayer
{
    [JsiiInterface(nativeType: typeof(IOpsworksMysqlLayerLoadBasedAutoScaling), fullyQualifiedName: "aws.opsworksMysqlLayer.OpsworksMysqlLayerLoadBasedAutoScaling")]
    public interface IOpsworksMysqlLayerLoadBasedAutoScaling
    {
        /// <summary>downscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#downscaling OpsworksMysqlLayer#downscaling}
        /// </remarks>
        [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksMysqlLayer.OpsworksMysqlLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpsworksMysqlLayer.IOpsworksMysqlLayerLoadBasedAutoScalingDownscaling? Downscaling
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#enable OpsworksMysqlLayer#enable}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#upscaling OpsworksMysqlLayer#upscaling}
        /// </remarks>
        [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksMysqlLayer.OpsworksMysqlLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpsworksMysqlLayer.IOpsworksMysqlLayerLoadBasedAutoScalingUpscaling? Upscaling
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksMysqlLayerLoadBasedAutoScaling), fullyQualifiedName: "aws.opsworksMysqlLayer.OpsworksMysqlLayerLoadBasedAutoScaling")]
        internal sealed class _Proxy : DeputyBase, aws.OpsworksMysqlLayer.IOpsworksMysqlLayerLoadBasedAutoScaling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>downscaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#downscaling OpsworksMysqlLayer#downscaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksMysqlLayer.OpsworksMysqlLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
            public aws.OpsworksMysqlLayer.IOpsworksMysqlLayerLoadBasedAutoScalingDownscaling? Downscaling
            {
                get => GetInstanceProperty<aws.OpsworksMysqlLayer.IOpsworksMysqlLayerLoadBasedAutoScalingDownscaling?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#enable OpsworksMysqlLayer#enable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>upscaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_mysql_layer#upscaling OpsworksMysqlLayer#upscaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksMysqlLayer.OpsworksMysqlLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
            public aws.OpsworksMysqlLayer.IOpsworksMysqlLayerLoadBasedAutoScalingUpscaling? Upscaling
            {
                get => GetInstanceProperty<aws.OpsworksMysqlLayer.IOpsworksMysqlLayerLoadBasedAutoScalingUpscaling?>();
            }
        }
    }
}
