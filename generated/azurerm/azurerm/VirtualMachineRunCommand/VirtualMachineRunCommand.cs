using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineRunCommand
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command azurerm_virtual_machine_run_command}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.VirtualMachineRunCommand.VirtualMachineRunCommand), fullyQualifiedName: "azurerm.virtualMachineRunCommand.VirtualMachineRunCommand", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandConfig\"}}]")]
    public class VirtualMachineRunCommand : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command azurerm_virtual_machine_run_command} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VirtualMachineRunCommand(Constructs.Construct scope, string id, azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualMachineRunCommand(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualMachineRunCommand(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a VirtualMachineRunCommand resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VirtualMachineRunCommand to import.</param>
        /// <param name="importFromId">The id of the existing VirtualMachineRunCommand that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VirtualMachineRunCommand to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VirtualMachineRunCommand to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VirtualMachineRunCommand that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VirtualMachineRunCommand to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.VirtualMachineRunCommand.VirtualMachineRunCommand), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putErrorBlobManagedIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandErrorBlobManagedIdentity\"}}]")]
        public virtual void PutErrorBlobManagedIdentity(azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandErrorBlobManagedIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandErrorBlobManagedIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutputBlobManagedIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandOutputBlobManagedIdentity\"}}]")]
        public virtual void PutOutputBlobManagedIdentity(azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandOutputBlobManagedIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandOutputBlobManagedIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putParameter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandParameter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutParameter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandParameter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandParameter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandParameter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProtectedParameter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandProtectedParameter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProtectedParameter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandProtectedParameter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandProtectedParameter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandProtectedParameter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSource\"}}]")]
        public virtual void PutSource(azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetErrorBlobManagedIdentity")]
        public virtual void ResetErrorBlobManagedIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetErrorBlobUri")]
        public virtual void ResetErrorBlobUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputBlobManagedIdentity")]
        public virtual void ResetOutputBlobManagedIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputBlobUri")]
        public virtual void ResetOutputBlobUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameter")]
        public virtual void ResetParameter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtectedParameter")]
        public virtual void ResetProtectedParameter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunAsPassword")]
        public virtual void ResetRunAsPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunAsUser")]
        public virtual void ResetRunAsUser()
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
        = GetStaticProperty<string>(typeof(azurerm.VirtualMachineRunCommand.VirtualMachineRunCommand))!;

        [JsiiProperty(name: "errorBlobManagedIdentity", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandErrorBlobManagedIdentityOutputReference\"}")]
        public virtual azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandErrorBlobManagedIdentityOutputReference ErrorBlobManagedIdentity
        {
            get => GetInstanceProperty<azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandErrorBlobManagedIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "instanceView", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandInstanceViewList\"}")]
        public virtual azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandInstanceViewList InstanceView
        {
            get => GetInstanceProperty<azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandInstanceViewList>()!;
        }

        [JsiiProperty(name: "outputBlobManagedIdentity", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandOutputBlobManagedIdentityOutputReference\"}")]
        public virtual azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandOutputBlobManagedIdentityOutputReference OutputBlobManagedIdentity
        {
            get => GetInstanceProperty<azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandOutputBlobManagedIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "parameter", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandParameterList\"}")]
        public virtual azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandParameterList Parameter
        {
            get => GetInstanceProperty<azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandParameterList>()!;
        }

        [JsiiProperty(name: "protectedParameter", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandProtectedParameterList\"}")]
        public virtual azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandProtectedParameterList ProtectedParameter
        {
            get => GetInstanceProperty<azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandProtectedParameterList>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSourceOutputReference\"}")]
        public virtual azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandSourceOutputReference Source
        {
            get => GetInstanceProperty<azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandSourceOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandTimeoutsOutputReference\"}")]
        public virtual azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorBlobManagedIdentityInput", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandErrorBlobManagedIdentity\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandErrorBlobManagedIdentity? ErrorBlobManagedIdentityInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandErrorBlobManagedIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorBlobUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ErrorBlobUriInput
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
        [JsiiProperty(name: "outputBlobManagedIdentityInput", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandOutputBlobManagedIdentity\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandOutputBlobManagedIdentity? OutputBlobManagedIdentityInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandOutputBlobManagedIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputBlobUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputBlobUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parameterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ParameterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protectedParameterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandProtectedParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProtectedParameterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runAsPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RunAsPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runAsUserInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RunAsUserInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSource\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSource? SourceInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualMachineIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualMachineIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "errorBlobUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorBlobUri
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

        [JsiiProperty(name: "outputBlobUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputBlobUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runAsPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunAsPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runAsUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunAsUser
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

        [JsiiProperty(name: "virtualMachineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualMachineId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
