namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnFrontdoorProfileState<'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.CdnFrontdoorProfile.CdnFrontdoorProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_profile">azurerm_cdn_frontdoor_profile</a>.
    /// </summary>
    type CdnFrontdoorProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnFrontdoorProfileState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorProfileState<Missing, Missing, Missing>)

        member _.Zero(()) : CdnFrontdoorProfileState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorProfileState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_profile#name-1">CdnFrontdoorProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CdnFrontdoorProfileState<Missing, 'ResourceGroupName, 'SkuName>, value: string) : CdnFrontdoorProfileState<Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CdnFrontdoorProfileState<Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_profile#resource_group_name-1">CdnFrontdoorProfile#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CdnFrontdoorProfileState<'Name, Missing, 'SkuName>, value: string) : CdnFrontdoorProfileState<'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CdnFrontdoorProfileState<'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_profile#sku_name-1">CdnFrontdoorProfile#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: CdnFrontdoorProfileState<'Name, 'ResourceGroupName, Missing>, value: string) : CdnFrontdoorProfileState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : CdnFrontdoorProfileState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_profile#id-1">CdnFrontdoorProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnFrontdoorProfileState<'Name, 'ResourceGroupName, 'SkuName>, value: string) : CdnFrontdoorProfileState<'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnFrontdoorProfileState<'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_profile#response_timeout_seconds-1">CdnFrontdoorProfile#response_timeout_seconds</a>.
        /// </summary>
        [<CustomOperation "response_timeout_seconds">]
        member _.ResponseTimeoutSeconds(state: CdnFrontdoorProfileState<'Name, 'ResourceGroupName, 'SkuName>, value: double) : CdnFrontdoorProfileState<'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.ResponseTimeoutSeconds <- value)
            state : CdnFrontdoorProfileState<'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_profile#tags-1">CdnFrontdoorProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CdnFrontdoorProfileState<'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : CdnFrontdoorProfileState<'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CdnFrontdoorProfileState<'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_profile#timeouts-1">CdnFrontdoorProfile#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnFrontdoorProfileState<'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.CdnFrontdoorProfile.CdnFrontdoorProfileTimeouts) : CdnFrontdoorProfileState<'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnFrontdoorProfileState<'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: CdnFrontdoorProfileState<Present, Present, Present>) : azurerm.CdnFrontdoorProfile.CdnFrontdoorProfile =
            let config = azurerm.CdnFrontdoorProfile.CdnFrontdoorProfileConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnFrontdoorProfile.CdnFrontdoorProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnFrontdoorProfile: missing required arguments. Must call: name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: CdnFrontdoorProfileState<_, _, _>) : azurerm.CdnFrontdoorProfile.CdnFrontdoorProfile =
            Unchecked.defaultof<azurerm.CdnFrontdoorProfile.CdnFrontdoorProfile>
