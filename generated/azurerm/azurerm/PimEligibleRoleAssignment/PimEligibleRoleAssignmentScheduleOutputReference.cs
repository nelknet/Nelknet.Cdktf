using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PimEligibleRoleAssignment
{
    [JsiiClass(nativeType: typeof(azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleOutputReference), fullyQualifiedName: "azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PimEligibleRoleAssignmentScheduleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PimEligibleRoleAssignmentScheduleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PimEligibleRoleAssignmentScheduleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PimEligibleRoleAssignmentScheduleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExpiration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleExpiration\"}}]")]
        public virtual void PutExpiration(azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentScheduleExpiration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentScheduleExpiration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExpiration")]
        public virtual void ResetExpiration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartDateTime")]
        public virtual void ResetStartDateTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleExpirationOutputReference\"}")]
        public virtual azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleExpirationOutputReference Expiration
        {
            get => GetInstanceProperty<azurerm.PimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleExpirationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "expirationInput", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleExpiration\"}", isOptional: true)]
        public virtual azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentScheduleExpiration? ExpirationInput
        {
            get => GetInstanceProperty<azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentScheduleExpiration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startDateTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartDateTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "startDateTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartDateTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentSchedule\"}", isOptional: true)]
        public virtual azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentSchedule? InternalValue
        {
            get => GetInstanceProperty<azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentSchedule?>();
            set => SetInstanceProperty(value);
        }
    }
}
