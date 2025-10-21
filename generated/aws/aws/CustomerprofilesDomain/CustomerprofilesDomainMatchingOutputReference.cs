using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    [JsiiClass(nativeType: typeof(aws.CustomerprofilesDomain.CustomerprofilesDomainMatchingOutputReference), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainMatchingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CustomerprofilesDomainMatchingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CustomerprofilesDomainMatchingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CustomerprofilesDomainMatchingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CustomerprofilesDomainMatchingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutoMerging", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMerging\"}}]")]
        public virtual void PutAutoMerging(aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMerging @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMerging)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExportingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingExportingConfig\"}}]")]
        public virtual void PutExportingConfig(aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingExportingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingExportingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJobSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingJobSchedule\"}}]")]
        public virtual void PutJobSchedule(aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingJobSchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingJobSchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoMerging")]
        public virtual void ResetAutoMerging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportingConfig")]
        public virtual void ResetExportingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobSchedule")]
        public virtual void ResetJobSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "autoMerging", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingOutputReference\"}")]
        public virtual aws.CustomerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingOutputReference AutoMerging
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingOutputReference>()!;
        }

        [JsiiProperty(name: "exportingConfig", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingExportingConfigOutputReference\"}")]
        public virtual aws.CustomerprofilesDomain.CustomerprofilesDomainMatchingExportingConfigOutputReference ExportingConfig
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.CustomerprofilesDomainMatchingExportingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "jobSchedule", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingJobScheduleOutputReference\"}")]
        public virtual aws.CustomerprofilesDomain.CustomerprofilesDomainMatchingJobScheduleOutputReference JobSchedule
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.CustomerprofilesDomainMatchingJobScheduleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoMergingInput", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMerging\"}", isOptional: true)]
        public virtual aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMerging? AutoMergingInput
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMerging?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportingConfigInput", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingExportingConfig\"}", isOptional: true)]
        public virtual aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingExportingConfig? ExportingConfigInput
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingExportingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobScheduleInput", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingJobSchedule\"}", isOptional: true)]
        public virtual aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingJobSchedule? JobScheduleInput
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingJobSchedule?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatching\"}", isOptional: true)]
        public virtual aws.CustomerprofilesDomain.ICustomerprofilesDomainMatching? InternalValue
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainMatching?>();
            set => SetInstanceProperty(value);
        }
    }
}
