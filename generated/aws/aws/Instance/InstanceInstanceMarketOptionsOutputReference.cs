using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    [JsiiClass(nativeType: typeof(aws.Instance.InstanceInstanceMarketOptionsOutputReference), fullyQualifiedName: "aws.instance.InstanceInstanceMarketOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InstanceInstanceMarketOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InstanceInstanceMarketOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InstanceInstanceMarketOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InstanceInstanceMarketOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSpotOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.instance.InstanceInstanceMarketOptionsSpotOptions\"}}]")]
        public virtual void PutSpotOptions(aws.Instance.IInstanceInstanceMarketOptionsSpotOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Instance.IInstanceInstanceMarketOptionsSpotOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMarketType")]
        public virtual void ResetMarketType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotOptions")]
        public virtual void ResetSpotOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "spotOptions", typeJson: "{\"fqn\":\"aws.instance.InstanceInstanceMarketOptionsSpotOptionsOutputReference\"}")]
        public virtual aws.Instance.InstanceInstanceMarketOptionsSpotOptionsOutputReference SpotOptions
        {
            get => GetInstanceProperty<aws.Instance.InstanceInstanceMarketOptionsSpotOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "marketTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MarketTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotOptionsInput", typeJson: "{\"fqn\":\"aws.instance.InstanceInstanceMarketOptionsSpotOptions\"}", isOptional: true)]
        public virtual aws.Instance.IInstanceInstanceMarketOptionsSpotOptions? SpotOptionsInput
        {
            get => GetInstanceProperty<aws.Instance.IInstanceInstanceMarketOptionsSpotOptions?>();
        }

        [JsiiProperty(name: "marketType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MarketType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.instance.InstanceInstanceMarketOptions\"}", isOptional: true)]
        public virtual aws.Instance.IInstanceInstanceMarketOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Instance.IInstanceInstanceMarketOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
