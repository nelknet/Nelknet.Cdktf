using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettings")]
    public interface IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#secondary_input_id MedialiveChannel#secondary_input_id}.</summary>
        [JsiiProperty(name: "secondaryInputId", typeJson: "{\"primitive\":\"string\"}")]
        string SecondaryInputId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#error_clear_time_msec MedialiveChannel#error_clear_time_msec}.</summary>
        [JsiiProperty(name: "errorClearTimeMsec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ErrorClearTimeMsec
        {
            get
            {
                return null;
            }
        }

        /// <summary>failover_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#failover_condition MedialiveChannel#failover_condition}
        /// </remarks>
        [JsiiProperty(name: "failoverCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FailoverCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_preference MedialiveChannel#input_preference}.</summary>
        [JsiiProperty(name: "inputPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputPreference
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#secondary_input_id MedialiveChannel#secondary_input_id}.</summary>
            [JsiiProperty(name: "secondaryInputId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecondaryInputId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#error_clear_time_msec MedialiveChannel#error_clear_time_msec}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "errorClearTimeMsec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ErrorClearTimeMsec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>failover_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#failover_condition MedialiveChannel#failover_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failoverCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FailoverCondition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_preference MedialiveChannel#input_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputPreference
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
