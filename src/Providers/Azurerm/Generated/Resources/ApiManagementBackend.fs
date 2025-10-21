namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url> = { assignments: ResizeArray<azurerm.ApiManagementBackend.ApiManagementBackendConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend">azurerm_api_management_backend</a>.
    /// </summary>
    type ApiManagementBackendBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementBackendState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementBackendState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementBackendState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementBackendState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#api_management_name-1">ApiManagementBackend#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementBackendState<Missing, 'Name, 'Protocol, 'ResourceGroupName, 'Url>, value: string) : ApiManagementBackendState<Present, 'Name, 'Protocol, 'ResourceGroupName, 'Url> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementBackendState<Present, 'Name, 'Protocol, 'ResourceGroupName, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#name-1">ApiManagementBackend#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementBackendState<'ApiManagementName, Missing, 'Protocol, 'ResourceGroupName, 'Url>, value: string) : ApiManagementBackendState<'ApiManagementName, Present, 'Protocol, 'ResourceGroupName, 'Url> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementBackendState<'ApiManagementName, Present, 'Protocol, 'ResourceGroupName, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#protocol-1">ApiManagementBackend#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: ApiManagementBackendState<'ApiManagementName, 'Name, Missing, 'ResourceGroupName, 'Url>, value: string) : ApiManagementBackendState<'ApiManagementName, 'Name, Present, 'ResourceGroupName, 'Url> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : ApiManagementBackendState<'ApiManagementName, 'Name, Present, 'ResourceGroupName, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#resource_group_name-1">ApiManagementBackend#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, Missing, 'Url>, value: string) : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, Present, 'Url> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, Present, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#url-1">ApiManagementBackend#url</a>.
        /// </summary>
        [<CustomOperation "url">]
        member _.Url(state: ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, Missing>, value: string) : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Url <- value)
            ({ assignments = state.assignments } : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, Present>)

        /// <summary>
        /// credentials block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#credentials-1">ApiManagementBackend#credentials</a>
        /// </summary>
        [<CustomOperation "credentials">]
        member _.Credentials(state: ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>, value: azurerm.ApiManagementBackend.ApiManagementBackendCredentials) : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url> =
            state.assignments.Add(fun config -> config.Credentials <- value)
            state : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#description-1">ApiManagementBackend#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>, value: string) : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#id-1">ApiManagementBackend#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>, value: string) : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>

        /// <summary>
        /// proxy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#proxy-1">ApiManagementBackend#proxy</a>
        /// </summary>
        [<CustomOperation "proxy">]
        member _.Proxy(state: ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>, value: azurerm.ApiManagementBackend.ApiManagementBackendProxy) : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url> =
            state.assignments.Add(fun config -> config.Proxy <- value)
            state : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#resource_id-1">ApiManagementBackend#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>, value: string) : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            state : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>

        /// <summary>
        /// service_fabric_cluster block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#service_fabric_cluster-1">ApiManagementBackend#service_fabric_cluster</a>
        /// </summary>
        [<CustomOperation "service_fabric_cluster">]
        member _.ServiceFabricCluster(state: ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>, value: azurerm.ApiManagementBackend.ApiManagementBackendServiceFabricCluster) : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url> =
            state.assignments.Add(fun config -> config.ServiceFabricCluster <- value)
            state : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#timeouts-1">ApiManagementBackend#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>, value: azurerm.ApiManagementBackend.ApiManagementBackendTimeouts) : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#title-1">ApiManagementBackend#title</a>.
        /// </summary>
        [<CustomOperation "title">]
        member _.Title(state: ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>, value: string) : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url> =
            state.assignments.Add(fun config -> config.Title <- value)
            state : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>

        /// <summary>
        /// tls block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#tls-1">ApiManagementBackend#tls</a>
        /// </summary>
        [<CustomOperation "tls">]
        member _.Tls(state: ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>, value: azurerm.ApiManagementBackend.ApiManagementBackendTls) : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url> =
            state.assignments.Add(fun config -> config.Tls <- value)
            state : ApiManagementBackendState<'ApiManagementName, 'Name, 'Protocol, 'ResourceGroupName, 'Url>

        member _.Run(state: ApiManagementBackendState<Present, Present, Present, Present, Present>) : azurerm.ApiManagementBackend.ApiManagementBackend =
            let config = azurerm.ApiManagementBackend.ApiManagementBackendConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementBackend.ApiManagementBackend(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementBackend: missing required arguments. Must call: api_management_name, name, protocol, resource_group_name, url.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementBackendState<_, _, _, _, _>) : azurerm.ApiManagementBackend.ApiManagementBackend =
            Unchecked.defaultof<azurerm.ApiManagementBackend.ApiManagementBackend>
