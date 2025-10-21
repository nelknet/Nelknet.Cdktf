using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettings")]
    public class MedialiveChannelInputAttachmentsAutomaticInputFailoverSettings : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#secondary_input_id MedialiveChannel#secondary_input_id}.</summary>
        [JsiiProperty(name: "secondaryInputId", typeJson: "{\"primitive\":\"string\"}")]
        public string SecondaryInputId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#error_clear_time_msec MedialiveChannel#error_clear_time_msec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errorClearTimeMsec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ErrorClearTimeMsec
        {
            get;
            set;
        }

        private object? _failoverCondition;

        /// <summary>failover_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#failover_condition MedialiveChannel#failover_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failoverCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FailoverCondition
        {
            get => _failoverCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _failoverCondition = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_preference MedialiveChannel#input_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputPreference
        {
            get;
            set;
        }
    }
}
