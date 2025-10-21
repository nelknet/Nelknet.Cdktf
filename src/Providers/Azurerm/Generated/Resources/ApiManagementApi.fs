namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> = { assignments: ResizeArray<azurerm.ApiManagementApi.ApiManagementApiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api">azurerm_api_management_api</a>.
    /// </summary>
    type ApiManagementApiBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementApiState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementApiState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#api_management_name-1">ApiManagementApi#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementApiState<Missing, 'Name, 'ResourceGroupName, 'Revision>, value: string) : ApiManagementApiState<Present, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementApiState<Present, 'Name, 'ResourceGroupName, 'Revision>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#name-1">ApiManagementApi#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementApiState<'ApiManagementName, Missing, 'ResourceGroupName, 'Revision>, value: string) : ApiManagementApiState<'ApiManagementName, Present, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementApiState<'ApiManagementName, Present, 'ResourceGroupName, 'Revision>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#resource_group_name-1">ApiManagementApi#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementApiState<'ApiManagementName, 'Name, Missing, 'Revision>, value: string) : ApiManagementApiState<'ApiManagementName, 'Name, Present, 'Revision> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementApiState<'ApiManagementName, 'Name, Present, 'Revision>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#revision-1">ApiManagementApi#revision</a>.
        /// </summary>
        [<CustomOperation "revision">]
        member _.Revision(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, Missing>, value: string) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Revision <- value)
            ({ assignments = state.assignments } : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#api_type-1">ApiManagementApi#api_type</a>.
        /// </summary>
        [<CustomOperation "api_type">]
        member _.ApiType(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: string) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.ApiType <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// contact block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#contact-1">ApiManagementApi#contact</a>
        /// </summary>
        [<CustomOperation "contact">]
        member _.Contact(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: azurerm.ApiManagementApi.ApiManagementApiContact) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.Contact <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#description-1">ApiManagementApi#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: string) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#display_name-1">ApiManagementApi#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: string) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#id-1">ApiManagementApi#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: string) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// import block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#import-1">ApiManagementApi#import</a>
        /// </summary>
        [<CustomOperation "import">]
        member _.Import(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: azurerm.ApiManagementApi.ApiManagementApiImport) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.Import <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// license block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#license-1">ApiManagementApi#license</a>
        /// </summary>
        [<CustomOperation "license">]
        member _.License(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: azurerm.ApiManagementApi.ApiManagementApiLicense) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.License <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// oauth2_authorization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#oauth2_authorization-1">ApiManagementApi#oauth2_authorization</a>
        /// </summary>
        [<CustomOperation "oauth2_authorization">]
        member _.Oauth2Authorization(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: azurerm.ApiManagementApi.ApiManagementApiOauth2Authorization) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.Oauth2Authorization <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// openid_authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#openid_authentication-1">ApiManagementApi#openid_authentication</a>
        /// </summary>
        [<CustomOperation "openid_authentication">]
        member _.OpenidAuthentication(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: azurerm.ApiManagementApi.ApiManagementApiOpenidAuthentication) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.OpenidAuthentication <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#path-1">ApiManagementApi#path</a>.
        /// </summary>
        [<CustomOperation "path">]
        member _.Path(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: string) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.Path <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#protocols-1">ApiManagementApi#protocols</a>.
        /// </summary>
        [<CustomOperation "protocols">]
        member _.Protocols(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: seq<string>) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.Protocols <- (value |> Seq.toArray))
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#revision_description-1">ApiManagementApi#revision_description</a>.
        /// </summary>
        [<CustomOperation "revision_description">]
        member _.RevisionDescription(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: string) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.RevisionDescription <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#service_url-1">ApiManagementApi#service_url</a>.
        /// </summary>
        [<CustomOperation "service_url">]
        member _.ServiceUrl(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: string) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.ServiceUrl <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#source_api_id-1">ApiManagementApi#source_api_id</a>.
        /// </summary>
        [<CustomOperation "source_api_id">]
        member _.SourceApiId(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: string) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.SourceApiId <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// subscription_key_parameter_names block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#subscription_key_parameter_names-1">ApiManagementApi#subscription_key_parameter_names</a>
        /// </summary>
        [<CustomOperation "subscription_key_parameter_names">]
        member _.SubscriptionKeyParameterNames(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: azurerm.ApiManagementApi.ApiManagementApiSubscriptionKeyParameterNames) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.SubscriptionKeyParameterNames <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#subscription_required-1">ApiManagementApi#subscription_required</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "subscription_required">]
        member _.SubscriptionRequired(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: bool) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.SubscriptionRequired <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#subscription_required-1">ApiManagementApi#subscription_required</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "subscription_required">]
        member _.SubscriptionRequired(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.SubscriptionRequired <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#terms_of_service_url-1">ApiManagementApi#terms_of_service_url</a>.
        /// </summary>
        [<CustomOperation "terms_of_service_url">]
        member _.TermsOfServiceUrl(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: string) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.TermsOfServiceUrl <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#timeouts-1">ApiManagementApi#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: azurerm.ApiManagementApi.ApiManagementApiTimeouts) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#version-1">ApiManagementApi#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: string) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#version_description-1">ApiManagementApi#version_description</a>.
        /// </summary>
        [<CustomOperation "version_description">]
        member _.VersionDescription(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: string) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.VersionDescription <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#version_set_id-1">ApiManagementApi#version_set_id</a>.
        /// </summary>
        [<CustomOperation "version_set_id">]
        member _.VersionSetId(state: ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: string) : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.VersionSetId <- value)
            state : ApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        member _.Run(state: ApiManagementApiState<Present, Present, Present, Present>) : azurerm.ApiManagementApi.ApiManagementApi =
            let config = azurerm.ApiManagementApi.ApiManagementApiConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementApi.ApiManagementApi(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementApi: missing required arguments. Must call: api_management_name, name, resource_group_name, revision.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementApiState<_, _, _, _>) : azurerm.ApiManagementApi.ApiManagementApi =
            Unchecked.defaultof<azurerm.ApiManagementApi.ApiManagementApi>
