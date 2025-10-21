using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    [JsiiClass(nativeType: typeof(aws.LightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedHeadersOutputReference), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedHeadersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LightsailDistributionCacheBehaviorSettingsForwardedHeadersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LightsailDistributionCacheBehaviorSettingsForwardedHeadersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LightsailDistributionCacheBehaviorSettingsForwardedHeadersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LightsailDistributionCacheBehaviorSettingsForwardedHeadersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetHeadersAllowList")]
        public virtual void ResetHeadersAllowList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOption")]
        public virtual void ResetOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "headersAllowListInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? HeadersAllowListInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "optionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "headersAllowList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] HeadersAllowList
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "option", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Option
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedHeaders\"}", isOptional: true)]
        public virtual aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedHeaders? InternalValue
        {
            get => GetInstanceProperty<aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedHeaders?>();
            set => SetInstanceProperty(value);
        }
    }
}
