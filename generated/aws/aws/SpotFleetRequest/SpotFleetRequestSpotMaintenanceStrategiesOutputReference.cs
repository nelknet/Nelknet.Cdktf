using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotFleetRequest
{
    [JsiiClass(nativeType: typeof(aws.SpotFleetRequest.SpotFleetRequestSpotMaintenanceStrategiesOutputReference), fullyQualifiedName: "aws.spotFleetRequest.SpotFleetRequestSpotMaintenanceStrategiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SpotFleetRequestSpotMaintenanceStrategiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SpotFleetRequestSpotMaintenanceStrategiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SpotFleetRequestSpotMaintenanceStrategiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpotFleetRequestSpotMaintenanceStrategiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCapacityRebalance", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance\"}}]")]
        public virtual void PutCapacityRebalance(aws.SpotFleetRequest.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SpotFleetRequest.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapacityRebalance")]
        public virtual void ResetCapacityRebalance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "capacityRebalance", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalanceOutputReference\"}")]
        public virtual aws.SpotFleetRequest.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalanceOutputReference CapacityRebalance
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalanceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityRebalanceInput", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance\"}", isOptional: true)]
        public virtual aws.SpotFleetRequest.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance? CapacityRebalanceInput
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestSpotMaintenanceStrategies\"}", isOptional: true)]
        public virtual aws.SpotFleetRequest.ISpotFleetRequestSpotMaintenanceStrategies? InternalValue
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestSpotMaintenanceStrategies?>();
            set => SetInstanceProperty(value);
        }
    }
}
