using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevCenterProjectEnvironmentType
{
    [JsiiInterface(nativeType: typeof(IDevCenterProjectEnvironmentTypeUserRoleAssignment), fullyQualifiedName: "azurerm.devCenterProjectEnvironmentType.DevCenterProjectEnvironmentTypeUserRoleAssignment")]
    public interface IDevCenterProjectEnvironmentTypeUserRoleAssignment
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type#roles DevCenterProjectEnvironmentType#roles}.</summary>
        [JsiiProperty(name: "roles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Roles
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type#user_id DevCenterProjectEnvironmentType#user_id}.</summary>
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        string UserId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevCenterProjectEnvironmentTypeUserRoleAssignment), fullyQualifiedName: "azurerm.devCenterProjectEnvironmentType.DevCenterProjectEnvironmentTypeUserRoleAssignment")]
        internal sealed class _Proxy : DeputyBase, azurerm.DevCenterProjectEnvironmentType.IDevCenterProjectEnvironmentTypeUserRoleAssignment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type#roles DevCenterProjectEnvironmentType#roles}.</summary>
            [JsiiProperty(name: "roles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Roles
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type#user_id DevCenterProjectEnvironmentType#user_id}.</summary>
            [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
