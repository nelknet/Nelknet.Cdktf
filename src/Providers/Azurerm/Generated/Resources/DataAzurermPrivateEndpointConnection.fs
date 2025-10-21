namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateEndpointConnectionState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermPrivateEndpointConnection.DataAzurermPrivateEndpointConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_endpoint_connection">azurerm_private_endpoint_connection</a>.
    /// </summary>
    type DataAzurermPrivateEndpointConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateEndpointConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateEndpointConnectionState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateEndpointConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateEndpointConnectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_endpoint_connection#name-1">DataAzurermPrivateEndpointConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateEndpointConnectionState<Missing, 'ResourceGroupName>, value: string) : DataAzurermPrivateEndpointConnectionState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateEndpointConnectionState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_endpoint_connection#resource_group_name-1">DataAzurermPrivateEndpointConnection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPrivateEndpointConnectionState<'Name, Missing>, value: string) : DataAzurermPrivateEndpointConnectionState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateEndpointConnectionState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_endpoint_connection#id-1">DataAzurermPrivateEndpointConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateEndpointConnectionState<'Name, 'ResourceGroupName>, value: string) : DataAzurermPrivateEndpointConnectionState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateEndpointConnectionState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_endpoint_connection#timeouts-1">DataAzurermPrivateEndpointConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateEndpointConnectionState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermPrivateEndpointConnection.DataAzurermPrivateEndpointConnectionTimeouts) : DataAzurermPrivateEndpointConnectionState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateEndpointConnectionState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermPrivateEndpointConnectionState<Present, Present>) : azurerm.DataAzurermPrivateEndpointConnection.DataAzurermPrivateEndpointConnection =
            let config = azurerm.DataAzurermPrivateEndpointConnection.DataAzurermPrivateEndpointConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateEndpointConnection.DataAzurermPrivateEndpointConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateEndpointConnection: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateEndpointConnectionState<_, _>) : azurerm.DataAzurermPrivateEndpointConnection.DataAzurermPrivateEndpointConnection =
            Unchecked.defaultof<azurerm.DataAzurermPrivateEndpointConnection.DataAzurermPrivateEndpointConnection>
