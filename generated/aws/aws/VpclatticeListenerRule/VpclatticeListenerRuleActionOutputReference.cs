using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    [JsiiClass(nativeType: typeof(aws.VpclatticeListenerRule.VpclatticeListenerRuleActionOutputReference), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpclatticeListenerRuleActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpclatticeListenerRuleActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VpclatticeListenerRuleActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpclatticeListenerRuleActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFixedResponse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionFixedResponse\"}}]")]
        public virtual void PutFixedResponse(aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionFixedResponse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionFixedResponse)}, new object[]{@value});
        }

        [JsiiMethod(name: "putForward", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionForward\"}}]")]
        public virtual void PutForward(aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionForward @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionForward)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFixedResponse")]
        public virtual void ResetFixedResponse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForward")]
        public virtual void ResetForward()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionFixedResponseOutputReference\"}")]
        public virtual aws.VpclatticeListenerRule.VpclatticeListenerRuleActionFixedResponseOutputReference FixedResponse
        {
            get => GetInstanceProperty<aws.VpclatticeListenerRule.VpclatticeListenerRuleActionFixedResponseOutputReference>()!;
        }

        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionForwardOutputReference\"}")]
        public virtual aws.VpclatticeListenerRule.VpclatticeListenerRuleActionForwardOutputReference Forward
        {
            get => GetInstanceProperty<aws.VpclatticeListenerRule.VpclatticeListenerRuleActionForwardOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedResponseInput", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionFixedResponse\"}", isOptional: true)]
        public virtual aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionFixedResponse? FixedResponseInput
        {
            get => GetInstanceProperty<aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionFixedResponse?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardInput", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleActionForward\"}", isOptional: true)]
        public virtual aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionForward? ForwardInput
        {
            get => GetInstanceProperty<aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionForward?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleAction\"}", isOptional: true)]
        public virtual aws.VpclatticeListenerRule.IVpclatticeListenerRuleAction? InternalValue
        {
            get => GetInstanceProperty<aws.VpclatticeListenerRule.IVpclatticeListenerRuleAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
