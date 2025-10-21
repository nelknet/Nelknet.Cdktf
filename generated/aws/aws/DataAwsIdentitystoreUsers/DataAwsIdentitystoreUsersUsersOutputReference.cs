using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIdentitystoreUsers
{
    [JsiiClass(nativeType: typeof(aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersOutputReference), fullyQualifiedName: "aws.dataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsIdentitystoreUsersUsersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsIdentitystoreUsersUsersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsIdentitystoreUsersUsersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsIdentitystoreUsersUsersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addresses", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersAddressesList\"}")]
        public virtual aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersAddressesList Addresses
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersAddressesList>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emails", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersEmailsList\"}")]
        public virtual aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersEmailsList Emails
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersEmailsList>()!;
        }

        [JsiiProperty(name: "externalIds", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersExternalIdsList\"}")]
        public virtual aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersExternalIdsList ExternalIds
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersExternalIdsList>()!;
        }

        [JsiiProperty(name: "identityStoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityStoreId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Locale
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersNameList\"}")]
        public virtual aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersNameList Name
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersNameList>()!;
        }

        [JsiiProperty(name: "nickname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Nickname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phoneNumbers", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersPhoneNumbersList\"}")]
        public virtual aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersPhoneNumbersList PhoneNumbers
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsersPhoneNumbersList>()!;
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

        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserId
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUsers.DataAwsIdentitystoreUsersUsers\"}", isOptional: true)]
        public virtual aws.DataAwsIdentitystoreUsers.IDataAwsIdentitystoreUsersUsers? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUsers.IDataAwsIdentitystoreUsersUsers?>();
            set => SetInstanceProperty(value);
        }
    }
}
