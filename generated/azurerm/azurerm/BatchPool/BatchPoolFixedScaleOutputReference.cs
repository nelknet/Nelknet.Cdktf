using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiClass(nativeType: typeof(azurerm.BatchPool.BatchPoolFixedScaleOutputReference), fullyQualifiedName: "azurerm.batchPool.BatchPoolFixedScaleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BatchPoolFixedScaleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BatchPoolFixedScaleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BatchPoolFixedScaleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchPoolFixedScaleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetNodeDeallocationMethod")]
        public virtual void ResetNodeDeallocationMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResizeTimeout")]
        public virtual void ResetResizeTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetDedicatedNodes")]
        public virtual void ResetTargetDedicatedNodes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetLowPriorityNodes")]
        public virtual void ResetTargetLowPriorityNodes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeDeallocationMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeDeallocationMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resizeTimeoutInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResizeTimeoutInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetDedicatedNodesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetDedicatedNodesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetLowPriorityNodesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetLowPriorityNodesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "nodeDeallocationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeDeallocationMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resizeTimeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResizeTimeout
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetDedicatedNodes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetDedicatedNodes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetLowPriorityNodes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetLowPriorityNodes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolFixedScale\"}", isOptional: true)]
        public virtual azurerm.BatchPool.IBatchPoolFixedScale? InternalValue
        {
            get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolFixedScale?>();
            set => SetInstanceProperty(value);
        }
    }
}
