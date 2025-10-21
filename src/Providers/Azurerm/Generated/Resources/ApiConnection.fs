namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiConnection.ApiConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_connection">azurerm_api_connection</a>.
    /// </summary>
    type ApiConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiConnectionState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiConnectionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_connection#managed_api_id-1">ApiConnection#managed_api_id</a>.
        /// </summary>
        [<CustomOperation "managed_api_id">]
        member _.ManagedApiId(state: ApiConnectionState<Missing, 'Name, 'ResourceGroupName>, value: string) : ApiConnectionState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ManagedApiId <- value)
            ({ assignments = state.assignments } : ApiConnectionState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_connection#name-1">ApiConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiConnectionState<'ManagedApiId, Missing, 'ResourceGroupName>, value: string) : ApiConnectionState<'ManagedApiId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiConnectionState<'ManagedApiId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_connection#resource_group_name-1">ApiConnection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiConnectionState<'ManagedApiId, 'Name, Missing>, value: string) : ApiConnectionState<'ManagedApiId, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiConnectionState<'ManagedApiId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_connection#display_name-1">ApiConnection#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName>, value: string) : ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_connection#id-1">ApiConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName>, value: string) : ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_connection#parameter_values-1">ApiConnection#parameter_values</a>.
        /// </summary>
        [<CustomOperation "parameter_values">]
        member _.ParameterValues(state: ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ParameterValues <- dict value)
            state : ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_connection#tags-1">ApiConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_connection#timeouts-1">ApiConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName>, value: azurerm.ApiConnection.ApiConnectionTimeouts) : ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiConnectionState<'ManagedApiId, 'Name, 'ResourceGroupName>

        member _.Run(state: ApiConnectionState<Present, Present, Present>) : azurerm.ApiConnection.ApiConnection =
            let config = azurerm.ApiConnection.ApiConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiConnection.ApiConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiConnection: missing required arguments. Must call: managed_api_id, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiConnectionState<_, _, _>) : azurerm.ApiConnection.ApiConnection =
            Unchecked.defaultof<azurerm.ApiConnection.ApiConnection>
