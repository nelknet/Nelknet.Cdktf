using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    [JsiiClass(nativeType: typeof(azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionTriggerOutputReference), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionTriggerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KeyVaultCertificateCertificatePolicyLifetimeActionTriggerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KeyVaultCertificateCertificatePolicyLifetimeActionTriggerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KeyVaultCertificateCertificatePolicyLifetimeActionTriggerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KeyVaultCertificateCertificatePolicyLifetimeActionTriggerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDaysBeforeExpiry")]
        public virtual void ResetDaysBeforeExpiry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLifetimePercentage")]
        public virtual void ResetLifetimePercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "daysBeforeExpiryInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DaysBeforeExpiryInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifetimePercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LifetimePercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "daysBeforeExpiry", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DaysBeforeExpiry
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lifetimePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LifetimePercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionTrigger\"}", isOptional: true)]
        public virtual azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionTrigger? InternalValue
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionTrigger?>();
            set => SetInstanceProperty(value);
        }
    }
}
