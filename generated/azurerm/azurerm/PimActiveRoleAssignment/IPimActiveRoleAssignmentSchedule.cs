using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PimActiveRoleAssignment
{
    [JsiiInterface(nativeType: typeof(IPimActiveRoleAssignmentSchedule), fullyQualifiedName: "azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentSchedule")]
    public interface IPimActiveRoleAssignmentSchedule
    {
        /// <summary>expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#expiration PimActiveRoleAssignment#expiration}
        /// </remarks>
        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentScheduleExpiration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentScheduleExpiration? Expiration
        {
            get
            {
                return null;
            }
        }

        /// <summary>The start date/time of the role assignment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#start_date_time PimActiveRoleAssignment#start_date_time}
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

        [JsiiTypeProxy(nativeType: typeof(IPimActiveRoleAssignmentSchedule), fullyQualifiedName: "azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentSchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>expiration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#expiration PimActiveRoleAssignment#expiration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentScheduleExpiration\"}", isOptional: true)]
            public azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentScheduleExpiration? Expiration
            {
                get => GetInstanceProperty<azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentScheduleExpiration?>();
            }

            /// <summary>The start date/time of the role assignment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#start_date_time PimActiveRoleAssignment#start_date_time}
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
