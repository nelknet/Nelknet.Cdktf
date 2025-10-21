using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster aws_emr_cluster}.</summary>
    [JsiiClass(nativeType: typeof(aws.EmrCluster.EmrCluster), fullyQualifiedName: "aws.emrCluster.EmrCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.emrCluster.EmrClusterConfig\"}}]")]
    public class EmrCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster aws_emr_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EmrCluster(Constructs.Construct scope, string id, aws.EmrCluster.IEmrClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.EmrCluster.IEmrClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a EmrCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the EmrCluster to import.</param>
        /// <param name="importFromId">The id of the existing EmrCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the EmrCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the EmrCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing EmrCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the EmrCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.EmrCluster.EmrCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutoTerminationPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrCluster.EmrClusterAutoTerminationPolicy\"}}]")]
        public virtual void PutAutoTerminationPolicy(aws.EmrCluster.IEmrClusterAutoTerminationPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrCluster.IEmrClusterAutoTerminationPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBootstrapAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterBootstrapAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBootstrapAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EmrCluster.IEmrClusterBootstrapAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterBootstrapAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterBootstrapAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCoreInstanceFleet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceFleet\"}}]")]
        public virtual void PutCoreInstanceFleet(aws.EmrCluster.IEmrClusterCoreInstanceFleet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrCluster.IEmrClusterCoreInstanceFleet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCoreInstanceGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceGroup\"}}]")]
        public virtual void PutCoreInstanceGroup(aws.EmrCluster.IEmrClusterCoreInstanceGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrCluster.IEmrClusterCoreInstanceGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEc2Attributes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrCluster.EmrClusterEc2Attributes\"}}]")]
        public virtual void PutEc2Attributes(aws.EmrCluster.IEmrClusterEc2Attributes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrCluster.IEmrClusterEc2Attributes)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKerberosAttributes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrCluster.EmrClusterKerberosAttributes\"}}]")]
        public virtual void PutKerberosAttributes(aws.EmrCluster.IEmrClusterKerberosAttributes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrCluster.IEmrClusterKerberosAttributes)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMasterInstanceFleet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceFleet\"}}]")]
        public virtual void PutMasterInstanceFleet(aws.EmrCluster.IEmrClusterMasterInstanceFleet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrCluster.IEmrClusterMasterInstanceFleet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMasterInstanceGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceGroup\"}}]")]
        public virtual void PutMasterInstanceGroup(aws.EmrCluster.IEmrClusterMasterInstanceGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrCluster.IEmrClusterMasterInstanceGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacementGroupConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterPlacementGroupConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPlacementGroupConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EmrCluster.IEmrClusterPlacementGroupConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterPlacementGroupConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterPlacementGroupConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStep", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterStep\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStep(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EmrCluster.IEmrClusterStep[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterStep).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterStep).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalInfo")]
        public virtual void ResetAdditionalInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplications")]
        public virtual void ResetApplications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoscalingRole")]
        public virtual void ResetAutoscalingRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoTerminationPolicy")]
        public virtual void ResetAutoTerminationPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootstrapAction")]
        public virtual void ResetBootstrapAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigurations")]
        public virtual void ResetConfigurations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigurationsJson")]
        public virtual void ResetConfigurationsJson()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoreInstanceFleet")]
        public virtual void ResetCoreInstanceFleet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoreInstanceGroup")]
        public virtual void ResetCoreInstanceGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomAmiId")]
        public virtual void ResetCustomAmiId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbsRootVolumeSize")]
        public virtual void ResetEbsRootVolumeSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2Attributes")]
        public virtual void ResetEc2Attributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeepJobFlowAliveWhenNoSteps")]
        public virtual void ResetKeepJobFlowAliveWhenNoSteps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKerberosAttributes")]
        public virtual void ResetKerberosAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetListStepsStates")]
        public virtual void ResetListStepsStates()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogEncryptionKmsKeyId")]
        public virtual void ResetLogEncryptionKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogUri")]
        public virtual void ResetLogUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterInstanceFleet")]
        public virtual void ResetMasterInstanceFleet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterInstanceGroup")]
        public virtual void ResetMasterInstanceGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementGroupConfig")]
        public virtual void ResetPlacementGroupConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleDownBehavior")]
        public virtual void ResetScaleDownBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityConfiguration")]
        public virtual void ResetSecurityConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStep")]
        public virtual void ResetStep()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepConcurrencyLevel")]
        public virtual void ResetStepConcurrencyLevel()
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

        [JsiiMethod(name: "resetTerminationProtection")]
        public virtual void ResetTerminationProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnhealthyNodeReplacement")]
        public virtual void ResetUnhealthyNodeReplacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVisibleToAllUsers")]
        public virtual void ResetVisibleToAllUsers()
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
        = GetStaticProperty<string>(typeof(aws.EmrCluster.EmrCluster))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoTerminationPolicy", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterAutoTerminationPolicyOutputReference\"}")]
        public virtual aws.EmrCluster.EmrClusterAutoTerminationPolicyOutputReference AutoTerminationPolicy
        {
            get => GetInstanceProperty<aws.EmrCluster.EmrClusterAutoTerminationPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "bootstrapAction", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterBootstrapActionList\"}")]
        public virtual aws.EmrCluster.EmrClusterBootstrapActionList BootstrapAction
        {
            get => GetInstanceProperty<aws.EmrCluster.EmrClusterBootstrapActionList>()!;
        }

        [JsiiProperty(name: "clusterState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "coreInstanceFleet", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceFleetOutputReference\"}")]
        public virtual aws.EmrCluster.EmrClusterCoreInstanceFleetOutputReference CoreInstanceFleet
        {
            get => GetInstanceProperty<aws.EmrCluster.EmrClusterCoreInstanceFleetOutputReference>()!;
        }

        [JsiiProperty(name: "coreInstanceGroup", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceGroupOutputReference\"}")]
        public virtual aws.EmrCluster.EmrClusterCoreInstanceGroupOutputReference CoreInstanceGroup
        {
            get => GetInstanceProperty<aws.EmrCluster.EmrClusterCoreInstanceGroupOutputReference>()!;
        }

        [JsiiProperty(name: "ec2Attributes", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterEc2AttributesOutputReference\"}")]
        public virtual aws.EmrCluster.EmrClusterEc2AttributesOutputReference Ec2Attributes
        {
            get => GetInstanceProperty<aws.EmrCluster.EmrClusterEc2AttributesOutputReference>()!;
        }

        [JsiiProperty(name: "kerberosAttributes", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterKerberosAttributesOutputReference\"}")]
        public virtual aws.EmrCluster.EmrClusterKerberosAttributesOutputReference KerberosAttributes
        {
            get => GetInstanceProperty<aws.EmrCluster.EmrClusterKerberosAttributesOutputReference>()!;
        }

        [JsiiProperty(name: "masterInstanceFleet", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceFleetOutputReference\"}")]
        public virtual aws.EmrCluster.EmrClusterMasterInstanceFleetOutputReference MasterInstanceFleet
        {
            get => GetInstanceProperty<aws.EmrCluster.EmrClusterMasterInstanceFleetOutputReference>()!;
        }

        [JsiiProperty(name: "masterInstanceGroup", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceGroupOutputReference\"}")]
        public virtual aws.EmrCluster.EmrClusterMasterInstanceGroupOutputReference MasterInstanceGroup
        {
            get => GetInstanceProperty<aws.EmrCluster.EmrClusterMasterInstanceGroupOutputReference>()!;
        }

        [JsiiProperty(name: "masterPublicDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterPublicDns
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementGroupConfig", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterPlacementGroupConfigList\"}")]
        public virtual aws.EmrCluster.EmrClusterPlacementGroupConfigList PlacementGroupConfig
        {
            get => GetInstanceProperty<aws.EmrCluster.EmrClusterPlacementGroupConfigList>()!;
        }

        [JsiiProperty(name: "step", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterStepList\"}")]
        public virtual aws.EmrCluster.EmrClusterStepList Step
        {
            get => GetInstanceProperty<aws.EmrCluster.EmrClusterStepList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalInfoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdditionalInfoInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ApplicationsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoscalingRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoTerminationPolicyInput", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterAutoTerminationPolicy\"}", isOptional: true)]
        public virtual aws.EmrCluster.IEmrClusterAutoTerminationPolicy? AutoTerminationPolicyInput
        {
            get => GetInstanceProperty<aws.EmrCluster.IEmrClusterAutoTerminationPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootstrapActionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterBootstrapAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BootstrapActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationsJsonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationsJsonInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceFleetInput", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceFleet\"}", isOptional: true)]
        public virtual aws.EmrCluster.IEmrClusterCoreInstanceFleet? CoreInstanceFleetInput
        {
            get => GetInstanceProperty<aws.EmrCluster.IEmrClusterCoreInstanceFleet?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceGroupInput", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceGroup\"}", isOptional: true)]
        public virtual aws.EmrCluster.IEmrClusterCoreInstanceGroup? CoreInstanceGroupInput
        {
            get => GetInstanceProperty<aws.EmrCluster.IEmrClusterCoreInstanceGroup?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customAmiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomAmiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsRootVolumeSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EbsRootVolumeSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2AttributesInput", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterEc2Attributes\"}", isOptional: true)]
        public virtual aws.EmrCluster.IEmrClusterEc2Attributes? Ec2AttributesInput
        {
            get => GetInstanceProperty<aws.EmrCluster.IEmrClusterEc2Attributes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keepJobFlowAliveWhenNoStepsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? KeepJobFlowAliveWhenNoStepsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kerberosAttributesInput", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterKerberosAttributes\"}", isOptional: true)]
        public virtual aws.EmrCluster.IEmrClusterKerberosAttributes? KerberosAttributesInput
        {
            get => GetInstanceProperty<aws.EmrCluster.IEmrClusterKerberosAttributes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "listStepsStatesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ListStepsStatesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logEncryptionKmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogEncryptionKmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterInstanceFleetInput", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceFleet\"}", isOptional: true)]
        public virtual aws.EmrCluster.IEmrClusterMasterInstanceFleet? MasterInstanceFleetInput
        {
            get => GetInstanceProperty<aws.EmrCluster.IEmrClusterMasterInstanceFleet?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterInstanceGroupInput", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceGroup\"}", isOptional: true)]
        public virtual aws.EmrCluster.IEmrClusterMasterInstanceGroup? MasterInstanceGroupInput
        {
            get => GetInstanceProperty<aws.EmrCluster.IEmrClusterMasterInstanceGroup?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementGroupConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterPlacementGroupConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PlacementGroupConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "releaseLabelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReleaseLabelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleDownBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScaleDownBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityConfigurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepConcurrencyLevelInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StepConcurrencyLevelInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StepInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "terminationProtectionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TerminationProtectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unhealthyNodeReplacementInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UnhealthyNodeReplacementInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "visibleToAllUsersInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? VisibleToAllUsersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "additionalInfo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdditionalInfo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "applications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Applications
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoscalingRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoscalingRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configurations", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Configurations
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configurationsJson", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationsJson
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customAmiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomAmiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsRootVolumeSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsRootVolumeSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keepJobFlowAliveWhenNoSteps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object KeepJobFlowAliveWhenNoSteps
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

        [JsiiProperty(name: "listStepsStates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ListStepsStates
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logEncryptionKmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogEncryptionKmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogUri
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

        [JsiiProperty(name: "scaleDownBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScaleDownBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityConfiguration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepConcurrencyLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StepConcurrencyLevel
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "terminationProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object TerminationProtection
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

        [JsiiProperty(name: "unhealthyNodeReplacement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object UnhealthyNodeReplacement
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

        [JsiiProperty(name: "visibleToAllUsers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object VisibleToAllUsers
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
    }
}
