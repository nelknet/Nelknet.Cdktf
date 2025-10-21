using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IdentitystoreUser
{
    [JsiiClass(nativeType: typeof(aws.IdentitystoreUser.IdentitystoreUserNameOutputReference), fullyQualifiedName: "aws.identitystoreUser.IdentitystoreUserNameOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IdentitystoreUserNameOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IdentitystoreUserNameOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IdentitystoreUserNameOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentitystoreUserNameOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFormatted")]
        public virtual void ResetFormatted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHonorificPrefix")]
        public virtual void ResetHonorificPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHonorificSuffix")]
        public virtual void ResetHonorificSuffix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMiddleName")]
        public virtual void ResetMiddleName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "familyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FamilyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "formattedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FormattedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "givenNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GivenNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "honorificPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HonorificPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "honorificSuffixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HonorificSuffixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "middleNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MiddleNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "familyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FamilyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "formatted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Formatted
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GivenName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "honorificPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HonorificPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "honorificSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HonorificSuffix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "middleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MiddleName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserName\"}", isOptional: true)]
        public virtual aws.IdentitystoreUser.IIdentitystoreUserName? InternalValue
        {
            get => GetInstanceProperty<aws.IdentitystoreUser.IIdentitystoreUserName?>();
            set => SetInstanceProperty(value);
        }
    }
}
