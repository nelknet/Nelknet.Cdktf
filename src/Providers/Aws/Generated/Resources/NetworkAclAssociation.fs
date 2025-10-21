namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkAclAssociationState<'NetworkAclId, 'SubnetId> = { assignments: ResizeArray<aws.NetworkAclAssociation.NetworkAclAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_association">aws_network_acl_association</a>.
    /// </summary>
    type NetworkAclAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkAclAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkAclAssociationState<Missing, Missing>)

        member _.Zero(()) : NetworkAclAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkAclAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_association#network_acl_id-1">NetworkAclAssociation#network_acl_id</a>.
        /// </summary>
        [<CustomOperation "network_acl_id">]
        member _.NetworkAclId(state: NetworkAclAssociationState<Missing, 'SubnetId>, value: string) : NetworkAclAssociationState<Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.NetworkAclId <- value)
            ({ assignments = state.assignments } : NetworkAclAssociationState<Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_association#subnet_id-1">NetworkAclAssociation#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: NetworkAclAssociationState<'NetworkAclId, Missing>, value: string) : NetworkAclAssociationState<'NetworkAclId, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : NetworkAclAssociationState<'NetworkAclId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_association#id-1">NetworkAclAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkAclAssociationState<'NetworkAclId, 'SubnetId>, value: string) : NetworkAclAssociationState<'NetworkAclId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkAclAssociationState<'NetworkAclId, 'SubnetId>

        member _.Run(state: NetworkAclAssociationState<Present, Present>) : aws.NetworkAclAssociation.NetworkAclAssociation =
            let config = aws.NetworkAclAssociation.NetworkAclAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkAclAssociation.NetworkAclAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkAclAssociation: missing required arguments. Must call: network_acl_id, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkAclAssociationState<_, _>) : aws.NetworkAclAssociation.NetworkAclAssociation =
            Unchecked.defaultof<aws.NetworkAclAssociation.NetworkAclAssociation>
