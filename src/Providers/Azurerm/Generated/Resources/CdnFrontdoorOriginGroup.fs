namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name> = { assignments: ResizeArray<azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group">azurerm_cdn_frontdoor_origin_group</a>.
    /// </summary>
    type CdnFrontdoorOriginGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnFrontdoorOriginGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorOriginGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : CdnFrontdoorOriginGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorOriginGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group#cdn_frontdoor_profile_id-1">CdnFrontdoorOriginGroup#cdn_frontdoor_profile_id</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_profile_id">]
        member _.CdnFrontdoorProfileId(state: CdnFrontdoorOriginGroupState<Missing, 'LoadBalancing, 'Name>, value: string) : CdnFrontdoorOriginGroupState<Present, 'LoadBalancing, 'Name> =
            state.assignments.Add(fun config -> config.CdnFrontdoorProfileId <- value)
            ({ assignments = state.assignments } : CdnFrontdoorOriginGroupState<Present, 'LoadBalancing, 'Name>)

        /// <summary>
        /// load_balancing block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group#load_balancing-1">CdnFrontdoorOriginGroup#load_balancing</a>
        /// </summary>
        [<CustomOperation "load_balancing">]
        member _.LoadBalancing(state: CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, Missing, 'Name>, value: azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupLoadBalancing) : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LoadBalancing <- value)
            ({ assignments = state.assignments } : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group#name-1">CdnFrontdoorOriginGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, Missing>, value: string) : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, Present>)

        /// <summary>
        /// health_probe block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group#health_probe-1">CdnFrontdoorOriginGroup#health_probe</a>
        /// </summary>
        [<CustomOperation "health_probe">]
        member _.HealthProbe(state: CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name>, value: azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupHealthProbe) : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name> =
            state.assignments.Add(fun config -> config.HealthProbe <- value)
            state : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group#id-1">CdnFrontdoorOriginGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name>, value: string) : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group#restore_traffic_time_to_healed_or_new_endpoint_in_minutes-1">CdnFrontdoorOriginGroup#restore_traffic_time_to_healed_or_new_endpoint_in_minutes</a>.
        /// </summary>
        [<CustomOperation "restore_traffic_time_to_healed_or_new_endpoint_in_minutes">]
        member _.RestoreTrafficTimeToHealedOrNewEndpointInMinutes(state: CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name>, value: double) : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name> =
            state.assignments.Add(fun config -> config.RestoreTrafficTimeToHealedOrNewEndpointInMinutes <- value)
            state : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group#session_affinity_enabled-1">CdnFrontdoorOriginGroup#session_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "session_affinity_enabled">]
        member _.SessionAffinityEnabled(state: CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name>, value: bool) : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name> =
            state.assignments.Add(fun config -> config.SessionAffinityEnabled <- value)
            state : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group#session_affinity_enabled-1">CdnFrontdoorOriginGroup#session_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "session_affinity_enabled">]
        member _.SessionAffinityEnabled(state: CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name>, value: HashiCorp.Cdktf.IResolvable) : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name> =
            state.assignments.Add(fun config -> config.SessionAffinityEnabled <- value)
            state : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin_group#timeouts-1">CdnFrontdoorOriginGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name>, value: azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupTimeouts) : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnFrontdoorOriginGroupState<'CdnFrontdoorProfileId, 'LoadBalancing, 'Name>

        member _.Run(state: CdnFrontdoorOriginGroupState<Present, Present, Present>) : azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroup =
            let config = azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnFrontdoorOriginGroup: missing required arguments. Must call: cdn_frontdoor_profile_id, load_balancing, name.", 9999, IsError = true)>]
        member _.Run(_: CdnFrontdoorOriginGroupState<_, _, _>) : azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroup =
            Unchecked.defaultof<azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroup>
