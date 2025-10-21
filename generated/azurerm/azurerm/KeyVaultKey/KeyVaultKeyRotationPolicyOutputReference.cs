using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultKey
{
    [JsiiClass(nativeType: typeof(azurerm.KeyVaultKey.KeyVaultKeyRotationPolicyOutputReference), fullyQualifiedName: "azurerm.keyVaultKey.KeyVaultKeyRotationPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KeyVaultKeyRotationPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KeyVaultKeyRotationPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KeyVaultKeyRotationPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KeyVaultKeyRotationPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutomatic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.keyVaultKey.KeyVaultKeyRotationPolicyAutomatic\"}}]")]
        public virtual void PutAutomatic(azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicyAutomatic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicyAutomatic)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutomatic")]
        public virtual void ResetAutomatic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpireAfter")]
        public virtual void ResetExpireAfter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotifyBeforeExpiry")]
        public virtual void ResetNotifyBeforeExpiry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "automatic", typeJson: "{\"fqn\":\"azurerm.keyVaultKey.KeyVaultKeyRotationPolicyAutomaticOutputReference\"}")]
        public virtual azurerm.KeyVaultKey.KeyVaultKeyRotationPolicyAutomaticOutputReference Automatic
        {
            get => GetInstanceProperty<azurerm.KeyVaultKey.KeyVaultKeyRotationPolicyAutomaticOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticInput", typeJson: "{\"fqn\":\"azurerm.keyVaultKey.KeyVaultKeyRotationPolicyAutomatic\"}", isOptional: true)]
        public virtual azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicyAutomatic? AutomaticInput
        {
            get => GetInstanceProperty<azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicyAutomatic?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expireAfterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExpireAfterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notifyBeforeExpiryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NotifyBeforeExpiryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "expireAfter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpireAfter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "notifyBeforeExpiry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotifyBeforeExpiry
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.keyVaultKey.KeyVaultKeyRotationPolicy\"}", isOptional: true)]
        public virtual azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
