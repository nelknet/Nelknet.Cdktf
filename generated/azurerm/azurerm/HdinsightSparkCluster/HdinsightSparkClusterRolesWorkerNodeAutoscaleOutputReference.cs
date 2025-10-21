using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleOutputReference), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HdinsightSparkClusterRolesWorkerNodeAutoscaleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HdinsightSparkClusterRolesWorkerNodeAutoscaleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HdinsightSparkClusterRolesWorkerNodeAutoscaleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightSparkClusterRolesWorkerNodeAutoscaleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCapacity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleCapacity\"}}]")]
        public virtual void PutCapacity(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscaleCapacity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscaleCapacity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRecurrence", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrence\"}}]")]
        public virtual void PutRecurrence(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrence @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrence)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapacity")]
        public virtual void ResetCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecurrence")]
        public virtual void ResetRecurrence()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "capacity", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleCapacityOutputReference\"}")]
        public virtual azurerm.HdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleCapacityOutputReference Capacity
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleCapacityOutputReference>()!;
        }

        [JsiiProperty(name: "recurrence", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference\"}")]
        public virtual azurerm.HdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference Recurrence
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityInput", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleCapacity\"}", isOptional: true)]
        public virtual azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscaleCapacity? CapacityInput
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscaleCapacity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recurrenceInput", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrence\"}", isOptional: true)]
        public virtual azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrence? RecurrenceInput
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrence?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscale\"}", isOptional: true)]
        public virtual azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscale? InternalValue
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscale?>();
            set => SetInstanceProperty(value);
        }
    }
}
