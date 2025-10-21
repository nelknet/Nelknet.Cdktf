using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningWorkspace
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace azurerm_machine_learning_workspace}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MachineLearningWorkspace.MachineLearningWorkspace), fullyQualifiedName: "azurerm.machineLearningWorkspace.MachineLearningWorkspace", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceConfig\"}}]")]
    public class MachineLearningWorkspace : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace azurerm_machine_learning_workspace} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MachineLearningWorkspace(Constructs.Construct scope, string id, azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MachineLearningWorkspace(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MachineLearningWorkspace(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a MachineLearningWorkspace resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MachineLearningWorkspace to import.</param>
        /// <param name="importFromId">The id of the existing MachineLearningWorkspace that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MachineLearningWorkspace to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MachineLearningWorkspace to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MachineLearningWorkspace that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MachineLearningWorkspace to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.MachineLearningWorkspace.MachineLearningWorkspace), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceEncryption\"}}]")]
        public virtual void PutEncryption(azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFeatureStore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceFeatureStore\"}}]")]
        public virtual void PutFeatureStore(azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceFeatureStore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceFeatureStore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManagedNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceManagedNetwork\"}}]")]
        public virtual void PutManagedNetwork(azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceManagedNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceManagedNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServerlessCompute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceServerlessCompute\"}}]")]
        public virtual void PutServerlessCompute(azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceServerlessCompute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceServerlessCompute)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContainerRegistryId")]
        public virtual void ResetContainerRegistryId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryption")]
        public virtual void ResetEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeatureStore")]
        public virtual void ResetFeatureStore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFriendlyName")]
        public virtual void ResetFriendlyName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHighBusinessImpact")]
        public virtual void ResetHighBusinessImpact()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageBuildComputeName")]
        public virtual void ResetImageBuildComputeName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKind")]
        public virtual void ResetKind()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedNetwork")]
        public virtual void ResetManagedNetwork()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryUserAssignedIdentity")]
        public virtual void ResetPrimaryUserAssignedIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicNetworkAccessEnabled")]
        public virtual void ResetPublicNetworkAccessEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerlessCompute")]
        public virtual void ResetServerlessCompute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkuName")]
        public virtual void ResetSkuName()
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

        [JsiiMethod(name: "resetV1LegacyModeEnabled")]
        public virtual void ResetV1LegacyModeEnabled()
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
        = GetStaticProperty<string>(typeof(azurerm.MachineLearningWorkspace.MachineLearningWorkspace))!;

        [JsiiProperty(name: "discoveryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiscoveryUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceEncryptionOutputReference\"}")]
        public virtual azurerm.MachineLearningWorkspace.MachineLearningWorkspaceEncryptionOutputReference Encryption
        {
            get => GetInstanceProperty<azurerm.MachineLearningWorkspace.MachineLearningWorkspaceEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "featureStore", typeJson: "{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceFeatureStoreOutputReference\"}")]
        public virtual azurerm.MachineLearningWorkspace.MachineLearningWorkspaceFeatureStoreOutputReference FeatureStore
        {
            get => GetInstanceProperty<azurerm.MachineLearningWorkspace.MachineLearningWorkspaceFeatureStoreOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceIdentityOutputReference\"}")]
        public virtual azurerm.MachineLearningWorkspace.MachineLearningWorkspaceIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.MachineLearningWorkspace.MachineLearningWorkspaceIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "managedNetwork", typeJson: "{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceManagedNetworkOutputReference\"}")]
        public virtual azurerm.MachineLearningWorkspace.MachineLearningWorkspaceManagedNetworkOutputReference ManagedNetwork
        {
            get => GetInstanceProperty<azurerm.MachineLearningWorkspace.MachineLearningWorkspaceManagedNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "serverlessCompute", typeJson: "{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceServerlessComputeOutputReference\"}")]
        public virtual azurerm.MachineLearningWorkspace.MachineLearningWorkspaceServerlessComputeOutputReference ServerlessCompute
        {
            get => GetInstanceProperty<azurerm.MachineLearningWorkspace.MachineLearningWorkspaceServerlessComputeOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceTimeoutsOutputReference\"}")]
        public virtual azurerm.MachineLearningWorkspace.MachineLearningWorkspaceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MachineLearningWorkspace.MachineLearningWorkspaceTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationInsightsIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationInsightsIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerRegistryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerRegistryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionInput", typeJson: "{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceEncryption\"}", isOptional: true)]
        public virtual azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceEncryption? EncryptionInput
        {
            get => GetInstanceProperty<azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featureStoreInput", typeJson: "{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceFeatureStore\"}", isOptional: true)]
        public virtual azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceFeatureStore? FeatureStoreInput
        {
            get => GetInstanceProperty<azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceFeatureStore?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "friendlyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FriendlyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "highBusinessImpactInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? HighBusinessImpactInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceIdentity\"}", isOptional: true)]
        public virtual azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageBuildComputeNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageBuildComputeNameInput
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
        [JsiiProperty(name: "kindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KindInput
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
        [JsiiProperty(name: "managedNetworkInput", typeJson: "{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceManagedNetwork\"}", isOptional: true)]
        public virtual azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceManagedNetwork? ManagedNetworkInput
        {
            get => GetInstanceProperty<azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceManagedNetwork?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryUserAssignedIdentityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimaryUserAssignedIdentityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicNetworkAccessEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PublicNetworkAccessEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverlessComputeInput", typeJson: "{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceServerlessCompute\"}", isOptional: true)]
        public virtual azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceServerlessCompute? ServerlessComputeInput
        {
            get => GetInstanceProperty<azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceServerlessCompute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageAccountIdInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.machineLearningWorkspace.MachineLearningWorkspaceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "v1LegacyModeEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? V1LegacyModeEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "applicationInsightsId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationInsightsId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "containerRegistryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerRegistryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "friendlyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FriendlyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "highBusinessImpact", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object HighBusinessImpact
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageBuildComputeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageBuildComputeName
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

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
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

        [JsiiProperty(name: "primaryUserAssignedIdentity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryUserAssignedIdentity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PublicNetworkAccessEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
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

        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountId
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

        [JsiiProperty(name: "v1LegacyModeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object V1LegacyModeEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
