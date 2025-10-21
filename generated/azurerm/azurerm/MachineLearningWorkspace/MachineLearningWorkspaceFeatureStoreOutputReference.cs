using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningWorkspace
{
    [JsiiClass(nativeType: typeof(azurerm.MachineLearningWorkspace.MachineLearningWorkspaceFeatureStoreOutputReference), fullyQualifiedName: "azurerm.machineLearningWorkspace.MachineLearningWorkspaceFeatureStoreOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MachineLearningWorkspaceFeatureStoreOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MachineLearningWorkspaceFeatureStoreOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MachineLearningWorkspaceFeatureStoreOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MachineLearningWorkspaceFeatureStoreOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetComputerSparkRuntimeVersion")]
        public virtual void ResetComputerSparkRuntimeVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOfflineConnectionName")]
        public virtual void ResetOfflineConnectionName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnlineConnectionName")]
        public virtual void ResetOnlineConnectionName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "computerSparkRuntimeVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputerSparkRuntimeVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "offlineConnectionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OfflineConnectionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onlineConnectionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnlineConnectionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "computerSparkRuntimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputerSparkRuntimeVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "offlineConnectionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OfflineConnectionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onlineConnectionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnlineConnectionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceFeatureStore\"}", isOptional: true)]
        public virtual azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceFeatureStore? InternalValue
        {
            get => GetInstanceProperty<azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceFeatureStore?>();
            set => SetInstanceProperty(value);
        }
    }
}
