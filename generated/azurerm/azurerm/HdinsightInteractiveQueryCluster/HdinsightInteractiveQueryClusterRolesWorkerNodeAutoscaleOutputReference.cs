using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightInteractiveQueryCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleOutputReference), fullyQualifiedName: "azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRecurrence", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence\"}}]")]
        public virtual void PutRecurrence(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRecurrence")]
        public virtual void ResetRecurrence()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "recurrence", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference\"}")]
        public virtual azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference Recurrence
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrenceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "recurrenceInput", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence\"}", isOptional: true)]
        public virtual azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence? RecurrenceInput
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscale\"}", isOptional: true)]
        public virtual azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscale? InternalValue
        {
            get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscale?>();
            set => SetInstanceProperty(value);
        }
    }
}
