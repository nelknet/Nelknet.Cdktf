using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMonitorActionGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMonitorActionGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupTimeouts")]
    public interface IDataAzurermMonitorActionGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_action_group#read DataAzurermMonitorActionGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMonitorActionGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMonitorActionGroup.IDataAzurermMonitorActionGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_action_group#read DataAzurermMonitorActionGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
