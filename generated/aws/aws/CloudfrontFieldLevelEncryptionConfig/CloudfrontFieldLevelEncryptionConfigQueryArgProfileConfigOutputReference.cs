using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontFieldLevelEncryptionConfig
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference), fullyQualifiedName: "aws.cloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putQueryArgProfiles", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles\"}}]")]
        public virtual void PutQueryArgProfiles(aws.CloudfrontFieldLevelEncryptionConfig.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontFieldLevelEncryptionConfig.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetQueryArgProfiles")]
        public virtual void ResetQueryArgProfiles()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "queryArgProfiles", typeJson: "{\"fqn\":\"aws.cloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesOutputReference\"}")]
        public virtual aws.CloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesOutputReference QueryArgProfiles
        {
            get => GetInstanceProperty<aws.CloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardWhenQueryArgProfileIsUnknownInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForwardWhenQueryArgProfileIsUnknownInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryArgProfilesInput", typeJson: "{\"fqn\":\"aws.cloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles\"}", isOptional: true)]
        public virtual aws.CloudfrontFieldLevelEncryptionConfig.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles? QueryArgProfilesInput
        {
            get => GetInstanceProperty<aws.CloudfrontFieldLevelEncryptionConfig.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles?>();
        }

        [JsiiProperty(name: "forwardWhenQueryArgProfileIsUnknown", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForwardWhenQueryArgProfileIsUnknown
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontFieldLevelEncryptionConfig.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig? InternalValue
        {
            get => GetInstanceProperty<aws.CloudfrontFieldLevelEncryptionConfig.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
