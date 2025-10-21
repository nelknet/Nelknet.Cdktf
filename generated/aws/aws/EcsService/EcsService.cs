using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service aws_ecs_service}.</summary>
    [JsiiClass(nativeType: typeof(aws.EcsService.EcsService), fullyQualifiedName: "aws.ecsService.EcsService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceConfig\"}}]")]
    public class EcsService : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service aws_ecs_service} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EcsService(Constructs.Construct scope, string id, aws.EcsService.IEcsServiceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.EcsService.IEcsServiceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsService(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a EcsService resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the EcsService to import.</param>
        /// <param name="importFromId">The id of the existing EcsService that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the EcsService to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the EcsService to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing EcsService that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the EcsService to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.EcsService.EcsService), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAlarms", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceAlarms\"}}]")]
        public virtual void PutAlarms(aws.EcsService.IEcsServiceAlarms @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceAlarms)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCapacityProviderStrategy", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceCapacityProviderStrategy\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCapacityProviderStrategy(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EcsService.IEcsServiceCapacityProviderStrategy[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceCapacityProviderStrategy).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceCapacityProviderStrategy).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeploymentCircuitBreaker", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceDeploymentCircuitBreaker\"}}]")]
        public virtual void PutDeploymentCircuitBreaker(aws.EcsService.IEcsServiceDeploymentCircuitBreaker @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceDeploymentCircuitBreaker)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeploymentController", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceDeploymentController\"}}]")]
        public virtual void PutDeploymentController(aws.EcsService.IEcsServiceDeploymentController @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceDeploymentController)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoadBalancer", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceLoadBalancer\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLoadBalancer(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EcsService.IEcsServiceLoadBalancer[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceLoadBalancer).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceLoadBalancer).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(aws.EcsService.IEcsServiceNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOrderedPlacementStrategy", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceOrderedPlacementStrategy\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOrderedPlacementStrategy(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EcsService.IEcsServiceOrderedPlacementStrategy[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceOrderedPlacementStrategy).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceOrderedPlacementStrategy).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacementConstraints", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServicePlacementConstraints\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPlacementConstraints(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EcsService.IEcsServicePlacementConstraints[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServicePlacementConstraints).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServicePlacementConstraints).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceConnectConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfiguration\"}}]")]
        public virtual void PutServiceConnectConfiguration(aws.EcsService.IEcsServiceServiceConnectConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceServiceConnectConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceRegistries", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceServiceRegistries\"}}]")]
        public virtual void PutServiceRegistries(aws.EcsService.IEcsServiceServiceRegistries @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceServiceRegistries)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.EcsService.IEcsServiceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVolumeConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceVolumeConfiguration\"}}]")]
        public virtual void PutVolumeConfiguration(aws.EcsService.IEcsServiceVolumeConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceVolumeConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcLatticeConfigurations", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceVpcLatticeConfigurations\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVpcLatticeConfigurations(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EcsService.IEcsServiceVpcLatticeConfigurations[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceVpcLatticeConfigurations).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceVpcLatticeConfigurations).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlarms")]
        public virtual void ResetAlarms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityZoneRebalancing")]
        public virtual void ResetAvailabilityZoneRebalancing()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityProviderStrategy")]
        public virtual void ResetCapacityProviderStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCluster")]
        public virtual void ResetCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentCircuitBreaker")]
        public virtual void ResetDeploymentCircuitBreaker()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentController")]
        public virtual void ResetDeploymentController()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentMaximumPercent")]
        public virtual void ResetDeploymentMaximumPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentMinimumHealthyPercent")]
        public virtual void ResetDeploymentMinimumHealthyPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDesiredCount")]
        public virtual void ResetDesiredCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableEcsManagedTags")]
        public virtual void ResetEnableEcsManagedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableExecuteCommand")]
        public virtual void ResetEnableExecuteCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceDelete")]
        public virtual void ResetForceDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceNewDeployment")]
        public virtual void ResetForceNewDeployment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckGracePeriodSeconds")]
        public virtual void ResetHealthCheckGracePeriodSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIamRole")]
        public virtual void ResetIamRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchType")]
        public virtual void ResetLaunchType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancer")]
        public virtual void ResetLoadBalancer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkConfiguration")]
        public virtual void ResetNetworkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrderedPlacementStrategy")]
        public virtual void ResetOrderedPlacementStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementConstraints")]
        public virtual void ResetPlacementConstraints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatformVersion")]
        public virtual void ResetPlatformVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPropagateTags")]
        public virtual void ResetPropagateTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedulingStrategy")]
        public virtual void ResetSchedulingStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceConnectConfiguration")]
        public virtual void ResetServiceConnectConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceRegistries")]
        public virtual void ResetServiceRegistries()
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

        [JsiiMethod(name: "resetTaskDefinition")]
        public virtual void ResetTaskDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTriggers")]
        public virtual void ResetTriggers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolumeConfiguration")]
        public virtual void ResetVolumeConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcLatticeConfigurations")]
        public virtual void ResetVpcLatticeConfigurations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitForSteadyState")]
        public virtual void ResetWaitForSteadyState()
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
        = GetStaticProperty<string>(typeof(aws.EcsService.EcsService))!;

        [JsiiProperty(name: "alarms", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceAlarmsOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceAlarmsOutputReference Alarms
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceAlarmsOutputReference>()!;
        }

        [JsiiProperty(name: "capacityProviderStrategy", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceCapacityProviderStrategyList\"}")]
        public virtual aws.EcsService.EcsServiceCapacityProviderStrategyList CapacityProviderStrategy
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceCapacityProviderStrategyList>()!;
        }

        [JsiiProperty(name: "deploymentCircuitBreaker", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentCircuitBreakerOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceDeploymentCircuitBreakerOutputReference DeploymentCircuitBreaker
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceDeploymentCircuitBreakerOutputReference>()!;
        }

        [JsiiProperty(name: "deploymentController", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentControllerOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceDeploymentControllerOutputReference DeploymentController
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceDeploymentControllerOutputReference>()!;
        }

        [JsiiProperty(name: "loadBalancer", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceLoadBalancerList\"}")]
        public virtual aws.EcsService.EcsServiceLoadBalancerList LoadBalancer
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceLoadBalancerList>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceNetworkConfigurationOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceNetworkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "orderedPlacementStrategy", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceOrderedPlacementStrategyList\"}")]
        public virtual aws.EcsService.EcsServiceOrderedPlacementStrategyList OrderedPlacementStrategy
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceOrderedPlacementStrategyList>()!;
        }

        [JsiiProperty(name: "placementConstraints", typeJson: "{\"fqn\":\"aws.ecsService.EcsServicePlacementConstraintsList\"}")]
        public virtual aws.EcsService.EcsServicePlacementConstraintsList PlacementConstraints
        {
            get => GetInstanceProperty<aws.EcsService.EcsServicePlacementConstraintsList>()!;
        }

        [JsiiProperty(name: "serviceConnectConfiguration", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceServiceConnectConfigurationOutputReference ServiceConnectConfiguration
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceServiceConnectConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "serviceRegistries", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceRegistriesOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceServiceRegistriesOutputReference ServiceRegistries
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceServiceRegistriesOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceTimeoutsOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "volumeConfiguration", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceVolumeConfigurationOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceVolumeConfigurationOutputReference VolumeConfiguration
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceVolumeConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "vpcLatticeConfigurations", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceVpcLatticeConfigurationsList\"}")]
        public virtual aws.EcsService.EcsServiceVpcLatticeConfigurationsList VpcLatticeConfigurations
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceVpcLatticeConfigurationsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alarmsInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceAlarms\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceAlarms? AlarmsInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceAlarms?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneRebalancingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityZoneRebalancingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityProviderStrategyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceCapacityProviderStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CapacityProviderStrategyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentCircuitBreakerInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentCircuitBreaker\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceDeploymentCircuitBreaker? DeploymentCircuitBreakerInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceDeploymentCircuitBreaker?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentControllerInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentController\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceDeploymentController? DeploymentControllerInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceDeploymentController?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentMaximumPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeploymentMaximumPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentMinimumHealthyPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeploymentMinimumHealthyPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DesiredCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableEcsManagedTagsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableEcsManagedTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableExecuteCommandInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableExecuteCommandInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDeleteInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceDeleteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceNewDeploymentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceNewDeploymentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckGracePeriodSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HealthCheckGracePeriodSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IamRoleInput
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
        [JsiiProperty(name: "launchTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LaunchTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceLoadBalancer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LoadBalancerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceNetworkConfiguration\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderedPlacementStrategyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceOrderedPlacementStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OrderedPlacementStrategyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementConstraintsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServicePlacementConstraints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PlacementConstraintsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlatformVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propagateTagsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PropagateTagsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedulingStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchedulingStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceConnectConfigurationInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfiguration\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceServiceConnectConfiguration? ServiceConnectConfigurationInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRegistriesInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceRegistries\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceServiceRegistries? ServiceRegistriesInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceRegistries?>();
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
        [JsiiProperty(name: "taskDefinitionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskDefinitionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.ecsService.EcsServiceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TriggersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeConfigurationInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceVolumeConfiguration\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceVolumeConfiguration? VolumeConfigurationInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceVolumeConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcLatticeConfigurationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceVpcLatticeConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VpcLatticeConfigurationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForSteadyStateInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WaitForSteadyStateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "availabilityZoneRebalancing", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZoneRebalancing
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cluster", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cluster
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentMaximumPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeploymentMaximumPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentMinimumHealthyPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeploymentMinimumHealthyPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "desiredCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableEcsManagedTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableEcsManagedTags
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

        [JsiiProperty(name: "enableExecuteCommand", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableExecuteCommand
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

        [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceDelete
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

        [JsiiProperty(name: "forceNewDeployment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceNewDeployment
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

        [JsiiProperty(name: "healthCheckGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckGracePeriodSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iamRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamRole
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

        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchType
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

        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PropagateTags
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schedulingStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchedulingStrategy
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

        [JsiiProperty(name: "taskDefinition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskDefinition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "triggers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Triggers
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitForSteadyState", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object WaitForSteadyState
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
