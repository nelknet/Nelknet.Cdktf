namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnFrontdoorSecurityPolicyState<'CdnFrontdoorProfileId, 'Name, 'SecurityPolicies> = { assignments: ResizeArray<azurerm.CdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy">azurerm_cdn_frontdoor_security_policy</a>.
    /// </summary>
    type CdnFrontdoorSecurityPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnFrontdoorSecurityPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorSecurityPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : CdnFrontdoorSecurityPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorSecurityPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#cdn_frontdoor_profile_id-1">CdnFrontdoorSecurityPolicy#cdn_frontdoor_profile_id</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_profile_id">]
        member _.CdnFrontdoorProfileId(state: CdnFrontdoorSecurityPolicyState<Missing, 'Name, 'SecurityPolicies>, value: string) : CdnFrontdoorSecurityPolicyState<Present, 'Name, 'SecurityPolicies> =
            state.assignments.Add(fun config -> config.CdnFrontdoorProfileId <- value)
            ({ assignments = state.assignments } : CdnFrontdoorSecurityPolicyState<Present, 'Name, 'SecurityPolicies>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#name-1">CdnFrontdoorSecurityPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CdnFrontdoorSecurityPolicyState<'CdnFrontdoorProfileId, Missing, 'SecurityPolicies>, value: string) : CdnFrontdoorSecurityPolicyState<'CdnFrontdoorProfileId, Present, 'SecurityPolicies> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CdnFrontdoorSecurityPolicyState<'CdnFrontdoorProfileId, Present, 'SecurityPolicies>)

        /// <summary>
        /// security_policies block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#security_policies-1">CdnFrontdoorSecurityPolicy#security_policies</a>
        /// </summary>
        [<CustomOperation "security_policies">]
        member _.SecurityPolicies(state: CdnFrontdoorSecurityPolicyState<'CdnFrontdoorProfileId, 'Name, Missing>, value: azurerm.CdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicySecurityPolicies) : CdnFrontdoorSecurityPolicyState<'CdnFrontdoorProfileId, 'Name, Present> =
            state.assignments.Add(fun config -> config.SecurityPolicies <- value)
            ({ assignments = state.assignments } : CdnFrontdoorSecurityPolicyState<'CdnFrontdoorProfileId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#id-1">CdnFrontdoorSecurityPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnFrontdoorSecurityPolicyState<'CdnFrontdoorProfileId, 'Name, 'SecurityPolicies>, value: string) : CdnFrontdoorSecurityPolicyState<'CdnFrontdoorProfileId, 'Name, 'SecurityPolicies> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnFrontdoorSecurityPolicyState<'CdnFrontdoorProfileId, 'Name, 'SecurityPolicies>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_security_policy#timeouts-1">CdnFrontdoorSecurityPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnFrontdoorSecurityPolicyState<'CdnFrontdoorProfileId, 'Name, 'SecurityPolicies>, value: azurerm.CdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicyTimeouts) : CdnFrontdoorSecurityPolicyState<'CdnFrontdoorProfileId, 'Name, 'SecurityPolicies> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnFrontdoorSecurityPolicyState<'CdnFrontdoorProfileId, 'Name, 'SecurityPolicies>

        member _.Run(state: CdnFrontdoorSecurityPolicyState<Present, Present, Present>) : azurerm.CdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicy =
            let config = azurerm.CdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnFrontdoorSecurityPolicy: missing required arguments. Must call: cdn_frontdoor_profile_id, name, security_policies.", 9999, IsError = true)>]
        member _.Run(_: CdnFrontdoorSecurityPolicyState<_, _, _>) : azurerm.CdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicy =
            Unchecked.defaultof<azurerm.CdnFrontdoorSecurityPolicy.CdnFrontdoorSecurityPolicy>
