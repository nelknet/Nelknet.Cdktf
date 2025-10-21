using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    [JsiiClass(nativeType: typeof(azurerm.ContainerAppJob.ContainerAppJobEventTriggerConfigOutputReference), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobEventTriggerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerAppJobEventTriggerConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerAppJobEventTriggerConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ContainerAppJobEventTriggerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerAppJobEventTriggerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putScale", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScale\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutScale(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScale[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScale).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScale).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetParallelism")]
        public virtual void ResetParallelism()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicaCompletionCount")]
        public virtual void ResetReplicaCompletionCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScale")]
        public virtual void ResetScale()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "scale", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScaleList\"}")]
        public virtual azurerm.ContainerAppJob.ContainerAppJobEventTriggerConfigScaleList Scale
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.ContainerAppJobEventTriggerConfigScaleList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "parallelismInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ParallelismInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicaCompletionCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReplicaCompletionCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScale\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ScaleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "parallelism", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Parallelism
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicaCompletionCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicaCompletionCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfig\"}", isOptional: true)]
        public virtual azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfig? InternalValue
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
