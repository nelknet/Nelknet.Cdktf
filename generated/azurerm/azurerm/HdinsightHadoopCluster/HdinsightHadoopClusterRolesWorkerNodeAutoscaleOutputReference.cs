using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleOutputReference), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HdinsightHadoopClusterRolesWorkerNodeAutoscaleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HdinsightHadoopClusterRolesWorkerNodeAutoscaleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HdinsightHadoopClusterRolesWorkerNodeAutoscaleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightHadoopClusterRolesWorkerNodeAutoscaleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCapacity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity\"}}]")]
        public virtual void PutCapacity(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRecurrence", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrence\"}}]")]
        public virtual void PutRecurrence(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrence @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrence)}, new object[]{@value});
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

        [JsiiProperty(name: "capacity", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacityOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacityOutputReference Capacity
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacityOutputReference>()!;
        }

        [JsiiProperty(name: "recurrence", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference Recurrence
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity? CapacityInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recurrenceInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrence\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrence? RecurrenceInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleRecurrence?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscale\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscale? InternalValue
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscale?>();
            set => SetInstanceProperty(value);
        }
    }
}
