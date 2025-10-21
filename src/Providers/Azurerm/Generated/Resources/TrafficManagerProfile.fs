namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod> = { assignments: ResizeArray<azurerm.TrafficManagerProfile.TrafficManagerProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile">azurerm_traffic_manager_profile</a>.
    /// </summary>
    type TrafficManagerProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : TrafficManagerProfileState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TrafficManagerProfileState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : TrafficManagerProfileState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TrafficManagerProfileState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// dns_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#dns_config-1">TrafficManagerProfile#dns_config</a>
        /// </summary>
        [<CustomOperation "dns_config">]
        member _.DnsConfig(state: TrafficManagerProfileState<Missing, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>, value: azurerm.TrafficManagerProfile.TrafficManagerProfileDnsConfig) : TrafficManagerProfileState<Present, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod> =
            state.assignments.Add(fun config -> config.DnsConfig <- value)
            ({ assignments = state.assignments } : TrafficManagerProfileState<Present, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>)

        /// <summary>
        /// monitor_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#monitor_config-1">TrafficManagerProfile#monitor_config</a>
        /// </summary>
        [<CustomOperation "monitor_config">]
        member _.MonitorConfig(state: TrafficManagerProfileState<'DnsConfig, Missing, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>, value: azurerm.TrafficManagerProfile.TrafficManagerProfileMonitorConfig) : TrafficManagerProfileState<'DnsConfig, Present, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod> =
            state.assignments.Add(fun config -> config.MonitorConfig <- value)
            ({ assignments = state.assignments } : TrafficManagerProfileState<'DnsConfig, Present, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#name-1">TrafficManagerProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, Missing, 'ResourceGroupName, 'TrafficRoutingMethod>, value: string) : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, Present, 'ResourceGroupName, 'TrafficRoutingMethod> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, Present, 'ResourceGroupName, 'TrafficRoutingMethod>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#resource_group_name-1">TrafficManagerProfile#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, Missing, 'TrafficRoutingMethod>, value: string) : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, Present, 'TrafficRoutingMethod> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, Present, 'TrafficRoutingMethod>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#traffic_routing_method-1">TrafficManagerProfile#traffic_routing_method</a>.
        /// </summary>
        [<CustomOperation "traffic_routing_method">]
        member _.TrafficRoutingMethod(state: TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, Missing>, value: string) : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.TrafficRoutingMethod <- value)
            ({ assignments = state.assignments } : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#id-1">TrafficManagerProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>, value: string) : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#max_return-1">TrafficManagerProfile#max_return</a>.
        /// </summary>
        [<CustomOperation "max_return">]
        member _.MaxReturn(state: TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>, value: double) : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod> =
            state.assignments.Add(fun config -> config.MaxReturn <- value)
            state : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#profile_status-1">TrafficManagerProfile#profile_status</a>.
        /// </summary>
        [<CustomOperation "profile_status">]
        member _.ProfileStatus(state: TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>, value: string) : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod> =
            state.assignments.Add(fun config -> config.ProfileStatus <- value)
            state : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#tags-1">TrafficManagerProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>, value: seq<string * string>) : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#timeouts-1">TrafficManagerProfile#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>, value: azurerm.TrafficManagerProfile.TrafficManagerProfileTimeouts) : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#traffic_view_enabled-1">TrafficManagerProfile#traffic_view_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "traffic_view_enabled">]
        member _.TrafficViewEnabled(state: TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>, value: bool) : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod> =
            state.assignments.Add(fun config -> config.TrafficViewEnabled <- value)
            state : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#traffic_view_enabled-1">TrafficManagerProfile#traffic_view_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "traffic_view_enabled">]
        member _.TrafficViewEnabled(state: TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>, value: HashiCorp.Cdktf.IResolvable) : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod> =
            state.assignments.Add(fun config -> config.TrafficViewEnabled <- value)
            state : TrafficManagerProfileState<'DnsConfig, 'MonitorConfig, 'Name, 'ResourceGroupName, 'TrafficRoutingMethod>

        member _.Run(state: TrafficManagerProfileState<Present, Present, Present, Present, Present>) : azurerm.TrafficManagerProfile.TrafficManagerProfile =
            let config = azurerm.TrafficManagerProfile.TrafficManagerProfileConfig()
            for setter in state.assignments do
                setter config
            azurerm.TrafficManagerProfile.TrafficManagerProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.trafficManagerProfile: missing required arguments. Must call: dns_config, monitor_config, name, resource_group_name, traffic_routing_method.", 9999, IsError = true)>]
        member _.Run(_: TrafficManagerProfileState<_, _, _, _, _>) : azurerm.TrafficManagerProfile.TrafficManagerProfile =
            Unchecked.defaultof<azurerm.TrafficManagerProfile.TrafficManagerProfile>
