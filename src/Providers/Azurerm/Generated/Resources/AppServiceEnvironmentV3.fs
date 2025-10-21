namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId> = { assignments: ResizeArray<azurerm.AppServiceEnvironmentV3.AppServiceEnvironmentV3Config -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3">azurerm_app_service_environment_v3</a>.
    /// </summary>
    type AppServiceEnvironmentV3Builder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceEnvironmentV3State<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceEnvironmentV3State<Missing, Missing, Missing>)

        member _.Zero(()) : AppServiceEnvironmentV3State<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceEnvironmentV3State<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#name-1">AppServiceEnvironmentV3#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppServiceEnvironmentV3State<Missing, 'ResourceGroupName, 'SubnetId>, value: string) : AppServiceEnvironmentV3State<Present, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppServiceEnvironmentV3State<Present, 'ResourceGroupName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#resource_group_name-1">AppServiceEnvironmentV3#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AppServiceEnvironmentV3State<'Name, Missing, 'SubnetId>, value: string) : AppServiceEnvironmentV3State<'Name, Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AppServiceEnvironmentV3State<'Name, Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#subnet_id-1">AppServiceEnvironmentV3#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, Missing>, value: string) : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#allow_new_private_endpoint_connections-1">AppServiceEnvironmentV3#allow_new_private_endpoint_connections</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_new_private_endpoint_connections">]
        member _.AllowNewPrivateEndpointConnections(state: AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>, value: bool) : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.AllowNewPrivateEndpointConnections <- value)
            state : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#allow_new_private_endpoint_connections-1">AppServiceEnvironmentV3#allow_new_private_endpoint_connections</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_new_private_endpoint_connections">]
        member _.AllowNewPrivateEndpointConnections(state: AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.AllowNewPrivateEndpointConnections <- value)
            state : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// cluster_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#cluster_setting-1">AppServiceEnvironmentV3#cluster_setting</a> Accepts: azurerm.IResolvable | azurerm.AppServiceEnvironmentV3.AppServiceEnvironmentV3ClusterSetting[]
        /// </summary>
        [<CustomOperation "cluster_setting">]
        member _.ClusterSetting(state: AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.ClusterSetting <- value)
            state : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#dedicated_host_count-1">AppServiceEnvironmentV3#dedicated_host_count</a>.
        /// </summary>
        [<CustomOperation "dedicated_host_count">]
        member _.DedicatedHostCount(state: AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>, value: double) : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.DedicatedHostCount <- value)
            state : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#id-1">AppServiceEnvironmentV3#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>, value: string) : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#internal_load_balancing_mode-1">AppServiceEnvironmentV3#internal_load_balancing_mode</a>.
        /// </summary>
        [<CustomOperation "internal_load_balancing_mode">]
        member _.InternalLoadBalancingMode(state: AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>, value: string) : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.InternalLoadBalancingMode <- value)
            state : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#remote_debugging_enabled-1">AppServiceEnvironmentV3#remote_debugging_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "remote_debugging_enabled">]
        member _.RemoteDebuggingEnabled(state: AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>, value: bool) : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.RemoteDebuggingEnabled <- value)
            state : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#remote_debugging_enabled-1">AppServiceEnvironmentV3#remote_debugging_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "remote_debugging_enabled">]
        member _.RemoteDebuggingEnabled(state: AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.RemoteDebuggingEnabled <- value)
            state : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#tags-1">AppServiceEnvironmentV3#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>, value: seq<string * string>) : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#timeouts-1">AppServiceEnvironmentV3#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>, value: azurerm.AppServiceEnvironmentV3.AppServiceEnvironmentV3Timeouts) : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#zone_redundant-1">AppServiceEnvironmentV3#zone_redundant</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundant">]
        member _.ZoneRedundant(state: AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>, value: bool) : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.ZoneRedundant <- value)
            state : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#zone_redundant-1">AppServiceEnvironmentV3#zone_redundant</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundant">]
        member _.ZoneRedundant(state: AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.ZoneRedundant <- value)
            state : AppServiceEnvironmentV3State<'Name, 'ResourceGroupName, 'SubnetId>

        member _.Run(state: AppServiceEnvironmentV3State<Present, Present, Present>) : azurerm.AppServiceEnvironmentV3.AppServiceEnvironmentV3 =
            let config = azurerm.AppServiceEnvironmentV3.AppServiceEnvironmentV3Config()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceEnvironmentV3.AppServiceEnvironmentV3(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceEnvironmentV3: missing required arguments. Must call: name, resource_group_name, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: AppServiceEnvironmentV3State<_, _, _>) : azurerm.AppServiceEnvironmentV3.AppServiceEnvironmentV3 =
            Unchecked.defaultof<azurerm.AppServiceEnvironmentV3.AppServiceEnvironmentV3>
