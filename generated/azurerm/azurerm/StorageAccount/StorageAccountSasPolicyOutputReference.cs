using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiClass(nativeType: typeof(azurerm.StorageAccount.StorageAccountSasPolicyOutputReference), fullyQualifiedName: "azurerm.storageAccount.StorageAccountSasPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StorageAccountSasPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StorageAccountSasPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StorageAccountSasPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccountSasPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetExpirationAction")]
        public virtual void ResetExpirationAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "expirationActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExpirationActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expirationPeriodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExpirationPeriodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "expirationAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpirationAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expirationPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpirationPeriod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSasPolicy\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountSasPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountSasPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
