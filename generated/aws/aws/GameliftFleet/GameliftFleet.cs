using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GameliftFleet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet aws_gamelift_fleet}.</summary>
    [JsiiClass(nativeType: typeof(aws.GameliftFleet.GameliftFleet), fullyQualifiedName: "aws.gameliftFleet.GameliftFleet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.gameliftFleet.GameliftFleetConfig\"}}]")]
    public class GameliftFleet : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet aws_gamelift_fleet} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GameliftFleet(Constructs.Construct scope, string id, aws.GameliftFleet.IGameliftFleetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.GameliftFleet.IGameliftFleetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GameliftFleet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GameliftFleet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a GameliftFleet resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the GameliftFleet to import.</param>
        /// <param name="importFromId">The id of the existing GameliftFleet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the GameliftFleet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the GameliftFleet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing GameliftFleet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the GameliftFleet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.GameliftFleet.GameliftFleet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCertificateConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.gameliftFleet.GameliftFleetCertificateConfiguration\"}}]")]
        public virtual void PutCertificateConfiguration(aws.GameliftFleet.IGameliftFleetCertificateConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GameliftFleet.IGameliftFleetCertificateConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEc2InboundPermission", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gameliftFleet.GameliftFleetEc2InboundPermission\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEc2InboundPermission(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GameliftFleet.IGameliftFleetEc2InboundPermission[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GameliftFleet.IGameliftFleetEc2InboundPermission).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GameliftFleet.IGameliftFleetEc2InboundPermission).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceCreationLimitPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.gameliftFleet.GameliftFleetResourceCreationLimitPolicy\"}}]")]
        public virtual void PutResourceCreationLimitPolicy(aws.GameliftFleet.IGameliftFleetResourceCreationLimitPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GameliftFleet.IGameliftFleetResourceCreationLimitPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRuntimeConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.gameliftFleet.GameliftFleetRuntimeConfiguration\"}}]")]
        public virtual void PutRuntimeConfiguration(aws.GameliftFleet.IGameliftFleetRuntimeConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GameliftFleet.IGameliftFleetRuntimeConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.gameliftFleet.GameliftFleetTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.GameliftFleet.IGameliftFleetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GameliftFleet.IGameliftFleetTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBuildId")]
        public virtual void ResetBuildId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateConfiguration")]
        public virtual void ResetCertificateConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2InboundPermission")]
        public virtual void ResetEc2InboundPermission()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFleetType")]
        public virtual void ResetFleetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceRoleArn")]
        public virtual void ResetInstanceRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricGroups")]
        public virtual void ResetMetricGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNewGameSessionProtectionPolicy")]
        public virtual void ResetNewGameSessionProtectionPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceCreationLimitPolicy")]
        public virtual void ResetResourceCreationLimitPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntimeConfiguration")]
        public virtual void ResetRuntimeConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScriptId")]
        public virtual void ResetScriptId()
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
        = GetStaticProperty<string>(typeof(aws.GameliftFleet.GameliftFleet))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "buildArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateConfiguration", typeJson: "{\"fqn\":\"aws.gameliftFleet.GameliftFleetCertificateConfigurationOutputReference\"}")]
        public virtual aws.GameliftFleet.GameliftFleetCertificateConfigurationOutputReference CertificateConfiguration
        {
            get => GetInstanceProperty<aws.GameliftFleet.GameliftFleetCertificateConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "ec2InboundPermission", typeJson: "{\"fqn\":\"aws.gameliftFleet.GameliftFleetEc2InboundPermissionList\"}")]
        public virtual aws.GameliftFleet.GameliftFleetEc2InboundPermissionList Ec2InboundPermission
        {
            get => GetInstanceProperty<aws.GameliftFleet.GameliftFleetEc2InboundPermissionList>()!;
        }

        [JsiiProperty(name: "logPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LogPaths
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatingSystem
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceCreationLimitPolicy", typeJson: "{\"fqn\":\"aws.gameliftFleet.GameliftFleetResourceCreationLimitPolicyOutputReference\"}")]
        public virtual aws.GameliftFleet.GameliftFleetResourceCreationLimitPolicyOutputReference ResourceCreationLimitPolicy
        {
            get => GetInstanceProperty<aws.GameliftFleet.GameliftFleetResourceCreationLimitPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "runtimeConfiguration", typeJson: "{\"fqn\":\"aws.gameliftFleet.GameliftFleetRuntimeConfigurationOutputReference\"}")]
        public virtual aws.GameliftFleet.GameliftFleetRuntimeConfigurationOutputReference RuntimeConfiguration
        {
            get => GetInstanceProperty<aws.GameliftFleet.GameliftFleetRuntimeConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "scriptArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScriptArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.gameliftFleet.GameliftFleetTimeoutsOutputReference\"}")]
        public virtual aws.GameliftFleet.GameliftFleetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.GameliftFleet.GameliftFleetTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateConfigurationInput", typeJson: "{\"fqn\":\"aws.gameliftFleet.GameliftFleetCertificateConfiguration\"}", isOptional: true)]
        public virtual aws.GameliftFleet.IGameliftFleetCertificateConfiguration? CertificateConfigurationInput
        {
            get => GetInstanceProperty<aws.GameliftFleet.IGameliftFleetCertificateConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2InboundPermissionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gameliftFleet.GameliftFleetEc2InboundPermission\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ec2InboundPermissionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2InstanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ec2InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fleetTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FleetTypeInput
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
        [JsiiProperty(name: "instanceRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? MetricGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "newGameSessionProtectionPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NewGameSessionProtectionPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceCreationLimitPolicyInput", typeJson: "{\"fqn\":\"aws.gameliftFleet.GameliftFleetResourceCreationLimitPolicy\"}", isOptional: true)]
        public virtual aws.GameliftFleet.IGameliftFleetResourceCreationLimitPolicy? ResourceCreationLimitPolicyInput
        {
            get => GetInstanceProperty<aws.GameliftFleet.IGameliftFleetResourceCreationLimitPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeConfigurationInput", typeJson: "{\"fqn\":\"aws.gameliftFleet.GameliftFleetRuntimeConfiguration\"}", isOptional: true)]
        public virtual aws.GameliftFleet.IGameliftFleetRuntimeConfiguration? RuntimeConfigurationInput
        {
            get => GetInstanceProperty<aws.GameliftFleet.IGameliftFleetRuntimeConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scriptIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScriptIdInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.gameliftFleet.GameliftFleetTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "buildId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildId
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

        [JsiiProperty(name: "ec2InstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ec2InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fleetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetType
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

        [JsiiProperty(name: "instanceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MetricGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "newGameSessionProtectionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NewGameSessionProtectionPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scriptId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScriptId
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
    }
}
