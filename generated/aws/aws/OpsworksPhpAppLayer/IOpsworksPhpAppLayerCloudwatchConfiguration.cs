using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksPhpAppLayer
{
    [JsiiInterface(nativeType: typeof(IOpsworksPhpAppLayerCloudwatchConfiguration), fullyQualifiedName: "aws.opsworksPhpAppLayer.OpsworksPhpAppLayerCloudwatchConfiguration")]
    public interface IOpsworksPhpAppLayerCloudwatchConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#enabled OpsworksPhpAppLayer#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_streams block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#log_streams OpsworksPhpAppLayer#log_streams}
        /// </remarks>
        [JsiiProperty(name: "logStreams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworksPhpAppLayer.OpsworksPhpAppLayerCloudwatchConfigurationLogStreams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogStreams
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksPhpAppLayerCloudwatchConfiguration), fullyQualifiedName: "aws.opsworksPhpAppLayer.OpsworksPhpAppLayerCloudwatchConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.OpsworksPhpAppLayer.IOpsworksPhpAppLayerCloudwatchConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#enabled OpsworksPhpAppLayer#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>log_streams block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#log_streams OpsworksPhpAppLayer#log_streams}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logStreams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworksPhpAppLayer.OpsworksPhpAppLayerCloudwatchConfigurationLogStreams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogStreams
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
