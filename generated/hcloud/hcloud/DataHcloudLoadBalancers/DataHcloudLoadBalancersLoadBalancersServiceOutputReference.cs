using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudLoadBalancers
{
    [JsiiClass(nativeType: typeof(hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersServiceOutputReference), fullyQualifiedName: "hcloud.dataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersServiceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataHcloudLoadBalancersLoadBalancersServiceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataHcloudLoadBalancersLoadBalancersServiceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudLoadBalancersLoadBalancersServiceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudLoadBalancersLoadBalancersServiceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "destinationPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DestinationPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"hcloud.dataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersServiceHealthCheckList\"}")]
        public virtual hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersServiceHealthCheckList HealthCheck
        {
            get => GetInstanceProperty<hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersServiceHealthCheckList>()!;
        }

        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"hcloud.dataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersServiceHttpList\"}")]
        public virtual hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersServiceHttpList Http
        {
            get => GetInstanceProperty<hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersServiceHttpList>()!;
        }

        [JsiiProperty(name: "listenPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ListenPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proxyprotocol", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Proxyprotocol
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"hcloud.dataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersService\"}", isOptional: true)]
        public virtual hcloud.DataHcloudLoadBalancers.IDataHcloudLoadBalancersLoadBalancersService? InternalValue
        {
            get => GetInstanceProperty<hcloud.DataHcloudLoadBalancers.IDataHcloudLoadBalancersLoadBalancersService?>();
            set => SetInstanceProperty(value);
        }
    }
}
