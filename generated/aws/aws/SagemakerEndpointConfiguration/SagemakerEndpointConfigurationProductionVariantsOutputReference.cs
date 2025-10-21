using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    [JsiiClass(nativeType: typeof(aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsOutputReference), fullyQualifiedName: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerEndpointConfigurationProductionVariantsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SagemakerEndpointConfigurationProductionVariantsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointConfigurationProductionVariantsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointConfigurationProductionVariantsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCoreDumpConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsCoreDumpConfig\"}}]")]
        public virtual void PutCoreDumpConfig(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsCoreDumpConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsCoreDumpConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManagedInstanceScaling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsManagedInstanceScaling\"}}]")]
        public virtual void PutManagedInstanceScaling(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsManagedInstanceScaling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsManagedInstanceScaling)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoutingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsRoutingConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRoutingConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsRoutingConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsRoutingConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsRoutingConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServerlessConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsServerlessConfig\"}}]")]
        public virtual void PutServerlessConfig(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsServerlessConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsServerlessConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcceleratorType")]
        public virtual void ResetAcceleratorType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainerStartupHealthCheckTimeoutInSeconds")]
        public virtual void ResetContainerStartupHealthCheckTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoreDumpConfig")]
        public virtual void ResetCoreDumpConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableSsmAccess")]
        public virtual void ResetEnableSsmAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInferenceAmiVersion")]
        public virtual void ResetInferenceAmiVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialInstanceCount")]
        public virtual void ResetInitialInstanceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialVariantWeight")]
        public virtual void ResetInitialVariantWeight()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceType")]
        public virtual void ResetInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedInstanceScaling")]
        public virtual void ResetManagedInstanceScaling()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelDataDownloadTimeoutInSeconds")]
        public virtual void ResetModelDataDownloadTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingConfig")]
        public virtual void ResetRoutingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerlessConfig")]
        public virtual void ResetServerlessConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVariantName")]
        public virtual void ResetVariantName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolumeSizeInGb")]
        public virtual void ResetVolumeSizeInGb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "coreDumpConfig", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsCoreDumpConfigOutputReference\"}")]
        public virtual aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsCoreDumpConfigOutputReference CoreDumpConfig
        {
            get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsCoreDumpConfigOutputReference>()!;
        }

        [JsiiProperty(name: "managedInstanceScaling", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsManagedInstanceScalingOutputReference\"}")]
        public virtual aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsManagedInstanceScalingOutputReference ManagedInstanceScaling
        {
            get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsManagedInstanceScalingOutputReference>()!;
        }

        [JsiiProperty(name: "routingConfig", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsRoutingConfigList\"}")]
        public virtual aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsRoutingConfigList RoutingConfig
        {
            get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsRoutingConfigList>()!;
        }

        [JsiiProperty(name: "serverlessConfig", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsServerlessConfigOutputReference\"}")]
        public virtual aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsServerlessConfigOutputReference ServerlessConfig
        {
            get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsServerlessConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AcceleratorTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerStartupHealthCheckTimeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ContainerStartupHealthCheckTimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "coreDumpConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsCoreDumpConfig\"}", isOptional: true)]
        public virtual aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsCoreDumpConfig? CoreDumpConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsCoreDumpConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableSsmAccessInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableSsmAccessInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inferenceAmiVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InferenceAmiVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialInstanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InitialInstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialVariantWeightInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InitialVariantWeightInput
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
        [JsiiProperty(name: "managedInstanceScalingInput", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsManagedInstanceScaling\"}", isOptional: true)]
        public virtual aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsManagedInstanceScaling? ManagedInstanceScalingInput
        {
            get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsManagedInstanceScaling?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelDataDownloadTimeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ModelDataDownloadTimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsRoutingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RoutingConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverlessConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsServerlessConfig\"}", isOptional: true)]
        public virtual aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsServerlessConfig? ServerlessConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsServerlessConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "variantNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VariantNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeSizeInGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VolumeSizeInGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "acceleratorType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcceleratorType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "containerStartupHealthCheckTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ContainerStartupHealthCheckTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableSsmAccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableSsmAccess
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

        [JsiiProperty(name: "inferenceAmiVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InferenceAmiVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialInstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialVariantWeight", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialVariantWeight
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

        [JsiiProperty(name: "modelDataDownloadTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ModelDataDownloadTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "variantName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VariantName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VolumeSizeInGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariants\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariants cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariants).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
