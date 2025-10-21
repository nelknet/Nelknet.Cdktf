using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmquicksetupConfigurationManager
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmquicksetup_configuration_manager aws_ssmquicksetup_configuration_manager}.</summary>
    [JsiiClass(nativeType: typeof(aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManager), fullyQualifiedName: "aws.ssmquicksetupConfigurationManager.SsmquicksetupConfigurationManager", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ssmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerConfig\"}}]")]
    public class SsmquicksetupConfigurationManager : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmquicksetup_configuration_manager aws_ssmquicksetup_configuration_manager} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SsmquicksetupConfigurationManager(Constructs.Construct scope, string id, aws.SsmquicksetupConfigurationManager.ISsmquicksetupConfigurationManagerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.SsmquicksetupConfigurationManager.ISsmquicksetupConfigurationManagerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmquicksetupConfigurationManager(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmquicksetupConfigurationManager(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SsmquicksetupConfigurationManager resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SsmquicksetupConfigurationManager to import.</param>
        /// <param name="importFromId">The id of the existing SsmquicksetupConfigurationManager that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SsmquicksetupConfigurationManager to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SsmquicksetupConfigurationManager to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmquicksetup_configuration_manager#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SsmquicksetupConfigurationManager that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SsmquicksetupConfigurationManager to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManager), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putConfigurationDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerConfigurationDefinition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConfigurationDefinition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SsmquicksetupConfigurationManager.ISsmquicksetupConfigurationManagerConfigurationDefinition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmquicksetupConfigurationManager.ISsmquicksetupConfigurationManagerConfigurationDefinition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmquicksetupConfigurationManager.ISsmquicksetupConfigurationManagerConfigurationDefinition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.SsmquicksetupConfigurationManager.ISsmquicksetupConfigurationManagerTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SsmquicksetupConfigurationManager.ISsmquicksetupConfigurationManagerTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfigurationDefinition")]
        public virtual void ResetConfigurationDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
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
        = GetStaticProperty<string>(typeof(aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManager))!;

        [JsiiProperty(name: "configurationDefinition", typeJson: "{\"fqn\":\"aws.ssmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerConfigurationDefinitionList\"}")]
        public virtual aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerConfigurationDefinitionList ConfigurationDefinition
        {
            get => GetInstanceProperty<aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerConfigurationDefinitionList>()!;
        }

        [JsiiProperty(name: "managerArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagerArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusSummaries", typeJson: "{\"fqn\":\"aws.ssmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerStatusSummariesList\"}")]
        public virtual aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerStatusSummariesList StatusSummaries
        {
            get => GetInstanceProperty<aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerStatusSummariesList>()!;
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap TagsAll
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ssmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerTimeoutsOutputReference\"}")]
        public virtual aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationDefinitionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerConfigurationDefinition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConfigurationDefinitionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
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
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.ssmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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
    }
}
