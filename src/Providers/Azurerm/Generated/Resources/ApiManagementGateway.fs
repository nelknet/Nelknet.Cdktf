namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementGatewayState<'ApiManagementId, 'LocationData, 'Name> = { assignments: ResizeArray<azurerm.ApiManagementGateway.ApiManagementGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway">azurerm_api_management_gateway</a>.
    /// </summary>
    type ApiManagementGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementGatewayState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementGatewayState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementGatewayState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementGatewayState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway#api_management_id-1">ApiManagementGateway#api_management_id</a>.
        /// </summary>
        [<CustomOperation "api_management_id">]
        member _.ApiManagementId(state: ApiManagementGatewayState<Missing, 'LocationData, 'Name>, value: string) : ApiManagementGatewayState<Present, 'LocationData, 'Name> =
            state.assignments.Add(fun config -> config.ApiManagementId <- value)
            ({ assignments = state.assignments } : ApiManagementGatewayState<Present, 'LocationData, 'Name>)

        /// <summary>
        /// location_data block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway#location_data-1">ApiManagementGateway#location_data</a>
        /// </summary>
        [<CustomOperation "location_data">]
        member _.LocationData(state: ApiManagementGatewayState<'ApiManagementId, Missing, 'Name>, value: azurerm.ApiManagementGateway.ApiManagementGatewayLocationData) : ApiManagementGatewayState<'ApiManagementId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LocationData <- value)
            ({ assignments = state.assignments } : ApiManagementGatewayState<'ApiManagementId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway#name-1">ApiManagementGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementGatewayState<'ApiManagementId, 'LocationData, Missing>, value: string) : ApiManagementGatewayState<'ApiManagementId, 'LocationData, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementGatewayState<'ApiManagementId, 'LocationData, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway#description-1">ApiManagementGateway#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiManagementGatewayState<'ApiManagementId, 'LocationData, 'Name>, value: string) : ApiManagementGatewayState<'ApiManagementId, 'LocationData, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiManagementGatewayState<'ApiManagementId, 'LocationData, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway#id-1">ApiManagementGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementGatewayState<'ApiManagementId, 'LocationData, 'Name>, value: string) : ApiManagementGatewayState<'ApiManagementId, 'LocationData, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementGatewayState<'ApiManagementId, 'LocationData, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway#timeouts-1">ApiManagementGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementGatewayState<'ApiManagementId, 'LocationData, 'Name>, value: azurerm.ApiManagementGateway.ApiManagementGatewayTimeouts) : ApiManagementGatewayState<'ApiManagementId, 'LocationData, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementGatewayState<'ApiManagementId, 'LocationData, 'Name>

        member _.Run(state: ApiManagementGatewayState<Present, Present, Present>) : azurerm.ApiManagementGateway.ApiManagementGateway =
            let config = azurerm.ApiManagementGateway.ApiManagementGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementGateway.ApiManagementGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementGateway: missing required arguments. Must call: api_management_id, location_data, name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementGatewayState<_, _, _>) : azurerm.ApiManagementGateway.ApiManagementGateway =
            Unchecked.defaultof<azurerm.ApiManagementGateway.ApiManagementGateway>
