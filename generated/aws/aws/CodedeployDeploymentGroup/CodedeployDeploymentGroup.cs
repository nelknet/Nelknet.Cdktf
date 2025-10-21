using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group aws_codedeploy_deployment_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.CodedeployDeploymentGroup.CodedeployDeploymentGroup), fullyQualifiedName: "aws.codedeployDeploymentGroup.CodedeployDeploymentGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupConfig\"}}]")]
    public class CodedeployDeploymentGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group aws_codedeploy_deployment_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CodedeployDeploymentGroup(Constructs.Construct scope, string id, aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CodedeployDeploymentGroup resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CodedeployDeploymentGroup to import.</param>
        /// <param name="importFromId">The id of the existing CodedeployDeploymentGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CodedeployDeploymentGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CodedeployDeploymentGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CodedeployDeploymentGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CodedeployDeploymentGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.CodedeployDeploymentGroup.CodedeployDeploymentGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAlarmConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupAlarmConfiguration\"}}]")]
        public virtual void PutAlarmConfiguration(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupAlarmConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupAlarmConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutoRollbackConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupAutoRollbackConfiguration\"}}]")]
        public virtual void PutAutoRollbackConfiguration(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupAutoRollbackConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupAutoRollbackConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlueGreenDeploymentConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfig\"}}]")]
        public virtual void PutBlueGreenDeploymentConfig(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeploymentStyle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupDeploymentStyle\"}}]")]
        public virtual void PutDeploymentStyle(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupDeploymentStyle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupDeploymentStyle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEc2TagFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEc2TagFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEc2TagFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEc2TagFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEc2TagFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEc2TagSet", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagSet\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEc2TagSet(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEc2TagSet[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEc2TagSet).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEc2TagSet).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEcsService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEcsService\"}}]")]
        public virtual void PutEcsService(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEcsService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEcsService)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoadBalancerInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfo\"}}]")]
        public virtual void PutLoadBalancerInfo(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOnPremisesInstanceTagFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupOnPremisesInstanceTagFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOnPremisesInstanceTagFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupOnPremisesInstanceTagFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupOnPremisesInstanceTagFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupOnPremisesInstanceTagFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTriggerConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupTriggerConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTriggerConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupTriggerConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupTriggerConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupTriggerConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlarmConfiguration")]
        public virtual void ResetAlarmConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoRollbackConfiguration")]
        public virtual void ResetAutoRollbackConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoscalingGroups")]
        public virtual void ResetAutoscalingGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlueGreenDeploymentConfig")]
        public virtual void ResetBlueGreenDeploymentConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentConfigName")]
        public virtual void ResetDeploymentConfigName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentStyle")]
        public virtual void ResetDeploymentStyle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2TagFilter")]
        public virtual void ResetEc2TagFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2TagSet")]
        public virtual void ResetEc2TagSet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcsService")]
        public virtual void ResetEcsService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancerInfo")]
        public virtual void ResetLoadBalancerInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnPremisesInstanceTagFilter")]
        public virtual void ResetOnPremisesInstanceTagFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutdatedInstancesStrategy")]
        public virtual void ResetOutdatedInstancesStrategy()
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

        [JsiiMethod(name: "resetTerminationHookEnabled")]
        public virtual void ResetTerminationHookEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTriggerConfiguration")]
        public virtual void ResetTriggerConfiguration()
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
        = GetStaticProperty<string>(typeof(aws.CodedeployDeploymentGroup.CodedeployDeploymentGroup))!;

        [JsiiProperty(name: "alarmConfiguration", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupAlarmConfigurationOutputReference\"}")]
        public virtual aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupAlarmConfigurationOutputReference AlarmConfiguration
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupAlarmConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupAutoRollbackConfigurationOutputReference\"}")]
        public virtual aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupAutoRollbackConfigurationOutputReference AutoRollbackConfiguration
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupAutoRollbackConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "blueGreenDeploymentConfig", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference\"}")]
        public virtual aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference BlueGreenDeploymentConfig
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference>()!;
        }

        [JsiiProperty(name: "computePlatform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputePlatform
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentStyle", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupDeploymentStyleOutputReference\"}")]
        public virtual aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupDeploymentStyleOutputReference DeploymentStyle
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupDeploymentStyleOutputReference>()!;
        }

        [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagFilterList\"}")]
        public virtual aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagFilterList Ec2TagFilter
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagFilterList>()!;
        }

        [JsiiProperty(name: "ec2TagSet", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagSetList\"}")]
        public virtual aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagSetList Ec2TagSet
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagSetList>()!;
        }

        [JsiiProperty(name: "ecsService", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEcsServiceOutputReference\"}")]
        public virtual aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupEcsServiceOutputReference EcsService
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupEcsServiceOutputReference>()!;
        }

        [JsiiProperty(name: "loadBalancerInfo", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfoOutputReference\"}")]
        public virtual aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfoOutputReference LoadBalancerInfo
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfoOutputReference>()!;
        }

        [JsiiProperty(name: "onPremisesInstanceTagFilter", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupOnPremisesInstanceTagFilterList\"}")]
        public virtual aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupOnPremisesInstanceTagFilterList OnPremisesInstanceTagFilter
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupOnPremisesInstanceTagFilterList>()!;
        }

        [JsiiProperty(name: "triggerConfiguration", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupTriggerConfigurationList\"}")]
        public virtual aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupTriggerConfigurationList TriggerConfiguration
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.CodedeployDeploymentGroupTriggerConfigurationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alarmConfigurationInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupAlarmConfiguration\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupAlarmConfiguration? AlarmConfigurationInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupAlarmConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoRollbackConfigurationInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupAutoRollbackConfiguration\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupAutoRollbackConfiguration? AutoRollbackConfigurationInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupAutoRollbackConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AutoscalingGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blueGreenDeploymentConfigInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfig\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfig? BlueGreenDeploymentConfigInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentConfigNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentConfigNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentStyleInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupDeploymentStyle\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupDeploymentStyle? DeploymentStyleInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupDeploymentStyle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2TagFilterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ec2TagFilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2TagSetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ec2TagSetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecsServiceInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEcsService\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEcsService? EcsServiceInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEcsService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerInfoInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfo\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfo? LoadBalancerInfoInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onPremisesInstanceTagFilterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupOnPremisesInstanceTagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OnPremisesInstanceTagFilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outdatedInstancesStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutdatedInstancesStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceRoleArnInput
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
        [JsiiProperty(name: "terminationHookEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TerminationHookEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupTriggerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TriggerConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "appName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoscalingGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AutoscalingGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentConfigName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentGroupName
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

        [JsiiProperty(name: "outdatedInstancesStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutdatedInstancesStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleArn
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

        [JsiiProperty(name: "terminationHookEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object TerminationHookEnabled
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
