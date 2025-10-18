using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudLoadBalancers
{
    [JsiiClass(nativeType: typeof(hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersOutputReference), fullyQualifiedName: "hcloud.dataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataHcloudLoadBalancersLoadBalancersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataHcloudLoadBalancersLoadBalancersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataHcloudLoadBalancersLoadBalancersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudLoadBalancersLoadBalancersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "algorithm", typeJson: "{\"fqn\":\"hcloud.dataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersAlgorithmList\"}")]
        public virtual hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersAlgorithmList Algorithm
        {
            get => GetInstanceProperty<hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersAlgorithmList>()!;
        }

        [JsiiProperty(name: "deleteProtection", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DeleteProtection
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Id
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ipv4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Labels
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "loadBalancerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetworkId
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "networkIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "service", typeJson: "{\"fqn\":\"hcloud.dataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersServiceList\"}")]
        public virtual hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersServiceList Service
        {
            get => GetInstanceProperty<hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersServiceList>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"hcloud.dataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersTargetList\"}")]
        public virtual hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersTargetList Target
        {
            get => GetInstanceProperty<hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancersTargetList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"hcloud.dataHcloudLoadBalancers.DataHcloudLoadBalancersLoadBalancers\"}", isOptional: true)]
        public virtual hcloud.DataHcloudLoadBalancers.IDataHcloudLoadBalancersLoadBalancers? InternalValue
        {
            get => GetInstanceProperty<hcloud.DataHcloudLoadBalancers.IDataHcloudLoadBalancersLoadBalancers?>();
            set => SetInstanceProperty(value);
        }
    }
}
