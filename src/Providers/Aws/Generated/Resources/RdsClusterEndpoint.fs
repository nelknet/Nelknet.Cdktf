namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType> = { assignments: ResizeArray<aws.RdsClusterEndpoint.RdsClusterEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_endpoint">aws_rds_cluster_endpoint</a>.
    /// </summary>
    type RdsClusterEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsClusterEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsClusterEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : RdsClusterEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsClusterEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_endpoint#cluster_endpoint_identifier-1">RdsClusterEndpoint#cluster_endpoint_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_endpoint_identifier">]
        member _.ClusterEndpointIdentifier(state: RdsClusterEndpointState<Missing, 'ClusterIdentifier, 'CustomEndpointType>, value: string) : RdsClusterEndpointState<Present, 'ClusterIdentifier, 'CustomEndpointType> =
            state.assignments.Add(fun config -> config.ClusterEndpointIdentifier <- value)
            ({ assignments = state.assignments } : RdsClusterEndpointState<Present, 'ClusterIdentifier, 'CustomEndpointType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_endpoint#cluster_identifier-1">RdsClusterEndpoint#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: RdsClusterEndpointState<'ClusterEndpointIdentifier, Missing, 'CustomEndpointType>, value: string) : RdsClusterEndpointState<'ClusterEndpointIdentifier, Present, 'CustomEndpointType> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : RdsClusterEndpointState<'ClusterEndpointIdentifier, Present, 'CustomEndpointType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_endpoint#custom_endpoint_type-1">RdsClusterEndpoint#custom_endpoint_type</a>.
        /// </summary>
        [<CustomOperation "custom_endpoint_type">]
        member _.CustomEndpointType(state: RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, Missing>, value: string) : RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, Present> =
            state.assignments.Add(fun config -> config.CustomEndpointType <- value)
            ({ assignments = state.assignments } : RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_endpoint#excluded_members-1">RdsClusterEndpoint#excluded_members</a>.
        /// </summary>
        [<CustomOperation "excluded_members">]
        member _.ExcludedMembers(state: RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType>, value: seq<string>) : RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType> =
            state.assignments.Add(fun config -> config.ExcludedMembers <- (value |> Seq.toArray))
            state : RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_endpoint#id-1">RdsClusterEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType>, value: string) : RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_endpoint#static_members-1">RdsClusterEndpoint#static_members</a>.
        /// </summary>
        [<CustomOperation "static_members">]
        member _.StaticMembers(state: RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType>, value: seq<string>) : RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType> =
            state.assignments.Add(fun config -> config.StaticMembers <- (value |> Seq.toArray))
            state : RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_endpoint#tags-1">RdsClusterEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType>, value: seq<string * string>) : RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_endpoint#tags_all-1">RdsClusterEndpoint#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType>, value: seq<string * string>) : RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RdsClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'CustomEndpointType>

        member _.Run(state: RdsClusterEndpointState<Present, Present, Present>) : aws.RdsClusterEndpoint.RdsClusterEndpoint =
            let config = aws.RdsClusterEndpoint.RdsClusterEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.RdsClusterEndpoint.RdsClusterEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsClusterEndpoint: missing required arguments. Must call: cluster_endpoint_identifier, cluster_identifier, custom_endpoint_type.", 9999, IsError = true)>]
        member _.Run(_: RdsClusterEndpointState<_, _, _>) : aws.RdsClusterEndpoint.RdsClusterEndpoint =
            Unchecked.defaultof<aws.RdsClusterEndpoint.RdsClusterEndpoint>
