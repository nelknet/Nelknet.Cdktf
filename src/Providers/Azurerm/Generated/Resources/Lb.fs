namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.Lb.LbConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb">azurerm_lb</a>.
    /// </summary>
    type LbBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbState<Missing, Missing, Missing>)

        member _.Zero(()) : LbState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#location-1">Lb#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: LbState<Missing, 'Name, 'ResourceGroupName>, value: string) : LbState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : LbState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#name-1">Lb#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LbState<'Location, Missing, 'ResourceGroupName>, value: string) : LbState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LbState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#resource_group_name-1">Lb#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LbState<'Location, 'Name, Missing>, value: string) : LbState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LbState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#edge_zone-1">Lb#edge_zone</a>.
        /// </summary>
        [<CustomOperation "edge_zone">]
        member _.EdgeZone(state: LbState<'Location, 'Name, 'ResourceGroupName>, value: string) : LbState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EdgeZone <- value)
            state : LbState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// frontend_ip_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#frontend_ip_configuration-1">Lb#frontend_ip_configuration</a> Accepts: azurerm.IResolvable | azurerm.Lb.LbFrontendIpConfiguration[]
        /// </summary>
        [<CustomOperation "frontend_ip_configuration">]
        member _.FrontendIpConfiguration(state: LbState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : LbState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FrontendIpConfiguration <- value)
            state : LbState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#id-1">Lb#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbState<'Location, 'Name, 'ResourceGroupName>, value: string) : LbState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#sku-1">Lb#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: LbState<'Location, 'Name, 'ResourceGroupName>, value: string) : LbState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Sku <- value)
            state : LbState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#sku_tier-1">Lb#sku_tier</a>.
        /// </summary>
        [<CustomOperation "sku_tier">]
        member _.SkuTier(state: LbState<'Location, 'Name, 'ResourceGroupName>, value: string) : LbState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SkuTier <- value)
            state : LbState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#tags-1">Lb#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LbState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : LbState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LbState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#timeouts-1">Lb#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LbState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.Lb.LbTimeouts) : LbState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LbState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: LbState<Present, Present, Present>) : azurerm.Lb.Lb =
            let config = azurerm.Lb.LbConfig()
            for setter in state.assignments do
                setter config
            azurerm.Lb.Lb(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.lb: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LbState<_, _, _>) : azurerm.Lb.Lb =
            Unchecked.defaultof<azurerm.Lb.Lb>
