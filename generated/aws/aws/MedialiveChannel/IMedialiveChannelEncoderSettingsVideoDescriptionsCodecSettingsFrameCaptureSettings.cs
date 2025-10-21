using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings")]
    public interface IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#capture_interval MedialiveChannel#capture_interval}.</summary>
        [JsiiProperty(name: "captureInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CaptureInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#capture_interval_units MedialiveChannel#capture_interval_units}.</summary>
        [JsiiProperty(name: "captureIntervalUnits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaptureIntervalUnits
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#capture_interval MedialiveChannel#capture_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "captureInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CaptureInterval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#capture_interval_units MedialiveChannel#capture_interval_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "captureIntervalUnits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaptureIntervalUnits
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
