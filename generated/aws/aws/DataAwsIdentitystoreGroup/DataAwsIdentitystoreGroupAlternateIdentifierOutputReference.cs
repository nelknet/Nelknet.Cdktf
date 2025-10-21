using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIdentitystoreGroup
{
    [JsiiClass(nativeType: typeof(aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierOutputReference), fullyQualifiedName: "aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsIdentitystoreGroupAlternateIdentifierOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataAwsIdentitystoreGroupAlternateIdentifierOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataAwsIdentitystoreGroupAlternateIdentifierOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsIdentitystoreGroupAlternateIdentifierOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExternalId", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierExternalId\"}}]")]
        public virtual void PutExternalId(aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierExternalId @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierExternalId)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUniqueAttribute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute\"}}]")]
        public virtual void PutUniqueAttribute(aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute)}, new object[]{@value});
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

        [JsiiProperty(name: "externalId", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierExternalIdOutputReference\"}")]
        public virtual aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierExternalIdOutputReference ExternalId
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierExternalIdOutputReference>()!;
        }

        [JsiiProperty(name: "uniqueAttribute", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierUniqueAttributeOutputReference\"}")]
        public virtual aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierUniqueAttributeOutputReference UniqueAttribute
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierUniqueAttributeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalIdInput", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierExternalId\"}", isOptional: true)]
        public virtual aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierExternalId? ExternalIdInput
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierExternalId?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uniqueAttributeInput", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute\"}", isOptional: true)]
        public virtual aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute? UniqueAttributeInput
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifier\"}", isOptional: true)]
        public virtual aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifier? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifier?>();
            set => SetInstanceProperty(value);
        }
    }
}
