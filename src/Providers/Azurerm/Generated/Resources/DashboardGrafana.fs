namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DashboardGrafana.DashboardGrafanaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana">azurerm_dashboard_grafana</a>.
    /// </summary>
    type DashboardGrafanaBuilder(logicalId: string) =
        member _.Yield(_: unit) : DashboardGrafanaState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DashboardGrafanaState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DashboardGrafanaState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DashboardGrafanaState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#grafana_major_version-1">DashboardGrafana#grafana_major_version</a>.
        /// </summary>
        [<CustomOperation "grafana_major_version">]
        member _.GrafanaMajorVersion(state: DashboardGrafanaState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : DashboardGrafanaState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GrafanaMajorVersion <- value)
            ({ assignments = state.assignments } : DashboardGrafanaState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#location-1">DashboardGrafana#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DashboardGrafanaState<'GrafanaMajorVersion, Missing, 'Name, 'ResourceGroupName>, value: string) : DashboardGrafanaState<'GrafanaMajorVersion, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DashboardGrafanaState<'GrafanaMajorVersion, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#name-1">DashboardGrafana#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, Missing, 'ResourceGroupName>, value: string) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#resource_group_name-1">DashboardGrafana#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, Missing>, value: string) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#api_key_enabled-1">DashboardGrafana#api_key_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "api_key_enabled">]
        member _.ApiKeyEnabled(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: bool) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiKeyEnabled <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#api_key_enabled-1">DashboardGrafana#api_key_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "api_key_enabled">]
        member _.ApiKeyEnabled(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiKeyEnabled <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#auto_generated_domain_name_label_scope-1">DashboardGrafana#auto_generated_domain_name_label_scope</a>.
        /// </summary>
        [<CustomOperation "auto_generated_domain_name_label_scope">]
        member _.AutoGeneratedDomainNameLabelScope(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: string) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoGeneratedDomainNameLabelScope <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// azure_monitor_workspace_integrations block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#azure_monitor_workspace_integrations-1">DashboardGrafana#azure_monitor_workspace_integrations</a> Accepts: azurerm.IResolvable | azurerm.DashboardGrafana.DashboardGrafanaAzureMonitorWorkspaceIntegrations[]
        /// </summary>
        [<CustomOperation "azure_monitor_workspace_integrations">]
        member _.AzureMonitorWorkspaceIntegrations(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AzureMonitorWorkspaceIntegrations <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#deterministic_outbound_ip_enabled-1">DashboardGrafana#deterministic_outbound_ip_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "deterministic_outbound_ip_enabled">]
        member _.DeterministicOutboundIpEnabled(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: bool) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DeterministicOutboundIpEnabled <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#deterministic_outbound_ip_enabled-1">DashboardGrafana#deterministic_outbound_ip_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "deterministic_outbound_ip_enabled">]
        member _.DeterministicOutboundIpEnabled(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DeterministicOutboundIpEnabled <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#id-1">DashboardGrafana#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: string) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#identity-1">DashboardGrafana#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.DashboardGrafana.DashboardGrafanaIdentity) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#public_network_access_enabled-1">DashboardGrafana#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: bool) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#public_network_access_enabled-1">DashboardGrafana#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#sku-1">DashboardGrafana#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: string) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Sku <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// smtp block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#smtp-1">DashboardGrafana#smtp</a>
        /// </summary>
        [<CustomOperation "smtp">]
        member _.Smtp(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.DashboardGrafana.DashboardGrafanaSmtp) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Smtp <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#tags-1">DashboardGrafana#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#timeouts-1">DashboardGrafana#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.DashboardGrafana.DashboardGrafanaTimeouts) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#zone_redundancy_enabled-1">DashboardGrafana#zone_redundancy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundancy_enabled">]
        member _.ZoneRedundancyEnabled(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: bool) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ZoneRedundancyEnabled <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#zone_redundancy_enabled-1">DashboardGrafana#zone_redundancy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundancy_enabled">]
        member _.ZoneRedundancyEnabled(state: DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ZoneRedundancyEnabled <- value)
            state : DashboardGrafanaState<'GrafanaMajorVersion, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: DashboardGrafanaState<Present, Present, Present, Present>) : azurerm.DashboardGrafana.DashboardGrafana =
            let config = azurerm.DashboardGrafana.DashboardGrafanaConfig()
            for setter in state.assignments do
                setter config
            azurerm.DashboardGrafana.DashboardGrafana(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dashboardGrafana: missing required arguments. Must call: grafana_major_version, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DashboardGrafanaState<_, _, _, _>) : azurerm.DashboardGrafana.DashboardGrafana =
            Unchecked.defaultof<azurerm.DashboardGrafana.DashboardGrafana>
