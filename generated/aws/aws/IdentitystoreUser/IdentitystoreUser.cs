using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IdentitystoreUser
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user aws_identitystore_user}.</summary>
    [JsiiClass(nativeType: typeof(aws.IdentitystoreUser.IdentitystoreUser), fullyQualifiedName: "aws.identitystoreUser.IdentitystoreUser", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserConfig\"}}]")]
    public class IdentitystoreUser : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user aws_identitystore_user} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IdentitystoreUser(Constructs.Construct scope, string id, aws.IdentitystoreUser.IIdentitystoreUserConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.IdentitystoreUser.IIdentitystoreUserConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentitystoreUser(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentitystoreUser(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a IdentitystoreUser resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IdentitystoreUser to import.</param>
        /// <param name="importFromId">The id of the existing IdentitystoreUser that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IdentitystoreUser to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IdentitystoreUser to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IdentitystoreUser that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IdentitystoreUser to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.IdentitystoreUser.IdentitystoreUser), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAddresses", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserAddresses\"}}]")]
        public virtual void PutAddresses(aws.IdentitystoreUser.IIdentitystoreUserAddresses @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IdentitystoreUser.IIdentitystoreUserAddresses)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserEmails\"}}]")]
        public virtual void PutEmails(aws.IdentitystoreUser.IIdentitystoreUserEmails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IdentitystoreUser.IIdentitystoreUserEmails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putName", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserName\"}}]")]
        public virtual void PutName(aws.IdentitystoreUser.IIdentitystoreUserName @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IdentitystoreUser.IIdentitystoreUserName)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPhoneNumbers", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserPhoneNumbers\"}}]")]
        public virtual void PutPhoneNumbers(aws.IdentitystoreUser.IIdentitystoreUserPhoneNumbers @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IdentitystoreUser.IIdentitystoreUserPhoneNumbers)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddresses")]
        public virtual void ResetAddresses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmails")]
        public virtual void ResetEmails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocale")]
        public virtual void ResetLocale()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNickname")]
        public virtual void ResetNickname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhoneNumbers")]
        public virtual void ResetPhoneNumbers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreferredLanguage")]
        public virtual void ResetPreferredLanguage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProfileUrl")]
        public virtual void ResetProfileUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimezone")]
        public virtual void ResetTimezone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTitle")]
        public virtual void ResetTitle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserType")]
        public virtual void ResetUserType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.IdentitystoreUser.IdentitystoreUser))!;

        [JsiiProperty(name: "addresses", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserAddressesOutputReference\"}")]
        public virtual aws.IdentitystoreUser.IdentitystoreUserAddressesOutputReference Addresses
        {
            get => GetInstanceProperty<aws.IdentitystoreUser.IdentitystoreUserAddressesOutputReference>()!;
        }

        [JsiiProperty(name: "emails", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserEmailsOutputReference\"}")]
        public virtual aws.IdentitystoreUser.IdentitystoreUserEmailsOutputReference Emails
        {
            get => GetInstanceProperty<aws.IdentitystoreUser.IdentitystoreUserEmailsOutputReference>()!;
        }

        [JsiiProperty(name: "externalIds", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserExternalIdsList\"}")]
        public virtual aws.IdentitystoreUser.IdentitystoreUserExternalIdsList ExternalIds
        {
            get => GetInstanceProperty<aws.IdentitystoreUser.IdentitystoreUserExternalIdsList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserNameOutputReference\"}")]
        public virtual aws.IdentitystoreUser.IdentitystoreUserNameOutputReference Name
        {
            get => GetInstanceProperty<aws.IdentitystoreUser.IdentitystoreUserNameOutputReference>()!;
        }

        [JsiiProperty(name: "phoneNumbers", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserPhoneNumbersOutputReference\"}")]
        public virtual aws.IdentitystoreUser.IdentitystoreUserPhoneNumbersOutputReference PhoneNumbers
        {
            get => GetInstanceProperty<aws.IdentitystoreUser.IdentitystoreUserPhoneNumbersOutputReference>()!;
        }

        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressesInput", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserAddresses\"}", isOptional: true)]
        public virtual aws.IdentitystoreUser.IIdentitystoreUserAddresses? AddressesInput
        {
            get => GetInstanceProperty<aws.IdentitystoreUser.IIdentitystoreUserAddresses?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailsInput", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserEmails\"}", isOptional: true)]
        public virtual aws.IdentitystoreUser.IIdentitystoreUserEmails? EmailsInput
        {
            get => GetInstanceProperty<aws.IdentitystoreUser.IIdentitystoreUserEmails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityStoreIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityStoreIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocaleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserName\"}", isOptional: true)]
        public virtual aws.IdentitystoreUser.IIdentitystoreUserName? NameInput
        {
            get => GetInstanceProperty<aws.IdentitystoreUser.IIdentitystoreUserName?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nicknameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NicknameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "phoneNumbersInput", typeJson: "{\"fqn\":\"aws.identitystoreUser.IdentitystoreUserPhoneNumbers\"}", isOptional: true)]
        public virtual aws.IdentitystoreUser.IIdentitystoreUserPhoneNumbers? PhoneNumbersInput
        {
            get => GetInstanceProperty<aws.IdentitystoreUser.IIdentitystoreUserPhoneNumbers?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredLanguageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreferredLanguageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "profileUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProfileUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timezoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimezoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "titleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TitleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identityStoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityStoreId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Locale
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nickname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Nickname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredLanguage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "profileUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timezone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
