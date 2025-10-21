using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiClass(nativeType: typeof(aws.MedialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorOutputReference), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInputLossImageSlate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate\"}}]")]
        public virtual void PutInputLossImageSlate(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBlackFrameMsec")]
        public virtual void ResetBlackFrameMsec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputLossImageColor")]
        public virtual void ResetInputLossImageColor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputLossImageSlate")]
        public virtual void ResetInputLossImageSlate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputLossImageType")]
        public virtual void ResetInputLossImageType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepeatFrameMsec")]
        public virtual void ResetRepeatFrameMsec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "inputLossImageSlate", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlateOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlateOutputReference InputLossImageSlate
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blackFrameMsecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BlackFrameMsecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputLossImageColorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputLossImageColorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputLossImageSlateInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate? InputLossImageSlateInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputLossImageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputLossImageTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repeatFrameMsecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RepeatFrameMsecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "blackFrameMsec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BlackFrameMsec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inputLossImageColor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputLossImageColor
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inputLossImageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputLossImageType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "repeatFrameMsec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RepeatFrameMsec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior? InternalValue
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior?>();
            set => SetInstanceProperty(value);
        }
    }
}
