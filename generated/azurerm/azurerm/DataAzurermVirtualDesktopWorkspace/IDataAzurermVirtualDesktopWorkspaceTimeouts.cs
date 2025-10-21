using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualDesktopWorkspace
{
    [JsiiInterface(nativeType: typeof(IDataAzurermVirtualDesktopWorkspaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualDesktopWorkspace.DataAzurermVirtualDesktopWorkspaceTimeouts")]
    public interface IDataAzurermVirtualDesktopWorkspaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_workspace#read DataAzurermVirtualDesktopWorkspace#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermVirtualDesktopWorkspaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualDesktopWorkspace.DataAzurermVirtualDesktopWorkspaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermVirtualDesktopWorkspace.IDataAzurermVirtualDesktopWorkspaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_workspace#read DataAzurermVirtualDesktopWorkspace#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
