using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job azurerm_container_app_job}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ContainerAppJob.ContainerAppJob), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobConfig\"}}]")]
    public class ContainerAppJob : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job azurerm_container_app_job} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ContainerAppJob(Constructs.Construct scope, string id, azurerm.ContainerAppJob.IContainerAppJobConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ContainerAppJob.IContainerAppJobConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerAppJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerAppJob(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ContainerAppJob resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ContainerAppJob to import.</param>
        /// <param name="importFromId">The id of the existing ContainerAppJob that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ContainerAppJob to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ContainerAppJob to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ContainerAppJob that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ContainerAppJob to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ContainerAppJob.ContainerAppJob), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putEventTriggerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfig\"}}]")]
        public virtual void PutEventTriggerConfig(azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.ContainerAppJob.IContainerAppJobIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerAppJob.IContainerAppJobIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManualTriggerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobManualTriggerConfig\"}}]")]
        public virtual void PutManualTriggerConfig(azurerm.ContainerAppJob.IContainerAppJobManualTriggerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerAppJob.IContainerAppJobManualTriggerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegistry", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobRegistry\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRegistry(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ContainerAppJob.IContainerAppJobRegistry[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobRegistry).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobRegistry).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScheduleTriggerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobScheduleTriggerConfig\"}}]")]
        public virtual void PutScheduleTriggerConfig(azurerm.ContainerAppJob.IContainerAppJobScheduleTriggerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerAppJob.IContainerAppJobScheduleTriggerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecret", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobSecret\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecret(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ContainerAppJob.IContainerAppJobSecret[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobSecret).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobSecret).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTemplate\"}}]")]
        public virtual void PutTemplate(azurerm.ContainerAppJob.IContainerAppJobTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerAppJob.IContainerAppJobTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ContainerAppJob.IContainerAppJobTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerAppJob.IContainerAppJobTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEventTriggerConfig")]
        public virtual void ResetEventTriggerConfig()
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

        [JsiiMethod(name: "resetManualTriggerConfig")]
        public virtual void ResetManualTriggerConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegistry")]
        public virtual void ResetRegistry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicaRetryLimit")]
        public virtual void ResetReplicaRetryLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduleTriggerConfig")]
        public virtual void ResetScheduleTriggerConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecret")]
        public virtual void ResetSecret()
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

        [JsiiMethod(name: "resetWorkloadProfileName")]
        public virtual void ResetWorkloadProfileName()
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
        = GetStaticProperty<string>(typeof(azurerm.ContainerAppJob.ContainerAppJob))!;

        [JsiiProperty(name: "eventStreamEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventStreamEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eventTriggerConfig", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfigOutputReference\"}")]
        public virtual azurerm.ContainerAppJob.ContainerAppJobEventTriggerConfigOutputReference EventTriggerConfig
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.ContainerAppJobEventTriggerConfigOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobIdentityOutputReference\"}")]
        public virtual azurerm.ContainerAppJob.ContainerAppJobIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.ContainerAppJobIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "manualTriggerConfig", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobManualTriggerConfigOutputReference\"}")]
        public virtual azurerm.ContainerAppJob.ContainerAppJobManualTriggerConfigOutputReference ManualTriggerConfig
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.ContainerAppJobManualTriggerConfigOutputReference>()!;
        }

        [JsiiProperty(name: "outboundIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OutboundIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "registry", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobRegistryList\"}")]
        public virtual azurerm.ContainerAppJob.ContainerAppJobRegistryList Registry
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.ContainerAppJobRegistryList>()!;
        }

        [JsiiProperty(name: "scheduleTriggerConfig", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobScheduleTriggerConfigOutputReference\"}")]
        public virtual azurerm.ContainerAppJob.ContainerAppJobScheduleTriggerConfigOutputReference ScheduleTriggerConfig
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.ContainerAppJobScheduleTriggerConfigOutputReference>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobSecretList\"}")]
        public virtual azurerm.ContainerAppJob.ContainerAppJobSecretList Secret
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.ContainerAppJobSecretList>()!;
        }

        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTemplateOutputReference\"}")]
        public virtual azurerm.ContainerAppJob.ContainerAppJobTemplateOutputReference Template
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.ContainerAppJobTemplateOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTimeoutsOutputReference\"}")]
        public virtual azurerm.ContainerAppJob.ContainerAppJobTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.ContainerAppJobTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerAppEnvironmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerAppEnvironmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventTriggerConfigInput", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfig\"}", isOptional: true)]
        public virtual azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfig? EventTriggerConfigInput
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobIdentity\"}", isOptional: true)]
        public virtual azurerm.ContainerAppJob.IContainerAppJobIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.IContainerAppJobIdentity?>();
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
        [JsiiProperty(name: "manualTriggerConfigInput", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobManualTriggerConfig\"}", isOptional: true)]
        public virtual azurerm.ContainerAppJob.IContainerAppJobManualTriggerConfig? ManualTriggerConfigInput
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.IContainerAppJobManualTriggerConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobRegistry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RegistryInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicaRetryLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReplicaRetryLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicaTimeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReplicaTimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleTriggerConfigInput", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobScheduleTriggerConfig\"}", isOptional: true)]
        public virtual azurerm.ContainerAppJob.IContainerAppJobScheduleTriggerConfig? ScheduleTriggerConfigInput
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.IContainerAppJobScheduleTriggerConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecretInput
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
        [JsiiProperty(name: "templateInput", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTemplate\"}", isOptional: true)]
        public virtual azurerm.ContainerAppJob.IContainerAppJobTemplate? TemplateInput
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.IContainerAppJobTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workloadProfileNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkloadProfileNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "containerAppEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerAppEnvironmentId
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

        [JsiiProperty(name: "replicaRetryLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicaRetryLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicaTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicaTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
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

        [JsiiProperty(name: "workloadProfileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkloadProfileName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
