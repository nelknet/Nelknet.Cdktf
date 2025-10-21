using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DashboardGrafana
{
    [JsiiInterface(nativeType: typeof(IDashboardGrafanaAzureMonitorWorkspaceIntegrations), fullyQualifiedName: "azurerm.dashboardGrafana.DashboardGrafanaAzureMonitorWorkspaceIntegrations")]
    public interface IDashboardGrafanaAzureMonitorWorkspaceIntegrations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#resource_id DashboardGrafana#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDashboardGrafanaAzureMonitorWorkspaceIntegrations), fullyQualifiedName: "azurerm.dashboardGrafana.DashboardGrafanaAzureMonitorWorkspaceIntegrations")]
        internal sealed class _Proxy : DeputyBase, azurerm.DashboardGrafana.IDashboardGrafanaAzureMonitorWorkspaceIntegrations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#resource_id DashboardGrafana#resource_id}.</summary>
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
