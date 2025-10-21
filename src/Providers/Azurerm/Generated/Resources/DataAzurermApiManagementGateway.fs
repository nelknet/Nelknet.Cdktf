namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermApiManagementGatewayState<'ApiManagementId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermApiManagementGateway.DataAzurermApiManagementGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_gateway">azurerm_api_management_gateway</a>.
    /// </summary>
    type DataAzurermApiManagementGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermApiManagementGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementGatewayState<Missing, Missing>)

        member _.Zero(()) : DataAzurermApiManagementGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementGatewayState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_gateway#api_management_id-1">DataAzurermApiManagementGateway#api_management_id</a>.
        /// </summary>
        [<CustomOperation "api_management_id">]
        member _.ApiManagementId(state: DataAzurermApiManagementGatewayState<Missing, 'Name>, value: string) : DataAzurermApiManagementGatewayState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ApiManagementId <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementGatewayState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_gateway#name-1">DataAzurermApiManagementGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermApiManagementGatewayState<'ApiManagementId, Missing>, value: string) : DataAzurermApiManagementGatewayState<'ApiManagementId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementGatewayState<'ApiManagementId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_gateway#id-1">DataAzurermApiManagementGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermApiManagementGatewayState<'ApiManagementId, 'Name>, value: string) : DataAzurermApiManagementGatewayState<'ApiManagementId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermApiManagementGatewayState<'ApiManagementId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_gateway#timeouts-1">DataAzurermApiManagementGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermApiManagementGatewayState<'ApiManagementId, 'Name>, value: azurerm.DataAzurermApiManagementGateway.DataAzurermApiManagementGatewayTimeouts) : DataAzurermApiManagementGatewayState<'ApiManagementId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermApiManagementGatewayState<'ApiManagementId, 'Name>

        member _.Run(state: DataAzurermApiManagementGatewayState<Present, Present>) : azurerm.DataAzurermApiManagementGateway.DataAzurermApiManagementGateway =
            let config = azurerm.DataAzurermApiManagementGateway.DataAzurermApiManagementGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermApiManagementGateway.DataAzurermApiManagementGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermApiManagementGateway: missing required arguments. Must call: api_management_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermApiManagementGatewayState<_, _>) : azurerm.DataAzurermApiManagementGateway.DataAzurermApiManagementGateway =
            Unchecked.defaultof<azurerm.DataAzurermApiManagementGateway.DataAzurermApiManagementGateway>
