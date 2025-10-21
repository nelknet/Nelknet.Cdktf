using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FlowLog
{
    [JsiiInterface(nativeType: typeof(IFlowLogDestinationOptions), fullyQualifiedName: "aws.flowLog.FlowLogDestinationOptions")]
    public interface IFlowLogDestinationOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#file_format FlowLog#file_format}.</summary>
        [JsiiProperty(name: "fileFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#hive_compatible_partitions FlowLog#hive_compatible_partitions}.</summary>
        [JsiiProperty(name: "hiveCompatiblePartitions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HiveCompatiblePartitions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#per_hour_partition FlowLog#per_hour_partition}.</summary>
        [JsiiProperty(name: "perHourPartition", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PerHourPartition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFlowLogDestinationOptions), fullyQualifiedName: "aws.flowLog.FlowLogDestinationOptions")]
        internal sealed class _Proxy : DeputyBase, aws.FlowLog.IFlowLogDestinationOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#file_format FlowLog#file_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#hive_compatible_partitions FlowLog#hive_compatible_partitions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hiveCompatiblePartitions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? HiveCompatiblePartitions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/flow_log#per_hour_partition FlowLog#per_hour_partition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "perHourPartition", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PerHourPartition
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
