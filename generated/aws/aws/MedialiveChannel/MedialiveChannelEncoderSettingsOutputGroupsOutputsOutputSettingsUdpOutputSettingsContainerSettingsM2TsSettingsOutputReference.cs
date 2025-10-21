using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiClass(nativeType: typeof(aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsOutputReference), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDvbNitSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbNitSettings\"}}]")]
        public virtual void PutDvbNitSettings(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbNitSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbNitSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDvbSdtSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbSdtSettings\"}}]")]
        public virtual void PutDvbSdtSettings(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbSdtSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbSdtSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDvbTdtSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbTdtSettings\"}}]")]
        public virtual void PutDvbTdtSettings(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbTdtSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbTdtSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAbsentInputAudioBehavior")]
        public virtual void ResetAbsentInputAudioBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetArib")]
        public virtual void ResetArib()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAribCaptionsPid")]
        public virtual void ResetAribCaptionsPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAribCaptionsPidControl")]
        public virtual void ResetAribCaptionsPidControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAudioBufferModel")]
        public virtual void ResetAudioBufferModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAudioFramesPerPes")]
        public virtual void ResetAudioFramesPerPes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAudioPids")]
        public virtual void ResetAudioPids()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAudioStreamType")]
        public virtual void ResetAudioStreamType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBitrate")]
        public virtual void ResetBitrate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBufferModel")]
        public virtual void ResetBufferModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCcDescriptor")]
        public virtual void ResetCcDescriptor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDvbNitSettings")]
        public virtual void ResetDvbNitSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDvbSdtSettings")]
        public virtual void ResetDvbSdtSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDvbSubPids")]
        public virtual void ResetDvbSubPids()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDvbTdtSettings")]
        public virtual void ResetDvbTdtSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDvbTeletextPid")]
        public virtual void ResetDvbTeletextPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbif")]
        public virtual void ResetEbif()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbpAudioInterval")]
        public virtual void ResetEbpAudioInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbpLookaheadMs")]
        public virtual void ResetEbpLookaheadMs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbpPlacement")]
        public virtual void ResetEbpPlacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcmPid")]
        public virtual void ResetEcmPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEsRateInPes")]
        public virtual void ResetEsRateInPes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEtvPlatformPid")]
        public virtual void ResetEtvPlatformPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEtvSignalPid")]
        public virtual void ResetEtvSignalPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFragmentTime")]
        public virtual void ResetFragmentTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKlv")]
        public virtual void ResetKlv()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKlvDataPids")]
        public virtual void ResetKlvDataPids()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNielsenId3Behavior")]
        public virtual void ResetNielsenId3Behavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNullPacketBitrate")]
        public virtual void ResetNullPacketBitrate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPatInterval")]
        public virtual void ResetPatInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPcrControl")]
        public virtual void ResetPcrControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPcrPeriod")]
        public virtual void ResetPcrPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPcrPid")]
        public virtual void ResetPcrPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPmtInterval")]
        public virtual void ResetPmtInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPmtPid")]
        public virtual void ResetPmtPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProgramNum")]
        public virtual void ResetProgramNum()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRateMode")]
        public virtual void ResetRateMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScte27Pids")]
        public virtual void ResetScte27Pids()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScte35Control")]
        public virtual void ResetScte35Control()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScte35Pid")]
        public virtual void ResetScte35Pid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSegmentationMarkers")]
        public virtual void ResetSegmentationMarkers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSegmentationStyle")]
        public virtual void ResetSegmentationStyle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSegmentationTime")]
        public virtual void ResetSegmentationTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimedMetadataBehavior")]
        public virtual void ResetTimedMetadataBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimedMetadataPid")]
        public virtual void ResetTimedMetadataPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransportStreamId")]
        public virtual void ResetTransportStreamId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVideoPid")]
        public virtual void ResetVideoPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dvbNitSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbNitSettingsOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbNitSettingsOutputReference DvbNitSettings
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbNitSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "dvbSdtSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbSdtSettingsOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbSdtSettingsOutputReference DvbSdtSettings
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbSdtSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "dvbTdtSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbTdtSettingsOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbTdtSettingsOutputReference DvbTdtSettings
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbTdtSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "absentInputAudioBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AbsentInputAudioBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "aribCaptionsPidControlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AribCaptionsPidControlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "aribCaptionsPidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AribCaptionsPidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "aribInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AribInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioBufferModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AudioBufferModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioFramesPerPesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AudioFramesPerPesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioPidsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AudioPidsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioStreamTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AudioStreamTypeInput
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
        [JsiiProperty(name: "bufferModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BufferModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ccDescriptorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CcDescriptorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dvbNitSettingsInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbNitSettings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbNitSettings? DvbNitSettingsInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbNitSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dvbSdtSettingsInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbSdtSettings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbSdtSettings? DvbSdtSettingsInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbSdtSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dvbSubPidsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DvbSubPidsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dvbTdtSettingsInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbTdtSettings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbTdtSettings? DvbTdtSettingsInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbTdtSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dvbTeletextPidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DvbTeletextPidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebifInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EbifInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebpAudioIntervalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EbpAudioIntervalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebpLookaheadMsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EbpLookaheadMsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebpPlacementInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EbpPlacementInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecmPidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EcmPidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "esRateInPesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EsRateInPesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "etvPlatformPidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EtvPlatformPidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "etvSignalPidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EtvSignalPidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fragmentTimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FragmentTimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "klvDataPidsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KlvDataPidsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "klvInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KlvInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nielsenId3BehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NielsenId3BehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nullPacketBitrateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NullPacketBitrateInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patIntervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PatIntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pcrControlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PcrControlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pcrPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PcrPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pcrPidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PcrPidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pmtIntervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PmtIntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pmtPidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PmtPidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "programNumInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ProgramNumInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rateModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RateModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scte27PidsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Scte27PidsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scte35ControlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Scte35ControlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scte35PidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Scte35PidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "segmentationMarkersInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SegmentationMarkersInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "segmentationStyleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SegmentationStyleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "segmentationTimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SegmentationTimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timedMetadataBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimedMetadataBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timedMetadataPidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimedMetadataPidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transportStreamIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TransportStreamIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "videoPidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VideoPidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "absentInputAudioBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AbsentInputAudioBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "arib", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arib
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "aribCaptionsPid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AribCaptionsPid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "aribCaptionsPidControl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AribCaptionsPidControl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "audioBufferModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AudioBufferModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "audioFramesPerPes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AudioFramesPerPes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "audioPids", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AudioPids
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "audioStreamType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AudioStreamType
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

        [JsiiProperty(name: "bufferModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BufferModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ccDescriptor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CcDescriptor
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dvbSubPids", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DvbSubPids
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dvbTeletextPid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DvbTeletextPid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebif", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ebif
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebpAudioInterval", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbpAudioInterval
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebpLookaheadMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbpLookaheadMs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebpPlacement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbpPlacement
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ecmPid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EcmPid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "esRateInPes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EsRateInPes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "etvPlatformPid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EtvPlatformPid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "etvSignalPid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EtvSignalPid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fragmentTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FragmentTime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "klv", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Klv
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "klvDataPids", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KlvDataPids
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nielsenId3Behavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NielsenId3Behavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nullPacketBitrate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NullPacketBitrate
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "patInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PatInterval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pcrControl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PcrControl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pcrPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PcrPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pcrPid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PcrPid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pmtInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PmtInterval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pmtPid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PmtPid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "programNum", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProgramNum
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rateMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RateMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scte27Pids", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scte27Pids
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scte35Control", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scte35Control
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scte35Pid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scte35Pid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "segmentationMarkers", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SegmentationMarkers
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "segmentationStyle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SegmentationStyle
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "segmentationTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SegmentationTime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timedMetadataBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimedMetadataBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timedMetadataPid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimedMetadataPid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transportStreamId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TransportStreamId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "videoPid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VideoPid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettings? InternalValue
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
