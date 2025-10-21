namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementGatewayApiState<'ApiId, 'GatewayId> = { assignments: ResizeArray<azurerm.ApiManagementGatewayApi.ApiManagementGatewayApiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_api">azurerm_api_management_gateway_api</a>.
    /// </summary>
    type ApiManagementGatewayApiBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementGatewayApiState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementGatewayApiState<Missing, Missing>)

        member _.Zero(()) : ApiManagementGatewayApiState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementGatewayApiState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_api#api_id-1">ApiManagementGatewayApi#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: ApiManagementGatewayApiState<Missing, 'GatewayId>, value: string) : ApiManagementGatewayApiState<Present, 'GatewayId> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : ApiManagementGatewayApiState<Present, 'GatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_api#gateway_id-1">ApiManagementGatewayApi#gateway_id</a>.
        /// </summary>
        [<CustomOperation "gateway_id">]
        member _.GatewayId(state: ApiManagementGatewayApiState<'ApiId, Missing>, value: string) : ApiManagementGatewayApiState<'ApiId, Present> =
            state.assignments.Add(fun config -> config.GatewayId <- value)
            ({ assignments = state.assignments } : ApiManagementGatewayApiState<'ApiId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_api#id-1">ApiManagementGatewayApi#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementGatewayApiState<'ApiId, 'GatewayId>, value: string) : ApiManagementGatewayApiState<'ApiId, 'GatewayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementGatewayApiState<'ApiId, 'GatewayId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_api#timeouts-1">ApiManagementGatewayApi#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementGatewayApiState<'ApiId, 'GatewayId>, value: azurerm.ApiManagementGatewayApi.ApiManagementGatewayApiTimeouts) : ApiManagementGatewayApiState<'ApiId, 'GatewayId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementGatewayApiState<'ApiId, 'GatewayId>

        member _.Run(state: ApiManagementGatewayApiState<Present, Present>) : azurerm.ApiManagementGatewayApi.ApiManagementGatewayApi =
            let config = azurerm.ApiManagementGatewayApi.ApiManagementGatewayApiConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementGatewayApi.ApiManagementGatewayApi(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementGatewayApi: missing required arguments. Must call: api_id, gateway_id.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementGatewayApiState<_, _>) : azurerm.ApiManagementGatewayApi.ApiManagementGatewayApi =
            Unchecked.defaultof<azurerm.ApiManagementGatewayApi.ApiManagementGatewayApi>
