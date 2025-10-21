using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiClass(nativeType: typeof(aws.LaunchTemplate.LaunchTemplateInstanceMarketOptionsOutputReference), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateInstanceMarketOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LaunchTemplateInstanceMarketOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LaunchTemplateInstanceMarketOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LaunchTemplateInstanceMarketOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplateInstanceMarketOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSpotOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceMarketOptionsSpotOptions\"}}]")]
        public virtual void PutSpotOptions(aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptionsSpotOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptionsSpotOptions)}, new object[]{@value});
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

        [JsiiProperty(name: "spotOptions", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceMarketOptionsSpotOptionsOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateInstanceMarketOptionsSpotOptionsOutputReference SpotOptions
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateInstanceMarketOptionsSpotOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "marketTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MarketTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotOptionsInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceMarketOptionsSpotOptions\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptionsSpotOptions? SpotOptionsInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptionsSpotOptions?>();
        }

        [JsiiProperty(name: "marketType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MarketType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceMarketOptions\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptions? InternalValue
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
