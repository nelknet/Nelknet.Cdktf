using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module_role_definition azurerm_key_vault_managed_hardware_security_module_role_definition}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition), fullyQualifiedName: "azurerm.dataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionConfig\"}}]")]
    public class DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module_role_definition azurerm_key_vault_managed_hardware_security_module_role_definition} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition(Constructs.Construct scope, string id, azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.IDataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.IDataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module_role_definition#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.IDataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.IDataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition))!;

        [JsiiProperty(name: "assignableScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AssignableScopes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "permission", typeJson: "{\"fqn\":\"azurerm.dataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionPermissionList\"}")]
        public virtual azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionPermissionList Permission
        {
            get => GetInstanceProperty<azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionPermissionList>()!;
        }

        [JsiiProperty(name: "resourceManagerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceManagerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedHsmIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedHsmIdInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedHsmId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedHsmId
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
    }
}
