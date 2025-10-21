using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiClass(nativeType: typeof(azurerm.StorageAccount.StorageAccountAzureFilesAuthenticationOutputReference), fullyQualifiedName: "azurerm.storageAccount.StorageAccountAzureFilesAuthenticationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StorageAccountAzureFilesAuthenticationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StorageAccountAzureFilesAuthenticationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StorageAccountAzureFilesAuthenticationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccountAzureFilesAuthenticationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActiveDirectory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountAzureFilesAuthenticationActiveDirectory\"}}]")]
        public virtual void PutActiveDirectory(azurerm.StorageAccount.IStorageAccountAzureFilesAuthenticationActiveDirectory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountAzureFilesAuthenticationActiveDirectory)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActiveDirectory")]
        public virtual void ResetActiveDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultShareLevelPermission")]
        public virtual void ResetDefaultShareLevelPermission()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountAzureFilesAuthenticationActiveDirectoryOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountAzureFilesAuthenticationActiveDirectoryOutputReference ActiveDirectory
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountAzureFilesAuthenticationActiveDirectoryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountAzureFilesAuthenticationActiveDirectory\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountAzureFilesAuthenticationActiveDirectory? ActiveDirectoryInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountAzureFilesAuthenticationActiveDirectory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultShareLevelPermissionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultShareLevelPermissionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "directoryTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DirectoryTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "defaultShareLevelPermission", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultShareLevelPermission
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "directoryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountAzureFilesAuthentication\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountAzureFilesAuthentication? InternalValue
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountAzureFilesAuthentication?>();
            set => SetInstanceProperty(value);
        }
    }
}
