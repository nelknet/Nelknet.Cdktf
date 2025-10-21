namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name> = { assignments: ResizeArray<azurerm.CdnFrontdoorEndpoint.CdnFrontdoorEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_endpoint">azurerm_cdn_frontdoor_endpoint</a>.
    /// </summary>
    type CdnFrontdoorEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnFrontdoorEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorEndpointState<Missing, Missing>)

        member _.Zero(()) : CdnFrontdoorEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorEndpointState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_endpoint#cdn_frontdoor_profile_id-1">CdnFrontdoorEndpoint#cdn_frontdoor_profile_id</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_profile_id">]
        member _.CdnFrontdoorProfileId(state: CdnFrontdoorEndpointState<Missing, 'Name>, value: string) : CdnFrontdoorEndpointState<Present, 'Name> =
            state.assignments.Add(fun config -> config.CdnFrontdoorProfileId <- value)
            ({ assignments = state.assignments } : CdnFrontdoorEndpointState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_endpoint#name-1">CdnFrontdoorEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, Missing>, value: string) : CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_endpoint#enabled-1">CdnFrontdoorEndpoint#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name>, value: bool) : CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_endpoint#enabled-1">CdnFrontdoorEndpoint#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_endpoint#id-1">CdnFrontdoorEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name>, value: string) : CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_endpoint#tags-1">CdnFrontdoorEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name>, value: seq<string * string>) : CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_endpoint#timeouts-1">CdnFrontdoorEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name>, value: azurerm.CdnFrontdoorEndpoint.CdnFrontdoorEndpointTimeouts) : CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnFrontdoorEndpointState<'CdnFrontdoorProfileId, 'Name>

        member _.Run(state: CdnFrontdoorEndpointState<Present, Present>) : azurerm.CdnFrontdoorEndpoint.CdnFrontdoorEndpoint =
            let config = azurerm.CdnFrontdoorEndpoint.CdnFrontdoorEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnFrontdoorEndpoint.CdnFrontdoorEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnFrontdoorEndpoint: missing required arguments. Must call: cdn_frontdoor_profile_id, name.", 9999, IsError = true)>]
        member _.Run(_: CdnFrontdoorEndpointState<_, _>) : azurerm.CdnFrontdoorEndpoint.CdnFrontdoorEndpoint =
            Unchecked.defaultof<azurerm.CdnFrontdoorEndpoint.CdnFrontdoorEndpoint>
