using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiClass(nativeType: typeof(azurerm.BatchPool.BatchPoolStartTaskOutputReference), fullyQualifiedName: "azurerm.batchPool.BatchPoolStartTaskOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BatchPoolStartTaskOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BatchPoolStartTaskOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BatchPoolStartTaskOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchPoolStartTaskOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContainer", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskContainer\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutContainer(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.BatchPool.IBatchPoolStartTaskContainer[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolStartTaskContainer).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolStartTaskContainer).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskResourceFile\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceFile(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.BatchPool.IBatchPoolStartTaskResourceFile[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolStartTaskResourceFile).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolStartTaskResourceFile).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskUserIdentity\"}}]")]
        public virtual void PutUserIdentity(azurerm.BatchPool.IBatchPoolStartTaskUserIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BatchPool.IBatchPoolStartTaskUserIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCommonEnvironmentProperties")]
        public virtual void ResetCommonEnvironmentProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainer")]
        public virtual void ResetContainer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceFile")]
        public virtual void ResetResourceFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskRetryMaximum")]
        public virtual void ResetTaskRetryMaximum()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitForSuccess")]
        public virtual void ResetWaitForSuccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "container", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskContainerList\"}")]
        public virtual azurerm.BatchPool.BatchPoolStartTaskContainerList Container
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolStartTaskContainerList>()!;
        }

        [JsiiProperty(name: "resourceFile", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskResourceFileList\"}")]
        public virtual azurerm.BatchPool.BatchPoolStartTaskResourceFileList ResourceFile
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolStartTaskResourceFileList>()!;
        }

        [JsiiProperty(name: "userIdentity", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskUserIdentityOutputReference\"}")]
        public virtual azurerm.BatchPool.BatchPoolStartTaskUserIdentityOutputReference UserIdentity
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolStartTaskUserIdentityOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "commandLineInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommandLineInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commonEnvironmentPropertiesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? CommonEnvironmentPropertiesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskContainer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ContainerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceFileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskResourceFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceFileInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskRetryMaximumInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TaskRetryMaximumInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userIdentityInput", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskUserIdentity\"}", isOptional: true)]
        public virtual azurerm.BatchPool.IBatchPoolStartTaskUserIdentity? UserIdentityInput
        {
            get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolStartTaskUserIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForSuccessInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WaitForSuccessInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "commandLine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommandLine
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "commonEnvironmentProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> CommonEnvironmentProperties
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskRetryMaximum", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TaskRetryMaximum
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitForSuccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object WaitForSuccess
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTask\"}", isOptional: true)]
        public virtual azurerm.BatchPool.IBatchPoolStartTask? InternalValue
        {
            get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolStartTask?>();
            set => SetInstanceProperty(value);
        }
    }
}
