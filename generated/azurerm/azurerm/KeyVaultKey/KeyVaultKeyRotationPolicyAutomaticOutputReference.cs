using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultKey
{
    [JsiiClass(nativeType: typeof(azurerm.KeyVaultKey.KeyVaultKeyRotationPolicyAutomaticOutputReference), fullyQualifiedName: "azurerm.keyVaultKey.KeyVaultKeyRotationPolicyAutomaticOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KeyVaultKeyRotationPolicyAutomaticOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KeyVaultKeyRotationPolicyAutomaticOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KeyVaultKeyRotationPolicyAutomaticOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KeyVaultKeyRotationPolicyAutomaticOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTimeAfterCreation")]
        public virtual void ResetTimeAfterCreation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeBeforeExpiry")]
        public virtual void ResetTimeBeforeExpiry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeAfterCreationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeAfterCreationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeBeforeExpiryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeBeforeExpiryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "timeAfterCreation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAfterCreation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeBeforeExpiry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeBeforeExpiry
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.keyVaultKey.KeyVaultKeyRotationPolicyAutomatic\"}", isOptional: true)]
        public virtual azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicyAutomatic? InternalValue
        {
            get => GetInstanceProperty<azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicyAutomatic?>();
            set => SetInstanceProperty(value);
        }
    }
}
