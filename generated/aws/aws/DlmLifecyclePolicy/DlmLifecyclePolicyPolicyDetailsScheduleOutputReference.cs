using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DlmLifecyclePolicy
{
    [JsiiClass(nativeType: typeof(aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleOutputReference), fullyQualifiedName: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DlmLifecyclePolicyPolicyDetailsScheduleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DlmLifecyclePolicyPolicyDetailsScheduleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DlmLifecyclePolicyPolicyDetailsScheduleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DlmLifecyclePolicyPolicyDetailsScheduleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCreateRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule\"}}]")]
        public virtual void PutCreateRule(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCrossRegionCopyRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCrossRegionCopyRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeprecateRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleDeprecateRule\"}}]")]
        public virtual void PutDeprecateRule(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleDeprecateRule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleDeprecateRule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFastRestoreRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleFastRestoreRule\"}}]")]
        public virtual void PutFastRestoreRule(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleFastRestoreRule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleFastRestoreRule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetainRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleRetainRule\"}}]")]
        public virtual void PutRetainRule(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShareRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleShareRule\"}}]")]
        public virtual void PutShareRule(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleShareRule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleShareRule)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCopyTags")]
        public virtual void ResetCopyTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCrossRegionCopyRule")]
        public virtual void ResetCrossRegionCopyRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeprecateRule")]
        public virtual void ResetDeprecateRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFastRestoreRule")]
        public virtual void ResetFastRestoreRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShareRule")]
        public virtual void ResetShareRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsToAdd")]
        public virtual void ResetTagsToAdd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVariableTags")]
        public virtual void ResetVariableTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "createRule", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleCreateRuleOutputReference\"}")]
        public virtual aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleCreateRuleOutputReference CreateRule
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleCreateRuleOutputReference>()!;
        }

        [JsiiProperty(name: "crossRegionCopyRule", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRuleList\"}")]
        public virtual aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRuleList CrossRegionCopyRule
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRuleList>()!;
        }

        [JsiiProperty(name: "deprecateRule", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleDeprecateRuleOutputReference\"}")]
        public virtual aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleDeprecateRuleOutputReference DeprecateRule
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleDeprecateRuleOutputReference>()!;
        }

        [JsiiProperty(name: "fastRestoreRule", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleFastRestoreRuleOutputReference\"}")]
        public virtual aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleFastRestoreRuleOutputReference FastRestoreRule
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleFastRestoreRuleOutputReference>()!;
        }

        [JsiiProperty(name: "retainRule", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleRetainRuleOutputReference\"}")]
        public virtual aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleRetainRuleOutputReference RetainRule
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleRetainRuleOutputReference>()!;
        }

        [JsiiProperty(name: "shareRule", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleShareRuleOutputReference\"}")]
        public virtual aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleShareRuleOutputReference ShareRule
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleShareRuleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyTagsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CopyTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createRuleInput", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule\"}", isOptional: true)]
        public virtual aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule? CreateRuleInput
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "crossRegionCopyRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CrossRegionCopyRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deprecateRuleInput", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleDeprecateRule\"}", isOptional: true)]
        public virtual aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleDeprecateRule? DeprecateRuleInput
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleDeprecateRule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fastRestoreRuleInput", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleFastRestoreRule\"}", isOptional: true)]
        public virtual aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleFastRestoreRule? FastRestoreRuleInput
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleFastRestoreRule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retainRuleInput", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleRetainRule\"}", isOptional: true)]
        public virtual aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule? RetainRuleInput
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shareRuleInput", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleShareRule\"}", isOptional: true)]
        public virtual aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleShareRule? ShareRuleInput
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleShareRule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsToAddInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsToAddInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "variableTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? VariableTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "copyTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CopyTags
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsToAdd", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsToAdd
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "variableTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> VariableTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsSchedule\"}]}}", isOptional: true)]
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
                        case aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsSchedule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsSchedule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
