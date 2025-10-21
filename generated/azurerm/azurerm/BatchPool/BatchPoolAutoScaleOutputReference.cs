using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiClass(nativeType: typeof(azurerm.BatchPool.BatchPoolAutoScaleOutputReference), fullyQualifiedName: "azurerm.batchPool.BatchPoolAutoScaleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BatchPoolAutoScaleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BatchPoolAutoScaleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BatchPoolAutoScaleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchPoolAutoScaleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEvaluationInterval")]
        public virtual void ResetEvaluationInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "evaluationIntervalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EvaluationIntervalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "formulaInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FormulaInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "evaluationInterval", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EvaluationInterval
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "formula", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Formula
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolAutoScale\"}", isOptional: true)]
        public virtual azurerm.BatchPool.IBatchPoolAutoScale? InternalValue
        {
            get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolAutoScale?>();
            set => SetInstanceProperty(value);
        }
    }
}
