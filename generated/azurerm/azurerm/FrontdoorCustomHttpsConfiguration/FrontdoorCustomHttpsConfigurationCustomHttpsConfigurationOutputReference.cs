using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FrontdoorCustomHttpsConfiguration
{
    [JsiiClass(nativeType: typeof(azurerm.FrontdoorCustomHttpsConfiguration.FrontdoorCustomHttpsConfigurationCustomHttpsConfigurationOutputReference), fullyQualifiedName: "azurerm.frontdoorCustomHttpsConfiguration.FrontdoorCustomHttpsConfigurationCustomHttpsConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FrontdoorCustomHttpsConfigurationCustomHttpsConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FrontdoorCustomHttpsConfigurationCustomHttpsConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FrontdoorCustomHttpsConfigurationCustomHttpsConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FrontdoorCustomHttpsConfigurationCustomHttpsConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAzureKeyVaultCertificateSecretName")]
        public virtual void ResetAzureKeyVaultCertificateSecretName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureKeyVaultCertificateSecretVersion")]
        public virtual void ResetAzureKeyVaultCertificateSecretVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureKeyVaultCertificateVaultId")]
        public virtual void ResetAzureKeyVaultCertificateVaultId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateSource")]
        public virtual void ResetCertificateSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "minimumTlsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinimumTlsVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisioningState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisioningSubstate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningSubstate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureKeyVaultCertificateSecretNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AzureKeyVaultCertificateSecretNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureKeyVaultCertificateSecretVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AzureKeyVaultCertificateSecretVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureKeyVaultCertificateVaultIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AzureKeyVaultCertificateVaultIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "azureKeyVaultCertificateSecretName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzureKeyVaultCertificateSecretName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "azureKeyVaultCertificateSecretVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzureKeyVaultCertificateSecretVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "azureKeyVaultCertificateVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzureKeyVaultCertificateVaultId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.frontdoorCustomHttpsConfiguration.FrontdoorCustomHttpsConfigurationCustomHttpsConfiguration\"}", isOptional: true)]
        public virtual azurerm.FrontdoorCustomHttpsConfiguration.IFrontdoorCustomHttpsConfigurationCustomHttpsConfiguration? InternalValue
        {
            get => GetInstanceProperty<azurerm.FrontdoorCustomHttpsConfiguration.IFrontdoorCustomHttpsConfigurationCustomHttpsConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
