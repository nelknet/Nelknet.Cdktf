using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FlowLog
{
    [JsiiByValue(fqn: "aws.flowLog.FlowLogDestinationOptions")]
    public class FlowLogDestinationOptions : aws.FlowLog.IFlowLogDestinationOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#file_format FlowLog#file_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileFormat
        {
            get;
            set;
        }

        private object? _hiveCompatiblePartitions;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#hive_compatible_partitions FlowLog#hive_compatible_partitions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hiveCompatiblePartitions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? HiveCompatiblePartitions
        {
            get => _hiveCompatiblePartitions;
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
                _hiveCompatiblePartitions = value;
            }
        }

        private object? _perHourPartition;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#per_hour_partition FlowLog#per_hour_partition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "perHourPartition", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PerHourPartition
        {
            get => _perHourPartition;
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
                _perHourPartition = value;
            }
        }
    }
}
