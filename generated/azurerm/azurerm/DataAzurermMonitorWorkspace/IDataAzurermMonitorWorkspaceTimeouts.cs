using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMonitorWorkspace
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMonitorWorkspaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermMonitorWorkspace.DataAzurermMonitorWorkspaceTimeouts")]
    public interface IDataAzurermMonitorWorkspaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_workspace#read DataAzurermMonitorWorkspace#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMonitorWorkspaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermMonitorWorkspace.DataAzurermMonitorWorkspaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMonitorWorkspace.IDataAzurermMonitorWorkspaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_workspace#read DataAzurermMonitorWorkspace#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
