using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbTargetGroup
{
    [JsiiClass(nativeType: typeof(aws.LbTargetGroup.LbTargetGroupTargetGroupHealthOutputReference), fullyQualifiedName: "aws.lbTargetGroup.LbTargetGroupTargetGroupHealthOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LbTargetGroupTargetGroupHealthOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LbTargetGroupTargetGroupHealthOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LbTargetGroupTargetGroupHealthOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbTargetGroupTargetGroupHealthOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDnsFailover", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbTargetGroup.LbTargetGroupTargetGroupHealthDnsFailover\"}}]")]
        public virtual void PutDnsFailover(aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthDnsFailover @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthDnsFailover)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUnhealthyStateRouting", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbTargetGroup.LbTargetGroupTargetGroupHealthUnhealthyStateRouting\"}}]")]
        public virtual void PutUnhealthyStateRouting(aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthUnhealthyStateRouting @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthUnhealthyStateRouting)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDnsFailover")]
        public virtual void ResetDnsFailover()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnhealthyStateRouting")]
        public virtual void ResetUnhealthyStateRouting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dnsFailover", typeJson: "{\"fqn\":\"aws.lbTargetGroup.LbTargetGroupTargetGroupHealthDnsFailoverOutputReference\"}")]
        public virtual aws.LbTargetGroup.LbTargetGroupTargetGroupHealthDnsFailoverOutputReference DnsFailover
        {
            get => GetInstanceProperty<aws.LbTargetGroup.LbTargetGroupTargetGroupHealthDnsFailoverOutputReference>()!;
        }

        [JsiiProperty(name: "unhealthyStateRouting", typeJson: "{\"fqn\":\"aws.lbTargetGroup.LbTargetGroupTargetGroupHealthUnhealthyStateRoutingOutputReference\"}")]
        public virtual aws.LbTargetGroup.LbTargetGroupTargetGroupHealthUnhealthyStateRoutingOutputReference UnhealthyStateRouting
        {
            get => GetInstanceProperty<aws.LbTargetGroup.LbTargetGroupTargetGroupHealthUnhealthyStateRoutingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsFailoverInput", typeJson: "{\"fqn\":\"aws.lbTargetGroup.LbTargetGroupTargetGroupHealthDnsFailover\"}", isOptional: true)]
        public virtual aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthDnsFailover? DnsFailoverInput
        {
            get => GetInstanceProperty<aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthDnsFailover?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unhealthyStateRoutingInput", typeJson: "{\"fqn\":\"aws.lbTargetGroup.LbTargetGroupTargetGroupHealthUnhealthyStateRouting\"}", isOptional: true)]
        public virtual aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthUnhealthyStateRouting? UnhealthyStateRoutingInput
        {
            get => GetInstanceProperty<aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthUnhealthyStateRouting?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lbTargetGroup.LbTargetGroupTargetGroupHealth\"}", isOptional: true)]
        public virtual aws.LbTargetGroup.ILbTargetGroupTargetGroupHealth? InternalValue
        {
            get => GetInstanceProperty<aws.LbTargetGroup.ILbTargetGroupTargetGroupHealth?>();
            set => SetInstanceProperty(value);
        }
    }
}
