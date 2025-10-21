namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerLinkAssociationState<'DeviceId, 'GlobalNetworkId, 'LinkId> = { assignments: ResizeArray<aws.NetworkmanagerLinkAssociation.NetworkmanagerLinkAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link_association">aws_networkmanager_link_association</a>.
    /// </summary>
    type NetworkmanagerLinkAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerLinkAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerLinkAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkmanagerLinkAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerLinkAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link_association#device_id-1">NetworkmanagerLinkAssociation#device_id</a>.
        /// </summary>
        [<CustomOperation "device_id">]
        member _.DeviceId(state: NetworkmanagerLinkAssociationState<Missing, 'GlobalNetworkId, 'LinkId>, value: string) : NetworkmanagerLinkAssociationState<Present, 'GlobalNetworkId, 'LinkId> =
            state.assignments.Add(fun config -> config.DeviceId <- value)
            ({ assignments = state.assignments } : NetworkmanagerLinkAssociationState<Present, 'GlobalNetworkId, 'LinkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link_association#global_network_id-1">NetworkmanagerLinkAssociation#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: NetworkmanagerLinkAssociationState<'DeviceId, Missing, 'LinkId>, value: string) : NetworkmanagerLinkAssociationState<'DeviceId, Present, 'LinkId> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerLinkAssociationState<'DeviceId, Present, 'LinkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link_association#link_id-1">NetworkmanagerLinkAssociation#link_id</a>.
        /// </summary>
        [<CustomOperation "link_id">]
        member _.LinkId(state: NetworkmanagerLinkAssociationState<'DeviceId, 'GlobalNetworkId, Missing>, value: string) : NetworkmanagerLinkAssociationState<'DeviceId, 'GlobalNetworkId, Present> =
            state.assignments.Add(fun config -> config.LinkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerLinkAssociationState<'DeviceId, 'GlobalNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link_association#id-1">NetworkmanagerLinkAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerLinkAssociationState<'DeviceId, 'GlobalNetworkId, 'LinkId>, value: string) : NetworkmanagerLinkAssociationState<'DeviceId, 'GlobalNetworkId, 'LinkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerLinkAssociationState<'DeviceId, 'GlobalNetworkId, 'LinkId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link_association#timeouts-1">NetworkmanagerLinkAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerLinkAssociationState<'DeviceId, 'GlobalNetworkId, 'LinkId>, value: aws.NetworkmanagerLinkAssociation.NetworkmanagerLinkAssociationTimeouts) : NetworkmanagerLinkAssociationState<'DeviceId, 'GlobalNetworkId, 'LinkId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerLinkAssociationState<'DeviceId, 'GlobalNetworkId, 'LinkId>

        member _.Run(state: NetworkmanagerLinkAssociationState<Present, Present, Present>) : aws.NetworkmanagerLinkAssociation.NetworkmanagerLinkAssociation =
            let config = aws.NetworkmanagerLinkAssociation.NetworkmanagerLinkAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerLinkAssociation.NetworkmanagerLinkAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerLinkAssociation: missing required arguments. Must call: device_id, global_network_id, link_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerLinkAssociationState<_, _, _>) : aws.NetworkmanagerLinkAssociation.NetworkmanagerLinkAssociation =
            Unchecked.defaultof<aws.NetworkmanagerLinkAssociation.NetworkmanagerLinkAssociation>
