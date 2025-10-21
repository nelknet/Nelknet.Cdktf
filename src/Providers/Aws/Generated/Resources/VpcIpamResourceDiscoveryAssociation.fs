namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcIpamResourceDiscoveryAssociationState<'IpamId, 'IpamResourceDiscoveryId> = { assignments: ResizeArray<aws.VpcIpamResourceDiscoveryAssociation.VpcIpamResourceDiscoveryAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery_association">aws_vpc_ipam_resource_discovery_association</a>.
    /// </summary>
    type VpcIpamResourceDiscoveryAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcIpamResourceDiscoveryAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcIpamResourceDiscoveryAssociationState<Missing, Missing>)

        member _.Zero(()) : VpcIpamResourceDiscoveryAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcIpamResourceDiscoveryAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery_association#ipam_id-1">VpcIpamResourceDiscoveryAssociation#ipam_id</a>.
        /// </summary>
        [<CustomOperation "ipam_id">]
        member _.IpamId(state: VpcIpamResourceDiscoveryAssociationState<Missing, 'IpamResourceDiscoveryId>, value: string) : VpcIpamResourceDiscoveryAssociationState<Present, 'IpamResourceDiscoveryId> =
            state.assignments.Add(fun config -> config.IpamId <- value)
            ({ assignments = state.assignments } : VpcIpamResourceDiscoveryAssociationState<Present, 'IpamResourceDiscoveryId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery_association#ipam_resource_discovery_id-1">VpcIpamResourceDiscoveryAssociation#ipam_resource_discovery_id</a>.
        /// </summary>
        [<CustomOperation "ipam_resource_discovery_id">]
        member _.IpamResourceDiscoveryId(state: VpcIpamResourceDiscoveryAssociationState<'IpamId, Missing>, value: string) : VpcIpamResourceDiscoveryAssociationState<'IpamId, Present> =
            state.assignments.Add(fun config -> config.IpamResourceDiscoveryId <- value)
            ({ assignments = state.assignments } : VpcIpamResourceDiscoveryAssociationState<'IpamId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery_association#id-1">VpcIpamResourceDiscoveryAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcIpamResourceDiscoveryAssociationState<'IpamId, 'IpamResourceDiscoveryId>, value: string) : VpcIpamResourceDiscoveryAssociationState<'IpamId, 'IpamResourceDiscoveryId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcIpamResourceDiscoveryAssociationState<'IpamId, 'IpamResourceDiscoveryId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery_association#tags-1">VpcIpamResourceDiscoveryAssociation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcIpamResourceDiscoveryAssociationState<'IpamId, 'IpamResourceDiscoveryId>, value: seq<string * string>) : VpcIpamResourceDiscoveryAssociationState<'IpamId, 'IpamResourceDiscoveryId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcIpamResourceDiscoveryAssociationState<'IpamId, 'IpamResourceDiscoveryId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery_association#tags_all-1">VpcIpamResourceDiscoveryAssociation#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpcIpamResourceDiscoveryAssociationState<'IpamId, 'IpamResourceDiscoveryId>, value: seq<string * string>) : VpcIpamResourceDiscoveryAssociationState<'IpamId, 'IpamResourceDiscoveryId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpcIpamResourceDiscoveryAssociationState<'IpamId, 'IpamResourceDiscoveryId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery_association#timeouts-1">VpcIpamResourceDiscoveryAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcIpamResourceDiscoveryAssociationState<'IpamId, 'IpamResourceDiscoveryId>, value: aws.VpcIpamResourceDiscoveryAssociation.VpcIpamResourceDiscoveryAssociationTimeouts) : VpcIpamResourceDiscoveryAssociationState<'IpamId, 'IpamResourceDiscoveryId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcIpamResourceDiscoveryAssociationState<'IpamId, 'IpamResourceDiscoveryId>

        member _.Run(state: VpcIpamResourceDiscoveryAssociationState<Present, Present>) : aws.VpcIpamResourceDiscoveryAssociation.VpcIpamResourceDiscoveryAssociation =
            let config = aws.VpcIpamResourceDiscoveryAssociation.VpcIpamResourceDiscoveryAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.VpcIpamResourceDiscoveryAssociation.VpcIpamResourceDiscoveryAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcIpamResourceDiscoveryAssociation: missing required arguments. Must call: ipam_id, ipam_resource_discovery_id.", 9999, IsError = true)>]
        member _.Run(_: VpcIpamResourceDiscoveryAssociationState<_, _>) : aws.VpcIpamResourceDiscoveryAssociation.VpcIpamResourceDiscoveryAssociation =
            Unchecked.defaultof<aws.VpcIpamResourceDiscoveryAssociation.VpcIpamResourceDiscoveryAssociation>
