using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelInputAttachments), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachments")]
    public interface IMedialiveChannelInputAttachments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_attachment_name MedialiveChannel#input_attachment_name}.</summary>
        [JsiiProperty(name: "inputAttachmentName", typeJson: "{\"primitive\":\"string\"}")]
        string InputAttachmentName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_id MedialiveChannel#input_id}.</summary>
        [JsiiProperty(name: "inputId", typeJson: "{\"primitive\":\"string\"}")]
        string InputId
        {
            get;
        }

        /// <summary>automatic_input_failover_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#automatic_input_failover_settings MedialiveChannel#automatic_input_failover_settings}
        /// </remarks>
        [JsiiProperty(name: "automaticInputFailoverSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettings? AutomaticInputFailoverSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>input_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_settings MedialiveChannel#input_settings}
        /// </remarks>
        [JsiiProperty(name: "inputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettings? InputSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelInputAttachments), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachments")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelInputAttachments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_attachment_name MedialiveChannel#input_attachment_name}.</summary>
            [JsiiProperty(name: "inputAttachmentName", typeJson: "{\"primitive\":\"string\"}")]
            public string InputAttachmentName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_id MedialiveChannel#input_id}.</summary>
            [JsiiProperty(name: "inputId", typeJson: "{\"primitive\":\"string\"}")]
            public string InputId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>automatic_input_failover_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#automatic_input_failover_settings MedialiveChannel#automatic_input_failover_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "automaticInputFailoverSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettings? AutomaticInputFailoverSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettings?>();
            }

            /// <summary>input_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_settings MedialiveChannel#input_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettings? InputSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettings?>();
            }
        }
    }
}
