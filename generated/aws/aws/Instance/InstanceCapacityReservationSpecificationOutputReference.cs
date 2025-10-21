using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    [JsiiClass(nativeType: typeof(aws.Instance.InstanceCapacityReservationSpecificationOutputReference), fullyQualifiedName: "aws.instance.InstanceCapacityReservationSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InstanceCapacityReservationSpecificationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InstanceCapacityReservationSpecificationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InstanceCapacityReservationSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InstanceCapacityReservationSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCapacityReservationTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.instance.InstanceCapacityReservationSpecificationCapacityReservationTarget\"}}]")]
        public virtual void PutCapacityReservationTarget(aws.Instance.IInstanceCapacityReservationSpecificationCapacityReservationTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Instance.IInstanceCapacityReservationSpecificationCapacityReservationTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapacityReservationPreference")]
        public virtual void ResetCapacityReservationPreference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityReservationTarget")]
        public virtual void ResetCapacityReservationTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"fqn\":\"aws.instance.InstanceCapacityReservationSpecificationCapacityReservationTargetOutputReference\"}")]
        public virtual aws.Instance.InstanceCapacityReservationSpecificationCapacityReservationTargetOutputReference CapacityReservationTarget
        {
            get => GetInstanceProperty<aws.Instance.InstanceCapacityReservationSpecificationCapacityReservationTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationPreferenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityReservationPreferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationTargetInput", typeJson: "{\"fqn\":\"aws.instance.InstanceCapacityReservationSpecificationCapacityReservationTarget\"}", isOptional: true)]
        public virtual aws.Instance.IInstanceCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTargetInput
        {
            get => GetInstanceProperty<aws.Instance.IInstanceCapacityReservationSpecificationCapacityReservationTarget?>();
        }

        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationPreference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.instance.InstanceCapacityReservationSpecification\"}", isOptional: true)]
        public virtual aws.Instance.IInstanceCapacityReservationSpecification? InternalValue
        {
            get => GetInstanceProperty<aws.Instance.IInstanceCapacityReservationSpecification?>();
            set => SetInstanceProperty(value);
        }
    }
}
