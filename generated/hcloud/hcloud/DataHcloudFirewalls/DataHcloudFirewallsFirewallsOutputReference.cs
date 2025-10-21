using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudFirewalls
{
    [JsiiClass(nativeType: typeof(hcloud.DataHcloudFirewalls.DataHcloudFirewallsFirewallsOutputReference), fullyQualifiedName: "hcloud.dataHcloudFirewalls.DataHcloudFirewallsFirewallsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataHcloudFirewallsFirewallsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataHcloudFirewallsFirewallsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataHcloudFirewallsFirewallsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudFirewallsFirewallsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applyTo", typeJson: "{\"fqn\":\"hcloud.dataHcloudFirewalls.DataHcloudFirewallsFirewallsApplyToList\"}")]
        public virtual hcloud.DataHcloudFirewalls.DataHcloudFirewallsFirewallsApplyToList ApplyTo
        {
            get => GetInstanceProperty<hcloud.DataHcloudFirewalls.DataHcloudFirewallsFirewallsApplyToList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Id
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Labels
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"hcloud.dataHcloudFirewalls.DataHcloudFirewallsFirewallsRuleList\"}")]
        public virtual hcloud.DataHcloudFirewalls.DataHcloudFirewallsFirewallsRuleList Rule
        {
            get => GetInstanceProperty<hcloud.DataHcloudFirewalls.DataHcloudFirewallsFirewallsRuleList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"hcloud.dataHcloudFirewalls.DataHcloudFirewallsFirewalls\"}", isOptional: true)]
        public virtual hcloud.DataHcloudFirewalls.IDataHcloudFirewallsFirewalls? InternalValue
        {
            get => GetInstanceProperty<hcloud.DataHcloudFirewalls.IDataHcloudFirewallsFirewalls?>();
            set => SetInstanceProperty(value);
        }
    }
}
