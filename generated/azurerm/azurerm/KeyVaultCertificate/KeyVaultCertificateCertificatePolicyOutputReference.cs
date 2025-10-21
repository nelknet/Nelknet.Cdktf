using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    [JsiiClass(nativeType: typeof(azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyOutputReference), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KeyVaultCertificateCertificatePolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KeyVaultCertificateCertificatePolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KeyVaultCertificateCertificatePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KeyVaultCertificateCertificatePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIssuerParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyIssuerParameters\"}}]")]
        public virtual void PutIssuerParameters(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyIssuerParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyIssuerParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKeyProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyKeyProperties\"}}]")]
        public virtual void PutKeyProperties(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyKeyProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyKeyProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLifetimeAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLifetimeAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecretProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicySecretProperties\"}}]")]
        public virtual void PutSecretProperties(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicySecretProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicySecretProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putX509CertificateProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificateProperties\"}}]")]
        public virtual void PutX509CertificateProperties(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificateProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificateProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLifetimeAction")]
        public virtual void ResetLifetimeAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetX509CertificateProperties")]
        public virtual void ResetX509CertificateProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "issuerParameters", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyIssuerParametersOutputReference\"}")]
        public virtual azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyIssuerParametersOutputReference IssuerParameters
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyIssuerParametersOutputReference>()!;
        }

        [JsiiProperty(name: "keyProperties", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyKeyPropertiesOutputReference\"}")]
        public virtual azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyKeyPropertiesOutputReference KeyProperties
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyKeyPropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "lifetimeAction", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionList\"}")]
        public virtual azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionList LifetimeAction
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionList>()!;
        }

        [JsiiProperty(name: "secretProperties", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicySecretPropertiesOutputReference\"}")]
        public virtual azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicySecretPropertiesOutputReference SecretProperties
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicySecretPropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "x509CertificateProperties", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificatePropertiesOutputReference\"}")]
        public virtual azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificatePropertiesOutputReference X509CertificateProperties
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificatePropertiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "issuerParametersInput", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyIssuerParameters\"}", isOptional: true)]
        public virtual azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyIssuerParameters? IssuerParametersInput
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyIssuerParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyPropertiesInput", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyKeyProperties\"}", isOptional: true)]
        public virtual azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyKeyProperties? KeyPropertiesInput
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyKeyProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifetimeActionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LifetimeActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretPropertiesInput", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicySecretProperties\"}", isOptional: true)]
        public virtual azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicySecretProperties? SecretPropertiesInput
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicySecretProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "x509CertificatePropertiesInput", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificateProperties\"}", isOptional: true)]
        public virtual azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificateProperties? X509CertificatePropertiesInput
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificateProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicy\"}", isOptional: true)]
        public virtual azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
