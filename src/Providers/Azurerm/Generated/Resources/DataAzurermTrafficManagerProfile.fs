namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermTrafficManagerProfile.DataAzurermTrafficManagerProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/traffic_manager_profile">azurerm_traffic_manager_profile</a>.
    /// </summary>
    type DataAzurermTrafficManagerProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermTrafficManagerProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermTrafficManagerProfileState<Missing, Missing>)

        member _.Zero(()) : DataAzurermTrafficManagerProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermTrafficManagerProfileState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/traffic_manager_profile#name-1">DataAzurermTrafficManagerProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermTrafficManagerProfileState<Missing, 'ResourceGroupName>, value: string) : DataAzurermTrafficManagerProfileState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermTrafficManagerProfileState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/traffic_manager_profile#resource_group_name-1">DataAzurermTrafficManagerProfile#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermTrafficManagerProfileState<'Name, Missing>, value: string) : DataAzurermTrafficManagerProfileState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermTrafficManagerProfileState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/traffic_manager_profile#id-1">DataAzurermTrafficManagerProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName>, value: string) : DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/traffic_manager_profile#tags-1">DataAzurermTrafficManagerProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/traffic_manager_profile#timeouts-1">DataAzurermTrafficManagerProfile#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermTrafficManagerProfile.DataAzurermTrafficManagerProfileTimeouts) : DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/traffic_manager_profile#traffic_view_enabled-1">DataAzurermTrafficManagerProfile#traffic_view_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "traffic_view_enabled">]
        member _.TrafficViewEnabled(state: DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName>, value: bool) : DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TrafficViewEnabled <- value)
            state : DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/traffic_manager_profile#traffic_view_enabled-1">DataAzurermTrafficManagerProfile#traffic_view_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "traffic_view_enabled">]
        member _.TrafficViewEnabled(state: DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TrafficViewEnabled <- value)
            state : DataAzurermTrafficManagerProfileState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermTrafficManagerProfileState<Present, Present>) : azurerm.DataAzurermTrafficManagerProfile.DataAzurermTrafficManagerProfile =
            let config = azurerm.DataAzurermTrafficManagerProfile.DataAzurermTrafficManagerProfileConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermTrafficManagerProfile.DataAzurermTrafficManagerProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermTrafficManagerProfile: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermTrafficManagerProfileState<_, _>) : azurerm.DataAzurermTrafficManagerProfile.DataAzurermTrafficManagerProfile =
            Unchecked.defaultof<azurerm.DataAzurermTrafficManagerProfile.DataAzurermTrafficManagerProfile>
