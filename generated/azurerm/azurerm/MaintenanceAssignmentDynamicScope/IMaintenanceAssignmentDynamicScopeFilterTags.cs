using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MaintenanceAssignmentDynamicScope
{
    [JsiiInterface(nativeType: typeof(IMaintenanceAssignmentDynamicScopeFilterTags), fullyQualifiedName: "azurerm.maintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeFilterTags")]
    public interface IMaintenanceAssignmentDynamicScopeFilterTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dynamic_scope#tag MaintenanceAssignmentDynamicScope#tag}.</summary>
        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}")]
        string Tag
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dynamic_scope#values MaintenanceAssignmentDynamicScope#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMaintenanceAssignmentDynamicScopeFilterTags), fullyQualifiedName: "azurerm.maintenanceAssignmentDynamicScope.MaintenanceAssignmentDynamicScopeFilterTags")]
        internal sealed class _Proxy : DeputyBase, azurerm.MaintenanceAssignmentDynamicScope.IMaintenanceAssignmentDynamicScopeFilterTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dynamic_scope#tag MaintenanceAssignmentDynamicScope#tag}.</summary>
            [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}")]
            public string Tag
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_dynamic_scope#values MaintenanceAssignmentDynamicScope#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
