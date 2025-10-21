using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EmailCommunicationServiceDomain
{
    [JsiiClass(nativeType: typeof(azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsOutputReference), fullyQualifiedName: "azurerm.emailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EmailCommunicationServiceDomainVerificationRecordsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public EmailCommunicationServiceDomainVerificationRecordsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected EmailCommunicationServiceDomainVerificationRecordsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmailCommunicationServiceDomainVerificationRecordsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dkim", typeJson: "{\"fqn\":\"azurerm.emailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsDkimList\"}")]
        public virtual azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsDkimList Dkim
        {
            get => GetInstanceProperty<azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsDkimList>()!;
        }

        [JsiiProperty(name: "dkim2", typeJson: "{\"fqn\":\"azurerm.emailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsDkim2List\"}")]
        public virtual azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsDkim2List Dkim2
        {
            get => GetInstanceProperty<azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsDkim2List>()!;
        }

        [JsiiProperty(name: "dmarc", typeJson: "{\"fqn\":\"azurerm.emailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsDmarcList\"}")]
        public virtual azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsDmarcList Dmarc
        {
            get => GetInstanceProperty<azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsDmarcList>()!;
        }

        [JsiiProperty(name: "domain", typeJson: "{\"fqn\":\"azurerm.emailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsDomainList\"}")]
        public virtual azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsDomainList Domain
        {
            get => GetInstanceProperty<azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsDomainList>()!;
        }

        [JsiiProperty(name: "spf", typeJson: "{\"fqn\":\"azurerm.emailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsSpfList\"}")]
        public virtual azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsSpfList Spf
        {
            get => GetInstanceProperty<azurerm.EmailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecordsSpfList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.emailCommunicationServiceDomain.EmailCommunicationServiceDomainVerificationRecords\"}", isOptional: true)]
        public virtual azurerm.EmailCommunicationServiceDomain.IEmailCommunicationServiceDomainVerificationRecords? InternalValue
        {
            get => GetInstanceProperty<azurerm.EmailCommunicationServiceDomain.IEmailCommunicationServiceDomainVerificationRecords?>();
            set => SetInstanceProperty(value);
        }
    }
}
