using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElastictranscoderPreset
{
    [JsiiClass(nativeType: typeof(aws.ElastictranscoderPreset.ElastictranscoderPresetVideoOutputReference), fullyQualifiedName: "aws.elastictranscoderPreset.ElastictranscoderPresetVideoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ElastictranscoderPresetVideoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ElastictranscoderPresetVideoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ElastictranscoderPresetVideoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPresetVideoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAspectRatio")]
        public virtual void ResetAspectRatio()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBitRate")]
        public virtual void ResetBitRate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodec")]
        public virtual void ResetCodec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayAspectRatio")]
        public virtual void ResetDisplayAspectRatio()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFixedGop")]
        public virtual void ResetFixedGop()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFrameRate")]
        public virtual void ResetFrameRate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyframesMaxDist")]
        public virtual void ResetKeyframesMaxDist()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxFrameRate")]
        public virtual void ResetMaxFrameRate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxHeight")]
        public virtual void ResetMaxHeight()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxWidth")]
        public virtual void ResetMaxWidth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaddingPolicy")]
        public virtual void ResetPaddingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResolution")]
        public virtual void ResetResolution()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSizingPolicy")]
        public virtual void ResetSizingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "aspectRatioInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AspectRatioInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bitRateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BitRateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codecInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CodecInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayAspectRatioInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayAspectRatioInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedGopInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FixedGopInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "frameRateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FrameRateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyframesMaxDistInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyframesMaxDistInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxFrameRateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxFrameRateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxHeightInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxHeightInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxWidthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxWidthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "paddingPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PaddingPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resolutionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResolutionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizingPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SizingPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "aspectRatio", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AspectRatio
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bitRate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BitRate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "codec", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Codec
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayAspectRatio", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayAspectRatio
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fixedGop", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FixedGop
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "frameRate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FrameRate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyframesMaxDist", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyframesMaxDist
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxFrameRate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxFrameRate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxHeight", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxHeight
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxWidth", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxWidth
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "paddingPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaddingPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resolution", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Resolution
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sizingPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SizingPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetVideo\"}", isOptional: true)]
        public virtual aws.ElastictranscoderPreset.IElastictranscoderPresetVideo? InternalValue
        {
            get => GetInstanceProperty<aws.ElastictranscoderPreset.IElastictranscoderPresetVideo?>();
            set => SetInstanceProperty(value);
        }
    }
}
