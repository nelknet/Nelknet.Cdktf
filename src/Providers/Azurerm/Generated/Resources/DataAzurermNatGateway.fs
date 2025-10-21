namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNatGatewayState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermNatGateway.DataAzurermNatGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nat_gateway">azurerm_nat_gateway</a>.
    /// </summary>
    type DataAzurermNatGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNatGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNatGatewayState<Missing, Missing>)

        member _.Zero(()) : DataAzurermNatGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNatGatewayState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nat_gateway#name-1">DataAzurermNatGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNatGatewayState<Missing, 'ResourceGroupName>, value: string) : DataAzurermNatGatewayState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNatGatewayState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nat_gateway#resource_group_name-1">DataAzurermNatGateway#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermNatGatewayState<'Name, Missing>, value: string) : DataAzurermNatGatewayState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermNatGatewayState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nat_gateway#id-1">DataAzurermNatGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNatGatewayState<'Name, 'ResourceGroupName>, value: string) : DataAzurermNatGatewayState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNatGatewayState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nat_gateway#public_ip_address_ids-1">DataAzurermNatGateway#public_ip_address_ids</a>.
        /// </summary>
        [<CustomOperation "public_ip_address_ids">]
        member _.PublicIpAddressIds(state: DataAzurermNatGatewayState<'Name, 'ResourceGroupName>, value: seq<string>) : DataAzurermNatGatewayState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicIpAddressIds <- (value |> Seq.toArray))
            state : DataAzurermNatGatewayState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nat_gateway#public_ip_prefix_ids-1">DataAzurermNatGateway#public_ip_prefix_ids</a>.
        /// </summary>
        [<CustomOperation "public_ip_prefix_ids">]
        member _.PublicIpPrefixIds(state: DataAzurermNatGatewayState<'Name, 'ResourceGroupName>, value: seq<string>) : DataAzurermNatGatewayState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicIpPrefixIds <- (value |> Seq.toArray))
            state : DataAzurermNatGatewayState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nat_gateway#timeouts-1">DataAzurermNatGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNatGatewayState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermNatGateway.DataAzurermNatGatewayTimeouts) : DataAzurermNatGatewayState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNatGatewayState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermNatGatewayState<Present, Present>) : azurerm.DataAzurermNatGateway.DataAzurermNatGateway =
            let config = azurerm.DataAzurermNatGateway.DataAzurermNatGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNatGateway.DataAzurermNatGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNatGateway: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNatGatewayState<_, _>) : azurerm.DataAzurermNatGateway.DataAzurermNatGateway =
            Unchecked.defaultof<azurerm.DataAzurermNatGateway.DataAzurermNatGateway>
