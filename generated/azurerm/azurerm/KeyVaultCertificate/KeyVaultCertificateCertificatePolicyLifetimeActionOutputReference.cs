using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    [JsiiClass(nativeType: typeof(azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionOutputReference), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class KeyVaultCertificateCertificatePolicyLifetimeActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public KeyVaultCertificateCertificatePolicyLifetimeActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected KeyVaultCertificateCertificatePolicyLifetimeActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KeyVaultCertificateCertificatePolicyLifetimeActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionAction\"}}]")]
        public virtual void PutAction(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrigger", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionTrigger\"}}]")]
        public virtual void PutTrigger(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionTrigger @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionTrigger)}, new object[]{@value});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionActionOutputReference\"}")]
        public virtual azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionActionOutputReference Action
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionActionOutputReference>()!;
        }

        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionTriggerOutputReference\"}")]
        public virtual azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionTriggerOutputReference Trigger
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionTriggerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionAction\"}", isOptional: true)]
        public virtual azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionAction? ActionInput
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerInput", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionTrigger\"}", isOptional: true)]
        public virtual azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionTrigger? TriggerInput
        {
            get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionTrigger?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeAction\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeAction cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeAction).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
