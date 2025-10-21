using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiClass(nativeType: typeof(aws.OpensearchDomain.OpensearchDomainClusterConfigOutputReference), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainClusterConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpensearchDomainClusterConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpensearchDomainClusterConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchDomainClusterConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchDomainClusterConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putColdStorageOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigColdStorageOptions\"}}]")]
        public virtual void PutColdStorageOptions(aws.OpensearchDomain.IOpensearchDomainClusterConfigColdStorageOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainClusterConfigColdStorageOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodeOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigNodeOptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNodeOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.OpensearchDomain.IOpensearchDomainClusterConfigNodeOptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.OpensearchDomain.IOpensearchDomainClusterConfigNodeOptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.OpensearchDomain.IOpensearchDomainClusterConfigNodeOptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putZoneAwarenessConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigZoneAwarenessConfig\"}}]")]
        public virtual void PutZoneAwarenessConfig(aws.OpensearchDomain.IOpensearchDomainClusterConfigZoneAwarenessConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainClusterConfigZoneAwarenessConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetColdStorageOptions")]
        public virtual void ResetColdStorageOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDedicatedMasterCount")]
        public virtual void ResetDedicatedMasterCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDedicatedMasterEnabled")]
        public virtual void ResetDedicatedMasterEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDedicatedMasterType")]
        public virtual void ResetDedicatedMasterType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceCount")]
        public virtual void ResetInstanceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceType")]
        public virtual void ResetInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMultiAzWithStandbyEnabled")]
        public virtual void ResetMultiAzWithStandbyEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeOptions")]
        public virtual void ResetNodeOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWarmCount")]
        public virtual void ResetWarmCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWarmEnabled")]
        public virtual void ResetWarmEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWarmType")]
        public virtual void ResetWarmType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZoneAwarenessConfig")]
        public virtual void ResetZoneAwarenessConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZoneAwarenessEnabled")]
        public virtual void ResetZoneAwarenessEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "coldStorageOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigColdStorageOptionsOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainClusterConfigColdStorageOptionsOutputReference ColdStorageOptions
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainClusterConfigColdStorageOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "nodeOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigNodeOptionsList\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainClusterConfigNodeOptionsList NodeOptions
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainClusterConfigNodeOptionsList>()!;
        }

        [JsiiProperty(name: "zoneAwarenessConfig", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigZoneAwarenessConfigOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainClusterConfigZoneAwarenessConfigOutputReference ZoneAwarenessConfig
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainClusterConfigZoneAwarenessConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "coldStorageOptionsInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigColdStorageOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainClusterConfigColdStorageOptions? ColdStorageOptionsInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainClusterConfigColdStorageOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DedicatedMasterCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DedicatedMasterEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DedicatedMasterTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstanceCountInput
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
        [JsiiProperty(name: "multiAzWithStandbyEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? MultiAzWithStandbyEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigNodeOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NodeOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "warmCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WarmCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "warmEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WarmEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "warmTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WarmTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneAwarenessConfigInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigZoneAwarenessConfig\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainClusterConfigZoneAwarenessConfig? ZoneAwarenessConfigInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainClusterConfigZoneAwarenessConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneAwarenessEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ZoneAwarenessEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "dedicatedMasterCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DedicatedMasterCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dedicatedMasterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DedicatedMasterEnabled
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

        [JsiiProperty(name: "dedicatedMasterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DedicatedMasterType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCount
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

        [JsiiProperty(name: "multiAzWithStandbyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object MultiAzWithStandbyEnabled
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

        [JsiiProperty(name: "warmCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WarmCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "warmEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object WarmEnabled
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

        [JsiiProperty(name: "warmType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WarmType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zoneAwarenessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ZoneAwarenessEnabled
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfig\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainClusterConfig? InternalValue
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainClusterConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
