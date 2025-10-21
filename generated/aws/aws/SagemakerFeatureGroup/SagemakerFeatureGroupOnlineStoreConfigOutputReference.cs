using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFeatureGroup
{
    [JsiiClass(nativeType: typeof(aws.SagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigOutputReference), fullyQualifiedName: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerFeatureGroupOnlineStoreConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerFeatureGroupOnlineStoreConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerFeatureGroupOnlineStoreConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFeatureGroupOnlineStoreConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSecurityConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigSecurityConfig\"}}]")]
        public virtual void PutSecurityConfig(aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTtlDuration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigTtlDuration\"}}]")]
        public virtual void PutTtlDuration(aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigTtlDuration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigTtlDuration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnableOnlineStore")]
        public virtual void ResetEnableOnlineStore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityConfig")]
        public virtual void ResetSecurityConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageType")]
        public virtual void ResetStorageType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTtlDuration")]
        public virtual void ResetTtlDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "securityConfig", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigSecurityConfigOutputReference\"}")]
        public virtual aws.SagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigSecurityConfigOutputReference SecurityConfig
        {
            get => GetInstanceProperty<aws.SagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigSecurityConfigOutputReference>()!;
        }

        [JsiiProperty(name: "ttlDuration", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigTtlDurationOutputReference\"}")]
        public virtual aws.SagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigTtlDurationOutputReference TtlDuration
        {
            get => GetInstanceProperty<aws.SagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigTtlDurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableOnlineStoreInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableOnlineStoreInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigSecurityConfig\"}", isOptional: true)]
        public virtual aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig? SecurityConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ttlDurationInput", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigTtlDuration\"}", isOptional: true)]
        public virtual aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigTtlDuration? TtlDurationInput
        {
            get => GetInstanceProperty<aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigTtlDuration?>();
        }

        [JsiiProperty(name: "enableOnlineStore", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableOnlineStore
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

        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfig\"}", isOptional: true)]
        public virtual aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
