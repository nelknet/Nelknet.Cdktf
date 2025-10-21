using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIdentitystoreUser
{
    [JsiiClass(nativeType: typeof(aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierOutputReference), fullyQualifiedName: "aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsIdentitystoreUserAlternateIdentifierOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataAwsIdentitystoreUserAlternateIdentifierOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataAwsIdentitystoreUserAlternateIdentifierOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsIdentitystoreUserAlternateIdentifierOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExternalId", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierExternalId\"}}]")]
        public virtual void PutExternalId(aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierExternalId @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierExternalId)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUniqueAttribute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute\"}}]")]
        public virtual void PutUniqueAttribute(aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExternalId")]
        public virtual void ResetExternalId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUniqueAttribute")]
        public virtual void ResetUniqueAttribute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierExternalIdOutputReference\"}")]
        public virtual aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierExternalIdOutputReference ExternalId
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierExternalIdOutputReference>()!;
        }

        [JsiiProperty(name: "uniqueAttribute", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierUniqueAttributeOutputReference\"}")]
        public virtual aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierUniqueAttributeOutputReference UniqueAttribute
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierUniqueAttributeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalIdInput", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierExternalId\"}", isOptional: true)]
        public virtual aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierExternalId? ExternalIdInput
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierExternalId?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uniqueAttributeInput", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute\"}", isOptional: true)]
        public virtual aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute? UniqueAttributeInput
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifier\"}", isOptional: true)]
        public virtual aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifier? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifier?>();
            set => SetInstanceProperty(value);
        }
    }
}
