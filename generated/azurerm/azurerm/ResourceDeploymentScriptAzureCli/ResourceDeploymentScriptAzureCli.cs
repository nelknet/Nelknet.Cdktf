using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceDeploymentScriptAzureCli
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli azurerm_resource_deployment_script_azure_cli}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCli), fullyQualifiedName: "azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCli", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliConfig\"}}]")]
    public class ResourceDeploymentScriptAzureCli : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli azurerm_resource_deployment_script_azure_cli} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ResourceDeploymentScriptAzureCli(Constructs.Construct scope, string id, azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ResourceDeploymentScriptAzureCli(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ResourceDeploymentScriptAzureCli(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ResourceDeploymentScriptAzureCli resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ResourceDeploymentScriptAzureCli to import.</param>
        /// <param name="importFromId">The id of the existing ResourceDeploymentScriptAzureCli that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ResourceDeploymentScriptAzureCli to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ResourceDeploymentScriptAzureCli to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ResourceDeploymentScriptAzureCli that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ResourceDeploymentScriptAzureCli to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCli), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putContainer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliContainer\"}}]")]
        public virtual void PutContainer(azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliContainer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliContainer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnvironmentVariable", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliEnvironmentVariable\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEnvironmentVariable(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliEnvironmentVariable[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliEnvironmentVariable).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliEnvironmentVariable).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliStorageAccount\"}}]")]
        public virtual void PutStorageAccount(azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliStorageAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliStorageAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCleanupPreference")]
        public virtual void ResetCleanupPreference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCommandLine")]
        public virtual void ResetCommandLine()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainer")]
        public virtual void ResetContainer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironmentVariable")]
        public virtual void ResetEnvironmentVariable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceUpdateTag")]
        public virtual void ResetForceUpdateTag()
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

        [JsiiMethod(name: "resetPrimaryScriptUri")]
        public virtual void ResetPrimaryScriptUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScriptContent")]
        public virtual void ResetScriptContent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageAccount")]
        public virtual void ResetStorageAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSupportingScriptUris")]
        public virtual void ResetSupportingScriptUris()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeout")]
        public virtual void ResetTimeout()
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
        = GetStaticProperty<string>(typeof(azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCli))!;

        [JsiiProperty(name: "container", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliContainerOutputReference\"}")]
        public virtual azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliContainerOutputReference Container
        {
            get => GetInstanceProperty<azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliContainerOutputReference>()!;
        }

        [JsiiProperty(name: "environmentVariable", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliEnvironmentVariableList\"}")]
        public virtual azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliEnvironmentVariableList EnvironmentVariable
        {
            get => GetInstanceProperty<azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliEnvironmentVariableList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliIdentityOutputReference\"}")]
        public virtual azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "outputs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Outputs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageAccount", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliStorageAccountOutputReference\"}")]
        public virtual azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliStorageAccountOutputReference StorageAccount
        {
            get => GetInstanceProperty<azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliStorageAccountOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliTimeoutsOutputReference\"}")]
        public virtual azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cleanupPreferenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CleanupPreferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commandLineInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommandLineInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerInput", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliContainer\"}", isOptional: true)]
        public virtual azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliContainer? ContainerInput
        {
            get => GetInstanceProperty<azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliContainer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentVariableInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliEnvironmentVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EnvironmentVariableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceUpdateTagInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ForceUpdateTagInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliIdentity\"}", isOptional: true)]
        public virtual azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliIdentity?>();
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryScriptUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimaryScriptUriInput
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
        [JsiiProperty(name: "retentionIntervalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RetentionIntervalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scriptContentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScriptContentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountInput", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliStorageAccount\"}", isOptional: true)]
        public virtual azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliStorageAccount? StorageAccountInput
        {
            get => GetInstanceProperty<azurerm.ResourceDeploymentScriptAzureCli.IResourceDeploymentScriptAzureCliStorageAccount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "supportingScriptUrisInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SupportingScriptUrisInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeoutInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.resourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cleanupPreference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CleanupPreference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "commandLine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommandLine
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceUpdateTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ForceUpdateTag
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

        [JsiiProperty(name: "primaryScriptUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryScriptUri
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

        [JsiiProperty(name: "retentionInterval", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetentionInterval
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scriptContent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScriptContent
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "supportingScriptUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportingScriptUris
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timeout
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
