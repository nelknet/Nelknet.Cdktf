namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StaticSiteState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.StaticSite.StaticSiteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site">azurerm_static_site</a>.
    /// </summary>
    type StaticSiteBuilder(logicalId: string) =
        member _.Yield(_: unit) : StaticSiteState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StaticSiteState<Missing, Missing, Missing>)

        member _.Zero(()) : StaticSiteState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StaticSiteState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site#location-1">StaticSite#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: StaticSiteState<Missing, 'Name, 'ResourceGroupName>, value: string) : StaticSiteState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : StaticSiteState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site#name-1">StaticSite#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StaticSiteState<'Location, Missing, 'ResourceGroupName>, value: string) : StaticSiteState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StaticSiteState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site#resource_group_name-1">StaticSite#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StaticSiteState<'Location, 'Name, Missing>, value: string) : StaticSiteState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StaticSiteState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site#app_settings-1">StaticSite#app_settings</a>.
        /// </summary>
        [<CustomOperation "app_settings">]
        member _.AppSettings(state: StaticSiteState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : StaticSiteState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppSettings <- dict value)
            state : StaticSiteState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site#id-1">StaticSite#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StaticSiteState<'Location, 'Name, 'ResourceGroupName>, value: string) : StaticSiteState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StaticSiteState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site#identity-1">StaticSite#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: StaticSiteState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.StaticSite.StaticSiteIdentity) : StaticSiteState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : StaticSiteState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site#sku_size-1">StaticSite#sku_size</a>.
        /// </summary>
        [<CustomOperation "sku_size">]
        member _.SkuSize(state: StaticSiteState<'Location, 'Name, 'ResourceGroupName>, value: string) : StaticSiteState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SkuSize <- value)
            state : StaticSiteState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site#sku_tier-1">StaticSite#sku_tier</a>.
        /// </summary>
        [<CustomOperation "sku_tier">]
        member _.SkuTier(state: StaticSiteState<'Location, 'Name, 'ResourceGroupName>, value: string) : StaticSiteState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SkuTier <- value)
            state : StaticSiteState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site#tags-1">StaticSite#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StaticSiteState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : StaticSiteState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StaticSiteState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site#timeouts-1">StaticSite#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StaticSiteState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.StaticSite.StaticSiteTimeouts) : StaticSiteState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StaticSiteState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: StaticSiteState<Present, Present, Present>) : azurerm.StaticSite.StaticSite =
            let config = azurerm.StaticSite.StaticSiteConfig()
            for setter in state.assignments do
                setter config
            azurerm.StaticSite.StaticSite(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.staticSite: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: StaticSiteState<_, _, _>) : azurerm.StaticSite.StaticSite =
            Unchecked.defaultof<azurerm.StaticSite.StaticSite>
