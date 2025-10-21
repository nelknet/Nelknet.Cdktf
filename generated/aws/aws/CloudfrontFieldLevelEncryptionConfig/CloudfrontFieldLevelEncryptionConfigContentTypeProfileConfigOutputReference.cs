using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontFieldLevelEncryptionConfig
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference), fullyQualifiedName: "aws.cloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContentTypeProfiles", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles\"}}]")]
        public virtual void PutContentTypeProfiles(aws.CloudfrontFieldLevelEncryptionConfig.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontFieldLevelEncryptionConfig.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles)}, new object[]{@value});
        }

        [JsiiProperty(name: "contentTypeProfiles", typeJson: "{\"fqn\":\"aws.cloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesOutputReference\"}")]
        public virtual aws.CloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesOutputReference ContentTypeProfiles
        {
            get => GetInstanceProperty<aws.CloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentTypeProfilesInput", typeJson: "{\"fqn\":\"aws.cloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles\"}", isOptional: true)]
        public virtual aws.CloudfrontFieldLevelEncryptionConfig.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles? ContentTypeProfilesInput
        {
            get => GetInstanceProperty<aws.CloudfrontFieldLevelEncryptionConfig.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardWhenContentTypeIsUnknownInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForwardWhenContentTypeIsUnknownInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "forwardWhenContentTypeIsUnknown", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForwardWhenContentTypeIsUnknown
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontFieldLevelEncryptionConfig.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig? InternalValue
        {
            get => GetInstanceProperty<aws.CloudfrontFieldLevelEncryptionConfig.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
