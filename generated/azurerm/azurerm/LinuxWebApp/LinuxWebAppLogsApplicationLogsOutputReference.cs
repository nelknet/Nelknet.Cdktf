using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.LinuxWebApp.LinuxWebAppLogsApplicationLogsOutputReference), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxWebAppLogsApplicationLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxWebAppLogsApplicationLogsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LinuxWebAppLogsApplicationLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxWebAppLogsApplicationLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAzureBlobStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogsAzureBlobStorage\"}}]")]
        public virtual void PutAzureBlobStorage(azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogsAzureBlobStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogsAzureBlobStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAzureBlobStorage")]
        public virtual void ResetAzureBlobStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogsAzureBlobStorageOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppLogsApplicationLogsAzureBlobStorageOutputReference AzureBlobStorage
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppLogsApplicationLogsAzureBlobStorageOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorageInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogsAzureBlobStorage? AzureBlobStorageInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogsAzureBlobStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileSystemLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogs\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogs? InternalValue
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
