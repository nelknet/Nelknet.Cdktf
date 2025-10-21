namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EipAssociationState = { assignments: ResizeArray<aws.EipAssociation.EipAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip_association">aws_eip_association</a>.
    /// </summary>
    type EipAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : EipAssociationState =
            { assignments = ResizeArray() }

        member _.Zero(()) : EipAssociationState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip_association#allocation_id-1">EipAssociation#allocation_id</a>.
        /// </summary>
        [<CustomOperation "allocation_id">]
        member _.AllocationId(state: EipAssociationState, value: string) : EipAssociationState =
            state.assignments.Add(fun config -> config.AllocationId <- value)
            state : EipAssociationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip_association#allow_reassociation-1">EipAssociation#allow_reassociation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_reassociation">]
        member _.AllowReassociation(state: EipAssociationState, value: bool) : EipAssociationState =
            state.assignments.Add(fun config -> config.AllowReassociation <- value)
            state : EipAssociationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip_association#allow_reassociation-1">EipAssociation#allow_reassociation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_reassociation">]
        member _.AllowReassociation(state: EipAssociationState, value: HashiCorp.Cdktf.IResolvable) : EipAssociationState =
            state.assignments.Add(fun config -> config.AllowReassociation <- value)
            state : EipAssociationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip_association#id-1">EipAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EipAssociationState, value: string) : EipAssociationState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EipAssociationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip_association#instance_id-1">EipAssociation#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: EipAssociationState, value: string) : EipAssociationState =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            state : EipAssociationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip_association#network_interface_id-1">EipAssociation#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: EipAssociationState, value: string) : EipAssociationState =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            state : EipAssociationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip_association#private_ip_address-1">EipAssociation#private_ip_address</a>.
        /// </summary>
        [<CustomOperation "private_ip_address">]
        member _.PrivateIpAddress(state: EipAssociationState, value: string) : EipAssociationState =
            state.assignments.Add(fun config -> config.PrivateIpAddress <- value)
            state : EipAssociationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip_association#public_ip-1">EipAssociation#public_ip</a>.
        /// </summary>
        [<CustomOperation "public_ip">]
        member _.PublicIp(state: EipAssociationState, value: string) : EipAssociationState =
            state.assignments.Add(fun config -> config.PublicIp <- value)
            state : EipAssociationState

        member _.Run(state: EipAssociationState) : aws.EipAssociation.EipAssociation =
            let config = aws.EipAssociation.EipAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.EipAssociation.EipAssociation(StackContext.get (), logicalId, config)
