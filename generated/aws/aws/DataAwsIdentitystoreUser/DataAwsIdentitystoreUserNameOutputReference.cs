using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIdentitystoreUser
{
    [JsiiClass(nativeType: typeof(aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserNameOutputReference), fullyQualifiedName: "aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserNameOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsIdentitystoreUserNameOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsIdentitystoreUserNameOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsIdentitystoreUserNameOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsIdentitystoreUserNameOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "familyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FamilyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "formatted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Formatted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GivenName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "honorificPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HonorificPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "honorificSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HonorificSuffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "middleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MiddleName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserName\"}", isOptional: true)]
        public virtual aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserName? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserName?>();
            set => SetInstanceProperty(value);
        }
    }
}
