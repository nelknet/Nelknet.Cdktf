using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OsisPipeline
{
    [JsiiInterface(nativeType: typeof(IOsisPipelineLogPublishingOptions), fullyQualifiedName: "aws.osisPipeline.OsisPipelineLogPublishingOptions")]
    public interface IOsisPipelineLogPublishingOptions
    {
        /// <summary>cloudwatch_log_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#cloudwatch_log_destination OsisPipeline#cloudwatch_log_destination}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.osisPipeline.OsisPipelineLogPublishingOptionsCloudwatchLogDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloudwatchLogDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#is_logging_enabled OsisPipeline#is_logging_enabled}.</summary>
        [JsiiProperty(name: "isLoggingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsLoggingEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsisPipelineLogPublishingOptions), fullyQualifiedName: "aws.osisPipeline.OsisPipelineLogPublishingOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OsisPipeline.IOsisPipelineLogPublishingOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_log_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#cloudwatch_log_destination OsisPipeline#cloudwatch_log_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.osisPipeline.OsisPipelineLogPublishingOptionsCloudwatchLogDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CloudwatchLogDestination
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#is_logging_enabled OsisPipeline#is_logging_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isLoggingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IsLoggingEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
