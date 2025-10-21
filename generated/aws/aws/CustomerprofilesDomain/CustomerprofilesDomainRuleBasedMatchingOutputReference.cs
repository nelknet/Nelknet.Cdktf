using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    [JsiiClass(nativeType: typeof(aws.CustomerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingOutputReference), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CustomerprofilesDomainRuleBasedMatchingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CustomerprofilesDomainRuleBasedMatchingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CustomerprofilesDomainRuleBasedMatchingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CustomerprofilesDomainRuleBasedMatchingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAttributeTypesSelector", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector\"}}]")]
        public virtual void PutAttributeTypesSelector(aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConflictResolution", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingConflictResolution\"}}]")]
        public virtual void PutConflictResolution(aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingConflictResolution @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingConflictResolution)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExportingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingExportingConfig\"}}]")]
        public virtual void PutExportingConfig(aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingExportingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingExportingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatchingRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingMatchingRules\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMatchingRules(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingMatchingRules[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingMatchingRules).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingMatchingRules).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAttributeTypesSelector")]
        public virtual void ResetAttributeTypesSelector()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConflictResolution")]
        public virtual void ResetConflictResolution()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportingConfig")]
        public virtual void ResetExportingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMatchingRules")]
        public virtual void ResetMatchingRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxAllowedRuleLevelForMatching")]
        public virtual void ResetMaxAllowedRuleLevelForMatching()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxAllowedRuleLevelForMerging")]
        public virtual void ResetMaxAllowedRuleLevelForMerging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "attributeTypesSelector", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingAttributeTypesSelectorOutputReference\"}")]
        public virtual aws.CustomerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingAttributeTypesSelectorOutputReference AttributeTypesSelector
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingAttributeTypesSelectorOutputReference>()!;
        }

        [JsiiProperty(name: "conflictResolution", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingConflictResolutionOutputReference\"}")]
        public virtual aws.CustomerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingConflictResolutionOutputReference ConflictResolution
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingConflictResolutionOutputReference>()!;
        }

        [JsiiProperty(name: "exportingConfig", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingExportingConfigOutputReference\"}")]
        public virtual aws.CustomerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingExportingConfigOutputReference ExportingConfig
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingExportingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "matchingRules", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingMatchingRulesList\"}")]
        public virtual aws.CustomerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingMatchingRulesList MatchingRules
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingMatchingRulesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributeTypesSelectorInput", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector\"}", isOptional: true)]
        public virtual aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector? AttributeTypesSelectorInput
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "conflictResolutionInput", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingConflictResolution\"}", isOptional: true)]
        public virtual aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingConflictResolution? ConflictResolutionInput
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingConflictResolution?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportingConfigInput", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingExportingConfig\"}", isOptional: true)]
        public virtual aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingExportingConfig? ExportingConfigInput
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingExportingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchingRulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingMatchingRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MatchingRulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxAllowedRuleLevelForMatchingInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxAllowedRuleLevelForMatchingInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxAllowedRuleLevelForMergingInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxAllowedRuleLevelForMergingInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "maxAllowedRuleLevelForMatching", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAllowedRuleLevelForMatching
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxAllowedRuleLevelForMerging", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAllowedRuleLevelForMerging
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatching\"}", isOptional: true)]
        public virtual aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatching? InternalValue
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatching?>();
            set => SetInstanceProperty(value);
        }
    }
}
