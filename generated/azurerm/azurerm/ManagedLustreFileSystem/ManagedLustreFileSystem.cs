using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedLustreFileSystem
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system azurerm_managed_lustre_file_system}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ManagedLustreFileSystem.ManagedLustreFileSystem), fullyQualifiedName: "azurerm.managedLustreFileSystem.ManagedLustreFileSystem", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemConfig\"}}]")]
    public class ManagedLustreFileSystem : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system azurerm_managed_lustre_file_system} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ManagedLustreFileSystem(Constructs.Construct scope, string id, azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedLustreFileSystem(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedLustreFileSystem(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ManagedLustreFileSystem resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ManagedLustreFileSystem to import.</param>
        /// <param name="importFromId">The id of the existing ManagedLustreFileSystem that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ManagedLustreFileSystem to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ManagedLustreFileSystem to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ManagedLustreFileSystem that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ManagedLustreFileSystem to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ManagedLustreFileSystem.ManagedLustreFileSystem), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putEncryptionKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemEncryptionKey\"}}]")]
        public virtual void PutEncryptionKey(azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemEncryptionKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemEncryptionKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHsmSetting", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemHsmSetting\"}}]")]
        public virtual void PutHsmSetting(azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemHsmSetting @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemHsmSetting)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaintenanceWindow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemMaintenanceWindow\"}}]")]
        public virtual void PutMaintenanceWindow(azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemMaintenanceWindow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemMaintenanceWindow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEncryptionKey")]
        public virtual void ResetEncryptionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHsmSetting")]
        public virtual void ResetHsmSetting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(azurerm.ManagedLustreFileSystem.ManagedLustreFileSystem))!;

        [JsiiProperty(name: "encryptionKey", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemEncryptionKeyOutputReference\"}")]
        public virtual azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemEncryptionKeyOutputReference EncryptionKey
        {
            get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemEncryptionKeyOutputReference>()!;
        }

        [JsiiProperty(name: "hsmSetting", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemHsmSettingOutputReference\"}")]
        public virtual azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemHsmSettingOutputReference HsmSetting
        {
            get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemHsmSettingOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemIdentityOutputReference\"}")]
        public virtual azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemMaintenanceWindowOutputReference\"}")]
        public virtual azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemMaintenanceWindowOutputReference MaintenanceWindow
        {
            get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemMaintenanceWindowOutputReference>()!;
        }

        [JsiiProperty(name: "mgsAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MgsAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemTimeoutsOutputReference\"}")]
        public virtual azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionKeyInput", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemEncryptionKey\"}", isOptional: true)]
        public virtual azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemEncryptionKey? EncryptionKeyInput
        {
            get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemEncryptionKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hsmSettingInput", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemHsmSetting\"}", isOptional: true)]
        public virtual azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemHsmSetting? HsmSettingInput
        {
            get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemHsmSetting?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemIdentity\"}", isOptional: true)]
        public virtual azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowInput", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemMaintenanceWindow\"}", isOptional: true)]
        public virtual azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemMaintenanceWindow? MaintenanceWindowInput
        {
            get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemMaintenanceWindow?>();
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
        [JsiiProperty(name: "skuNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageCapacityInTbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StorageCapacityInTbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zonesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ZonesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
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

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageCapacityInTb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageCapacityInTb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Zones
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
