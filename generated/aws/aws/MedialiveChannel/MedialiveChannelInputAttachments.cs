using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachments")]
    public class MedialiveChannelInputAttachments : aws.MedialiveChannel.IMedialiveChannelInputAttachments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_attachment_name MedialiveChannel#input_attachment_name}.</summary>
        [JsiiProperty(name: "inputAttachmentName", typeJson: "{\"primitive\":\"string\"}")]
        public string InputAttachmentName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_id MedialiveChannel#input_id}.</summary>
        [JsiiProperty(name: "inputId", typeJson: "{\"primitive\":\"string\"}")]
        public string InputId
        {
            get;
            set;
        }

        /// <summary>automatic_input_failover_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#automatic_input_failover_settings MedialiveChannel#automatic_input_failover_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticInputFailoverSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettings? AutomaticInputFailoverSettings
        {
            get;
            set;
        }

        /// <summary>input_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_settings MedialiveChannel#input_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettings? InputSettings
        {
            get;
            set;
        }
    }
}
