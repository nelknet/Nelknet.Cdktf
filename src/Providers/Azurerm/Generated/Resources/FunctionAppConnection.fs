namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId> = { assignments: ResizeArray<azurerm.FunctionAppConnection.FunctionAppConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection">azurerm_function_app_connection</a>.
    /// </summary>
    type FunctionAppConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : FunctionAppConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FunctionAppConnectionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FunctionAppConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FunctionAppConnectionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection#authentication-1">FunctionAppConnection#authentication</a>
        /// </summary>
        [<CustomOperation "authentication">]
        member _.Authentication(state: FunctionAppConnectionState<Missing, 'FunctionAppId, 'Name, 'TargetResourceId>, value: azurerm.FunctionAppConnection.FunctionAppConnectionAuthentication) : FunctionAppConnectionState<Present, 'FunctionAppId, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Authentication <- value)
            ({ assignments = state.assignments } : FunctionAppConnectionState<Present, 'FunctionAppId, 'Name, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection#function_app_id-1">FunctionAppConnection#function_app_id</a>.
        /// </summary>
        [<CustomOperation "function_app_id">]
        member _.FunctionAppId(state: FunctionAppConnectionState<'Authentication, Missing, 'Name, 'TargetResourceId>, value: string) : FunctionAppConnectionState<'Authentication, Present, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.FunctionAppId <- value)
            ({ assignments = state.assignments } : FunctionAppConnectionState<'Authentication, Present, 'Name, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection#name-1">FunctionAppConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FunctionAppConnectionState<'Authentication, 'FunctionAppId, Missing, 'TargetResourceId>, value: string) : FunctionAppConnectionState<'Authentication, 'FunctionAppId, Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FunctionAppConnectionState<'Authentication, 'FunctionAppId, Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection#target_resource_id-1">FunctionAppConnection#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, Missing>, value: string) : FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection#client_type-1">FunctionAppConnection#client_type</a>.
        /// </summary>
        [<CustomOperation "client_type">]
        member _.ClientType(state: FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId>, value: string) : FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.ClientType <- value)
            state : FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection#id-1">FunctionAppConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId>, value: string) : FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId>

        /// <summary>
        /// secret_store block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection#secret_store-1">FunctionAppConnection#secret_store</a>
        /// </summary>
        [<CustomOperation "secret_store">]
        member _.SecretStore(state: FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId>, value: azurerm.FunctionAppConnection.FunctionAppConnectionSecretStore) : FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.SecretStore <- value)
            state : FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection#timeouts-1">FunctionAppConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId>, value: azurerm.FunctionAppConnection.FunctionAppConnectionTimeouts) : FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection#vnet_solution-1">FunctionAppConnection#vnet_solution</a>.
        /// </summary>
        [<CustomOperation "vnet_solution">]
        member _.VnetSolution(state: FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId>, value: string) : FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.VnetSolution <- value)
            state : FunctionAppConnectionState<'Authentication, 'FunctionAppId, 'Name, 'TargetResourceId>

        member _.Run(state: FunctionAppConnectionState<Present, Present, Present, Present>) : azurerm.FunctionAppConnection.FunctionAppConnection =
            let config = azurerm.FunctionAppConnection.FunctionAppConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.FunctionAppConnection.FunctionAppConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.functionAppConnection: missing required arguments. Must call: authentication, function_app_id, name, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: FunctionAppConnectionState<_, _, _, _>) : azurerm.FunctionAppConnection.FunctionAppConnection =
            Unchecked.defaultof<azurerm.FunctionAppConnection.FunctionAppConnection>
