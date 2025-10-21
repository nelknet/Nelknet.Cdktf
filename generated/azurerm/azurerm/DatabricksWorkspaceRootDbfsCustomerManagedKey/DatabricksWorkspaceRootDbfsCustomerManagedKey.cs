using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_root_dbfs_customer_managed_key azurerm_databricks_workspace_root_dbfs_customer_managed_key}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKey), fullyQualifiedName: "azurerm.databricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKey", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.databricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKeyConfig\"}}]")]
    public class DatabricksWorkspaceRootDbfsCustomerManagedKey : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_root_dbfs_customer_managed_key azurerm_databricks_workspace_root_dbfs_customer_managed_key} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabricksWorkspaceRootDbfsCustomerManagedKey(Constructs.Construct scope, string id, azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.IDatabricksWorkspaceRootDbfsCustomerManagedKeyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.IDatabricksWorkspaceRootDbfsCustomerManagedKeyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabricksWorkspaceRootDbfsCustomerManagedKey(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabricksWorkspaceRootDbfsCustomerManagedKey(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DatabricksWorkspaceRootDbfsCustomerManagedKey resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabricksWorkspaceRootDbfsCustomerManagedKey to import.</param>
        /// <param name="importFromId">The id of the existing DatabricksWorkspaceRootDbfsCustomerManagedKey that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabricksWorkspaceRootDbfsCustomerManagedKey to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabricksWorkspaceRootDbfsCustomerManagedKey to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_root_dbfs_customer_managed_key#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabricksWorkspaceRootDbfsCustomerManagedKey that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabricksWorkspaceRootDbfsCustomerManagedKey to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKey), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.databricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKeyTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.IDatabricksWorkspaceRootDbfsCustomerManagedKeyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.IDatabricksWorkspaceRootDbfsCustomerManagedKeyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyVaultId")]
        public virtual void ResetKeyVaultId()
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
        = GetStaticProperty<string>(typeof(azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKey))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.databricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKeyTimeoutsOutputReference\"}")]
        public virtual azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKeyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKeyTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyVaultIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyVaultKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.databricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKeyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkspaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyVaultId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyVaultKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
