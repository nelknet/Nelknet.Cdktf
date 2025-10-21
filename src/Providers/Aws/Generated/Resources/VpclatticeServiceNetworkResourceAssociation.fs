namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpclatticeServiceNetworkResourceAssociationState<'ResourceConfigurationIdentifier, 'ServiceNetworkIdentifier> = { assignments: ResizeArray<aws.VpclatticeServiceNetworkResourceAssociation.VpclatticeServiceNetworkResourceAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_resource_association">aws_vpclattice_service_network_resource_association</a>.
    /// </summary>
    type VpclatticeServiceNetworkResourceAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpclatticeServiceNetworkResourceAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeServiceNetworkResourceAssociationState<Missing, Missing>)

        member _.Zero(()) : VpclatticeServiceNetworkResourceAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeServiceNetworkResourceAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_resource_association#resource_configuration_identifier-1">VpclatticeServiceNetworkResourceAssociation#resource_configuration_identifier</a>.
        /// </summary>
        [<CustomOperation "resource_configuration_identifier">]
        member _.ResourceConfigurationIdentifier(state: VpclatticeServiceNetworkResourceAssociationState<Missing, 'ServiceNetworkIdentifier>, value: string) : VpclatticeServiceNetworkResourceAssociationState<Present, 'ServiceNetworkIdentifier> =
            state.assignments.Add(fun config -> config.ResourceConfigurationIdentifier <- value)
            ({ assignments = state.assignments } : VpclatticeServiceNetworkResourceAssociationState<Present, 'ServiceNetworkIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_resource_association#service_network_identifier-1">VpclatticeServiceNetworkResourceAssociation#service_network_identifier</a>.
        /// </summary>
        [<CustomOperation "service_network_identifier">]
        member _.ServiceNetworkIdentifier(state: VpclatticeServiceNetworkResourceAssociationState<'ResourceConfigurationIdentifier, Missing>, value: string) : VpclatticeServiceNetworkResourceAssociationState<'ResourceConfigurationIdentifier, Present> =
            state.assignments.Add(fun config -> config.ServiceNetworkIdentifier <- value)
            ({ assignments = state.assignments } : VpclatticeServiceNetworkResourceAssociationState<'ResourceConfigurationIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_resource_association#tags-1">VpclatticeServiceNetworkResourceAssociation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpclatticeServiceNetworkResourceAssociationState<'ResourceConfigurationIdentifier, 'ServiceNetworkIdentifier>, value: seq<string * string>) : VpclatticeServiceNetworkResourceAssociationState<'ResourceConfigurationIdentifier, 'ServiceNetworkIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpclatticeServiceNetworkResourceAssociationState<'ResourceConfigurationIdentifier, 'ServiceNetworkIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_service_network_resource_association#timeouts-1">VpclatticeServiceNetworkResourceAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpclatticeServiceNetworkResourceAssociationState<'ResourceConfigurationIdentifier, 'ServiceNetworkIdentifier>, value: aws.VpclatticeServiceNetworkResourceAssociation.VpclatticeServiceNetworkResourceAssociationTimeouts) : VpclatticeServiceNetworkResourceAssociationState<'ResourceConfigurationIdentifier, 'ServiceNetworkIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpclatticeServiceNetworkResourceAssociationState<'ResourceConfigurationIdentifier, 'ServiceNetworkIdentifier>

        member _.Run(state: VpclatticeServiceNetworkResourceAssociationState<Present, Present>) : aws.VpclatticeServiceNetworkResourceAssociation.VpclatticeServiceNetworkResourceAssociation =
            let config = aws.VpclatticeServiceNetworkResourceAssociation.VpclatticeServiceNetworkResourceAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.VpclatticeServiceNetworkResourceAssociation.VpclatticeServiceNetworkResourceAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpclatticeServiceNetworkResourceAssociation: missing required arguments. Must call: resource_configuration_identifier, service_network_identifier.", 9999, IsError = true)>]
        member _.Run(_: VpclatticeServiceNetworkResourceAssociationState<_, _>) : aws.VpclatticeServiceNetworkResourceAssociation.VpclatticeServiceNetworkResourceAssociation =
            Unchecked.defaultof<aws.VpclatticeServiceNetworkResourceAssociation.VpclatticeServiceNetworkResourceAssociation>
