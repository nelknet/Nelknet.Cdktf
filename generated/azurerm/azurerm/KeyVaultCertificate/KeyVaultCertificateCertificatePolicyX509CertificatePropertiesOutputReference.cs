using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    [JsiiClass(nativeType: typeof(azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificatePropertiesOutputReference), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificatePropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KeyVaultCertificateCertificatePolicyX509CertificatePropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KeyVaultCertificateCertificatePolicyX509CertificatePropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KeyVaultCertificateCertificatePolicyX509CertificatePropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KeyVaultCertificateCertificatePolicyX509CertificatePropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSubjectAlternativeNames", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames\"}}]")]
        public virtual void PutSubjectAlternativeNames(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExtendedKeyUsage")]
        public virtual void ResetExtendedKeyUsage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubjectAlternativeNames")]
        public virtual void ResetSubjectAlternativeNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNamesOutputReference\"}")]
        public virtual azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNamesOutputReference SubjectAlternativeNames
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNamesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "extendedKeyUsageInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ExtendedKeyUsageInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyUsageInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? KeyUsageInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectAlternativeNamesInput", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames\"}", isOptional: true)]
        public virtual azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames? SubjectAlternativeNamesInput
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubjectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validityInMonthsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ValidityInMonthsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "extendedKeyUsage", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExtendedKeyUsage
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyUsage", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] KeyUsage
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subject
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "validityInMonths", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidityInMonths
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificateProperties\"}", isOptional: true)]
        public virtual azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificateProperties? InternalValue
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificateProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
