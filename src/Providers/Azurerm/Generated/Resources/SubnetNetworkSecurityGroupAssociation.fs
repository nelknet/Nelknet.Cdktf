namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SubnetNetworkSecurityGroupAssociationState<'NetworkSecurityGroupId, 'SubnetId> = { assignments: ResizeArray<azurerm.SubnetNetworkSecurityGroupAssociation.SubnetNetworkSecurityGroupAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_network_security_group_association">azurerm_subnet_network_security_group_association</a>.
    /// </summary>
    type SubnetNetworkSecurityGroupAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SubnetNetworkSecurityGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SubnetNetworkSecurityGroupAssociationState<Missing, Missing>)

        member _.Zero(()) : SubnetNetworkSecurityGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SubnetNetworkSecurityGroupAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_network_security_group_association#network_security_group_id-1">SubnetNetworkSecurityGroupAssociation#network_security_group_id</a>.
        /// </summary>
        [<CustomOperation "network_security_group_id">]
        member _.NetworkSecurityGroupId(state: SubnetNetworkSecurityGroupAssociationState<Missing, 'SubnetId>, value: string) : SubnetNetworkSecurityGroupAssociationState<Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.NetworkSecurityGroupId <- value)
            ({ assignments = state.assignments } : SubnetNetworkSecurityGroupAssociationState<Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_network_security_group_association#subnet_id-1">SubnetNetworkSecurityGroupAssociation#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: SubnetNetworkSecurityGroupAssociationState<'NetworkSecurityGroupId, Missing>, value: string) : SubnetNetworkSecurityGroupAssociationState<'NetworkSecurityGroupId, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : SubnetNetworkSecurityGroupAssociationState<'NetworkSecurityGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_network_security_group_association#id-1">SubnetNetworkSecurityGroupAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SubnetNetworkSecurityGroupAssociationState<'NetworkSecurityGroupId, 'SubnetId>, value: string) : SubnetNetworkSecurityGroupAssociationState<'NetworkSecurityGroupId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SubnetNetworkSecurityGroupAssociationState<'NetworkSecurityGroupId, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_network_security_group_association#timeouts-1">SubnetNetworkSecurityGroupAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SubnetNetworkSecurityGroupAssociationState<'NetworkSecurityGroupId, 'SubnetId>, value: azurerm.SubnetNetworkSecurityGroupAssociation.SubnetNetworkSecurityGroupAssociationTimeouts) : SubnetNetworkSecurityGroupAssociationState<'NetworkSecurityGroupId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SubnetNetworkSecurityGroupAssociationState<'NetworkSecurityGroupId, 'SubnetId>

        member _.Run(state: SubnetNetworkSecurityGroupAssociationState<Present, Present>) : azurerm.SubnetNetworkSecurityGroupAssociation.SubnetNetworkSecurityGroupAssociation =
            let config = azurerm.SubnetNetworkSecurityGroupAssociation.SubnetNetworkSecurityGroupAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.SubnetNetworkSecurityGroupAssociation.SubnetNetworkSecurityGroupAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.subnetNetworkSecurityGroupAssociation: missing required arguments. Must call: network_security_group_id, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: SubnetNetworkSecurityGroupAssociationState<_, _>) : azurerm.SubnetNetworkSecurityGroupAssociation.SubnetNetworkSecurityGroupAssociation =
            Unchecked.defaultof<azurerm.SubnetNetworkSecurityGroupAssociation.SubnetNetworkSecurityGroupAssociation>
