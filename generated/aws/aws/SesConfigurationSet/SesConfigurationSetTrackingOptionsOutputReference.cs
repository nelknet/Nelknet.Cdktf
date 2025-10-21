using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SesConfigurationSet
{
    [JsiiClass(nativeType: typeof(aws.SesConfigurationSet.SesConfigurationSetTrackingOptionsOutputReference), fullyQualifiedName: "aws.sesConfigurationSet.SesConfigurationSetTrackingOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SesConfigurationSetTrackingOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SesConfigurationSetTrackingOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SesConfigurationSetTrackingOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesConfigurationSetTrackingOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCustomRedirectDomain")]
        public virtual void ResetCustomRedirectDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "customRedirectDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomRedirectDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "customRedirectDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomRedirectDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sesConfigurationSet.SesConfigurationSetTrackingOptions\"}", isOptional: true)]
        public virtual aws.SesConfigurationSet.ISesConfigurationSetTrackingOptions? InternalValue
        {
            get => GetInstanceProperty<aws.SesConfigurationSet.ISesConfigurationSetTrackingOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
