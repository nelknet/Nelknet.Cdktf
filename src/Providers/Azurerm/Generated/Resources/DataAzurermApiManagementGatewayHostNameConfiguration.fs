namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'GatewayName, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermApiManagementGatewayHostNameConfiguration.DataAzurermApiManagementGatewayHostNameConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_gateway_host_name_configuration">azurerm_api_management_gateway_host_name_configuration</a>.
    /// </summary>
    type DataAzurermApiManagementGatewayHostNameConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermApiManagementGatewayHostNameConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementGatewayHostNameConfigurationState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermApiManagementGatewayHostNameConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementGatewayHostNameConfigurationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_gateway_host_name_configuration#api_management_id-1">DataAzurermApiManagementGatewayHostNameConfiguration#api_management_id</a>.
        /// </summary>
        [<CustomOperation "api_management_id">]
        member _.ApiManagementId(state: DataAzurermApiManagementGatewayHostNameConfigurationState<Missing, 'GatewayName, 'Name>, value: string) : DataAzurermApiManagementGatewayHostNameConfigurationState<Present, 'GatewayName, 'Name> =
            state.assignments.Add(fun config -> config.ApiManagementId <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementGatewayHostNameConfigurationState<Present, 'GatewayName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_gateway_host_name_configuration#gateway_name-1">DataAzurermApiManagementGatewayHostNameConfiguration#gateway_name</a>.
        /// </summary>
        [<CustomOperation "gateway_name">]
        member _.GatewayName(state: DataAzurermApiManagementGatewayHostNameConfigurationState<'ApiManagementId, Missing, 'Name>, value: string) : DataAzurermApiManagementGatewayHostNameConfigurationState<'ApiManagementId, Present, 'Name> =
            state.assignments.Add(fun config -> config.GatewayName <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementGatewayHostNameConfigurationState<'ApiManagementId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_gateway_host_name_configuration#name-1">DataAzurermApiManagementGatewayHostNameConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'GatewayName, Missing>, value: string) : DataAzurermApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'GatewayName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'GatewayName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_gateway_host_name_configuration#id-1">DataAzurermApiManagementGatewayHostNameConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'GatewayName, 'Name>, value: string) : DataAzurermApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'GatewayName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'GatewayName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_gateway_host_name_configuration#timeouts-1">DataAzurermApiManagementGatewayHostNameConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'GatewayName, 'Name>, value: azurerm.DataAzurermApiManagementGatewayHostNameConfiguration.DataAzurermApiManagementGatewayHostNameConfigurationTimeouts) : DataAzurermApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'GatewayName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'GatewayName, 'Name>

        member _.Run(state: DataAzurermApiManagementGatewayHostNameConfigurationState<Present, Present, Present>) : azurerm.DataAzurermApiManagementGatewayHostNameConfiguration.DataAzurermApiManagementGatewayHostNameConfiguration =
            let config = azurerm.DataAzurermApiManagementGatewayHostNameConfiguration.DataAzurermApiManagementGatewayHostNameConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermApiManagementGatewayHostNameConfiguration.DataAzurermApiManagementGatewayHostNameConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermApiManagementGatewayHostNameConfiguration: missing required arguments. Must call: api_management_id, gateway_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermApiManagementGatewayHostNameConfigurationState<_, _, _>) : azurerm.DataAzurermApiManagementGatewayHostNameConfiguration.DataAzurermApiManagementGatewayHostNameConfiguration =
            Unchecked.defaultof<azurerm.DataAzurermApiManagementGatewayHostNameConfiguration.DataAzurermApiManagementGatewayHostNameConfiguration>
