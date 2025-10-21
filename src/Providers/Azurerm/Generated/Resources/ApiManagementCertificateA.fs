namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementCertificate.ApiManagementCertificateAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_certificate">azurerm_api_management_certificate</a>.
    /// </summary>
    type ApiManagementCertificateABuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementCertificateAState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementCertificateAState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementCertificateAState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementCertificateAState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_certificate#api_management_name-1">ApiManagementCertificateA#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementCertificateAState<Missing, 'Name, 'ResourceGroupName>, value: string) : ApiManagementCertificateAState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementCertificateAState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_certificate#name-1">ApiManagementCertificateA#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementCertificateAState<'ApiManagementName, Missing, 'ResourceGroupName>, value: string) : ApiManagementCertificateAState<'ApiManagementName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementCertificateAState<'ApiManagementName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_certificate#resource_group_name-1">ApiManagementCertificateA#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementCertificateAState<'ApiManagementName, 'Name, Missing>, value: string) : ApiManagementCertificateAState<'ApiManagementName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementCertificateAState<'ApiManagementName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_certificate#data-1">ApiManagementCertificateA#data</a>.
        /// </summary>
        [<CustomOperation "data">]
        member _.Data(state: ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Data <- value)
            state : ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_certificate#id-1">ApiManagementCertificateA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_certificate#key_vault_identity_client_id-1">ApiManagementCertificateA#key_vault_identity_client_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_identity_client_id">]
        member _.KeyVaultIdentityClientId(state: ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeyVaultIdentityClientId <- value)
            state : ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_certificate#key_vault_secret_id-1">ApiManagementCertificateA#key_vault_secret_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_secret_id">]
        member _.KeyVaultSecretId(state: ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeyVaultSecretId <- value)
            state : ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_certificate#password-1">ApiManagementCertificateA#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_certificate#timeouts-1">ApiManagementCertificateA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: azurerm.ApiManagementCertificate.ApiManagementCertificateTimeouts) : ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementCertificateAState<'ApiManagementName, 'Name, 'ResourceGroupName>

        member _.Run(state: ApiManagementCertificateAState<Present, Present, Present>) : azurerm.ApiManagementCertificate.ApiManagementCertificateA =
            let config = azurerm.ApiManagementCertificate.ApiManagementCertificateAConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementCertificate.ApiManagementCertificateA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementCertificateA: missing required arguments. Must call: api_management_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementCertificateAState<_, _, _>) : azurerm.ApiManagementCertificate.ApiManagementCertificateA =
            Unchecked.defaultof<azurerm.ApiManagementCertificate.ApiManagementCertificateA>
