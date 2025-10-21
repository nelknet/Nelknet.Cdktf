using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSlot
{
    [JsiiClass(nativeType: typeof(azurerm.AppServiceSlot.AppServiceSlotLogsHttpLogsOutputReference), fullyQualifiedName: "azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppServiceSlotLogsHttpLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppServiceSlotLogsHttpLogsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppServiceSlotLogsHttpLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppServiceSlotLogsHttpLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAzureBlobStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsAzureBlobStorage\"}}]")]
        public virtual void PutAzureBlobStorage(azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsAzureBlobStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsAzureBlobStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFileSystem", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsFileSystem\"}}]")]
        public virtual void PutFileSystem(azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsFileSystem @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsFileSystem)}, new object[]{@value});
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

        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsAzureBlobStorageOutputReference\"}")]
        public virtual azurerm.AppServiceSlot.AppServiceSlotLogsHttpLogsAzureBlobStorageOutputReference AzureBlobStorage
        {
            get => GetInstanceProperty<azurerm.AppServiceSlot.AppServiceSlotLogsHttpLogsAzureBlobStorageOutputReference>()!;
        }

        [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsFileSystemOutputReference\"}")]
        public virtual azurerm.AppServiceSlot.AppServiceSlotLogsHttpLogsFileSystemOutputReference FileSystem
        {
            get => GetInstanceProperty<azurerm.AppServiceSlot.AppServiceSlotLogsHttpLogsFileSystemOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorageInput", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        public virtual azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsAzureBlobStorage? AzureBlobStorageInput
        {
            get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsAzureBlobStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemInput", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsFileSystem\"}", isOptional: true)]
        public virtual azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsFileSystem? FileSystemInput
        {
            get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsFileSystem?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogs\"}", isOptional: true)]
        public virtual azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogs? InternalValue
        {
            get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
