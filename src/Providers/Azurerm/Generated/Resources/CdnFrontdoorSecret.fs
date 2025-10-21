namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnFrontdoorSecretState<'CdnFrontdoorProfileId, 'Name, 'Secret> = { assignments: ResizeArray<azurerm.CdnFrontdoorSecret.CdnFrontdoorSecretConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_secret">azurerm_cdn_frontdoor_secret</a>.
    /// </summary>
    type CdnFrontdoorSecretBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnFrontdoorSecretState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorSecretState<Missing, Missing, Missing>)

        member _.Zero(()) : CdnFrontdoorSecretState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorSecretState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_secret#cdn_frontdoor_profile_id-1">CdnFrontdoorSecret#cdn_frontdoor_profile_id</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_profile_id">]
        member _.CdnFrontdoorProfileId(state: CdnFrontdoorSecretState<Missing, 'Name, 'Secret>, value: string) : CdnFrontdoorSecretState<Present, 'Name, 'Secret> =
            state.assignments.Add(fun config -> config.CdnFrontdoorProfileId <- value)
            ({ assignments = state.assignments } : CdnFrontdoorSecretState<Present, 'Name, 'Secret>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_secret#name-1">CdnFrontdoorSecret#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CdnFrontdoorSecretState<'CdnFrontdoorProfileId, Missing, 'Secret>, value: string) : CdnFrontdoorSecretState<'CdnFrontdoorProfileId, Present, 'Secret> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CdnFrontdoorSecretState<'CdnFrontdoorProfileId, Present, 'Secret>)

        /// <summary>
        /// secret block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_secret#secret-1">CdnFrontdoorSecret#secret</a>
        /// </summary>
        [<CustomOperation "secret">]
        member _.Secret(state: CdnFrontdoorSecretState<'CdnFrontdoorProfileId, 'Name, Missing>, value: azurerm.CdnFrontdoorSecret.CdnFrontdoorSecretSecret) : CdnFrontdoorSecretState<'CdnFrontdoorProfileId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Secret <- value)
            ({ assignments = state.assignments } : CdnFrontdoorSecretState<'CdnFrontdoorProfileId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_secret#id-1">CdnFrontdoorSecret#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnFrontdoorSecretState<'CdnFrontdoorProfileId, 'Name, 'Secret>, value: string) : CdnFrontdoorSecretState<'CdnFrontdoorProfileId, 'Name, 'Secret> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnFrontdoorSecretState<'CdnFrontdoorProfileId, 'Name, 'Secret>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_secret#timeouts-1">CdnFrontdoorSecret#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnFrontdoorSecretState<'CdnFrontdoorProfileId, 'Name, 'Secret>, value: azurerm.CdnFrontdoorSecret.CdnFrontdoorSecretTimeouts) : CdnFrontdoorSecretState<'CdnFrontdoorProfileId, 'Name, 'Secret> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnFrontdoorSecretState<'CdnFrontdoorProfileId, 'Name, 'Secret>

        member _.Run(state: CdnFrontdoorSecretState<Present, Present, Present>) : azurerm.CdnFrontdoorSecret.CdnFrontdoorSecret =
            let config = azurerm.CdnFrontdoorSecret.CdnFrontdoorSecretConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnFrontdoorSecret.CdnFrontdoorSecret(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnFrontdoorSecret: missing required arguments. Must call: cdn_frontdoor_profile_id, name, secret.", 9999, IsError = true)>]
        member _.Run(_: CdnFrontdoorSecretState<_, _, _>) : azurerm.CdnFrontdoorSecret.CdnFrontdoorSecret =
            Unchecked.defaultof<azurerm.CdnFrontdoorSecret.CdnFrontdoorSecret>
