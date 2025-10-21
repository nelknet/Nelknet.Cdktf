using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiClass(nativeType: typeof(aws.OpensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindowOutputReference), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindowOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpensearchDomainOffPeakWindowOptionsOffPeakWindowOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpensearchDomainOffPeakWindowOptionsOffPeakWindowOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpensearchDomainOffPeakWindowOptionsOffPeakWindowOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchDomainOffPeakWindowOptionsOffPeakWindowOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putWindowStartTime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime\"}}]")]
        public virtual void PutWindowStartTime(aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetWindowStartTime")]
        public virtual void ResetWindowStartTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "windowStartTime", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTimeOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTimeOutputReference WindowStartTime
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTimeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "windowStartTimeInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime? WindowStartTimeInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindow\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindow? InternalValue
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindow?>();
            set => SetInstanceProperty(value);
        }
    }
}
