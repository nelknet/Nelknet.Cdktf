using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    [JsiiClass(nativeType: typeof(aws.KendraIndex.KendraIndexUserTokenConfigurationsOutputReference), fullyQualifiedName: "aws.kendraIndex.KendraIndexUserTokenConfigurationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KendraIndexUserTokenConfigurationsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KendraIndexUserTokenConfigurationsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KendraIndexUserTokenConfigurationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KendraIndexUserTokenConfigurationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putJsonTokenTypeConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration\"}}]")]
        public virtual void PutJsonTokenTypeConfiguration(aws.KendraIndex.IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraIndex.IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJwtTokenTypeConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration\"}}]")]
        public virtual void PutJwtTokenTypeConfiguration(aws.KendraIndex.IKendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraIndex.IKendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetJsonTokenTypeConfiguration")]
        public virtual void ResetJsonTokenTypeConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJwtTokenTypeConfiguration")]
        public virtual void ResetJwtTokenTypeConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "jsonTokenTypeConfiguration", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurationsJsonTokenTypeConfigurationOutputReference\"}")]
        public virtual aws.KendraIndex.KendraIndexUserTokenConfigurationsJsonTokenTypeConfigurationOutputReference JsonTokenTypeConfiguration
        {
            get => GetInstanceProperty<aws.KendraIndex.KendraIndexUserTokenConfigurationsJsonTokenTypeConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "jwtTokenTypeConfiguration", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurationsJwtTokenTypeConfigurationOutputReference\"}")]
        public virtual aws.KendraIndex.KendraIndexUserTokenConfigurationsJwtTokenTypeConfigurationOutputReference JwtTokenTypeConfiguration
        {
            get => GetInstanceProperty<aws.KendraIndex.KendraIndexUserTokenConfigurationsJwtTokenTypeConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "jsonTokenTypeConfigurationInput", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration\"}", isOptional: true)]
        public virtual aws.KendraIndex.IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration? JsonTokenTypeConfigurationInput
        {
            get => GetInstanceProperty<aws.KendraIndex.IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jwtTokenTypeConfigurationInput", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration\"}", isOptional: true)]
        public virtual aws.KendraIndex.IKendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration? JwtTokenTypeConfigurationInput
        {
            get => GetInstanceProperty<aws.KendraIndex.IKendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurations\"}", isOptional: true)]
        public virtual aws.KendraIndex.IKendraIndexUserTokenConfigurations? InternalValue
        {
            get => GetInstanceProperty<aws.KendraIndex.IKendraIndexUserTokenConfigurations?>();
            set => SetInstanceProperty(value);
        }
    }
}
