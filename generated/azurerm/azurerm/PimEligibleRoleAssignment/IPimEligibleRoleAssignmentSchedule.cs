using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PimEligibleRoleAssignment
{
    [JsiiInterface(nativeType: typeof(IPimEligibleRoleAssignmentSchedule), fullyQualifiedName: "azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentSchedule")]
    public interface IPimEligibleRoleAssignmentSchedule
    {
        /// <summary>expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#expiration PimEligibleRoleAssignment#expiration}
        /// </remarks>
        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleExpiration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentScheduleExpiration? Expiration
        {
            get
            {
                return null;
            }
        }

        /// <summary>The start date/time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#start_date_time PimEligibleRoleAssignment#start_date_time}
        /// </remarks>
        [JsiiProperty(name: "startDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartDateTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPimEligibleRoleAssignmentSchedule), fullyQualifiedName: "azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentSchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>expiration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#expiration PimEligibleRoleAssignment#expiration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleExpiration\"}", isOptional: true)]
            public azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentScheduleExpiration? Expiration
            {
                get => GetInstanceProperty<azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentScheduleExpiration?>();
            }

            /// <summary>The start date/time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#start_date_time PimEligibleRoleAssignment#start_date_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartDateTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
