using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PimActiveRoleAssignment
{
    [JsiiByValue(fqn: "azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentSchedule")]
    public class PimActiveRoleAssignmentSchedule : azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentSchedule
    {
        /// <summary>expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#expiration PimActiveRoleAssignment#expiration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentScheduleExpiration\"}", isOptional: true)]
        public azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentScheduleExpiration? Expiration
        {
            get;
            set;
        }

        /// <summary>The start date/time of the role assignment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#start_date_time PimActiveRoleAssignment#start_date_time}
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
