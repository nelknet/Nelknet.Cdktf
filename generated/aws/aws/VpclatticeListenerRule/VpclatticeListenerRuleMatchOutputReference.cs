using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    [JsiiClass(nativeType: typeof(aws.VpclatticeListenerRule.VpclatticeListenerRuleMatchOutputReference), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpclatticeListenerRuleMatchOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpclatticeListenerRuleMatchOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VpclatticeListenerRuleMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpclatticeListenerRuleMatchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHttpMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatch\"}}]")]
        public virtual void PutHttpMatch(aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatch)}, new object[]{@value});
        }

        [JsiiProperty(name: "httpMatch", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchOutputReference\"}")]
        public virtual aws.VpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchOutputReference HttpMatch
        {
            get => GetInstanceProperty<aws.VpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpMatchInput", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatch\"}", isOptional: true)]
        public virtual aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatch? HttpMatchInput
        {
            get => GetInstanceProperty<aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatch\"}", isOptional: true)]
        public virtual aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatch? InternalValue
        {
            get => GetInstanceProperty<aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatch?>();
            set => SetInstanceProperty(value);
        }
    }
}
