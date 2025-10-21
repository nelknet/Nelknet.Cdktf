using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PimEligibleRoleAssignment
{
    [JsiiInterface(nativeType: typeof(IPimEligibleRoleAssignmentScheduleExpiration), fullyQualifiedName: "azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleExpiration")]
    public interface IPimEligibleRoleAssignmentScheduleExpiration
    {
        /// <summary>The duration of the eligible role assignment in days.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#duration_days PimEligibleRoleAssignment#duration_days}
        /// </remarks>
        [JsiiProperty(name: "durationDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DurationDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>The duration of the eligible role assignment in hours.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#duration_hours PimEligibleRoleAssignment#duration_hours}
        /// </remarks>
        [JsiiProperty(name: "durationHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DurationHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>The end date/time of the eligible role assignment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#end_date_time PimEligibleRoleAssignment#end_date_time}
        /// </remarks>
        [JsiiProperty(name: "endDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndDateTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPimEligibleRoleAssignmentScheduleExpiration), fullyQualifiedName: "azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentScheduleExpiration")]
        internal sealed class _Proxy : DeputyBase, azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentScheduleExpiration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The duration of the eligible role assignment in days.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#duration_days PimEligibleRoleAssignment#duration_days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "durationDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DurationDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The duration of the eligible role assignment in hours.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#duration_hours PimEligibleRoleAssignment#duration_hours}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "durationHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DurationHours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The end date/time of the eligible role assignment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#end_date_time PimEligibleRoleAssignment#end_date_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndDateTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
