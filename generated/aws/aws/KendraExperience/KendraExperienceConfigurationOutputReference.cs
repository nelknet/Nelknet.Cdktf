using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraExperience
{
    [JsiiClass(nativeType: typeof(aws.KendraExperience.KendraExperienceConfigurationOutputReference), fullyQualifiedName: "aws.kendraExperience.KendraExperienceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KendraExperienceConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KendraExperienceConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KendraExperienceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KendraExperienceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContentSourceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraExperience.KendraExperienceConfigurationContentSourceConfiguration\"}}]")]
        public virtual void PutContentSourceConfiguration(aws.KendraExperience.IKendraExperienceConfigurationContentSourceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraExperience.IKendraExperienceConfigurationContentSourceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserIdentityConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraExperience.KendraExperienceConfigurationUserIdentityConfiguration\"}}]")]
        public virtual void PutUserIdentityConfiguration(aws.KendraExperience.IKendraExperienceConfigurationUserIdentityConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraExperience.IKendraExperienceConfigurationUserIdentityConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContentSourceConfiguration")]
        public virtual void ResetContentSourceConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserIdentityConfiguration")]
        public virtual void ResetUserIdentityConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "contentSourceConfiguration", typeJson: "{\"fqn\":\"aws.kendraExperience.KendraExperienceConfigurationContentSourceConfigurationOutputReference\"}")]
        public virtual aws.KendraExperience.KendraExperienceConfigurationContentSourceConfigurationOutputReference ContentSourceConfiguration
        {
            get => GetInstanceProperty<aws.KendraExperience.KendraExperienceConfigurationContentSourceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "userIdentityConfiguration", typeJson: "{\"fqn\":\"aws.kendraExperience.KendraExperienceConfigurationUserIdentityConfigurationOutputReference\"}")]
        public virtual aws.KendraExperience.KendraExperienceConfigurationUserIdentityConfigurationOutputReference UserIdentityConfiguration
        {
            get => GetInstanceProperty<aws.KendraExperience.KendraExperienceConfigurationUserIdentityConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentSourceConfigurationInput", typeJson: "{\"fqn\":\"aws.kendraExperience.KendraExperienceConfigurationContentSourceConfiguration\"}", isOptional: true)]
        public virtual aws.KendraExperience.IKendraExperienceConfigurationContentSourceConfiguration? ContentSourceConfigurationInput
        {
            get => GetInstanceProperty<aws.KendraExperience.IKendraExperienceConfigurationContentSourceConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userIdentityConfigurationInput", typeJson: "{\"fqn\":\"aws.kendraExperience.KendraExperienceConfigurationUserIdentityConfiguration\"}", isOptional: true)]
        public virtual aws.KendraExperience.IKendraExperienceConfigurationUserIdentityConfiguration? UserIdentityConfigurationInput
        {
            get => GetInstanceProperty<aws.KendraExperience.IKendraExperienceConfigurationUserIdentityConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kendraExperience.KendraExperienceConfiguration\"}", isOptional: true)]
        public virtual aws.KendraExperience.IKendraExperienceConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.KendraExperience.IKendraExperienceConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
