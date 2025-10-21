namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PostgresqlFlexibleServerVirtualEndpointState<'Name, 'ReplicaServerId, 'SourceServerId, 'Type> = { assignments: ResizeArray<azurerm.PostgresqlFlexibleServerVirtualEndpoint.PostgresqlFlexibleServerVirtualEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_virtual_endpoint">azurerm_postgresql_flexible_server_virtual_endpoint</a>.
    /// </summary>
    type PostgresqlFlexibleServerVirtualEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : PostgresqlFlexibleServerVirtualEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlFlexibleServerVirtualEndpointState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PostgresqlFlexibleServerVirtualEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlFlexibleServerVirtualEndpointState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// The name of the Virtual Endpoint. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_virtual_endpoint#name-1">PostgresqlFlexibleServerVirtualEndpoint#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PostgresqlFlexibleServerVirtualEndpointState<Missing, 'ReplicaServerId, 'SourceServerId, 'Type>, value: string) : PostgresqlFlexibleServerVirtualEndpointState<Present, 'ReplicaServerId, 'SourceServerId, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerVirtualEndpointState<Present, 'ReplicaServerId, 'SourceServerId, 'Type>)

        /// <summary>
        /// The Resource ID of the *Replica* Postgres Flexible Server this should be associated with. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_virtual_endpoint#replica_server_id-1">PostgresqlFlexibleServerVirtualEndpoint#replica_server_id</a>
        /// </summary>
        [<CustomOperation "replica_server_id">]
        member _.ReplicaServerId(state: PostgresqlFlexibleServerVirtualEndpointState<'Name, Missing, 'SourceServerId, 'Type>, value: string) : PostgresqlFlexibleServerVirtualEndpointState<'Name, Present, 'SourceServerId, 'Type> =
            state.assignments.Add(fun config -> config.ReplicaServerId <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerVirtualEndpointState<'Name, Present, 'SourceServerId, 'Type>)

        /// <summary>
        /// The Resource ID of the *Source* Postgres Flexible Server this should be associated with. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_virtual_endpoint#source_server_id-1">PostgresqlFlexibleServerVirtualEndpoint#source_server_id</a>
        /// </summary>
        [<CustomOperation "source_server_id">]
        member _.SourceServerId(state: PostgresqlFlexibleServerVirtualEndpointState<'Name, 'ReplicaServerId, Missing, 'Type>, value: string) : PostgresqlFlexibleServerVirtualEndpointState<'Name, 'ReplicaServerId, Present, 'Type> =
            state.assignments.Add(fun config -> config.SourceServerId <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerVirtualEndpointState<'Name, 'ReplicaServerId, Present, 'Type>)

        /// <summary>
        /// The type of Virtual Endpoint. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_virtual_endpoint#type-1">PostgresqlFlexibleServerVirtualEndpoint#type</a>
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: PostgresqlFlexibleServerVirtualEndpointState<'Name, 'ReplicaServerId, 'SourceServerId, Missing>, value: string) : PostgresqlFlexibleServerVirtualEndpointState<'Name, 'ReplicaServerId, 'SourceServerId, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerVirtualEndpointState<'Name, 'ReplicaServerId, 'SourceServerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_virtual_endpoint#id-1">PostgresqlFlexibleServerVirtualEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PostgresqlFlexibleServerVirtualEndpointState<'Name, 'ReplicaServerId, 'SourceServerId, 'Type>, value: string) : PostgresqlFlexibleServerVirtualEndpointState<'Name, 'ReplicaServerId, 'SourceServerId, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PostgresqlFlexibleServerVirtualEndpointState<'Name, 'ReplicaServerId, 'SourceServerId, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_virtual_endpoint#timeouts-1">PostgresqlFlexibleServerVirtualEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PostgresqlFlexibleServerVirtualEndpointState<'Name, 'ReplicaServerId, 'SourceServerId, 'Type>, value: azurerm.PostgresqlFlexibleServerVirtualEndpoint.PostgresqlFlexibleServerVirtualEndpointTimeouts) : PostgresqlFlexibleServerVirtualEndpointState<'Name, 'ReplicaServerId, 'SourceServerId, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PostgresqlFlexibleServerVirtualEndpointState<'Name, 'ReplicaServerId, 'SourceServerId, 'Type>

        member _.Run(state: PostgresqlFlexibleServerVirtualEndpointState<Present, Present, Present, Present>) : azurerm.PostgresqlFlexibleServerVirtualEndpoint.PostgresqlFlexibleServerVirtualEndpoint =
            let config = azurerm.PostgresqlFlexibleServerVirtualEndpoint.PostgresqlFlexibleServerVirtualEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.PostgresqlFlexibleServerVirtualEndpoint.PostgresqlFlexibleServerVirtualEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.postgresqlFlexibleServerVirtualEndpoint: missing required arguments. Must call: name, replica_server_id, source_server_id, type.", 9999, IsError = true)>]
        member _.Run(_: PostgresqlFlexibleServerVirtualEndpointState<_, _, _, _>) : azurerm.PostgresqlFlexibleServerVirtualEndpoint.PostgresqlFlexibleServerVirtualEndpoint =
            Unchecked.defaultof<azurerm.PostgresqlFlexibleServerVirtualEndpoint.PostgresqlFlexibleServerVirtualEndpoint>
