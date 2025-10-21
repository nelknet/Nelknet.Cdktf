using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIdentitystoreUser
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user aws_identitystore_user}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUser), fullyQualifiedName: "aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUser", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserConfig\"}}]")]
    public class DataAwsIdentitystoreUser : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user aws_identitystore_user} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsIdentitystoreUser(Constructs.Construct scope, string id, aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsIdentitystoreUser(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsIdentitystoreUser(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsIdentitystoreUser resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsIdentitystoreUser to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsIdentitystoreUser that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsIdentitystoreUser to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsIdentitystoreUser to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsIdentitystoreUser that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsIdentitystoreUser to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUser), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAlternateIdentifier", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifier\"}}]")]
        public virtual void PutAlternateIdentifier(aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifier @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifier)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserFilter\"}}]")]
        public virtual void PutFilter(aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlternateIdentifier")]
        public virtual void ResetAlternateIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserId")]
        public virtual void ResetUserId()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUser))!;

        [JsiiProperty(name: "addresses", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAddressesList\"}")]
        public virtual aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserAddressesList Addresses
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserAddressesList>()!;
        }

        [JsiiProperty(name: "alternateIdentifier", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierOutputReference\"}")]
        public virtual aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierOutputReference AlternateIdentifier
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierOutputReference>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emails", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserEmailsList\"}")]
        public virtual aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserEmailsList Emails
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserEmailsList>()!;
        }

        [JsiiProperty(name: "externalIds", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserExternalIdsList\"}")]
        public virtual aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserExternalIdsList ExternalIds
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserExternalIdsList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserFilterOutputReference\"}")]
        public virtual aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserFilterOutputReference Filter
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserFilterOutputReference>()!;
        }

        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Locale
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserNameList\"}")]
        public virtual aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserNameList Name
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserNameList>()!;
        }

        [JsiiProperty(name: "nickname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Nickname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phoneNumbers", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserPhoneNumbersList\"}")]
        public virtual aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserPhoneNumbersList PhoneNumbers
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserPhoneNumbersList>()!;
        }

        [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredLanguage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "profileUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timezone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alternateIdentifierInput", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifier\"}", isOptional: true)]
        public virtual aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifier? AlternateIdentifierInput
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifier?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserFilter\"}", isOptional: true)]
        public virtual aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserFilter? FilterInput
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserFilter?>();
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
        [JsiiProperty(name: "userIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserIdInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
