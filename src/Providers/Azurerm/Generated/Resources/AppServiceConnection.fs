namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId> = { assignments: ResizeArray<azurerm.AppServiceConnection.AppServiceConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection">azurerm_app_service_connection</a>.
    /// </summary>
    type AppServiceConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceConnectionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppServiceConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceConnectionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection#app_service_id-1">AppServiceConnection#app_service_id</a>.
        /// </summary>
        [<CustomOperation "app_service_id">]
        member _.AppServiceId(state: AppServiceConnectionState<Missing, 'Authentication, 'Name, 'TargetResourceId>, value: string) : AppServiceConnectionState<Present, 'Authentication, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.AppServiceId <- value)
            ({ assignments = state.assignments } : AppServiceConnectionState<Present, 'Authentication, 'Name, 'TargetResourceId>)

        /// <summary>
        /// authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection#authentication-1">AppServiceConnection#authentication</a>
        /// </summary>
        [<CustomOperation "authentication">]
        member _.Authentication(state: AppServiceConnectionState<'AppServiceId, Missing, 'Name, 'TargetResourceId>, value: azurerm.AppServiceConnection.AppServiceConnectionAuthentication) : AppServiceConnectionState<'AppServiceId, Present, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Authentication <- value)
            ({ assignments = state.assignments } : AppServiceConnectionState<'AppServiceId, Present, 'Name, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection#name-1">AppServiceConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppServiceConnectionState<'AppServiceId, 'Authentication, Missing, 'TargetResourceId>, value: string) : AppServiceConnectionState<'AppServiceId, 'Authentication, Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppServiceConnectionState<'AppServiceId, 'Authentication, Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection#target_resource_id-1">AppServiceConnection#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, Missing>, value: string) : AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection#client_type-1">AppServiceConnection#client_type</a>.
        /// </summary>
        [<CustomOperation "client_type">]
        member _.ClientType(state: AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId>, value: string) : AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.ClientType <- value)
            state : AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection#id-1">AppServiceConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId>, value: string) : AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId>

        /// <summary>
        /// secret_store block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection#secret_store-1">AppServiceConnection#secret_store</a>
        /// </summary>
        [<CustomOperation "secret_store">]
        member _.SecretStore(state: AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId>, value: azurerm.AppServiceConnection.AppServiceConnectionSecretStore) : AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.SecretStore <- value)
            state : AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection#timeouts-1">AppServiceConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId>, value: azurerm.AppServiceConnection.AppServiceConnectionTimeouts) : AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection#vnet_solution-1">AppServiceConnection#vnet_solution</a>.
        /// </summary>
        [<CustomOperation "vnet_solution">]
        member _.VnetSolution(state: AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId>, value: string) : AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.VnetSolution <- value)
            state : AppServiceConnectionState<'AppServiceId, 'Authentication, 'Name, 'TargetResourceId>

        member _.Run(state: AppServiceConnectionState<Present, Present, Present, Present>) : azurerm.AppServiceConnection.AppServiceConnection =
            let config = azurerm.AppServiceConnection.AppServiceConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceConnection.AppServiceConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceConnection: missing required arguments. Must call: app_service_id, authentication, name, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: AppServiceConnectionState<_, _, _, _>) : azurerm.AppServiceConnection.AppServiceConnection =
            Unchecked.defaultof<azurerm.AppServiceConnection.AppServiceConnection>
