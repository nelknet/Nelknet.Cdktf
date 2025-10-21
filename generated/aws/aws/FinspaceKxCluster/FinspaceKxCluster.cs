using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster aws_finspace_kx_cluster}.</summary>
    [JsiiClass(nativeType: typeof(aws.FinspaceKxCluster.FinspaceKxCluster), fullyQualifiedName: "aws.finspaceKxCluster.FinspaceKxCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterConfig\"}}]")]
    public class FinspaceKxCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster aws_finspace_kx_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FinspaceKxCluster(Constructs.Construct scope, string id, aws.FinspaceKxCluster.IFinspaceKxClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.FinspaceKxCluster.IFinspaceKxClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FinspaceKxCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FinspaceKxCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a FinspaceKxCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the FinspaceKxCluster to import.</param>
        /// <param name="importFromId">The id of the existing FinspaceKxCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the FinspaceKxCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the FinspaceKxCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing FinspaceKxCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the FinspaceKxCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.FinspaceKxCluster.FinspaceKxCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutoScalingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterAutoScalingConfiguration\"}}]")]
        public virtual void PutAutoScalingConfiguration(aws.FinspaceKxCluster.IFinspaceKxClusterAutoScalingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FinspaceKxCluster.IFinspaceKxClusterAutoScalingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCacheStorageConfigurations", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterCacheStorageConfigurations\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCacheStorageConfigurations(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.FinspaceKxCluster.IFinspaceKxClusterCacheStorageConfigurations[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FinspaceKxCluster.IFinspaceKxClusterCacheStorageConfigurations).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FinspaceKxCluster.IFinspaceKxClusterCacheStorageConfigurations).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCapacityConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterCapacityConfiguration\"}}]")]
        public virtual void PutCapacityConfiguration(aws.FinspaceKxCluster.IFinspaceKxClusterCapacityConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FinspaceKxCluster.IFinspaceKxClusterCapacityConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterCode\"}}]")]
        public virtual void PutCode(aws.FinspaceKxCluster.IFinspaceKxClusterCode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FinspaceKxCluster.IFinspaceKxClusterCode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatabase", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterDatabase\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDatabase(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.FinspaceKxCluster.IFinspaceKxClusterDatabase[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FinspaceKxCluster.IFinspaceKxClusterDatabase).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FinspaceKxCluster.IFinspaceKxClusterDatabase).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSavedownStorageConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterSavedownStorageConfiguration\"}}]")]
        public virtual void PutSavedownStorageConfiguration(aws.FinspaceKxCluster.IFinspaceKxClusterSavedownStorageConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FinspaceKxCluster.IFinspaceKxClusterSavedownStorageConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScalingGroupConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterScalingGroupConfiguration\"}}]")]
        public virtual void PutScalingGroupConfiguration(aws.FinspaceKxCluster.IFinspaceKxClusterScalingGroupConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FinspaceKxCluster.IFinspaceKxClusterScalingGroupConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTickerplantLogConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterTickerplantLogConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTickerplantLogConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.FinspaceKxCluster.IFinspaceKxClusterTickerplantLogConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FinspaceKxCluster.IFinspaceKxClusterTickerplantLogConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FinspaceKxCluster.IFinspaceKxClusterTickerplantLogConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.FinspaceKxCluster.IFinspaceKxClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FinspaceKxCluster.IFinspaceKxClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterVpcConfiguration\"}}]")]
        public virtual void PutVpcConfiguration(aws.FinspaceKxCluster.IFinspaceKxClusterVpcConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FinspaceKxCluster.IFinspaceKxClusterVpcConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoScalingConfiguration")]
        public virtual void ResetAutoScalingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityZoneId")]
        public virtual void ResetAvailabilityZoneId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCacheStorageConfigurations")]
        public virtual void ResetCacheStorageConfigurations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityConfiguration")]
        public virtual void ResetCapacityConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCode")]
        public virtual void ResetCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCommandLineArguments")]
        public virtual void ResetCommandLineArguments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabase")]
        public virtual void ResetDatabase()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutionRole")]
        public virtual void ResetExecutionRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitializationScript")]
        public virtual void ResetInitializationScript()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSavedownStorageConfiguration")]
        public virtual void ResetSavedownStorageConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScalingGroupConfiguration")]
        public virtual void ResetScalingGroupConfiguration()
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

        [JsiiMethod(name: "resetTickerplantLogConfiguration")]
        public virtual void ResetTickerplantLogConfiguration()
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
        = GetStaticProperty<string>(typeof(aws.FinspaceKxCluster.FinspaceKxCluster))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoScalingConfiguration", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterAutoScalingConfigurationOutputReference\"}")]
        public virtual aws.FinspaceKxCluster.FinspaceKxClusterAutoScalingConfigurationOutputReference AutoScalingConfiguration
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.FinspaceKxClusterAutoScalingConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "cacheStorageConfigurations", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterCacheStorageConfigurationsList\"}")]
        public virtual aws.FinspaceKxCluster.FinspaceKxClusterCacheStorageConfigurationsList CacheStorageConfigurations
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.FinspaceKxClusterCacheStorageConfigurationsList>()!;
        }

        [JsiiProperty(name: "capacityConfiguration", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterCapacityConfigurationOutputReference\"}")]
        public virtual aws.FinspaceKxCluster.FinspaceKxClusterCapacityConfigurationOutputReference CapacityConfiguration
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.FinspaceKxClusterCapacityConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "code", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterCodeOutputReference\"}")]
        public virtual aws.FinspaceKxCluster.FinspaceKxClusterCodeOutputReference Code
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.FinspaceKxClusterCodeOutputReference>()!;
        }

        [JsiiProperty(name: "createdTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedTimestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterDatabaseList\"}")]
        public virtual aws.FinspaceKxCluster.FinspaceKxClusterDatabaseList Database
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.FinspaceKxClusterDatabaseList>()!;
        }

        [JsiiProperty(name: "lastModifiedTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModifiedTimestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "savedownStorageConfiguration", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterSavedownStorageConfigurationOutputReference\"}")]
        public virtual aws.FinspaceKxCluster.FinspaceKxClusterSavedownStorageConfigurationOutputReference SavedownStorageConfiguration
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.FinspaceKxClusterSavedownStorageConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "scalingGroupConfiguration", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterScalingGroupConfigurationOutputReference\"}")]
        public virtual aws.FinspaceKxCluster.FinspaceKxClusterScalingGroupConfigurationOutputReference ScalingGroupConfiguration
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.FinspaceKxClusterScalingGroupConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tickerplantLogConfiguration", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterTickerplantLogConfigurationList\"}")]
        public virtual aws.FinspaceKxCluster.FinspaceKxClusterTickerplantLogConfigurationList TickerplantLogConfiguration
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.FinspaceKxClusterTickerplantLogConfigurationList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterTimeoutsOutputReference\"}")]
        public virtual aws.FinspaceKxCluster.FinspaceKxClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.FinspaceKxClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcConfiguration", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterVpcConfigurationOutputReference\"}")]
        public virtual aws.FinspaceKxCluster.FinspaceKxClusterVpcConfigurationOutputReference VpcConfiguration
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.FinspaceKxClusterVpcConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScalingConfigurationInput", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterAutoScalingConfiguration\"}", isOptional: true)]
        public virtual aws.FinspaceKxCluster.IFinspaceKxClusterAutoScalingConfiguration? AutoScalingConfigurationInput
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.IFinspaceKxClusterAutoScalingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AzModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheStorageConfigurationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterCacheStorageConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CacheStorageConfigurationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityConfigurationInput", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterCapacityConfiguration\"}", isOptional: true)]
        public virtual aws.FinspaceKxCluster.IFinspaceKxClusterCapacityConfiguration? CapacityConfigurationInput
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.IFinspaceKxClusterCapacityConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeInput", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterCode\"}", isOptional: true)]
        public virtual aws.FinspaceKxCluster.IFinspaceKxClusterCode? CodeInput
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.IFinspaceKxClusterCode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commandLineArgumentsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? CommandLineArgumentsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterDatabase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DatabaseInput
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
        [JsiiProperty(name: "environmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnvironmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleInput
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
        [JsiiProperty(name: "initializationScriptInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InitializationScriptInput
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
        [JsiiProperty(name: "releaseLabelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReleaseLabelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "savedownStorageConfigurationInput", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterSavedownStorageConfiguration\"}", isOptional: true)]
        public virtual aws.FinspaceKxCluster.IFinspaceKxClusterSavedownStorageConfiguration? SavedownStorageConfigurationInput
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.IFinspaceKxClusterSavedownStorageConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalingGroupConfigurationInput", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterScalingGroupConfiguration\"}", isOptional: true)]
        public virtual aws.FinspaceKxCluster.IFinspaceKxClusterScalingGroupConfiguration? ScalingGroupConfigurationInput
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.IFinspaceKxClusterScalingGroupConfiguration?>();
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
        [JsiiProperty(name: "tickerplantLogConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterTickerplantLogConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TickerplantLogConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigurationInput", typeJson: "{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterVpcConfiguration\"}", isOptional: true)]
        public virtual aws.FinspaceKxCluster.IFinspaceKxClusterVpcConfiguration? VpcConfigurationInput
        {
            get => GetInstanceProperty<aws.FinspaceKxCluster.IFinspaceKxClusterVpcConfiguration?>();
        }

        [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "azMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "commandLineArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> CommandLineArguments
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRole
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

        [JsiiProperty(name: "initializationScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitializationScript
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
