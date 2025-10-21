using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodecatalystDevEnvironment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment aws_codecatalyst_dev_environment}.</summary>
    [JsiiClass(nativeType: typeof(aws.CodecatalystDevEnvironment.CodecatalystDevEnvironment), fullyQualifiedName: "aws.codecatalystDevEnvironment.CodecatalystDevEnvironment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentConfig\"}}]")]
    public class CodecatalystDevEnvironment : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment aws_codecatalyst_dev_environment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CodecatalystDevEnvironment(Constructs.Construct scope, string id, aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodecatalystDevEnvironment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodecatalystDevEnvironment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CodecatalystDevEnvironment resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CodecatalystDevEnvironment to import.</param>
        /// <param name="importFromId">The id of the existing CodecatalystDevEnvironment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CodecatalystDevEnvironment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CodecatalystDevEnvironment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CodecatalystDevEnvironment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CodecatalystDevEnvironment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.CodecatalystDevEnvironment.CodecatalystDevEnvironment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putIdes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentIdes\"}}]")]
        public virtual void PutIdes(aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentIdes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentIdes)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPersistentStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentPersistentStorage\"}}]")]
        public virtual void PutPersistentStorage(aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentPersistentStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentPersistentStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRepositories", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentRepositories\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRepositories(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentRepositories[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentRepositories).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentRepositories).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlias")]
        public virtual void ResetAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInactivityTimeoutMinutes")]
        public virtual void ResetInactivityTimeoutMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepositories")]
        public virtual void ResetRepositories()
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
        = GetStaticProperty<string>(typeof(aws.CodecatalystDevEnvironment.CodecatalystDevEnvironment))!;

        [JsiiProperty(name: "ides", typeJson: "{\"fqn\":\"aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentIdesOutputReference\"}")]
        public virtual aws.CodecatalystDevEnvironment.CodecatalystDevEnvironmentIdesOutputReference Ides
        {
            get => GetInstanceProperty<aws.CodecatalystDevEnvironment.CodecatalystDevEnvironmentIdesOutputReference>()!;
        }

        [JsiiProperty(name: "persistentStorage", typeJson: "{\"fqn\":\"aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentPersistentStorageOutputReference\"}")]
        public virtual aws.CodecatalystDevEnvironment.CodecatalystDevEnvironmentPersistentStorageOutputReference PersistentStorage
        {
            get => GetInstanceProperty<aws.CodecatalystDevEnvironment.CodecatalystDevEnvironmentPersistentStorageOutputReference>()!;
        }

        [JsiiProperty(name: "repositories", typeJson: "{\"fqn\":\"aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentRepositoriesList\"}")]
        public virtual aws.CodecatalystDevEnvironment.CodecatalystDevEnvironmentRepositoriesList Repositories
        {
            get => GetInstanceProperty<aws.CodecatalystDevEnvironment.CodecatalystDevEnvironmentRepositoriesList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentTimeoutsOutputReference\"}")]
        public virtual aws.CodecatalystDevEnvironment.CodecatalystDevEnvironmentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.CodecatalystDevEnvironment.CodecatalystDevEnvironmentTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AliasInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idesInput", typeJson: "{\"fqn\":\"aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentIdes\"}", isOptional: true)]
        public virtual aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentIdes? IdesInput
        {
            get => GetInstanceProperty<aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentIdes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inactivityTimeoutMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InactivityTimeoutMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "persistentStorageInput", typeJson: "{\"fqn\":\"aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentPersistentStorage\"}", isOptional: true)]
        public virtual aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentPersistentStorage? PersistentStorageInput
        {
            get => GetInstanceProperty<aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentPersistentStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoriesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentRepositories\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RepositoriesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spaceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpaceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Alias
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

        [JsiiProperty(name: "inactivityTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InactivityTimeoutMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spaceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpaceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
