using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    [JsiiClass(nativeType: typeof(aws.KendraIndex.KendraIndexUserTokenConfigurationsJsonTokenTypeConfigurationOutputReference), fullyQualifiedName: "aws.kendraIndex.KendraIndexUserTokenConfigurationsJsonTokenTypeConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KendraIndexUserTokenConfigurationsJsonTokenTypeConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KendraIndexUserTokenConfigurationsJsonTokenTypeConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KendraIndexUserTokenConfigurationsJsonTokenTypeConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KendraIndexUserTokenConfigurationsJsonTokenTypeConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupAttributeFieldInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupAttributeFieldInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userNameAttributeFieldInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserNameAttributeFieldInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "groupAttributeField", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupAttributeField
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userNameAttributeField", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserNameAttributeField
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration\"}", isOptional: true)]
        public virtual aws.KendraIndex.IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.KendraIndex.IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
