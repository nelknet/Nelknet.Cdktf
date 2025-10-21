using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningComputeInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance azurerm_machine_learning_compute_instance}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MachineLearningComputeInstance.MachineLearningComputeInstance), fullyQualifiedName: "azurerm.machineLearningComputeInstance.MachineLearningComputeInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceConfig\"}}]")]
    public class MachineLearningComputeInstance : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance azurerm_machine_learning_compute_instance} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MachineLearningComputeInstance(Constructs.Construct scope, string id, azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MachineLearningComputeInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MachineLearningComputeInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a MachineLearningComputeInstance resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MachineLearningComputeInstance to import.</param>
        /// <param name="importFromId">The id of the existing MachineLearningComputeInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MachineLearningComputeInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MachineLearningComputeInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MachineLearningComputeInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MachineLearningComputeInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.MachineLearningComputeInstance.MachineLearningComputeInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAssignToUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceAssignToUser\"}}]")]
        public virtual void PutAssignToUser(azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceAssignToUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceAssignToUser)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSsh", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceSsh\"}}]")]
        public virtual void PutSsh(azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceSsh @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceSsh)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAssignToUser")]
        public virtual void ResetAssignToUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorizationType")]
        public virtual void ResetAuthorizationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
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

        [JsiiMethod(name: "resetLocalAuthEnabled")]
        public virtual void ResetLocalAuthEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodePublicIpEnabled")]
        public virtual void ResetNodePublicIpEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSsh")]
        public virtual void ResetSsh()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetResourceId")]
        public virtual void ResetSubnetResourceId()
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
        = GetStaticProperty<string>(typeof(azurerm.MachineLearningComputeInstance.MachineLearningComputeInstance))!;

        [JsiiProperty(name: "assignToUser", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceAssignToUserOutputReference\"}")]
        public virtual azurerm.MachineLearningComputeInstance.MachineLearningComputeInstanceAssignToUserOutputReference AssignToUser
        {
            get => GetInstanceProperty<azurerm.MachineLearningComputeInstance.MachineLearningComputeInstanceAssignToUserOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceIdentityOutputReference\"}")]
        public virtual azurerm.MachineLearningComputeInstance.MachineLearningComputeInstanceIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.MachineLearningComputeInstance.MachineLearningComputeInstanceIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "ssh", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceSshOutputReference\"}")]
        public virtual azurerm.MachineLearningComputeInstance.MachineLearningComputeInstanceSshOutputReference Ssh
        {
            get => GetInstanceProperty<azurerm.MachineLearningComputeInstance.MachineLearningComputeInstanceSshOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceTimeoutsOutputReference\"}")]
        public virtual azurerm.MachineLearningComputeInstance.MachineLearningComputeInstanceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MachineLearningComputeInstance.MachineLearningComputeInstanceTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "assignToUserInput", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceAssignToUser\"}", isOptional: true)]
        public virtual azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceAssignToUser? AssignToUserInput
        {
            get => GetInstanceProperty<azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceAssignToUser?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizationTypeInput
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
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceIdentity\"}", isOptional: true)]
        public virtual azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localAuthEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? LocalAuthEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "machineLearningWorkspaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MachineLearningWorkspaceIdInput
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
        [JsiiProperty(name: "nodePublicIpEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? NodePublicIpEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshInput", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceSsh\"}", isOptional: true)]
        public virtual azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceSsh? SshInput
        {
            get => GetInstanceProperty<azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceSsh?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetResourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetResourceIdInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualMachineSizeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualMachineSizeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "authorizationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationType
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localAuthEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object LocalAuthEnabled
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

        [JsiiProperty(name: "machineLearningWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MachineLearningWorkspaceId
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

        [JsiiProperty(name: "nodePublicIpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object NodePublicIpEnabled
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

        [JsiiProperty(name: "subnetResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetResourceId
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

        [JsiiProperty(name: "virtualMachineSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualMachineSize
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
