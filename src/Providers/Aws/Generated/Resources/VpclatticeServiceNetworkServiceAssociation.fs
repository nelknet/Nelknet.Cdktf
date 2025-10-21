namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, 'ServiceNetworkIdentifier> = { assignments: ResizeArray<aws.VpclatticeServiceNetworkServiceAssociation.VpclatticeServiceNetworkServiceAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_service_association">aws_vpclattice_service_network_service_association</a>.
    /// </summary>
    type VpclatticeServiceNetworkServiceAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpclatticeServiceNetworkServiceAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeServiceNetworkServiceAssociationState<Missing, Missing>)

        member _.Zero(()) : VpclatticeServiceNetworkServiceAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeServiceNetworkServiceAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_service_association#service_identifier-1">VpclatticeServiceNetworkServiceAssociation#service_identifier</a>.
        /// </summary>
        [<CustomOperation "service_identifier">]
        member _.ServiceIdentifier(state: VpclatticeServiceNetworkServiceAssociationState<Missing, 'ServiceNetworkIdentifier>, value: string) : VpclatticeServiceNetworkServiceAssociationState<Present, 'ServiceNetworkIdentifier> =
            state.assignments.Add(fun config -> config.ServiceIdentifier <- value)
            ({ assignments = state.assignments } : VpclatticeServiceNetworkServiceAssociationState<Present, 'ServiceNetworkIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_service_association#service_network_identifier-1">VpclatticeServiceNetworkServiceAssociation#service_network_identifier</a>.
        /// </summary>
        [<CustomOperation "service_network_identifier">]
        member _.ServiceNetworkIdentifier(state: VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, Missing>, value: string) : VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, Present> =
            state.assignments.Add(fun config -> config.ServiceNetworkIdentifier <- value)
            ({ assignments = state.assignments } : VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_service_association#id-1">VpclatticeServiceNetworkServiceAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, 'ServiceNetworkIdentifier>, value: string) : VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, 'ServiceNetworkIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, 'ServiceNetworkIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_service_association#tags-1">VpclatticeServiceNetworkServiceAssociation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, 'ServiceNetworkIdentifier>, value: seq<string * string>) : VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, 'ServiceNetworkIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, 'ServiceNetworkIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_service_association#tags_all-1">VpclatticeServiceNetworkServiceAssociation#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, 'ServiceNetworkIdentifier>, value: seq<string * string>) : VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, 'ServiceNetworkIdentifier> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, 'ServiceNetworkIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_service_association#timeouts-1">VpclatticeServiceNetworkServiceAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, 'ServiceNetworkIdentifier>, value: aws.VpclatticeServiceNetworkServiceAssociation.VpclatticeServiceNetworkServiceAssociationTimeouts) : VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, 'ServiceNetworkIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpclatticeServiceNetworkServiceAssociationState<'ServiceIdentifier, 'ServiceNetworkIdentifier>

        member _.Run(state: VpclatticeServiceNetworkServiceAssociationState<Present, Present>) : aws.VpclatticeServiceNetworkServiceAssociation.VpclatticeServiceNetworkServiceAssociation =
            let config = aws.VpclatticeServiceNetworkServiceAssociation.VpclatticeServiceNetworkServiceAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.VpclatticeServiceNetworkServiceAssociation.VpclatticeServiceNetworkServiceAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpclatticeServiceNetworkServiceAssociation: missing required arguments. Must call: service_identifier, service_network_identifier.", 9999, IsError = true)>]
        member _.Run(_: VpclatticeServiceNetworkServiceAssociationState<_, _>) : aws.VpclatticeServiceNetworkServiceAssociation.VpclatticeServiceNetworkServiceAssociation =
            Unchecked.defaultof<aws.VpclatticeServiceNetworkServiceAssociation.VpclatticeServiceNetworkServiceAssociation>
