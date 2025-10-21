using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    [JsiiClass(nativeType: typeof(azurerm.ContainerAppJob.ContainerAppJobScheduleTriggerConfigOutputReference), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobScheduleTriggerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerAppJobScheduleTriggerConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerAppJobScheduleTriggerConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ContainerAppJobScheduleTriggerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerAppJobScheduleTriggerConfigOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiOptional]
        [JsiiProperty(name: "cronExpressionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CronExpressionInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "cronExpression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CronExpression
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobScheduleTriggerConfig\"}", isOptional: true)]
        public virtual azurerm.ContainerAppJob.IContainerAppJobScheduleTriggerConfig? InternalValue
        {
            get => GetInstanceProperty<azurerm.ContainerAppJob.IContainerAppJobScheduleTriggerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
