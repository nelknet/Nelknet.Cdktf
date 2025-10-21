namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, 'DeviceId, 'GlobalNetworkId> = { assignments: ResizeArray<aws.NetworkmanagerCustomerGatewayAssociation.NetworkmanagerCustomerGatewayAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_customer_gateway_association">aws_networkmanager_customer_gateway_association</a>.
    /// </summary>
    type NetworkmanagerCustomerGatewayAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerCustomerGatewayAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerCustomerGatewayAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkmanagerCustomerGatewayAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerCustomerGatewayAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_customer_gateway_association#customer_gateway_arn-1">NetworkmanagerCustomerGatewayAssociation#customer_gateway_arn</a>.
        /// </summary>
        [<CustomOperation "customer_gateway_arn">]
        member _.CustomerGatewayArn(state: NetworkmanagerCustomerGatewayAssociationState<Missing, 'DeviceId, 'GlobalNetworkId>, value: string) : NetworkmanagerCustomerGatewayAssociationState<Present, 'DeviceId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.CustomerGatewayArn <- value)
            ({ assignments = state.assignments } : NetworkmanagerCustomerGatewayAssociationState<Present, 'DeviceId, 'GlobalNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_customer_gateway_association#device_id-1">NetworkmanagerCustomerGatewayAssociation#device_id</a>.
        /// </summary>
        [<CustomOperation "device_id">]
        member _.DeviceId(state: NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, Missing, 'GlobalNetworkId>, value: string) : NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, Present, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.DeviceId <- value)
            ({ assignments = state.assignments } : NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, Present, 'GlobalNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_customer_gateway_association#global_network_id-1">NetworkmanagerCustomerGatewayAssociation#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, 'DeviceId, Missing>, value: string) : NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, 'DeviceId, Present> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, 'DeviceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_customer_gateway_association#id-1">NetworkmanagerCustomerGatewayAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, 'DeviceId, 'GlobalNetworkId>, value: string) : NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, 'DeviceId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, 'DeviceId, 'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_customer_gateway_association#link_id-1">NetworkmanagerCustomerGatewayAssociation#link_id</a>.
        /// </summary>
        [<CustomOperation "link_id">]
        member _.LinkId(state: NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, 'DeviceId, 'GlobalNetworkId>, value: string) : NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, 'DeviceId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.LinkId <- value)
            state : NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, 'DeviceId, 'GlobalNetworkId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_customer_gateway_association#timeouts-1">NetworkmanagerCustomerGatewayAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, 'DeviceId, 'GlobalNetworkId>, value: aws.NetworkmanagerCustomerGatewayAssociation.NetworkmanagerCustomerGatewayAssociationTimeouts) : NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, 'DeviceId, 'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerCustomerGatewayAssociationState<'CustomerGatewayArn, 'DeviceId, 'GlobalNetworkId>

        member _.Run(state: NetworkmanagerCustomerGatewayAssociationState<Present, Present, Present>) : aws.NetworkmanagerCustomerGatewayAssociation.NetworkmanagerCustomerGatewayAssociation =
            let config = aws.NetworkmanagerCustomerGatewayAssociation.NetworkmanagerCustomerGatewayAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerCustomerGatewayAssociation.NetworkmanagerCustomerGatewayAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerCustomerGatewayAssociation: missing required arguments. Must call: customer_gateway_arn, device_id, global_network_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerCustomerGatewayAssociationState<_, _, _>) : aws.NetworkmanagerCustomerGatewayAssociation.NetworkmanagerCustomerGatewayAssociation =
            Unchecked.defaultof<aws.NetworkmanagerCustomerGatewayAssociation.NetworkmanagerCustomerGatewayAssociation>
