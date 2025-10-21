namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId> = { assignments: ResizeArray<azurerm.SpringCloudConnection.SpringCloudConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection">azurerm_spring_cloud_connection</a>.
    /// </summary>
    type SpringCloudConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudConnectionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudConnectionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection#authentication-1">SpringCloudConnection#authentication</a>
        /// </summary>
        [<CustomOperation "authentication">]
        member _.Authentication(state: SpringCloudConnectionState<Missing, 'Name, 'SpringCloudId, 'TargetResourceId>, value: azurerm.SpringCloudConnection.SpringCloudConnectionAuthentication) : SpringCloudConnectionState<Present, 'Name, 'SpringCloudId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Authentication <- value)
            ({ assignments = state.assignments } : SpringCloudConnectionState<Present, 'Name, 'SpringCloudId, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection#name-1">SpringCloudConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudConnectionState<'Authentication, Missing, 'SpringCloudId, 'TargetResourceId>, value: string) : SpringCloudConnectionState<'Authentication, Present, 'SpringCloudId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudConnectionState<'Authentication, Present, 'SpringCloudId, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection#spring_cloud_id-1">SpringCloudConnection#spring_cloud_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_id">]
        member _.SpringCloudId(state: SpringCloudConnectionState<'Authentication, 'Name, Missing, 'TargetResourceId>, value: string) : SpringCloudConnectionState<'Authentication, 'Name, Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.SpringCloudId <- value)
            ({ assignments = state.assignments } : SpringCloudConnectionState<'Authentication, 'Name, Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection#target_resource_id-1">SpringCloudConnection#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, Missing>, value: string) : SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection#client_type-1">SpringCloudConnection#client_type</a>.
        /// </summary>
        [<CustomOperation "client_type">]
        member _.ClientType(state: SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId>, value: string) : SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.ClientType <- value)
            state : SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection#id-1">SpringCloudConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId>, value: string) : SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId>

        /// <summary>
        /// secret_store block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection#secret_store-1">SpringCloudConnection#secret_store</a>
        /// </summary>
        [<CustomOperation "secret_store">]
        member _.SecretStore(state: SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId>, value: azurerm.SpringCloudConnection.SpringCloudConnectionSecretStore) : SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.SecretStore <- value)
            state : SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection#timeouts-1">SpringCloudConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId>, value: azurerm.SpringCloudConnection.SpringCloudConnectionTimeouts) : SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection#vnet_solution-1">SpringCloudConnection#vnet_solution</a>.
        /// </summary>
        [<CustomOperation "vnet_solution">]
        member _.VnetSolution(state: SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId>, value: string) : SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.VnetSolution <- value)
            state : SpringCloudConnectionState<'Authentication, 'Name, 'SpringCloudId, 'TargetResourceId>

        member _.Run(state: SpringCloudConnectionState<Present, Present, Present, Present>) : azurerm.SpringCloudConnection.SpringCloudConnection =
            let config = azurerm.SpringCloudConnection.SpringCloudConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudConnection.SpringCloudConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudConnection: missing required arguments. Must call: authentication, name, spring_cloud_id, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudConnectionState<_, _, _, _>) : azurerm.SpringCloudConnection.SpringCloudConnection =
            Unchecked.defaultof<azurerm.SpringCloudConnection.SpringCloudConnection>
