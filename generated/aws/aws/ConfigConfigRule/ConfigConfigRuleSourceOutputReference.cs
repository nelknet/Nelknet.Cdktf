using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigRule
{
    [JsiiClass(nativeType: typeof(aws.ConfigConfigRule.ConfigConfigRuleSourceOutputReference), fullyQualifiedName: "aws.configConfigRule.ConfigConfigRuleSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConfigConfigRuleSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConfigConfigRuleSourceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ConfigConfigRuleSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigRuleSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomPolicyDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.configConfigRule.ConfigConfigRuleSourceCustomPolicyDetails\"}}]")]
        public virtual void PutCustomPolicyDetails(aws.ConfigConfigRule.IConfigConfigRuleSourceCustomPolicyDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConfigConfigRule.IConfigConfigRuleSourceCustomPolicyDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceDetail", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.configConfigRule.ConfigConfigRuleSourceSourceDetail\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSourceDetail(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ConfigConfigRule.IConfigConfigRuleSourceSourceDetail[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ConfigConfigRule.IConfigConfigRuleSourceSourceDetail).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ConfigConfigRule.IConfigConfigRuleSourceSourceDetail).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomPolicyDetails")]
        public virtual void ResetCustomPolicyDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceDetail")]
        public virtual void ResetSourceDetail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceIdentifier")]
        public virtual void ResetSourceIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customPolicyDetails", typeJson: "{\"fqn\":\"aws.configConfigRule.ConfigConfigRuleSourceCustomPolicyDetailsOutputReference\"}")]
        public virtual aws.ConfigConfigRule.ConfigConfigRuleSourceCustomPolicyDetailsOutputReference CustomPolicyDetails
        {
            get => GetInstanceProperty<aws.ConfigConfigRule.ConfigConfigRuleSourceCustomPolicyDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "sourceDetail", typeJson: "{\"fqn\":\"aws.configConfigRule.ConfigConfigRuleSourceSourceDetailList\"}")]
        public virtual aws.ConfigConfigRule.ConfigConfigRuleSourceSourceDetailList SourceDetail
        {
            get => GetInstanceProperty<aws.ConfigConfigRule.ConfigConfigRuleSourceSourceDetailList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customPolicyDetailsInput", typeJson: "{\"fqn\":\"aws.configConfigRule.ConfigConfigRuleSourceCustomPolicyDetails\"}", isOptional: true)]
        public virtual aws.ConfigConfigRule.IConfigConfigRuleSourceCustomPolicyDetails? CustomPolicyDetailsInput
        {
            get => GetInstanceProperty<aws.ConfigConfigRule.IConfigConfigRuleSourceCustomPolicyDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OwnerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDetailInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.configConfigRule.ConfigConfigRuleSourceSourceDetail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SourceDetailInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.configConfigRule.ConfigConfigRuleSource\"}", isOptional: true)]
        public virtual aws.ConfigConfigRule.IConfigConfigRuleSource? InternalValue
        {
            get => GetInstanceProperty<aws.ConfigConfigRule.IConfigConfigRuleSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
