using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBatchPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_pool azurerm_batch_pool}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermBatchPool.DataAzurermBatchPool), fullyQualifiedName: "azurerm.dataAzurermBatchPool.DataAzurermBatchPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolConfig\"}}]")]
    public class DataAzurermBatchPool : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_pool azurerm_batch_pool} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermBatchPool(Constructs.Construct scope, string id, azurerm.DataAzurermBatchPool.IDataAzurermBatchPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermBatchPool.IDataAzurermBatchPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermBatchPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermBatchPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermBatchPool resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermBatchPool to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermBatchPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermBatchPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermBatchPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermBatchPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermBatchPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermBatchPool.DataAzurermBatchPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermBatchPool.IDataAzurermBatchPoolTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermBatchPool.IDataAzurermBatchPoolTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermBatchPool.DataAzurermBatchPool))!;

        [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolAutoScaleList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolAutoScaleList AutoScale
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolAutoScaleList>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolCertificateList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolCertificateList Certificate
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolCertificateList>()!;
        }

        [JsiiProperty(name: "containerConfiguration", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolContainerConfigurationList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolContainerConfigurationList ContainerConfiguration
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolContainerConfigurationList>()!;
        }

        [JsiiProperty(name: "dataDisks", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolDataDisksList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolDataDisksList DataDisks
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolDataDisksList>()!;
        }

        [JsiiProperty(name: "diskEncryption", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolDiskEncryptionList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolDiskEncryptionList DiskEncryption
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolDiskEncryptionList>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "extensions", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolExtensionsList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolExtensionsList Extensions
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolExtensionsList>()!;
        }

        [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolFixedScaleList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolFixedScaleList FixedScale
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolFixedScaleList>()!;
        }

        [JsiiProperty(name: "interNodeCommunication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InterNodeCommunication
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxTasksPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTasksPerNode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Metadata
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "mount", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolMountList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolMountList Mount
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolMountList>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolNetworkConfigurationList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolNetworkConfigurationList NetworkConfiguration
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolNetworkConfigurationList>()!;
        }

        [JsiiProperty(name: "nodeAgentSkuId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeAgentSkuId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodePlacement", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolNodePlacementList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolNodePlacementList NodePlacement
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolNodePlacementList>()!;
        }

        [JsiiProperty(name: "osDiskPlacement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsDiskPlacement
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startTask", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolStartTaskList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolStartTaskList StartTask
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolStartTaskList>()!;
        }

        [JsiiProperty(name: "storageImageReference", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolStorageImageReferenceList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolStorageImageReferenceList StorageImageReference
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolStorageImageReferenceList>()!;
        }

        [JsiiProperty(name: "taskSchedulingPolicy", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolTaskSchedulingPolicyList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolTaskSchedulingPolicyList TaskSchedulingPolicy
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolTaskSchedulingPolicyList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "userAccounts", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolUserAccountsList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolUserAccountsList UserAccounts
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolUserAccountsList>()!;
        }

        [JsiiProperty(name: "vmSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "windows", typeJson: "{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolWindowsList\"}")]
        public virtual azurerm.DataAzurermBatchPool.DataAzurermBatchPoolWindowsList Windows
        {
            get => GetInstanceProperty<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolWindowsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermBatchPool.DataAzurermBatchPoolTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
