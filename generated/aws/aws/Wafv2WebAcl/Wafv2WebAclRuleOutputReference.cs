using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiClass(nativeType: typeof(aws.Wafv2WebAcl.Wafv2WebAclRuleOutputReference), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2WebAclRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public Wafv2WebAclRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected Wafv2WebAclRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleAction\"}}]")]
        public virtual void PutAction(aws.Wafv2WebAcl.IWafv2WebAclRuleAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCaptchaConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleCaptchaConfig\"}}]")]
        public virtual void PutCaptchaConfig(aws.Wafv2WebAcl.IWafv2WebAclRuleCaptchaConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleCaptchaConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putChallengeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleChallengeConfig\"}}]")]
        public virtual void PutChallengeConfig(aws.Wafv2WebAcl.IWafv2WebAclRuleChallengeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleChallengeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOverrideAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideAction\"}}]")]
        public virtual void PutOverrideAction(aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRuleLabel", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleRuleLabel\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRuleLabel(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAcl.IWafv2WebAclRuleRuleLabel[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleRuleLabel).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleRuleLabel).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVisibilityConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleVisibilityConfig\"}}]")]
        public virtual void PutVisibilityConfig(aws.Wafv2WebAcl.IWafv2WebAclRuleVisibilityConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleVisibilityConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAction")]
        public virtual void ResetAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCaptchaConfig")]
        public virtual void ResetCaptchaConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChallengeConfig")]
        public virtual void ResetChallengeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOverrideAction")]
        public virtual void ResetOverrideAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuleLabel")]
        public virtual void ResetRuleLabel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatement")]
        public virtual void ResetStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleActionOutputReference Action
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleActionOutputReference>()!;
        }

        [JsiiProperty(name: "captchaConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleCaptchaConfigOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleCaptchaConfigOutputReference CaptchaConfig
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleCaptchaConfigOutputReference>()!;
        }

        [JsiiProperty(name: "challengeConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleChallengeConfigOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleChallengeConfigOutputReference ChallengeConfig
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleChallengeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "overrideAction", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideActionOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleOverrideActionOutputReference OverrideAction
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleOverrideActionOutputReference>()!;
        }

        [JsiiProperty(name: "ruleLabel", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleRuleLabelList\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleRuleLabelList RuleLabel
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleRuleLabelList>()!;
        }

        [JsiiProperty(name: "statementInput", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object StatementInput
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "visibilityConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleVisibilityConfigOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleVisibilityConfigOutputReference VisibilityConfig
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleVisibilityConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleAction\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleAction? ActionInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "captchaConfigInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleCaptchaConfig\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleCaptchaConfig? CaptchaConfigInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleCaptchaConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "challengeConfigInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleChallengeConfig\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleChallengeConfig? ChallengeConfigInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleChallengeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideActionInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideAction\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideAction? OverrideActionInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PriorityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleLabelInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleRuleLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RuleLabelInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "visibilityConfigInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleVisibilityConfig\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleVisibilityConfig? VisibilityConfigInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleVisibilityConfig?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "statement", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Statement
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRule\"}]}}", isOptional: true)]
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
                        case aws.Wafv2WebAcl.IWafv2WebAclRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
