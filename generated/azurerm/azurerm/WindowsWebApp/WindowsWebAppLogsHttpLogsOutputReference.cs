using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.WindowsWebApp.WindowsWebAppLogsHttpLogsOutputReference), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppLogsHttpLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WindowsWebAppLogsHttpLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WindowsWebAppLogsHttpLogsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WindowsWebAppLogsHttpLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsWebAppLogsHttpLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAzureBlobStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogsAzureBlobStorage\"}}]")]
        public virtual void PutAzureBlobStorage(azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsAzureBlobStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsAzureBlobStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFileSystem", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogsFileSystem\"}}]")]
        public virtual void PutFileSystem(azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsFileSystem @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsFileSystem)}, new object[]{@value});
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

        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogsAzureBlobStorageOutputReference\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppLogsHttpLogsAzureBlobStorageOutputReference AzureBlobStorage
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppLogsHttpLogsAzureBlobStorageOutputReference>()!;
        }

        [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogsFileSystemOutputReference\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppLogsHttpLogsFileSystemOutputReference FileSystem
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppLogsHttpLogsFileSystemOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorageInput", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsAzureBlobStorage? AzureBlobStorageInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsAzureBlobStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemInput", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogsFileSystem\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsFileSystem? FileSystemInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogsFileSystem?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogs\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogs? InternalValue
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
