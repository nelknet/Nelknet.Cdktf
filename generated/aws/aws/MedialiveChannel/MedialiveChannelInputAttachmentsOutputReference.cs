using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiClass(nativeType: typeof(aws.MedialiveChannel.MedialiveChannelInputAttachmentsOutputReference), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MedialiveChannelInputAttachmentsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MedialiveChannelInputAttachmentsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelInputAttachmentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelInputAttachmentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutomaticInputFailoverSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettings\"}}]")]
        public virtual void PutAutomaticInputFailoverSettings(aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInputSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettings\"}}]")]
        public virtual void PutInputSettings(aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutomaticInputFailoverSettings")]
        public virtual void ResetAutomaticInputFailoverSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputSettings")]
        public virtual void ResetInputSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "automaticInputFailoverSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsOutputReference AutomaticInputFailoverSettings
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "inputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelInputAttachmentsInputSettingsOutputReference InputSettings
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelInputAttachmentsInputSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticInputFailoverSettingsInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettings? AutomaticInputFailoverSettingsInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputAttachmentNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputAttachmentNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputSettingsInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettings? InputSettingsInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettings?>();
        }

        [JsiiProperty(name: "inputAttachmentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputAttachmentName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inputId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachments\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MedialiveChannel.IMedialiveChannelInputAttachments cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveChannel.IMedialiveChannelInputAttachments).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
