namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkSecurityGroupState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.NetworkSecurityGroup.NetworkSecurityGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_group">azurerm_network_security_group</a>.
    /// </summary>
    type NetworkSecurityGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkSecurityGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkSecurityGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkSecurityGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkSecurityGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_group#location-1">NetworkSecurityGroup#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetworkSecurityGroupState<Missing, 'Name, 'ResourceGroupName>, value: string) : NetworkSecurityGroupState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetworkSecurityGroupState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_group#name-1">NetworkSecurityGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkSecurityGroupState<'Location, Missing, 'ResourceGroupName>, value: string) : NetworkSecurityGroupState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkSecurityGroupState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_group#resource_group_name-1">NetworkSecurityGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetworkSecurityGroupState<'Location, 'Name, Missing>, value: string) : NetworkSecurityGroupState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetworkSecurityGroupState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_group#id-1">NetworkSecurityGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkSecurityGroupState<'Location, 'Name, 'ResourceGroupName>, value: string) : NetworkSecurityGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkSecurityGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_group#security_rule-1">NetworkSecurityGroup#security_rule</a>. Accepts: azurerm.IResolvable | azurerm.NetworkSecurityGroup.NetworkSecurityGroupSecurityRule[]
        /// </summary>
        [<CustomOperation "security_rule">]
        member _.SecurityRule(state: NetworkSecurityGroupState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : NetworkSecurityGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SecurityRule <- value)
            state : NetworkSecurityGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_group#tags-1">NetworkSecurityGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkSecurityGroupState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : NetworkSecurityGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkSecurityGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_security_group#timeouts-1">NetworkSecurityGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkSecurityGroupState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetworkSecurityGroup.NetworkSecurityGroupTimeouts) : NetworkSecurityGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkSecurityGroupState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: NetworkSecurityGroupState<Present, Present, Present>) : azurerm.NetworkSecurityGroup.NetworkSecurityGroup =
            let config = azurerm.NetworkSecurityGroup.NetworkSecurityGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkSecurityGroup.NetworkSecurityGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkSecurityGroup: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: NetworkSecurityGroupState<_, _, _>) : azurerm.NetworkSecurityGroup.NetworkSecurityGroup =
            Unchecked.defaultof<azurerm.NetworkSecurityGroup.NetworkSecurityGroup>
