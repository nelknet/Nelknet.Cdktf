using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogDelivery
{
    [JsiiByValue(fqn: "aws.cloudwatchLogDelivery.CloudwatchLogDeliveryS3DeliveryConfiguration")]
    public class CloudwatchLogDeliveryS3DeliveryConfiguration : aws.CloudwatchLogDelivery.ICloudwatchLogDeliveryS3DeliveryConfiguration
    {
        private object? _enableHiveCompatiblePath;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery#enable_hive_compatible_path CloudwatchLogDelivery#enable_hive_compatible_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableHiveCompatiblePath", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableHiveCompatiblePath
        {
            get => _enableHiveCompatiblePath;
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
                _enableHiveCompatiblePath = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery#suffix_path CloudwatchLogDelivery#suffix_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "suffixPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SuffixPath
        {
            get;
            set;
        }
    }
}
