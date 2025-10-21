using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PimEligibleRoleAssignment
{
    [JsiiInterface(nativeType: typeof(IPimEligibleRoleAssignmentTicket), fullyQualifiedName: "azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentTicket")]
    public interface IPimEligibleRoleAssignmentTicket
    {
        /// <summary>User-supplied ticket number to be included with the request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#number PimEligibleRoleAssignment#number}
        /// </remarks>
        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Number
        {
            get
            {
                return null;
            }
        }

        /// <summary>User-supplied ticket system name to be included with the request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#system PimEligibleRoleAssignment#system}
        /// </remarks>
        [JsiiProperty(name: "systemAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SystemAttribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPimEligibleRoleAssignmentTicket), fullyQualifiedName: "azurerm.pimEligibleRoleAssignment.PimEligibleRoleAssignmentTicket")]
        internal sealed class _Proxy : DeputyBase, azurerm.PimEligibleRoleAssignment.IPimEligibleRoleAssignmentTicket
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>User-supplied ticket number to be included with the request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#number PimEligibleRoleAssignment#number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Number
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>User-supplied ticket system name to be included with the request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_eligible_role_assignment#system PimEligibleRoleAssignment#system}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "systemAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SystemAttribute
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
