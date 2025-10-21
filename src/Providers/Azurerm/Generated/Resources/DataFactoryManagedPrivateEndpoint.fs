namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, 'TargetResourceId> = { assignments: ResizeArray<azurerm.DataFactoryManagedPrivateEndpoint.DataFactoryManagedPrivateEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_managed_private_endpoint">azurerm_data_factory_managed_private_endpoint</a>.
    /// </summary>
    type DataFactoryManagedPrivateEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryManagedPrivateEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryManagedPrivateEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryManagedPrivateEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryManagedPrivateEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_managed_private_endpoint#data_factory_id-1">DataFactoryManagedPrivateEndpoint#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryManagedPrivateEndpointState<Missing, 'Name, 'TargetResourceId>, value: string) : DataFactoryManagedPrivateEndpointState<Present, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryManagedPrivateEndpointState<Present, 'Name, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_managed_private_endpoint#name-1">DataFactoryManagedPrivateEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryManagedPrivateEndpointState<'DataFactoryId, Missing, 'TargetResourceId>, value: string) : DataFactoryManagedPrivateEndpointState<'DataFactoryId, Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryManagedPrivateEndpointState<'DataFactoryId, Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_managed_private_endpoint#target_resource_id-1">DataFactoryManagedPrivateEndpoint#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, Missing>, value: string) : DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_managed_private_endpoint#fqdns-1">DataFactoryManagedPrivateEndpoint#fqdns</a>.
        /// </summary>
        [<CustomOperation "fqdns">]
        member _.Fqdns(state: DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, 'TargetResourceId>, value: seq<string>) : DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Fqdns <- (value |> Seq.toArray))
            state : DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_managed_private_endpoint#id-1">DataFactoryManagedPrivateEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, 'TargetResourceId>, value: string) : DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_managed_private_endpoint#subresource_name-1">DataFactoryManagedPrivateEndpoint#subresource_name</a>.
        /// </summary>
        [<CustomOperation "subresource_name">]
        member _.SubresourceName(state: DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, 'TargetResourceId>, value: string) : DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.SubresourceName <- value)
            state : DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_managed_private_endpoint#timeouts-1">DataFactoryManagedPrivateEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, 'TargetResourceId>, value: azurerm.DataFactoryManagedPrivateEndpoint.DataFactoryManagedPrivateEndpointTimeouts) : DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryManagedPrivateEndpointState<'DataFactoryId, 'Name, 'TargetResourceId>

        member _.Run(state: DataFactoryManagedPrivateEndpointState<Present, Present, Present>) : azurerm.DataFactoryManagedPrivateEndpoint.DataFactoryManagedPrivateEndpoint =
            let config = azurerm.DataFactoryManagedPrivateEndpoint.DataFactoryManagedPrivateEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryManagedPrivateEndpoint.DataFactoryManagedPrivateEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryManagedPrivateEndpoint: missing required arguments. Must call: data_factory_id, name, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryManagedPrivateEndpointState<_, _, _>) : azurerm.DataFactoryManagedPrivateEndpoint.DataFactoryManagedPrivateEndpoint =
            Unchecked.defaultof<azurerm.DataFactoryManagedPrivateEndpoint.DataFactoryManagedPrivateEndpoint>
