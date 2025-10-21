using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafregionalWebAcl
{
    [JsiiClass(nativeType: typeof(aws.WafregionalWebAcl.WafregionalWebAclRuleOutputReference), fullyQualifiedName: "aws.wafregionalWebAcl.WafregionalWebAclRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class WafregionalWebAclRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public WafregionalWebAclRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected WafregionalWebAclRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafregionalWebAclRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclRuleAction\"}}]")]
        public virtual void PutAction(aws.WafregionalWebAcl.IWafregionalWebAclRuleAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.WafregionalWebAcl.IWafregionalWebAclRuleAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOverrideAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclRuleOverrideAction\"}}]")]
        public virtual void PutOverrideAction(aws.WafregionalWebAcl.IWafregionalWebAclRuleOverrideAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.WafregionalWebAcl.IWafregionalWebAclRuleOverrideAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAction")]
        public virtual void ResetAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOverrideAction")]
        public virtual void ResetOverrideAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclRuleActionOutputReference\"}")]
        public virtual aws.WafregionalWebAcl.WafregionalWebAclRuleActionOutputReference Action
        {
            get => GetInstanceProperty<aws.WafregionalWebAcl.WafregionalWebAclRuleActionOutputReference>()!;
        }

        [JsiiProperty(name: "overrideAction", typeJson: "{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclRuleOverrideActionOutputReference\"}")]
        public virtual aws.WafregionalWebAcl.WafregionalWebAclRuleOverrideActionOutputReference OverrideAction
        {
            get => GetInstanceProperty<aws.WafregionalWebAcl.WafregionalWebAclRuleOverrideActionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclRuleAction\"}", isOptional: true)]
        public virtual aws.WafregionalWebAcl.IWafregionalWebAclRuleAction? ActionInput
        {
            get => GetInstanceProperty<aws.WafregionalWebAcl.IWafregionalWebAclRuleAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideActionInput", typeJson: "{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclRuleOverrideAction\"}", isOptional: true)]
        public virtual aws.WafregionalWebAcl.IWafregionalWebAclRuleOverrideAction? OverrideActionInput
        {
            get => GetInstanceProperty<aws.WafregionalWebAcl.IWafregionalWebAclRuleOverrideAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PriorityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuleIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclRule\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.WafregionalWebAcl.IWafregionalWebAclRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.WafregionalWebAcl.IWafregionalWebAclRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
