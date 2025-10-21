namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier> = { assignments: ResizeArray<aws.VpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_vpc_association">aws_vpclattice_service_network_vpc_association</a>.
    /// </summary>
    type VpclatticeServiceNetworkVpcAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpclatticeServiceNetworkVpcAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeServiceNetworkVpcAssociationState<Missing, Missing>)

        member _.Zero(()) : VpclatticeServiceNetworkVpcAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeServiceNetworkVpcAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_vpc_association#service_network_identifier-1">VpclatticeServiceNetworkVpcAssociation#service_network_identifier</a>.
        /// </summary>
        [<CustomOperation "service_network_identifier">]
        member _.ServiceNetworkIdentifier(state: VpclatticeServiceNetworkVpcAssociationState<Missing, 'VpcIdentifier>, value: string) : VpclatticeServiceNetworkVpcAssociationState<Present, 'VpcIdentifier> =
            state.assignments.Add(fun config -> config.ServiceNetworkIdentifier <- value)
            ({ assignments = state.assignments } : VpclatticeServiceNetworkVpcAssociationState<Present, 'VpcIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_vpc_association#vpc_identifier-1">VpclatticeServiceNetworkVpcAssociation#vpc_identifier</a>.
        /// </summary>
        [<CustomOperation "vpc_identifier">]
        member _.VpcIdentifier(state: VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, Missing>, value: string) : VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, Present> =
            state.assignments.Add(fun config -> config.VpcIdentifier <- value)
            ({ assignments = state.assignments } : VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_vpc_association#id-1">VpclatticeServiceNetworkVpcAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier>, value: string) : VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_vpc_association#security_group_ids-1">VpclatticeServiceNetworkVpcAssociation#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier>, value: seq<string>) : VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_vpc_association#tags-1">VpclatticeServiceNetworkVpcAssociation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier>, value: seq<string * string>) : VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_vpc_association#tags_all-1">VpclatticeServiceNetworkVpcAssociation#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier>, value: seq<string * string>) : VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_vpc_association#timeouts-1">VpclatticeServiceNetworkVpcAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier>, value: aws.VpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationTimeouts) : VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpclatticeServiceNetworkVpcAssociationState<'ServiceNetworkIdentifier, 'VpcIdentifier>

        member _.Run(state: VpclatticeServiceNetworkVpcAssociationState<Present, Present>) : aws.VpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociation =
            let config = aws.VpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.VpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpclatticeServiceNetworkVpcAssociation: missing required arguments. Must call: service_network_identifier, vpc_identifier.", 9999, IsError = true)>]
        member _.Run(_: VpclatticeServiceNetworkVpcAssociationState<_, _>) : aws.VpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociation =
            Unchecked.defaultof<aws.VpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociation>
