using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition")]
    public class MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition
    {
        /// <summary>failover_condition_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#failover_condition_settings MedialiveChannel#failover_condition_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failoverConditionSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings? FailoverConditionSettings
        {
            get;
            set;
        }
    }
}
