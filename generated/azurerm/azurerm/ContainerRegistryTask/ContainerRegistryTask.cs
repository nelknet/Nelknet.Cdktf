using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTask
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task azurerm_container_registry_task}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ContainerRegistryTask.ContainerRegistryTask), fullyQualifiedName: "azurerm.containerRegistryTask.ContainerRegistryTask", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskConfig\"}}]")]
    public class ContainerRegistryTask : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task azurerm_container_registry_task} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ContainerRegistryTask(Constructs.Construct scope, string id, azurerm.ContainerRegistryTask.IContainerRegistryTaskConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ContainerRegistryTask.IContainerRegistryTaskConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerRegistryTask(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerRegistryTask(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ContainerRegistryTask resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ContainerRegistryTask to import.</param>
        /// <param name="importFromId">The id of the existing ContainerRegistryTask that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ContainerRegistryTask to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ContainerRegistryTask to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ContainerRegistryTask that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ContainerRegistryTask to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ContainerRegistryTask.ContainerRegistryTask), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAgentSetting", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskAgentSetting\"}}]")]
        public virtual void PutAgentSetting(azurerm.ContainerRegistryTask.IContainerRegistryTaskAgentSetting @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskAgentSetting)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBaseImageTrigger", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskBaseImageTrigger\"}}]")]
        public virtual void PutBaseImageTrigger(azurerm.ContainerRegistryTask.IContainerRegistryTaskBaseImageTrigger @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskBaseImageTrigger)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDockerStep", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskDockerStep\"}}]")]
        public virtual void PutDockerStep(azurerm.ContainerRegistryTask.IContainerRegistryTaskDockerStep @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskDockerStep)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncodedStep", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskEncodedStep\"}}]")]
        public virtual void PutEncodedStep(azurerm.ContainerRegistryTask.IContainerRegistryTaskEncodedStep @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskEncodedStep)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFileStep", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskFileStep\"}}]")]
        public virtual void PutFileStep(azurerm.ContainerRegistryTask.IContainerRegistryTaskFileStep @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskFileStep)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.ContainerRegistryTask.IContainerRegistryTaskIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlatform", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskPlatform\"}}]")]
        public virtual void PutPlatform(azurerm.ContainerRegistryTask.IContainerRegistryTaskPlatform @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskPlatform)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegistryCredential", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredential\"}}]")]
        public virtual void PutRegistryCredential(azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredential @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredential)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceTrigger", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskSourceTrigger\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSourceTrigger(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ContainerRegistryTask.IContainerRegistryTaskSourceTrigger[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskSourceTrigger).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskSourceTrigger).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ContainerRegistryTask.IContainerRegistryTaskTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimerTrigger", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskTimerTrigger\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTimerTrigger(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ContainerRegistryTask.IContainerRegistryTaskTimerTrigger[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskTimerTrigger).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskTimerTrigger).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAgentPoolName")]
        public virtual void ResetAgentPoolName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAgentSetting")]
        public virtual void ResetAgentSetting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBaseImageTrigger")]
        public virtual void ResetBaseImageTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDockerStep")]
        public virtual void ResetDockerStep()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncodedStep")]
        public virtual void ResetEncodedStep()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileStep")]
        public virtual void ResetFileStep()
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

        [JsiiMethod(name: "resetIsSystemTask")]
        public virtual void ResetIsSystemTask()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogTemplate")]
        public virtual void ResetLogTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatform")]
        public virtual void ResetPlatform()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegistryCredential")]
        public virtual void ResetRegistryCredential()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceTrigger")]
        public virtual void ResetSourceTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeoutInSeconds")]
        public virtual void ResetTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimerTrigger")]
        public virtual void ResetTimerTrigger()
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
        = GetStaticProperty<string>(typeof(azurerm.ContainerRegistryTask.ContainerRegistryTask))!;

        [JsiiProperty(name: "agentSetting", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskAgentSettingOutputReference\"}")]
        public virtual azurerm.ContainerRegistryTask.ContainerRegistryTaskAgentSettingOutputReference AgentSetting
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.ContainerRegistryTaskAgentSettingOutputReference>()!;
        }

        [JsiiProperty(name: "baseImageTrigger", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskBaseImageTriggerOutputReference\"}")]
        public virtual azurerm.ContainerRegistryTask.ContainerRegistryTaskBaseImageTriggerOutputReference BaseImageTrigger
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.ContainerRegistryTaskBaseImageTriggerOutputReference>()!;
        }

        [JsiiProperty(name: "dockerStep", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskDockerStepOutputReference\"}")]
        public virtual azurerm.ContainerRegistryTask.ContainerRegistryTaskDockerStepOutputReference DockerStep
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.ContainerRegistryTaskDockerStepOutputReference>()!;
        }

        [JsiiProperty(name: "encodedStep", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskEncodedStepOutputReference\"}")]
        public virtual azurerm.ContainerRegistryTask.ContainerRegistryTaskEncodedStepOutputReference EncodedStep
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.ContainerRegistryTaskEncodedStepOutputReference>()!;
        }

        [JsiiProperty(name: "fileStep", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskFileStepOutputReference\"}")]
        public virtual azurerm.ContainerRegistryTask.ContainerRegistryTaskFileStepOutputReference FileStep
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.ContainerRegistryTaskFileStepOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskIdentityOutputReference\"}")]
        public virtual azurerm.ContainerRegistryTask.ContainerRegistryTaskIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.ContainerRegistryTaskIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "platform", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskPlatformOutputReference\"}")]
        public virtual azurerm.ContainerRegistryTask.ContainerRegistryTaskPlatformOutputReference Platform
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.ContainerRegistryTaskPlatformOutputReference>()!;
        }

        [JsiiProperty(name: "registryCredential", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialOutputReference\"}")]
        public virtual azurerm.ContainerRegistryTask.ContainerRegistryTaskRegistryCredentialOutputReference RegistryCredential
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.ContainerRegistryTaskRegistryCredentialOutputReference>()!;
        }

        [JsiiProperty(name: "sourceTrigger", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskSourceTriggerList\"}")]
        public virtual azurerm.ContainerRegistryTask.ContainerRegistryTaskSourceTriggerList SourceTrigger
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.ContainerRegistryTaskSourceTriggerList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskTimeoutsOutputReference\"}")]
        public virtual azurerm.ContainerRegistryTask.ContainerRegistryTaskTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.ContainerRegistryTaskTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timerTrigger", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskTimerTriggerList\"}")]
        public virtual azurerm.ContainerRegistryTask.ContainerRegistryTaskTimerTriggerList TimerTrigger
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.ContainerRegistryTaskTimerTriggerList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentPoolNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AgentPoolNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentSettingInput", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskAgentSetting\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryTask.IContainerRegistryTaskAgentSetting? AgentSettingInput
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskAgentSetting?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "baseImageTriggerInput", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskBaseImageTrigger\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryTask.IContainerRegistryTaskBaseImageTrigger? BaseImageTriggerInput
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskBaseImageTrigger?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerRegistryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerRegistryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dockerStepInput", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskDockerStep\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryTask.IContainerRegistryTaskDockerStep? DockerStepInput
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskDockerStep?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encodedStepInput", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskEncodedStep\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryTask.IContainerRegistryTaskEncodedStep? EncodedStepInput
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskEncodedStep?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileStepInput", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskFileStep\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryTask.IContainerRegistryTaskFileStep? FileStepInput
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskFileStep?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskIdentity\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryTask.IContainerRegistryTaskIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isSystemTaskInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsSystemTaskInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logTemplateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogTemplateInput
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
        [JsiiProperty(name: "platformInput", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskPlatform\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryTask.IContainerRegistryTaskPlatform? PlatformInput
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskPlatform?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registryCredentialInput", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredential\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredential? RegistryCredentialInput
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredential?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTriggerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskSourceTrigger\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SourceTriggerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timerTriggerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskTimerTrigger\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TimerTriggerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "agentPoolName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentPoolName
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

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "isSystemTask", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object IsSystemTask
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

        [JsiiProperty(name: "logTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogTemplate
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
