namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.PublicIpPrefix.PublicIpPrefixConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip_prefix">azurerm_public_ip_prefix</a>.
    /// </summary>
    type PublicIpPrefixBuilder(logicalId: string) =
        member _.Yield(_: unit) : PublicIpPrefixState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PublicIpPrefixState<Missing, Missing, Missing>)

        member _.Zero(()) : PublicIpPrefixState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PublicIpPrefixState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip_prefix#location-1">PublicIpPrefix#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PublicIpPrefixState<Missing, 'Name, 'ResourceGroupName>, value: string) : PublicIpPrefixState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PublicIpPrefixState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip_prefix#name-1">PublicIpPrefix#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PublicIpPrefixState<'Location, Missing, 'ResourceGroupName>, value: string) : PublicIpPrefixState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PublicIpPrefixState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip_prefix#resource_group_name-1">PublicIpPrefix#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PublicIpPrefixState<'Location, 'Name, Missing>, value: string) : PublicIpPrefixState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PublicIpPrefixState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip_prefix#id-1">PublicIpPrefix#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName>, value: string) : PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip_prefix#ip_version-1">PublicIpPrefix#ip_version</a>.
        /// </summary>
        [<CustomOperation "ip_version">]
        member _.IpVersion(state: PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName>, value: string) : PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IpVersion <- value)
            state : PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip_prefix#prefix_length-1">PublicIpPrefix#prefix_length</a>.
        /// </summary>
        [<CustomOperation "prefix_length">]
        member _.PrefixLength(state: PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName>, value: double) : PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrefixLength <- value)
            state : PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip_prefix#sku-1">PublicIpPrefix#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName>, value: string) : PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Sku <- value)
            state : PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip_prefix#tags-1">PublicIpPrefix#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip_prefix#timeouts-1">PublicIpPrefix#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.PublicIpPrefix.PublicIpPrefixTimeouts) : PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip_prefix#zones-1">PublicIpPrefix#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : PublicIpPrefixState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: PublicIpPrefixState<Present, Present, Present>) : azurerm.PublicIpPrefix.PublicIpPrefix =
            let config = azurerm.PublicIpPrefix.PublicIpPrefixConfig()
            for setter in state.assignments do
                setter config
            azurerm.PublicIpPrefix.PublicIpPrefix(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.publicIpPrefix: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: PublicIpPrefixState<_, _, _>) : azurerm.PublicIpPrefix.PublicIpPrefix =
            Unchecked.defaultof<azurerm.PublicIpPrefix.PublicIpPrefix>
