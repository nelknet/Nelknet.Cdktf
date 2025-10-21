namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementOpenidConnectProvider.ApiManagementOpenidConnectProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_openid_connect_provider">azurerm_api_management_openid_connect_provider</a>.
    /// </summary>
    type ApiManagementOpenidConnectProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementOpenidConnectProviderState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementOpenidConnectProviderState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementOpenidConnectProviderState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementOpenidConnectProviderState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_openid_connect_provider#api_management_name-1">ApiManagementOpenidConnectProvider#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementOpenidConnectProviderState<Missing, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName>, value: string) : ApiManagementOpenidConnectProviderState<Present, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementOpenidConnectProviderState<Present, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_openid_connect_provider#client_id-1">ApiManagementOpenidConnectProvider#client_id</a>.
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: ApiManagementOpenidConnectProviderState<'ApiManagementName, Missing, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName>, value: string) : ApiManagementOpenidConnectProviderState<'ApiManagementName, Present, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientId <- value)
            ({ assignments = state.assignments } : ApiManagementOpenidConnectProviderState<'ApiManagementName, Present, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_openid_connect_provider#client_secret-1">ApiManagementOpenidConnectProvider#client_secret</a>.
        /// </summary>
        [<CustomOperation "client_secret">]
        member _.ClientSecret(state: ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, Missing, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName>, value: string) : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, Present, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientSecret <- value)
            ({ assignments = state.assignments } : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, Present, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_openid_connect_provider#display_name-1">ApiManagementOpenidConnectProvider#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, Missing, 'MetadataEndpoint, 'Name, 'ResourceGroupName>, value: string) : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, Present, 'MetadataEndpoint, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, Present, 'MetadataEndpoint, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_openid_connect_provider#metadata_endpoint-1">ApiManagementOpenidConnectProvider#metadata_endpoint</a>.
        /// </summary>
        [<CustomOperation "metadata_endpoint">]
        member _.MetadataEndpoint(state: ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, Missing, 'Name, 'ResourceGroupName>, value: string) : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MetadataEndpoint <- value)
            ({ assignments = state.assignments } : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_openid_connect_provider#name-1">ApiManagementOpenidConnectProvider#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, Missing, 'ResourceGroupName>, value: string) : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_openid_connect_provider#resource_group_name-1">ApiManagementOpenidConnectProvider#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, Missing>, value: string) : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_openid_connect_provider#description-1">ApiManagementOpenidConnectProvider#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName>, value: string) : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_openid_connect_provider#id-1">ApiManagementOpenidConnectProvider#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName>, value: string) : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_openid_connect_provider#timeouts-1">ApiManagementOpenidConnectProvider#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName>, value: azurerm.ApiManagementOpenidConnectProvider.ApiManagementOpenidConnectProviderTimeouts) : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementOpenidConnectProviderState<'ApiManagementName, 'ClientId, 'ClientSecret, 'DisplayName, 'MetadataEndpoint, 'Name, 'ResourceGroupName>

        member _.Run(state: ApiManagementOpenidConnectProviderState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.ApiManagementOpenidConnectProvider.ApiManagementOpenidConnectProvider =
            let config = azurerm.ApiManagementOpenidConnectProvider.ApiManagementOpenidConnectProviderConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementOpenidConnectProvider.ApiManagementOpenidConnectProvider(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementOpenidConnectProvider: missing required arguments. Must call: api_management_name, client_id, client_secret, display_name, metadata_endpoint, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementOpenidConnectProviderState<_, _, _, _, _, _, _>) : azurerm.ApiManagementOpenidConnectProvider.ApiManagementOpenidConnectProvider =
            Unchecked.defaultof<azurerm.ApiManagementOpenidConnectProvider.ApiManagementOpenidConnectProvider>
