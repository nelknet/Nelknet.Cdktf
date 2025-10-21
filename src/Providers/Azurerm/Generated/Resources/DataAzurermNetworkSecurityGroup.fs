namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetworkSecurityGroupState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermNetworkSecurityGroup.DataAzurermNetworkSecurityGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_security_group">azurerm_network_security_group</a>.
    /// </summary>
    type DataAzurermNetworkSecurityGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetworkSecurityGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetworkSecurityGroupState<Missing, Missing>)

        member _.Zero(()) : DataAzurermNetworkSecurityGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetworkSecurityGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_security_group#name-1">DataAzurermNetworkSecurityGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNetworkSecurityGroupState<Missing, 'ResourceGroupName>, value: string) : DataAzurermNetworkSecurityGroupState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNetworkSecurityGroupState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_security_group#resource_group_name-1">DataAzurermNetworkSecurityGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermNetworkSecurityGroupState<'Name, Missing>, value: string) : DataAzurermNetworkSecurityGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermNetworkSecurityGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_security_group#id-1">DataAzurermNetworkSecurityGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetworkSecurityGroupState<'Name, 'ResourceGroupName>, value: string) : DataAzurermNetworkSecurityGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetworkSecurityGroupState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_security_group#timeouts-1">DataAzurermNetworkSecurityGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetworkSecurityGroupState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermNetworkSecurityGroup.DataAzurermNetworkSecurityGroupTimeouts) : DataAzurermNetworkSecurityGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetworkSecurityGroupState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermNetworkSecurityGroupState<Present, Present>) : azurerm.DataAzurermNetworkSecurityGroup.DataAzurermNetworkSecurityGroup =
            let config = azurerm.DataAzurermNetworkSecurityGroup.DataAzurermNetworkSecurityGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetworkSecurityGroup.DataAzurermNetworkSecurityGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetworkSecurityGroup: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetworkSecurityGroupState<_, _>) : azurerm.DataAzurermNetworkSecurityGroup.DataAzurermNetworkSecurityGroup =
            Unchecked.defaultof<azurerm.DataAzurermNetworkSecurityGroup.DataAzurermNetworkSecurityGroup>
