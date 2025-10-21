using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.LinuxWebApp.LinuxWebAppLogsHttpLogsOutputReference), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppLogsHttpLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxWebAppLogsHttpLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxWebAppLogsHttpLogsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LinuxWebAppLogsHttpLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxWebAppLogsHttpLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAzureBlobStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsHttpLogsAzureBlobStorage\"}}]")]
        public virtual void PutAzureBlobStorage(azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogsAzureBlobStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogsAzureBlobStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFileSystem", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsHttpLogsFileSystem\"}}]")]
        public virtual void PutFileSystem(azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogsFileSystem @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogsFileSystem)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAzureBlobStorage")]
        public virtual void ResetAzureBlobStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileSystem")]
        public virtual void ResetFileSystem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsHttpLogsAzureBlobStorageOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppLogsHttpLogsAzureBlobStorageOutputReference AzureBlobStorage
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppLogsHttpLogsAzureBlobStorageOutputReference>()!;
        }

        [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsHttpLogsFileSystemOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppLogsHttpLogsFileSystemOutputReference FileSystem
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppLogsHttpLogsFileSystemOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorageInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogsAzureBlobStorage? AzureBlobStorageInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogsAzureBlobStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsHttpLogsFileSystem\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogsFileSystem? FileSystemInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogsFileSystem?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsHttpLogs\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogs? InternalValue
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
