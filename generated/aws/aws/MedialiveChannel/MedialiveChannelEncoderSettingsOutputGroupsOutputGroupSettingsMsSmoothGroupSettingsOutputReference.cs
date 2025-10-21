using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiClass(nativeType: typeof(aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsOutputReference), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination\"}}]")]
        public virtual void PutDestination(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcquisitionPointId")]
        public virtual void ResetAcquisitionPointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAudioOnlyTimecodeControl")]
        public virtual void ResetAudioOnlyTimecodeControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateMode")]
        public virtual void ResetCertificateMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionRetryInterval")]
        public virtual void ResetConnectionRetryInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventId")]
        public virtual void ResetEventId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventIdMode")]
        public virtual void ResetEventIdMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventStopBehavior")]
        public virtual void ResetEventStopBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilecacheDuration")]
        public virtual void ResetFilecacheDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFragmentLength")]
        public virtual void ResetFragmentLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputLossAction")]
        public virtual void ResetInputLossAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumRetries")]
        public virtual void ResetNumRetries()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestartDelay")]
        public virtual void ResetRestartDelay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSegmentationMode")]
        public virtual void ResetSegmentationMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSendDelayMs")]
        public virtual void ResetSendDelayMs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSparseTrackType")]
        public virtual void ResetSparseTrackType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamManifestBehavior")]
        public virtual void ResetStreamManifestBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimestampOffset")]
        public virtual void ResetTimestampOffset()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimestampOffsetMode")]
        public virtual void ResetTimestampOffsetMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestinationOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestinationOutputReference Destination
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestinationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acquisitionPointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AcquisitionPointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioOnlyTimecodeControlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AudioOnlyTimecodeControlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionRetryIntervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConnectionRetryIntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination? DestinationInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventIdModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventIdModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventStopBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventStopBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filecacheDurationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FilecacheDurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fragmentLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FragmentLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputLossActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputLossActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numRetriesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumRetriesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restartDelayInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RestartDelayInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "segmentationModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SegmentationModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sendDelayMsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SendDelayMsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sparseTrackTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SparseTrackTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamManifestBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StreamManifestBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timestampOffsetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimestampOffsetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timestampOffsetModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimestampOffsetModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "acquisitionPointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcquisitionPointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "audioOnlyTimecodeControl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AudioOnlyTimecodeControl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectionRetryInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectionRetryInterval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventIdMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventIdMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventStopBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventStopBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filecacheDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FilecacheDuration
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fragmentLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FragmentLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inputLossAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputLossAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numRetries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumRetries
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "restartDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RestartDelay
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "segmentationMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SegmentationMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sendDelayMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SendDelayMs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sparseTrackType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SparseTrackType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "streamManifestBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamManifestBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timestampOffset", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimestampOffset
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timestampOffsetMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimestampOffsetMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings? InternalValue
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
