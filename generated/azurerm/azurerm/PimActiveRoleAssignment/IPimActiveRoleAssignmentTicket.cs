using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PimActiveRoleAssignment
{
    [JsiiInterface(nativeType: typeof(IPimActiveRoleAssignmentTicket), fullyQualifiedName: "azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentTicket")]
    public interface IPimActiveRoleAssignmentTicket
    {
        /// <summary>User-supplied ticket number to be included with the request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#number PimActiveRoleAssignment#number}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#system PimActiveRoleAssignment#system}
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

        [JsiiTypeProxy(nativeType: typeof(IPimActiveRoleAssignmentTicket), fullyQualifiedName: "azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentTicket")]
        internal sealed class _Proxy : DeputyBase, azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentTicket
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>User-supplied ticket number to be included with the request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#number PimActiveRoleAssignment#number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Number
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>User-supplied ticket system name to be included with the request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/pim_active_role_assignment#system PimActiveRoleAssignment#system}
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
