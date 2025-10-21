using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKeyVaultCertificate
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificateCertificatePolicyLifetimeActionOutputReference), fullyQualifiedName: "azurerm.dataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificateCertificatePolicyLifetimeActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermKeyVaultCertificateCertificatePolicyLifetimeActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermKeyVaultCertificateCertificatePolicyLifetimeActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermKeyVaultCertificateCertificatePolicyLifetimeActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermKeyVaultCertificateCertificatePolicyLifetimeActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.dataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificateCertificatePolicyLifetimeActionActionList\"}")]
        public virtual azurerm.DataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificateCertificatePolicyLifetimeActionActionList Action
        {
            get => GetInstanceProperty<azurerm.DataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificateCertificatePolicyLifetimeActionActionList>()!;
        }

        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.dataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificateCertificatePolicyLifetimeActionTriggerList\"}")]
        public virtual azurerm.DataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificateCertificatePolicyLifetimeActionTriggerList Trigger
        {
            get => GetInstanceProperty<azurerm.DataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificateCertificatePolicyLifetimeActionTriggerList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificateCertificatePolicyLifetimeAction\"}", isOptional: true)]
        public virtual azurerm.DataAzurermKeyVaultCertificate.IDataAzurermKeyVaultCertificateCertificatePolicyLifetimeAction? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermKeyVaultCertificate.IDataAzurermKeyVaultCertificateCertificatePolicyLifetimeAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
