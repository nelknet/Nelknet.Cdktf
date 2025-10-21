using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application aws_emrserverless_application}.</summary>
    [JsiiClass(nativeType: typeof(aws.EmrserverlessApplication.EmrserverlessApplication), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplication", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationConfig\"}}]")]
    public class EmrserverlessApplication : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application aws_emrserverless_application} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EmrserverlessApplication(Constructs.Construct scope, string id, aws.EmrserverlessApplication.IEmrserverlessApplicationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.EmrserverlessApplication.IEmrserverlessApplicationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrserverlessApplication(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrserverlessApplication(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a EmrserverlessApplication resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the EmrserverlessApplication to import.</param>
        /// <param name="importFromId">The id of the existing EmrserverlessApplication that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the EmrserverlessApplication to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the EmrserverlessApplication to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing EmrserverlessApplication that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the EmrserverlessApplication to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.EmrserverlessApplication.EmrserverlessApplication), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutoStartConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationAutoStartConfiguration\"}}]")]
        public virtual void PutAutoStartConfiguration(aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStartConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStartConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutoStopConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationAutoStopConfiguration\"}}]")]
        public virtual void PutAutoStopConfiguration(aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStopConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStopConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImageConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationImageConfiguration\"}}]")]
        public virtual void PutImageConfiguration(aws.EmrserverlessApplication.IEmrserverlessApplicationImageConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationImageConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInitialCapacity", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacity\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInitialCapacity(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacity[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacity).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacity).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInteractiveConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInteractiveConfiguration\"}}]")]
        public virtual void PutInteractiveConfiguration(aws.EmrserverlessApplication.IEmrserverlessApplicationInteractiveConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationInteractiveConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaximumCapacity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMaximumCapacity\"}}]")]
        public virtual void PutMaximumCapacity(aws.EmrserverlessApplication.IEmrserverlessApplicationMaximumCapacity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationMaximumCapacity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(aws.EmrserverlessApplication.IEmrserverlessApplicationNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArchitecture")]
        public virtual void ResetArchitecture()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoStartConfiguration")]
        public virtual void ResetAutoStartConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoStopConfiguration")]
        public virtual void ResetAutoStopConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageConfiguration")]
        public virtual void ResetImageConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialCapacity")]
        public virtual void ResetInitialCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInteractiveConfiguration")]
        public virtual void ResetInteractiveConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumCapacity")]
        public virtual void ResetMaximumCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkConfiguration")]
        public virtual void ResetNetworkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
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
        = GetStaticProperty<string>(typeof(aws.EmrserverlessApplication.EmrserverlessApplication))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoStartConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationAutoStartConfigurationOutputReference\"}")]
        public virtual aws.EmrserverlessApplication.EmrserverlessApplicationAutoStartConfigurationOutputReference AutoStartConfiguration
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.EmrserverlessApplicationAutoStartConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "autoStopConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationAutoStopConfigurationOutputReference\"}")]
        public virtual aws.EmrserverlessApplication.EmrserverlessApplicationAutoStopConfigurationOutputReference AutoStopConfiguration
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.EmrserverlessApplicationAutoStopConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "imageConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationImageConfigurationOutputReference\"}")]
        public virtual aws.EmrserverlessApplication.EmrserverlessApplicationImageConfigurationOutputReference ImageConfiguration
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.EmrserverlessApplicationImageConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "initialCapacity", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityList\"}")]
        public virtual aws.EmrserverlessApplication.EmrserverlessApplicationInitialCapacityList InitialCapacity
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.EmrserverlessApplicationInitialCapacityList>()!;
        }

        [JsiiProperty(name: "interactiveConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInteractiveConfigurationOutputReference\"}")]
        public virtual aws.EmrserverlessApplication.EmrserverlessApplicationInteractiveConfigurationOutputReference InteractiveConfiguration
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.EmrserverlessApplicationInteractiveConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "maximumCapacity", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMaximumCapacityOutputReference\"}")]
        public virtual aws.EmrserverlessApplication.EmrserverlessApplicationMaximumCapacityOutputReference MaximumCapacity
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.EmrserverlessApplicationMaximumCapacityOutputReference>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationNetworkConfigurationOutputReference\"}")]
        public virtual aws.EmrserverlessApplication.EmrserverlessApplicationNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.EmrserverlessApplicationNetworkConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "architectureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArchitectureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoStartConfigurationInput", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationAutoStartConfiguration\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStartConfiguration? AutoStartConfigurationInput
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStartConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoStopConfigurationInput", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationAutoStopConfiguration\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStopConfiguration? AutoStopConfigurationInput
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationAutoStopConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageConfigurationInput", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationImageConfiguration\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationImageConfiguration? ImageConfigurationInput
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationImageConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialCapacityInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InitialCapacityInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "interactiveConfigurationInput", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationInteractiveConfiguration\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationInteractiveConfiguration? InteractiveConfigurationInput
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationInteractiveConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumCapacityInput", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMaximumCapacity\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationMaximumCapacity? MaximumCapacityInput
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationMaximumCapacity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationNetworkConfiguration\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "releaseLabelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReleaseLabelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
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

        [JsiiProperty(name: "releaseLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseLabel
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
