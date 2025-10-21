using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsRoute53ResolverFirewallRules
{
    [JsiiClass(nativeType: typeof(aws.DataAwsRoute53ResolverFirewallRules.DataAwsRoute53ResolverFirewallRulesFirewallRulesOutputReference), fullyQualifiedName: "aws.dataAwsRoute53ResolverFirewallRules.DataAwsRoute53ResolverFirewallRulesFirewallRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsRoute53ResolverFirewallRulesFirewallRulesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsRoute53ResolverFirewallRulesFirewallRulesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsRoute53ResolverFirewallRulesFirewallRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsRoute53ResolverFirewallRulesFirewallRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockOverrideDnsType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockOverrideDnsType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockOverrideDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockOverrideDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockOverrideTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BlockOverrideTtl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "blockResponse", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockResponse
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creationTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creatorRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatorRequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "firewallDomainListId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirewallDomainListId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "firewallRuleGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirewallRuleGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modificationTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModificationTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsRoute53ResolverFirewallRules.DataAwsRoute53ResolverFirewallRulesFirewallRules\"}", isOptional: true)]
        public virtual aws.DataAwsRoute53ResolverFirewallRules.IDataAwsRoute53ResolverFirewallRulesFirewallRules? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsRoute53ResolverFirewallRules.IDataAwsRoute53ResolverFirewallRulesFirewallRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
