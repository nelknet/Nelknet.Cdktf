using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GameliftGameServerGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group aws_gamelift_game_server_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.GameliftGameServerGroup.GameliftGameServerGroup), fullyQualifiedName: "aws.gameliftGameServerGroup.GameliftGameServerGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupConfig\"}}]")]
    public class GameliftGameServerGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group aws_gamelift_game_server_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GameliftGameServerGroup(Constructs.Construct scope, string id, aws.GameliftGameServerGroup.IGameliftGameServerGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.GameliftGameServerGroup.IGameliftGameServerGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GameliftGameServerGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GameliftGameServerGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a GameliftGameServerGroup resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the GameliftGameServerGroup to import.</param>
        /// <param name="importFromId">The id of the existing GameliftGameServerGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the GameliftGameServerGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the GameliftGameServerGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing GameliftGameServerGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the GameliftGameServerGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.GameliftGameServerGroup.GameliftGameServerGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutoScalingPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicy\"}}]")]
        public virtual void PutAutoScalingPolicy(aws.GameliftGameServerGroup.IGameliftGameServerGroupAutoScalingPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GameliftGameServerGroup.IGameliftGameServerGroupAutoScalingPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInstanceDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupInstanceDefinition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInstanceDefinition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GameliftGameServerGroup.IGameliftGameServerGroupInstanceDefinition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GameliftGameServerGroup.IGameliftGameServerGroupInstanceDefinition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GameliftGameServerGroup.IGameliftGameServerGroupInstanceDefinition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLaunchTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupLaunchTemplate\"}}]")]
        public virtual void PutLaunchTemplate(aws.GameliftGameServerGroup.IGameliftGameServerGroupLaunchTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GameliftGameServerGroup.IGameliftGameServerGroupLaunchTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.GameliftGameServerGroup.IGameliftGameServerGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GameliftGameServerGroup.IGameliftGameServerGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoScalingPolicy")]
        public virtual void ResetAutoScalingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBalancingStrategy")]
        public virtual void ResetBalancingStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGameServerProtectionPolicy")]
        public virtual void ResetGameServerProtectionPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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

        [JsiiMethod(name: "resetVpcSubnets")]
        public virtual void ResetVpcSubnets()
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
        = GetStaticProperty<string>(typeof(aws.GameliftGameServerGroup.GameliftGameServerGroup))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoScalingGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoScalingGroupArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoScalingPolicy", typeJson: "{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicyOutputReference\"}")]
        public virtual aws.GameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicyOutputReference AutoScalingPolicy
        {
            get => GetInstanceProperty<aws.GameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "instanceDefinition", typeJson: "{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupInstanceDefinitionList\"}")]
        public virtual aws.GameliftGameServerGroup.GameliftGameServerGroupInstanceDefinitionList InstanceDefinition
        {
            get => GetInstanceProperty<aws.GameliftGameServerGroup.GameliftGameServerGroupInstanceDefinitionList>()!;
        }

        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupLaunchTemplateOutputReference\"}")]
        public virtual aws.GameliftGameServerGroup.GameliftGameServerGroupLaunchTemplateOutputReference LaunchTemplate
        {
            get => GetInstanceProperty<aws.GameliftGameServerGroup.GameliftGameServerGroupLaunchTemplateOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupTimeoutsOutputReference\"}")]
        public virtual aws.GameliftGameServerGroup.GameliftGameServerGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.GameliftGameServerGroup.GameliftGameServerGroupTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScalingPolicyInput", typeJson: "{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicy\"}", isOptional: true)]
        public virtual aws.GameliftGameServerGroup.IGameliftGameServerGroupAutoScalingPolicy? AutoScalingPolicyInput
        {
            get => GetInstanceProperty<aws.GameliftGameServerGroup.IGameliftGameServerGroupAutoScalingPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "balancingStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BalancingStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gameServerGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GameServerGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gameServerProtectionPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GameServerProtectionPolicyInput
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
        [JsiiProperty(name: "instanceDefinitionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupInstanceDefinition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InstanceDefinitionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateInput", typeJson: "{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupLaunchTemplate\"}", isOptional: true)]
        public virtual aws.GameliftGameServerGroup.IGameliftGameServerGroupLaunchTemplate? LaunchTemplateInput
        {
            get => GetInstanceProperty<aws.GameliftGameServerGroup.IGameliftGameServerGroupLaunchTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcSubnetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VpcSubnetsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "balancingStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BalancingStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gameServerGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GameServerGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gameServerProtectionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GameServerProtectionPolicy
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

        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
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

        [JsiiProperty(name: "vpcSubnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcSubnets
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
