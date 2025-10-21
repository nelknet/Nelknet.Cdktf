using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogDelivery
{
    [JsiiInterface(nativeType: typeof(ICloudwatchLogDeliveryS3DeliveryConfiguration), fullyQualifiedName: "aws.cloudwatchLogDelivery.CloudwatchLogDeliveryS3DeliveryConfiguration")]
    public interface ICloudwatchLogDeliveryS3DeliveryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery#enable_hive_compatible_path CloudwatchLogDelivery#enable_hive_compatible_path}.</summary>
        [JsiiProperty(name: "enableHiveCompatiblePath", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableHiveCompatiblePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery#suffix_path CloudwatchLogDelivery#suffix_path}.</summary>
        [JsiiProperty(name: "suffixPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SuffixPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchLogDeliveryS3DeliveryConfiguration), fullyQualifiedName: "aws.cloudwatchLogDelivery.CloudwatchLogDeliveryS3DeliveryConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchLogDelivery.ICloudwatchLogDeliveryS3DeliveryConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery#enable_hive_compatible_path CloudwatchLogDelivery#enable_hive_compatible_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableHiveCompatiblePath", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableHiveCompatiblePath
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery#suffix_path CloudwatchLogDelivery#suffix_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "suffixPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SuffixPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
