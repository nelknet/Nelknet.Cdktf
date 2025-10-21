namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.NetworkSecurityRule.NetworkSecurityRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule">azurerm_network_security_rule</a>.
    /// </summary>
    type NetworkSecurityRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkSecurityRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkSecurityRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkSecurityRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkSecurityRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#access-1">NetworkSecurityRule#access</a>.
        /// </summary>
        [<CustomOperation "access">]
        member _.Access(state: NetworkSecurityRuleState<Missing, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: string) : NetworkSecurityRuleState<Present, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Access <- value)
            ({ assignments = state.assignments } : NetworkSecurityRuleState<Present, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#direction-1">NetworkSecurityRule#direction</a>.
        /// </summary>
        [<CustomOperation "direction">]
        member _.Direction(state: NetworkSecurityRuleState<'Access, Missing, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: string) : NetworkSecurityRuleState<'Access, Present, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Direction <- value)
            ({ assignments = state.assignments } : NetworkSecurityRuleState<'Access, Present, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#name-1">NetworkSecurityRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkSecurityRuleState<'Access, 'Direction, Missing, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: string) : NetworkSecurityRuleState<'Access, 'Direction, Present, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkSecurityRuleState<'Access, 'Direction, Present, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#network_security_group_name-1">NetworkSecurityRule#network_security_group_name</a>.
        /// </summary>
        [<CustomOperation "network_security_group_name">]
        member _.NetworkSecurityGroupName(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, Missing, 'Priority, 'Protocol, 'ResourceGroupName>, value: string) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, Present, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NetworkSecurityGroupName <- value)
            ({ assignments = state.assignments } : NetworkSecurityRuleState<'Access, 'Direction, 'Name, Present, 'Priority, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#priority-1">NetworkSecurityRule#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, Missing, 'Protocol, 'ResourceGroupName>, value: double) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, Present, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Priority <- value)
            ({ assignments = state.assignments } : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, Present, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#protocol-1">NetworkSecurityRule#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, Missing, 'ResourceGroupName>, value: string) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#resource_group_name-1">NetworkSecurityRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, Missing>, value: string) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#description-1">NetworkSecurityRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: string) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#destination_address_prefix-1">NetworkSecurityRule#destination_address_prefix</a>.
        /// </summary>
        [<CustomOperation "destination_address_prefix">]
        member _.DestinationAddressPrefix(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: string) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DestinationAddressPrefix <- value)
            state : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#destination_address_prefixes-1">NetworkSecurityRule#destination_address_prefixes</a>.
        /// </summary>
        [<CustomOperation "destination_address_prefixes">]
        member _.DestinationAddressPrefixes(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: seq<string>) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DestinationAddressPrefixes <- (value |> Seq.toArray))
            state : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#destination_application_security_group_ids-1">NetworkSecurityRule#destination_application_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "destination_application_security_group_ids">]
        member _.DestinationApplicationSecurityGroupIds(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: seq<string>) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DestinationApplicationSecurityGroupIds <- (value |> Seq.toArray))
            state : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#destination_port_range-1">NetworkSecurityRule#destination_port_range</a>.
        /// </summary>
        [<CustomOperation "destination_port_range">]
        member _.DestinationPortRange(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: string) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DestinationPortRange <- value)
            state : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#destination_port_ranges-1">NetworkSecurityRule#destination_port_ranges</a>.
        /// </summary>
        [<CustomOperation "destination_port_ranges">]
        member _.DestinationPortRanges(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: seq<string>) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DestinationPortRanges <- (value |> Seq.toArray))
            state : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#id-1">NetworkSecurityRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: string) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#source_address_prefix-1">NetworkSecurityRule#source_address_prefix</a>.
        /// </summary>
        [<CustomOperation "source_address_prefix">]
        member _.SourceAddressPrefix(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: string) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceAddressPrefix <- value)
            state : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#source_address_prefixes-1">NetworkSecurityRule#source_address_prefixes</a>.
        /// </summary>
        [<CustomOperation "source_address_prefixes">]
        member _.SourceAddressPrefixes(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: seq<string>) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceAddressPrefixes <- (value |> Seq.toArray))
            state : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#source_application_security_group_ids-1">NetworkSecurityRule#source_application_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "source_application_security_group_ids">]
        member _.SourceApplicationSecurityGroupIds(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: seq<string>) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceApplicationSecurityGroupIds <- (value |> Seq.toArray))
            state : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#source_port_range-1">NetworkSecurityRule#source_port_range</a>.
        /// </summary>
        [<CustomOperation "source_port_range">]
        member _.SourcePortRange(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: string) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourcePortRange <- value)
            state : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#source_port_ranges-1">NetworkSecurityRule#source_port_ranges</a>.
        /// </summary>
        [<CustomOperation "source_port_ranges">]
        member _.SourcePortRanges(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: seq<string>) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourcePortRanges <- (value |> Seq.toArray))
            state : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_rule#timeouts-1">NetworkSecurityRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>, value: azurerm.NetworkSecurityRule.NetworkSecurityRuleTimeouts) : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkSecurityRuleState<'Access, 'Direction, 'Name, 'NetworkSecurityGroupName, 'Priority, 'Protocol, 'ResourceGroupName>

        member _.Run(state: NetworkSecurityRuleState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.NetworkSecurityRule.NetworkSecurityRule =
            let config = azurerm.NetworkSecurityRule.NetworkSecurityRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkSecurityRule.NetworkSecurityRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkSecurityRule: missing required arguments. Must call: access, direction, name, network_security_group_name, priority, protocol, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: NetworkSecurityRuleState<_, _, _, _, _, _, _>) : azurerm.NetworkSecurityRule.NetworkSecurityRule =
            Unchecked.defaultof<azurerm.NetworkSecurityRule.NetworkSecurityRule>
