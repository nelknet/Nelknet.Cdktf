using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PimEligibleRoleAssignment
{
    [JsiiByValue(fqn: "azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleExpiration")]
    public class PimEligibleRoleAssignmentScheduleExpiration : azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentScheduleExpiration
    {
        /// <summary>The duration of the eligible role assignment in days.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#duration_days PimEligibleRoleAssignment#duration_days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "durationDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DurationDays
        {
            get;
            set;
        }

        /// <summary>The duration of the eligible role assignment in hours.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#duration_hours PimEligibleRoleAssignment#duration_hours}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "durationHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DurationHours
        {
            get;
            set;
        }

        /// <summary>The end date/time of the eligible role assignment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#end_date_time PimEligibleRoleAssignment#end_date_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndDateTime
        {
            get;
            set;
        }
    }
}
