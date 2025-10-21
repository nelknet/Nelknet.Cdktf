using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OsisPipeline
{
    [JsiiByValue(fqn: "aws.osisPipeline.OsisPipelineLogPublishingOptions")]
    public class OsisPipelineLogPublishingOptions : aws.OsisPipeline.IOsisPipelineLogPublishingOptions
    {
        private object? _cloudwatchLogDestination;

        /// <summary>cloudwatch_log_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#cloudwatch_log_destination OsisPipeline#cloudwatch_log_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.osisPipeline.OsisPipelineLogPublishingOptionsCloudwatchLogDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CloudwatchLogDestination
        {
            get => _cloudwatchLogDestination;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.OsisPipeline.IOsisPipelineLogPublishingOptionsCloudwatchLogDestination[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.OsisPipeline.IOsisPipelineLogPublishingOptionsCloudwatchLogDestination).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cloudwatchLogDestination = value;
            }
        }

        private object? _isLoggingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#is_logging_enabled OsisPipeline#is_logging_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isLoggingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IsLoggingEnabled
        {
            get => _isLoggingEnabled;
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
                _isLoggingEnabled = value;
            }
        }
    }
}
