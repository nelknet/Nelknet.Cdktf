using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyFeature
{
    [JsiiClass(nativeType: typeof(aws.EvidentlyFeature.EvidentlyFeatureVariationsValueOutputReference), fullyQualifiedName: "aws.evidentlyFeature.EvidentlyFeatureVariationsValueOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EvidentlyFeatureVariationsValueOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EvidentlyFeatureVariationsValueOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EvidentlyFeatureVariationsValueOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EvidentlyFeatureVariationsValueOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBoolValue")]
        public virtual void ResetBoolValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDoubleValue")]
        public virtual void ResetDoubleValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLongValue")]
        public virtual void ResetLongValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStringValue")]
        public virtual void ResetStringValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "boolValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BoolValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "doubleValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DoubleValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "longValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LongValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stringValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StringValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "boolValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BoolValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "doubleValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DoubleValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "longValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LongValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stringValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StringValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.evidentlyFeature.EvidentlyFeatureVariationsValue\"}", isOptional: true)]
        public virtual aws.EvidentlyFeature.IEvidentlyFeatureVariationsValue? InternalValue
        {
            get => GetInstanceProperty<aws.EvidentlyFeature.IEvidentlyFeatureVariationsValue?>();
            set => SetInstanceProperty(value);
        }
    }
}
