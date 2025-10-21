using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksNodeGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group aws_eks_node_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.EksNodeGroup.EksNodeGroup), fullyQualifiedName: "aws.eksNodeGroup.EksNodeGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupConfig\"}}]")]
    public class EksNodeGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group aws_eks_node_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EksNodeGroup(Constructs.Construct scope, string id, aws.EksNodeGroup.IEksNodeGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.EksNodeGroup.IEksNodeGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksNodeGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksNodeGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a EksNodeGroup resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the EksNodeGroup to import.</param>
        /// <param name="importFromId">The id of the existing EksNodeGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the EksNodeGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the EksNodeGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing EksNodeGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the EksNodeGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.EksNodeGroup.EksNodeGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLaunchTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupLaunchTemplate\"}}]")]
        public virtual void PutLaunchTemplate(aws.EksNodeGroup.IEksNodeGroupLaunchTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksNodeGroup.IEksNodeGroupLaunchTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodeRepairConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupNodeRepairConfig\"}}]")]
        public virtual void PutNodeRepairConfig(aws.EksNodeGroup.IEksNodeGroupNodeRepairConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksNodeGroup.IEksNodeGroupNodeRepairConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRemoteAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupRemoteAccess\"}}]")]
        public virtual void PutRemoteAccess(aws.EksNodeGroup.IEksNodeGroupRemoteAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksNodeGroup.IEksNodeGroupRemoteAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScalingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupScalingConfig\"}}]")]
        public virtual void PutScalingConfig(aws.EksNodeGroup.IEksNodeGroupScalingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksNodeGroup.IEksNodeGroupScalingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTaint", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupTaint\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTaint(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EksNodeGroup.IEksNodeGroupTaint[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EksNodeGroup.IEksNodeGroupTaint).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EksNodeGroup.IEksNodeGroupTaint).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.EksNodeGroup.IEksNodeGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksNodeGroup.IEksNodeGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpdateConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupUpdateConfig\"}}]")]
        public virtual void PutUpdateConfig(aws.EksNodeGroup.IEksNodeGroupUpdateConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksNodeGroup.IEksNodeGroupUpdateConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmiType")]
        public virtual void ResetAmiType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityType")]
        public virtual void ResetCapacityType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiskSize")]
        public virtual void ResetDiskSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceUpdateVersion")]
        public virtual void ResetForceUpdateVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceTypes")]
        public virtual void ResetInstanceTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabels")]
        public virtual void ResetLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchTemplate")]
        public virtual void ResetLaunchTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeGroupName")]
        public virtual void ResetNodeGroupName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeGroupNamePrefix")]
        public virtual void ResetNodeGroupNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeRepairConfig")]
        public virtual void ResetNodeRepairConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReleaseVersion")]
        public virtual void ResetReleaseVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRemoteAccess")]
        public virtual void ResetRemoteAccess()
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

        [JsiiMethod(name: "resetTaint")]
        public virtual void ResetTaint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdateConfig")]
        public virtual void ResetUpdateConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
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
        = GetStaticProperty<string>(typeof(aws.EksNodeGroup.EksNodeGroup))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupLaunchTemplateOutputReference\"}")]
        public virtual aws.EksNodeGroup.EksNodeGroupLaunchTemplateOutputReference LaunchTemplate
        {
            get => GetInstanceProperty<aws.EksNodeGroup.EksNodeGroupLaunchTemplateOutputReference>()!;
        }

        [JsiiProperty(name: "nodeRepairConfig", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupNodeRepairConfigOutputReference\"}")]
        public virtual aws.EksNodeGroup.EksNodeGroupNodeRepairConfigOutputReference NodeRepairConfig
        {
            get => GetInstanceProperty<aws.EksNodeGroup.EksNodeGroupNodeRepairConfigOutputReference>()!;
        }

        [JsiiProperty(name: "remoteAccess", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupRemoteAccessOutputReference\"}")]
        public virtual aws.EksNodeGroup.EksNodeGroupRemoteAccessOutputReference RemoteAccess
        {
            get => GetInstanceProperty<aws.EksNodeGroup.EksNodeGroupRemoteAccessOutputReference>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupResourcesList\"}")]
        public virtual aws.EksNodeGroup.EksNodeGroupResourcesList Resources
        {
            get => GetInstanceProperty<aws.EksNodeGroup.EksNodeGroupResourcesList>()!;
        }

        [JsiiProperty(name: "scalingConfig", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupScalingConfigOutputReference\"}")]
        public virtual aws.EksNodeGroup.EksNodeGroupScalingConfigOutputReference ScalingConfig
        {
            get => GetInstanceProperty<aws.EksNodeGroup.EksNodeGroupScalingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "taint", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupTaintList\"}")]
        public virtual aws.EksNodeGroup.EksNodeGroupTaintList Taint
        {
            get => GetInstanceProperty<aws.EksNodeGroup.EksNodeGroupTaintList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupTimeoutsOutputReference\"}")]
        public virtual aws.EksNodeGroup.EksNodeGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.EksNodeGroup.EksNodeGroupTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "updateConfig", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupUpdateConfigOutputReference\"}")]
        public virtual aws.EksNodeGroup.EksNodeGroupUpdateConfigOutputReference UpdateConfig
        {
            get => GetInstanceProperty<aws.EksNodeGroup.EksNodeGroupUpdateConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amiTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AmiTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DiskSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceUpdateVersionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceUpdateVersionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? InstanceTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? LabelsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateInput", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupLaunchTemplate\"}", isOptional: true)]
        public virtual aws.EksNodeGroup.IEksNodeGroupLaunchTemplate? LaunchTemplateInput
        {
            get => GetInstanceProperty<aws.EksNodeGroup.IEksNodeGroupLaunchTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeGroupNamePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeGroupNamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeRepairConfigInput", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupNodeRepairConfig\"}", isOptional: true)]
        public virtual aws.EksNodeGroup.IEksNodeGroupNodeRepairConfig? NodeRepairConfigInput
        {
            get => GetInstanceProperty<aws.EksNodeGroup.IEksNodeGroupNodeRepairConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "releaseVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReleaseVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "remoteAccessInput", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupRemoteAccess\"}", isOptional: true)]
        public virtual aws.EksNodeGroup.IEksNodeGroupRemoteAccess? RemoteAccessInput
        {
            get => GetInstanceProperty<aws.EksNodeGroup.IEksNodeGroupRemoteAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalingConfigInput", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupScalingConfig\"}", isOptional: true)]
        public virtual aws.EksNodeGroup.IEksNodeGroupScalingConfig? ScalingConfigInput
        {
            get => GetInstanceProperty<aws.EksNodeGroup.IEksNodeGroupScalingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SubnetIdsInput
        {
            get => GetInstanceProperty<string[]?>();
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
        [JsiiProperty(name: "taintInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupTaint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TaintInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateConfigInput", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupUpdateConfig\"}", isOptional: true)]
        public virtual aws.EksNodeGroup.IEksNodeGroupUpdateConfig? UpdateConfigInput
        {
            get => GetInstanceProperty<aws.EksNodeGroup.IEksNodeGroupUpdateConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "amiType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AmiType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "capacityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DiskSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceUpdateVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceUpdateVersion
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

        [JsiiProperty(name: "instanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InstanceTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeGroupNamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeGroupNamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "releaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
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
