using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorSecurityPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesOutputReference), fullyQualifiedName: "azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CdnFrontdoorSecurityPolicySecurityPoliciesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CdnFrontdoorSecurityPolicySecurityPoliciesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CdnFrontdoorSecurityPolicySecurityPoliciesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorSecurityPolicySecurityPoliciesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFirewall", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewall\"}}]")]
        public virtual void PutFirewall(azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPoliciesFirewall @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPoliciesFirewall)}, new object[]{@value});
        }

        [JsiiProperty(name: "firewall", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewallOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewallOutputReference Firewall
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewallOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "firewallInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPoliciesFirewall\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPoliciesFirewall? FirewallInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPoliciesFirewall?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPolicies\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPolicies? InternalValue
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorSecurityPolicy.ICdnFrontdoorSecurityPolicySecurityPolicies?>();
            set => SetInstanceProperty(value);
        }
    }
}
