using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDashboardGrafana
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDashboardGrafanaTimeouts), fullyQualifiedName: "azurerm.dataAzurermDashboardGrafana.DataAzurermDashboardGrafanaTimeouts")]
    public interface IDataAzurermDashboardGrafanaTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dashboard_grafana#read DataAzurermDashboardGrafana#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDashboardGrafanaTimeouts), fullyQualifiedName: "azurerm.dataAzurermDashboardGrafana.DataAzurermDashboardGrafanaTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDashboardGrafana.IDataAzurermDashboardGrafanaTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dashboard_grafana#read DataAzurermDashboardGrafana#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
