using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomain
{
    [JsiiClass(nativeType: typeof(aws.ElasticsearchDomain.ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference), fullyQualifiedName: "aws.elasticsearchDomain.ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAvailabilityZoneCount")]
        public virtual void ResetAvailabilityZoneCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AvailabilityZoneCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "availabilityZoneCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailabilityZoneCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainClusterConfigZoneAwarenessConfig\"}", isOptional: true)]
        public virtual aws.ElasticsearchDomain.IElasticsearchDomainClusterConfigZoneAwarenessConfig? InternalValue
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.IElasticsearchDomainClusterConfigZoneAwarenessConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
