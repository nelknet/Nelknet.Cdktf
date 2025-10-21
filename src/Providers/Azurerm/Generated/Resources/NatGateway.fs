namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NatGatewayState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.NatGateway.NatGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway">azurerm_nat_gateway</a>.
    /// </summary>
    type NatGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : NatGatewayState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NatGatewayState<Missing, Missing, Missing>)

        member _.Zero(()) : NatGatewayState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NatGatewayState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway#location-1">NatGateway#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NatGatewayState<Missing, 'Name, 'ResourceGroupName>, value: string) : NatGatewayState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NatGatewayState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway#name-1">NatGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NatGatewayState<'Location, Missing, 'ResourceGroupName>, value: string) : NatGatewayState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NatGatewayState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway#resource_group_name-1">NatGateway#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NatGatewayState<'Location, 'Name, Missing>, value: string) : NatGatewayState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NatGatewayState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway#id-1">NatGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NatGatewayState<'Location, 'Name, 'ResourceGroupName>, value: string) : NatGatewayState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NatGatewayState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway#idle_timeout_in_minutes-1">NatGateway#idle_timeout_in_minutes</a>.
        /// </summary>
        [<CustomOperation "idle_timeout_in_minutes">]
        member _.IdleTimeoutInMinutes(state: NatGatewayState<'Location, 'Name, 'ResourceGroupName>, value: double) : NatGatewayState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IdleTimeoutInMinutes <- value)
            state : NatGatewayState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway#sku_name-1">NatGateway#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: NatGatewayState<'Location, 'Name, 'ResourceGroupName>, value: string) : NatGatewayState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            state : NatGatewayState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway#tags-1">NatGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NatGatewayState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : NatGatewayState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NatGatewayState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway#timeouts-1">NatGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NatGatewayState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.NatGateway.NatGatewayTimeouts) : NatGatewayState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NatGatewayState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway#zones-1">NatGateway#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: NatGatewayState<'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : NatGatewayState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : NatGatewayState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: NatGatewayState<Present, Present, Present>) : azurerm.NatGateway.NatGateway =
            let config = azurerm.NatGateway.NatGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.NatGateway.NatGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.natGateway: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: NatGatewayState<_, _, _>) : azurerm.NatGateway.NatGateway =
            Unchecked.defaultof<azurerm.NatGateway.NatGateway>
