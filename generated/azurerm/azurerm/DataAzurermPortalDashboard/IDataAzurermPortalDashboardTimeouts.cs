using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPortalDashboard
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPortalDashboardTimeouts), fullyQualifiedName: "azurerm.dataAzurermPortalDashboard.DataAzurermPortalDashboardTimeouts")]
    public interface IDataAzurermPortalDashboardTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/portal_dashboard#read DataAzurermPortalDashboard#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPortalDashboardTimeouts), fullyQualifiedName: "azurerm.dataAzurermPortalDashboard.DataAzurermPortalDashboardTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPortalDashboard.IDataAzurermPortalDashboardTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/portal_dashboard#read DataAzurermPortalDashboard#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
