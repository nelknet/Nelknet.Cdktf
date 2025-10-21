using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiClass(nativeType: typeof(aws.LaunchTemplate.LaunchTemplateCapacityReservationSpecificationOutputReference), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateCapacityReservationSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LaunchTemplateCapacityReservationSpecificationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LaunchTemplateCapacityReservationSpecificationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LaunchTemplateCapacityReservationSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplateCapacityReservationSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCapacityReservationTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget\"}}]")]
        public virtual void PutCapacityReservationTarget(aws.LaunchTemplate.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget)}, new object[]{@value});
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

        [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateCapacityReservationSpecificationCapacityReservationTargetOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateCapacityReservationSpecificationCapacityReservationTargetOutputReference CapacityReservationTarget
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateCapacityReservationSpecificationCapacityReservationTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationPreferenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityReservationPreferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationTargetInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTargetInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget?>();
        }

        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationPreference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateCapacityReservationSpecification\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateCapacityReservationSpecification? InternalValue
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateCapacityReservationSpecification?>();
            set => SetInstanceProperty(value);
        }
    }
}
