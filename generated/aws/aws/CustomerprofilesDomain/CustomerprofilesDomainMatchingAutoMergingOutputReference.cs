using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    [JsiiClass(nativeType: typeof(aws.CustomerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingOutputReference), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CustomerprofilesDomainMatchingAutoMergingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CustomerprofilesDomainMatchingAutoMergingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CustomerprofilesDomainMatchingAutoMergingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CustomerprofilesDomainMatchingAutoMergingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConflictResolution", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConflictResolution\"}}]")]
        public virtual void PutConflictResolution(aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConflictResolution @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConflictResolution)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConsolidation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConsolidation\"}}]")]
        public virtual void PutConsolidation(aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConsolidation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConsolidation)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConflictResolution")]
        public virtual void ResetConflictResolution()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConsolidation")]
        public virtual void ResetConsolidation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinAllowedConfidenceScoreForMerging")]
        public virtual void ResetMinAllowedConfidenceScoreForMerging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "conflictResolution", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConflictResolutionOutputReference\"}")]
        public virtual aws.CustomerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConflictResolutionOutputReference ConflictResolution
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConflictResolutionOutputReference>()!;
        }

        [JsiiProperty(name: "consolidation", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConsolidationOutputReference\"}")]
        public virtual aws.CustomerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConsolidationOutputReference Consolidation
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConsolidationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "conflictResolutionInput", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConflictResolution\"}", isOptional: true)]
        public virtual aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConflictResolution? ConflictResolutionInput
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConflictResolution?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "consolidationInput", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConsolidation\"}", isOptional: true)]
        public virtual aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConsolidation? ConsolidationInput
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConsolidation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minAllowedConfidenceScoreForMergingInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinAllowedConfidenceScoreForMergingInput
        {
            get => GetInstanceProperty<double?>();
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

        [JsiiProperty(name: "minAllowedConfidenceScoreForMerging", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinAllowedConfidenceScoreForMerging
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMerging\"}", isOptional: true)]
        public virtual aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMerging? InternalValue
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMerging?>();
            set => SetInstanceProperty(value);
        }
    }
}
