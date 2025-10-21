using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PimActiveRoleAssignment
{
    [JsiiByValue(fqn: "azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentScheduleExpiration")]
    public class PimActiveRoleAssignmentScheduleExpiration : azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentScheduleExpiration
    {
        /// <summary>The duration of the role assignment in days.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#duration_days PimActiveRoleAssignment#duration_days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "durationDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DurationDays
        {
            get;
            set;
        }

        /// <summary>The duration of the role assignment in hours.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#duration_hours PimActiveRoleAssignment#duration_hours}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "durationHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DurationHours
        {
            get;
            set;
        }

        /// <summary>The end date/time of the role assignment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#end_date_time PimActiveRoleAssignment#end_date_time}
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
