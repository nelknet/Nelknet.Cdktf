using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PimEligibleRoleAssignment
{
    [JsiiByValue(fqn: "azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentSchedule")]
    public class PimEligibleRoleAssignmentSchedule : azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentSchedule
    {
        /// <summary>expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#expiration PimEligibleRoleAssignment#expiration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleExpiration\"}", isOptional: true)]
        public azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentScheduleExpiration? Expiration
        {
            get;
            set;
        }

        /// <summary>The start date/time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#start_date_time PimEligibleRoleAssignment#start_date_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartDateTime
        {
            get;
            set;
        }
    }
}
