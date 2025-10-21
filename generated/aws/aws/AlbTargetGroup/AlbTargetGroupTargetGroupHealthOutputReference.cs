using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbTargetGroup
{
    [JsiiClass(nativeType: typeof(aws.AlbTargetGroup.AlbTargetGroupTargetGroupHealthOutputReference), fullyQualifiedName: "aws.albTargetGroup.AlbTargetGroupTargetGroupHealthOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbTargetGroupTargetGroupHealthOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbTargetGroupTargetGroupHealthOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbTargetGroupTargetGroupHealthOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbTargetGroupTargetGroupHealthOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDnsFailover", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albTargetGroup.AlbTargetGroupTargetGroupHealthDnsFailover\"}}]")]
        public virtual void PutDnsFailover(aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthDnsFailover @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthDnsFailover)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUnhealthyStateRouting", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albTargetGroup.AlbTargetGroupTargetGroupHealthUnhealthyStateRouting\"}}]")]
        public virtual void PutUnhealthyStateRouting(aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthUnhealthyStateRouting @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthUnhealthyStateRouting)}, new object[]{@value});
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

        [JsiiProperty(name: "dnsFailover", typeJson: "{\"fqn\":\"aws.albTargetGroup.AlbTargetGroupTargetGroupHealthDnsFailoverOutputReference\"}")]
        public virtual aws.AlbTargetGroup.AlbTargetGroupTargetGroupHealthDnsFailoverOutputReference DnsFailover
        {
            get => GetInstanceProperty<aws.AlbTargetGroup.AlbTargetGroupTargetGroupHealthDnsFailoverOutputReference>()!;
        }

        [JsiiProperty(name: "unhealthyStateRouting", typeJson: "{\"fqn\":\"aws.albTargetGroup.AlbTargetGroupTargetGroupHealthUnhealthyStateRoutingOutputReference\"}")]
        public virtual aws.AlbTargetGroup.AlbTargetGroupTargetGroupHealthUnhealthyStateRoutingOutputReference UnhealthyStateRouting
        {
            get => GetInstanceProperty<aws.AlbTargetGroup.AlbTargetGroupTargetGroupHealthUnhealthyStateRoutingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsFailoverInput", typeJson: "{\"fqn\":\"aws.albTargetGroup.AlbTargetGroupTargetGroupHealthDnsFailover\"}", isOptional: true)]
        public virtual aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthDnsFailover? DnsFailoverInput
        {
            get => GetInstanceProperty<aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthDnsFailover?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unhealthyStateRoutingInput", typeJson: "{\"fqn\":\"aws.albTargetGroup.AlbTargetGroupTargetGroupHealthUnhealthyStateRouting\"}", isOptional: true)]
        public virtual aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthUnhealthyStateRouting? UnhealthyStateRoutingInput
        {
            get => GetInstanceProperty<aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthUnhealthyStateRouting?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.albTargetGroup.AlbTargetGroupTargetGroupHealth\"}", isOptional: true)]
        public virtual aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealth? InternalValue
        {
            get => GetInstanceProperty<aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealth?>();
            set => SetInstanceProperty(value);
        }
    }
}
