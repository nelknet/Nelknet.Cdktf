using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FmsPolicy
{
    [JsiiClass(nativeType: typeof(aws.FmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionOutputReference), fullyQualifiedName: "aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FmsPolicySecurityServicePolicyDataPolicyOptionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FmsPolicySecurityServicePolicyDataPolicyOptionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FmsPolicySecurityServicePolicyDataPolicyOptionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FmsPolicySecurityServicePolicyDataPolicyOptionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNetworkAclCommonPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy\"}}]")]
        public virtual void PutNetworkAclCommonPolicy(aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkFirewallPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicy\"}}]")]
        public virtual void PutNetworkFirewallPolicy(aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThirdPartyFirewallPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy\"}}]")]
        public virtual void PutThirdPartyFirewallPolicy(aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetNetworkAclCommonPolicy")]
        public virtual void ResetNetworkAclCommonPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkFirewallPolicy")]
        public virtual void ResetNetworkFirewallPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThirdPartyFirewallPolicy")]
        public virtual void ResetThirdPartyFirewallPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "networkAclCommonPolicy", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicyOutputReference\"}")]
        public virtual aws.FmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicyOutputReference NetworkAclCommonPolicy
        {
            get => GetInstanceProperty<aws.FmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "networkFirewallPolicy", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicyOutputReference\"}")]
        public virtual aws.FmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicyOutputReference NetworkFirewallPolicy
        {
            get => GetInstanceProperty<aws.FmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "thirdPartyFirewallPolicy", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicyOutputReference\"}")]
        public virtual aws.FmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicyOutputReference ThirdPartyFirewallPolicy
        {
            get => GetInstanceProperty<aws.FmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkAclCommonPolicyInput", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy\"}", isOptional: true)]
        public virtual aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy? NetworkAclCommonPolicyInput
        {
            get => GetInstanceProperty<aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkAclCommonPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkFirewallPolicyInput", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicy\"}", isOptional: true)]
        public virtual aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicy? NetworkFirewallPolicyInput
        {
            get => GetInstanceProperty<aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionNetworkFirewallPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thirdPartyFirewallPolicyInput", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy\"}", isOptional: true)]
        public virtual aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy? ThirdPartyFirewallPolicyInput
        {
            get => GetInstanceProperty<aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOptionThirdPartyFirewallPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOption\"}", isOptional: true)]
        public virtual aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOption? InternalValue
        {
            get => GetInstanceProperty<aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOption?>();
            set => SetInstanceProperty(value);
        }
    }
}
