using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings")]
    public class MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_threshold_msec MedialiveChannel#input_loss_threshold_msec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputLossThresholdMsec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InputLossThresholdMsec
        {
            get;
            set;
        }
    }
}
