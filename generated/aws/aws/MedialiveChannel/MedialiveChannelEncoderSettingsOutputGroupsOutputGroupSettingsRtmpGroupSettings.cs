using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ad_markers MedialiveChannel#ad_markers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adMarkers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AdMarkers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#authentication_scheme MedialiveChannel#authentication_scheme}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthenticationScheme
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#cache_full_behavior MedialiveChannel#cache_full_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheFullBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CacheFullBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#cache_length MedialiveChannel#cache_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CacheLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_data MedialiveChannel#caption_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "captionData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaptionData
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_action MedialiveChannel#input_loss_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputLossAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputLossAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#restart_delay MedialiveChannel#restart_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "restartDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RestartDelay
        {
            get;
            set;
        }
    }
}
