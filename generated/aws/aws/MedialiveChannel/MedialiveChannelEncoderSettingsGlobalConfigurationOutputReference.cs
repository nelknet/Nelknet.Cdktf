using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiClass(nativeType: typeof(aws.MedialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationOutputReference), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MedialiveChannelEncoderSettingsGlobalConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MedialiveChannelEncoderSettingsGlobalConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MedialiveChannelEncoderSettingsGlobalConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelEncoderSettingsGlobalConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInputLossBehavior", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior\"}}]")]
        public virtual void PutInputLossBehavior(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInitialAudioGain")]
        public virtual void ResetInitialAudioGain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputEndAction")]
        public virtual void ResetInputEndAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputLossBehavior")]
        public virtual void ResetInputLossBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputLockingMode")]
        public virtual void ResetOutputLockingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputTimingSource")]
        public virtual void ResetOutputTimingSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSupportLowFramerateInputs")]
        public virtual void ResetSupportLowFramerateInputs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "inputLossBehavior", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorOutputReference InputLossBehavior
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialAudioGainInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InitialAudioGainInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputEndActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputEndActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputLossBehaviorInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior? InputLossBehaviorInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputLockingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputLockingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputTimingSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputTimingSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "supportLowFramerateInputsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SupportLowFramerateInputsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "initialAudioGain", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialAudioGain
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inputEndAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputEndAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outputLockingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputLockingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outputTimingSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputTimingSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "supportLowFramerateInputs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SupportLowFramerateInputs
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfiguration\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
