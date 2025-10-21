using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsMqBroker
{
    [JsiiClass(nativeType: typeof(aws.DataAwsMqBroker.DataAwsMqBrokerLdapServerMetadataOutputReference), fullyQualifiedName: "aws.dataAwsMqBroker.DataAwsMqBrokerLdapServerMetadataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsMqBrokerLdapServerMetadataOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsMqBrokerLdapServerMetadataOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsMqBrokerLdapServerMetadataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMqBrokerLdapServerMetadataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Hosts
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "roleBase", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleBase
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleSearchMatching", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleSearchMatching
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleSearchSubtree", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable RoleSearchSubtree
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "serviceAccountPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccountPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceAccountUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccountUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userBase", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserBase
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userRoleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserRoleName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userSearchMatching", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserSearchMatching
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userSearchSubtree", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable UserSearchSubtree
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsMqBroker.DataAwsMqBrokerLdapServerMetadata\"}", isOptional: true)]
        public virtual aws.DataAwsMqBroker.IDataAwsMqBrokerLdapServerMetadata? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsMqBroker.IDataAwsMqBrokerLdapServerMetadata?>();
            set => SetInstanceProperty(value);
        }
    }
}
