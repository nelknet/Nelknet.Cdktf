namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AppServiceCertificate.AppServiceCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate">azurerm_app_service_certificate</a>.
    /// </summary>
    type AppServiceCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceCertificateState<Missing, Missing, Missing>)

        member _.Zero(()) : AppServiceCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceCertificateState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate#location-1">AppServiceCertificate#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AppServiceCertificateState<Missing, 'Name, 'ResourceGroupName>, value: string) : AppServiceCertificateState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AppServiceCertificateState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate#name-1">AppServiceCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppServiceCertificateState<'Location, Missing, 'ResourceGroupName>, value: string) : AppServiceCertificateState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppServiceCertificateState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate#resource_group_name-1">AppServiceCertificate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AppServiceCertificateState<'Location, 'Name, Missing>, value: string) : AppServiceCertificateState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AppServiceCertificateState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate#app_service_plan_id-1">AppServiceCertificate#app_service_plan_id</a>.
        /// </summary>
        [<CustomOperation "app_service_plan_id">]
        member _.AppServicePlanId(state: AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppServicePlanId <- value)
            state : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate#id-1">AppServiceCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate#key_vault_id-1">AppServiceCertificate#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            state : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate#key_vault_secret_id-1">AppServiceCertificate#key_vault_secret_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_secret_id">]
        member _.KeyVaultSecretId(state: AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeyVaultSecretId <- value)
            state : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate#password-1">AppServiceCertificate#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate#pfx_blob-1">AppServiceCertificate#pfx_blob</a>.
        /// </summary>
        [<CustomOperation "pfx_blob">]
        member _.PfxBlob(state: AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PfxBlob <- value)
            state : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate#tags-1">AppServiceCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate#timeouts-1">AppServiceCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppServiceCertificate.AppServiceCertificateTimeouts) : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceCertificateState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: AppServiceCertificateState<Present, Present, Present>) : azurerm.AppServiceCertificate.AppServiceCertificate =
            let config = azurerm.AppServiceCertificate.AppServiceCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceCertificate.AppServiceCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceCertificate: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AppServiceCertificateState<_, _, _>) : azurerm.AppServiceCertificate.AppServiceCertificate =
            Unchecked.defaultof<azurerm.AppServiceCertificate.AppServiceCertificate>
