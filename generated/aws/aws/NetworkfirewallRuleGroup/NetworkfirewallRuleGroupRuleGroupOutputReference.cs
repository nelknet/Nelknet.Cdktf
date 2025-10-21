using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallRuleGroup
{
    [JsiiClass(nativeType: typeof(aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupOutputReference), fullyQualifiedName: "aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetworkfirewallRuleGroupRuleGroupOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetworkfirewallRuleGroupRuleGroupOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetworkfirewallRuleGroupRuleGroupOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkfirewallRuleGroupRuleGroupOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putReferenceSets", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupReferenceSets\"}}]")]
        public virtual void PutReferenceSets(aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupReferenceSets @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupReferenceSets)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRulesSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSource\"}}]")]
        public virtual void PutRulesSource(aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRuleVariables", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariables\"}}]")]
        public virtual void PutRuleVariables(aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariables @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariables)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStatefulRuleOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptions\"}}]")]
        public virtual void PutStatefulRuleOptions(aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetReferenceSets")]
        public virtual void ResetReferenceSets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuleVariables")]
        public virtual void ResetRuleVariables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatefulRuleOptions")]
        public virtual void ResetStatefulRuleOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "referenceSets", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupReferenceSetsOutputReference\"}")]
        public virtual aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupReferenceSetsOutputReference ReferenceSets
        {
            get => GetInstanceProperty<aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupReferenceSetsOutputReference>()!;
        }

        [JsiiProperty(name: "rulesSource", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceOutputReference\"}")]
        public virtual aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceOutputReference RulesSource
        {
            get => GetInstanceProperty<aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceOutputReference>()!;
        }

        [JsiiProperty(name: "ruleVariables", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariablesOutputReference\"}")]
        public virtual aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariablesOutputReference RuleVariables
        {
            get => GetInstanceProperty<aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariablesOutputReference>()!;
        }

        [JsiiProperty(name: "statefulRuleOptions", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptionsOutputReference\"}")]
        public virtual aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptionsOutputReference StatefulRuleOptions
        {
            get => GetInstanceProperty<aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "referenceSetsInput", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupReferenceSets\"}", isOptional: true)]
        public virtual aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupReferenceSets? ReferenceSetsInput
        {
            get => GetInstanceProperty<aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupReferenceSets?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rulesSourceInput", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSource\"}", isOptional: true)]
        public virtual aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSource? RulesSourceInput
        {
            get => GetInstanceProperty<aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleVariablesInput", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariables\"}", isOptional: true)]
        public virtual aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariables? RuleVariablesInput
        {
            get => GetInstanceProperty<aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariables?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statefulRuleOptionsInput", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptions\"}", isOptional: true)]
        public virtual aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions? StatefulRuleOptionsInput
        {
            get => GetInstanceProperty<aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroup\"}", isOptional: true)]
        public virtual aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroup? InternalValue
        {
            get => GetInstanceProperty<aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroup?>();
            set => SetInstanceProperty(value);
        }
    }
}
