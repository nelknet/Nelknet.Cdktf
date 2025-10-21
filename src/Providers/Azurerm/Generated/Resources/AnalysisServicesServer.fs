namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.AnalysisServicesServer.AnalysisServicesServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server">azurerm_analysis_services_server</a>.
    /// </summary>
    type AnalysisServicesServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : AnalysisServicesServerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AnalysisServicesServerState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AnalysisServicesServerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AnalysisServicesServerState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#location-1">AnalysisServicesServer#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AnalysisServicesServerState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : AnalysisServicesServerState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AnalysisServicesServerState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#name-1">AnalysisServicesServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AnalysisServicesServerState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : AnalysisServicesServerState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AnalysisServicesServerState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#resource_group_name-1">AnalysisServicesServer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AnalysisServicesServerState<'Location, 'Name, Missing, 'Sku>, value: string) : AnalysisServicesServerState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AnalysisServicesServerState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#sku-1">AnalysisServicesServer#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#admin_users-1">AnalysisServicesServer#admin_users</a>.
        /// </summary>
        [<CustomOperation "admin_users">]
        member _.AdminUsers(state: AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string>) : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AdminUsers <- (value |> Seq.toArray))
            state : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#backup_blob_container_uri-1">AnalysisServicesServer#backup_blob_container_uri</a>.
        /// </summary>
        [<CustomOperation "backup_blob_container_uri">]
        member _.BackupBlobContainerUri(state: AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.BackupBlobContainerUri <- value)
            state : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#id-1">AnalysisServicesServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// ipv4_firewall_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#ipv4_firewall_rule-1">AnalysisServicesServer#ipv4_firewall_rule</a> Accepts: azurerm.IResolvable | azurerm.AnalysisServicesServer.AnalysisServicesServerIpv4FirewallRule[]
        /// </summary>
        [<CustomOperation "ipv4_firewall_rule">]
        member _.Ipv4FirewallRule(state: AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Ipv4FirewallRule <- value)
            state : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#power_bi_service_enabled-1">AnalysisServicesServer#power_bi_service_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "power_bi_service_enabled">]
        member _.PowerBiServiceEnabled(state: AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PowerBiServiceEnabled <- value)
            state : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#power_bi_service_enabled-1">AnalysisServicesServer#power_bi_service_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "power_bi_service_enabled">]
        member _.PowerBiServiceEnabled(state: AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PowerBiServiceEnabled <- value)
            state : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#querypool_connection_mode-1">AnalysisServicesServer#querypool_connection_mode</a>.
        /// </summary>
        [<CustomOperation "querypool_connection_mode">]
        member _.QuerypoolConnectionMode(state: AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.QuerypoolConnectionMode <- value)
            state : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#tags-1">AnalysisServicesServer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#timeouts-1">AnalysisServicesServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.AnalysisServicesServer.AnalysisServicesServerTimeouts) : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AnalysisServicesServerState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: AnalysisServicesServerState<Present, Present, Present, Present>) : azurerm.AnalysisServicesServer.AnalysisServicesServer =
            let config = azurerm.AnalysisServicesServer.AnalysisServicesServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.AnalysisServicesServer.AnalysisServicesServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.analysisServicesServer: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: AnalysisServicesServerState<_, _, _, _>) : azurerm.AnalysisServicesServer.AnalysisServicesServer =
            Unchecked.defaultof<azurerm.AnalysisServicesServer.AnalysisServicesServer>
