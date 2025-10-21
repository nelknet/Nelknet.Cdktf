using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings")]
    public class MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#black_detect_threshold MedialiveChannel#black_detect_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blackDetectThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BlackDetectThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#video_black_threshold_msec MedialiveChannel#video_black_threshold_msec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "videoBlackThresholdMsec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VideoBlackThresholdMsec
        {
            get;
            set;
        }
    }
}
