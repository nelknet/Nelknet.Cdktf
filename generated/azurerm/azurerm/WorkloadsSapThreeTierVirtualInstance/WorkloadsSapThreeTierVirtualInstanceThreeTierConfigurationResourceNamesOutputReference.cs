using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WorkloadsSapThreeTierVirtualInstance
{
    [JsiiClass(nativeType: typeof(azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesOutputReference), fullyQualifiedName: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApplicationServer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServer\"}}]")]
        public virtual void PutApplicationServer(azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCentralServer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesCentralServer\"}}]")]
        public virtual void PutCentralServer(azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesCentralServer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesCentralServer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatabaseServer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServer\"}}]")]
        public virtual void PutDatabaseServer(azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSharedStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesSharedStorage\"}}]")]
        public virtual void PutSharedStorage(azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesSharedStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesSharedStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplicationServer")]
        public virtual void ResetApplicationServer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCentralServer")]
        public virtual void ResetCentralServer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseServer")]
        public virtual void ResetDatabaseServer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSharedStorage")]
        public virtual void ResetSharedStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "applicationServer", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerOutputReference\"}")]
        public virtual azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerOutputReference ApplicationServer
        {
            get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerOutputReference>()!;
        }

        [JsiiProperty(name: "centralServer", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesCentralServerOutputReference\"}")]
        public virtual azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesCentralServerOutputReference CentralServer
        {
            get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesCentralServerOutputReference>()!;
        }

        [JsiiProperty(name: "databaseServer", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServerOutputReference\"}")]
        public virtual azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServerOutputReference DatabaseServer
        {
            get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServerOutputReference>()!;
        }

        [JsiiProperty(name: "sharedStorage", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesSharedStorageOutputReference\"}")]
        public virtual azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesSharedStorageOutputReference SharedStorage
        {
            get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesSharedStorageOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationServerInput", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServer\"}", isOptional: true)]
        public virtual azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServer? ApplicationServerInput
        {
            get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "centralServerInput", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesCentralServer\"}", isOptional: true)]
        public virtual azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesCentralServer? CentralServerInput
        {
            get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesCentralServer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseServerInput", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServer\"}", isOptional: true)]
        public virtual azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServer? DatabaseServerInput
        {
            get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sharedStorageInput", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesSharedStorage\"}", isOptional: true)]
        public virtual azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesSharedStorage? SharedStorageInput
        {
            get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesSharedStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNames\"}", isOptional: true)]
        public virtual azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNames? InternalValue
        {
            get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNames?>();
            set => SetInstanceProperty(value);
        }
    }
}
