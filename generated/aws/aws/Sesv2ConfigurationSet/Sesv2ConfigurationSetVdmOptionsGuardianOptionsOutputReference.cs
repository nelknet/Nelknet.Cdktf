using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSet
{
    [JsiiClass(nativeType: typeof(aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsGuardianOptionsOutputReference), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsGuardianOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Sesv2ConfigurationSetVdmOptionsGuardianOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Sesv2ConfigurationSetVdmOptionsGuardianOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Sesv2ConfigurationSetVdmOptionsGuardianOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Sesv2ConfigurationSetVdmOptionsGuardianOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetOptimizedSharedDelivery")]
        public virtual void ResetOptimizedSharedDelivery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "optimizedSharedDeliveryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OptimizedSharedDeliveryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "optimizedSharedDelivery", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OptimizedSharedDelivery
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsGuardianOptions\"}", isOptional: true)]
        public virtual aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsGuardianOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsGuardianOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
