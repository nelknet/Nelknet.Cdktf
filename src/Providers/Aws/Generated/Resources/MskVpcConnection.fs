namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, 'VpcId> = { assignments: ResizeArray<aws.MskVpcConnection.MskVpcConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_vpc_connection">aws_msk_vpc_connection</a>.
    /// </summary>
    type MskVpcConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : MskVpcConnectionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MskVpcConnectionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MskVpcConnectionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MskVpcConnectionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_vpc_connection#authentication-1">MskVpcConnection#authentication</a>.
        /// </summary>
        [<CustomOperation "authentication">]
        member _.Authentication(state: MskVpcConnectionState<Missing, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, 'VpcId>, value: string) : MskVpcConnectionState<Present, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, 'VpcId> =
            state.assignments.Add(fun config -> config.Authentication <- value)
            ({ assignments = state.assignments } : MskVpcConnectionState<Present, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_vpc_connection#client_subnets-1">MskVpcConnection#client_subnets</a>.
        /// </summary>
        [<CustomOperation "client_subnets">]
        member _.ClientSubnets(state: MskVpcConnectionState<'Authentication, Missing, 'SecurityGroups, 'TargetClusterArn, 'VpcId>, value: seq<string>) : MskVpcConnectionState<'Authentication, Present, 'SecurityGroups, 'TargetClusterArn, 'VpcId> =
            state.assignments.Add(fun config -> config.ClientSubnets <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MskVpcConnectionState<'Authentication, Present, 'SecurityGroups, 'TargetClusterArn, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_vpc_connection#security_groups-1">MskVpcConnection#security_groups</a>.
        /// </summary>
        [<CustomOperation "security_groups">]
        member _.SecurityGroups(state: MskVpcConnectionState<'Authentication, 'ClientSubnets, Missing, 'TargetClusterArn, 'VpcId>, value: seq<string>) : MskVpcConnectionState<'Authentication, 'ClientSubnets, Present, 'TargetClusterArn, 'VpcId> =
            state.assignments.Add(fun config -> config.SecurityGroups <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MskVpcConnectionState<'Authentication, 'ClientSubnets, Present, 'TargetClusterArn, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_vpc_connection#target_cluster_arn-1">MskVpcConnection#target_cluster_arn</a>.
        /// </summary>
        [<CustomOperation "target_cluster_arn">]
        member _.TargetClusterArn(state: MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, Missing, 'VpcId>, value: string) : MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, Present, 'VpcId> =
            state.assignments.Add(fun config -> config.TargetClusterArn <- value)
            ({ assignments = state.assignments } : MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_vpc_connection#vpc_id-1">MskVpcConnection#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, Missing>, value: string) : MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_vpc_connection#id-1">MskVpcConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, 'VpcId>, value: string) : MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, 'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_vpc_connection#tags-1">MskVpcConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, 'VpcId>, value: seq<string * string>) : MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, 'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_vpc_connection#tags_all-1">MskVpcConnection#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, 'VpcId>, value: seq<string * string>) : MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, 'VpcId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MskVpcConnectionState<'Authentication, 'ClientSubnets, 'SecurityGroups, 'TargetClusterArn, 'VpcId>

        member _.Run(state: MskVpcConnectionState<Present, Present, Present, Present, Present>) : aws.MskVpcConnection.MskVpcConnection =
            let config = aws.MskVpcConnection.MskVpcConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.MskVpcConnection.MskVpcConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mskVpcConnection: missing required arguments. Must call: authentication, client_subnets, security_groups, target_cluster_arn, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: MskVpcConnectionState<_, _, _, _, _>) : aws.MskVpcConnection.MskVpcConnection =
            Unchecked.defaultof<aws.MskVpcConnection.MskVpcConnection>
