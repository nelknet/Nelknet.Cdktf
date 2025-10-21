using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiClass(nativeType: typeof(aws.MedialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3SettingsOutputReference), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3SettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3SettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3SettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3SettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3SettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAttenuationControl")]
        public virtual void ResetAttenuationControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBitrate")]
        public virtual void ResetBitrate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBitstreamMode")]
        public virtual void ResetBitstreamMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodingMode")]
        public virtual void ResetCodingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDcFilter")]
        public virtual void ResetDcFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDialnorm")]
        public virtual void ResetDialnorm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDrcLine")]
        public virtual void ResetDrcLine()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDrcRf")]
        public virtual void ResetDrcRf()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLfeControl")]
        public virtual void ResetLfeControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLfeFilter")]
        public virtual void ResetLfeFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoRoCenterMixLevel")]
        public virtual void ResetLoRoCenterMixLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoRoSurroundMixLevel")]
        public virtual void ResetLoRoSurroundMixLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLtRtCenterMixLevel")]
        public virtual void ResetLtRtCenterMixLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLtRtSurroundMixLevel")]
        public virtual void ResetLtRtSurroundMixLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadataControl")]
        public virtual void ResetMetadataControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPassthroughControl")]
        public virtual void ResetPassthroughControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhaseControl")]
        public virtual void ResetPhaseControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStereoDownmix")]
        public virtual void ResetStereoDownmix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSurroundExMode")]
        public virtual void ResetSurroundExMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSurroundMode")]
        public virtual void ResetSurroundMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "attenuationControlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttenuationControlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bitrateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BitrateInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bitstreamModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BitstreamModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CodingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dcFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DcFilterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dialnormInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DialnormInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "drcLineInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DrcLineInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "drcRfInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DrcRfInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lfeControlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LfeControlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lfeFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LfeFilterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loRoCenterMixLevelInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LoRoCenterMixLevelInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loRoSurroundMixLevelInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LoRoSurroundMixLevelInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ltRtCenterMixLevelInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LtRtCenterMixLevelInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ltRtSurroundMixLevelInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LtRtSurroundMixLevelInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataControlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetadataControlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passthroughControlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PassthroughControlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "phaseControlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhaseControlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stereoDownmixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StereoDownmixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "surroundExModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SurroundExModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "surroundModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SurroundModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "attenuationControl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttenuationControl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bitrate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Bitrate
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bitstreamMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BitstreamMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "codingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CodingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dcFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DcFilter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dialnorm", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Dialnorm
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "drcLine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DrcLine
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "drcRf", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DrcRf
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lfeControl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LfeControl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lfeFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LfeFilter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loRoCenterMixLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoRoCenterMixLevel
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loRoSurroundMixLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoRoSurroundMixLevel
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ltRtCenterMixLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LtRtCenterMixLevel
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ltRtSurroundMixLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LtRtSurroundMixLevel
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadataControl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetadataControl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "passthroughControl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PassthroughControl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "phaseControl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhaseControl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stereoDownmix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StereoDownmix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "surroundExMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SurroundExMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "surroundMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SurroundMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings? InternalValue
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings?>();
            set => SetInstanceProperty(value);
        }
    }
}
