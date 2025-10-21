using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualDesktopApplicationGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermVirtualDesktopApplicationGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualDesktopApplicationGroup.DataAzurermVirtualDesktopApplicationGroupTimeouts")]
    public interface IDataAzurermVirtualDesktopApplicationGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_application_group#read DataAzurermVirtualDesktopApplicationGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermVirtualDesktopApplicationGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualDesktopApplicationGroup.DataAzurermVirtualDesktopApplicationGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermVirtualDesktopApplicationGroup.IDataAzurermVirtualDesktopApplicationGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_application_group#read DataAzurermVirtualDesktopApplicationGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
