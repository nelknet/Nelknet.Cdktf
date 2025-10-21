using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsAudioNormalizationSettings")]
    public class MedialiveChannelEncoderSettingsAudioDescriptionsAudioNormalizationSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsAudioNormalizationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#algorithm MedialiveChannel#algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Algorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#algorithm_control MedialiveChannel#algorithm_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "algorithmControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AlgorithmControl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#target_lkfs MedialiveChannel#target_lkfs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetLkfs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetLkfs
        {
            get;
            set;
        }
    }
}
