using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiClass(nativeType: typeof(aws.MedialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsOutputReference), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFilterSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings\"}}]")]
        public virtual void PutFilterSettings(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdaptiveQuantization")]
        public virtual void ResetAdaptiveQuantization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAfdSignaling")]
        public virtual void ResetAfdSignaling()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBitrate")]
        public virtual void ResetBitrate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBufFillPct")]
        public virtual void ResetBufFillPct()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBufSize")]
        public virtual void ResetBufSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetColorMetadata")]
        public virtual void ResetColorMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEntropyEncoding")]
        public virtual void ResetEntropyEncoding()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilterSettings")]
        public virtual void ResetFilterSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFixedAfd")]
        public virtual void ResetFixedAfd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFlickerAq")]
        public virtual void ResetFlickerAq()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceFieldPictures")]
        public virtual void ResetForceFieldPictures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFramerateControl")]
        public virtual void ResetFramerateControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFramerateDenominator")]
        public virtual void ResetFramerateDenominator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFramerateNumerator")]
        public virtual void ResetFramerateNumerator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGopBReference")]
        public virtual void ResetGopBReference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGopClosedCadence")]
        public virtual void ResetGopClosedCadence()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGopNumBFrames")]
        public virtual void ResetGopNumBFrames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGopSize")]
        public virtual void ResetGopSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGopSizeUnits")]
        public virtual void ResetGopSizeUnits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLevel")]
        public virtual void ResetLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLookAheadRateControl")]
        public virtual void ResetLookAheadRateControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxBitrate")]
        public virtual void ResetMaxBitrate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinIInterval")]
        public virtual void ResetMinIInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumRefFrames")]
        public virtual void ResetNumRefFrames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParControl")]
        public virtual void ResetParControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParDenominator")]
        public virtual void ResetParDenominator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParNumerator")]
        public virtual void ResetParNumerator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProfile")]
        public virtual void ResetProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQualityLevel")]
        public virtual void ResetQualityLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQvbrQualityLevel")]
        public virtual void ResetQvbrQualityLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRateControlMode")]
        public virtual void ResetRateControlMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScanType")]
        public virtual void ResetScanType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSceneChangeDetect")]
        public virtual void ResetSceneChangeDetect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlices")]
        public virtual void ResetSlices()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSoftness")]
        public virtual void ResetSoftness()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpatialAq")]
        public virtual void ResetSpatialAq()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubgopLength")]
        public virtual void ResetSubgopLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSyntax")]
        public virtual void ResetSyntax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTemporalAq")]
        public virtual void ResetTemporalAq()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimecodeInsertion")]
        public virtual void ResetTimecodeInsertion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "filterSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsOutputReference FilterSettings
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adaptiveQuantizationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdaptiveQuantizationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "afdSignalingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AfdSignalingInput
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
        [JsiiProperty(name: "bufFillPctInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BufFillPctInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bufSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BufSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "colorMetadataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ColorMetadataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "entropyEncodingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EntropyEncodingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterSettingsInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings? FilterSettingsInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedAfdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FixedAfdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "flickerAqInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FlickerAqInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceFieldPicturesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ForceFieldPicturesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "framerateControlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FramerateControlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "framerateDenominatorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FramerateDenominatorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "framerateNumeratorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FramerateNumeratorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gopBReferenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GopBReferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gopClosedCadenceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GopClosedCadenceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gopNumBFramesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GopNumBFramesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gopSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GopSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gopSizeUnitsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GopSizeUnitsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "levelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lookAheadRateControlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LookAheadRateControlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxBitrateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxBitrateInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minIIntervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinIIntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numRefFramesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumRefFramesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parControlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParControlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parDenominatorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ParDenominatorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parNumeratorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ParNumeratorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "profileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProfileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "qualityLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QualityLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "qvbrQualityLevelInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QvbrQualityLevelInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rateControlModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RateControlModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scanTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScanTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sceneChangeDetectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SceneChangeDetectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slicesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SlicesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softnessInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SoftnessInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spatialAqInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpatialAqInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subgopLengthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubgopLengthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "syntaxInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SyntaxInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "temporalAqInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TemporalAqInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timecodeInsertionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimecodeInsertionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "adaptiveQuantization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdaptiveQuantization
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "afdSignaling", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AfdSignaling
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

        [JsiiProperty(name: "bufFillPct", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BufFillPct
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bufSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BufSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "colorMetadata", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ColorMetadata
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "entropyEncoding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntropyEncoding
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fixedAfd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FixedAfd
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "flickerAq", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlickerAq
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceFieldPictures", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ForceFieldPictures
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "framerateControl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FramerateControl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "framerateDenominator", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FramerateDenominator
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "framerateNumerator", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FramerateNumerator
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gopBReference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GopBReference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gopClosedCadence", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GopClosedCadence
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gopNumBFrames", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GopNumBFrames
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gopSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GopSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gopSizeUnits", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GopSizeUnits
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Level
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lookAheadRateControl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LookAheadRateControl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxBitrate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBitrate
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minIInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinIInterval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numRefFrames", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumRefFrames
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parControl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParControl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parDenominator", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ParDenominator
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parNumerator", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ParNumerator
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Profile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "qualityLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QualityLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "qvbrQualityLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QvbrQualityLevel
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rateControlMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RateControlMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scanType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScanType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sceneChangeDetect", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SceneChangeDetect
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "slices", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Slices
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "softness", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Softness
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spatialAq", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpatialAq
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subgopLength", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubgopLength
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "syntax", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Syntax
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "temporalAq", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TemporalAq
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timecodeInsertion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimecodeInsertion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264Settings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264Settings? InternalValue
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264Settings?>();
            set => SetInstanceProperty(value);
        }
    }
}
