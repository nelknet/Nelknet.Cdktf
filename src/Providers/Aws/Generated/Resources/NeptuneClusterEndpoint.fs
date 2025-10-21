namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType> = { assignments: ResizeArray<aws.NeptuneClusterEndpoint.NeptuneClusterEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_endpoint">aws_neptune_cluster_endpoint</a>.
    /// </summary>
    type NeptuneClusterEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : NeptuneClusterEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NeptuneClusterEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : NeptuneClusterEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NeptuneClusterEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_endpoint#cluster_endpoint_identifier-1">NeptuneClusterEndpoint#cluster_endpoint_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_endpoint_identifier">]
        member _.ClusterEndpointIdentifier(state: NeptuneClusterEndpointState<Missing, 'ClusterIdentifier, 'EndpointType>, value: string) : NeptuneClusterEndpointState<Present, 'ClusterIdentifier, 'EndpointType> =
            state.assignments.Add(fun config -> config.ClusterEndpointIdentifier <- value)
            ({ assignments = state.assignments } : NeptuneClusterEndpointState<Present, 'ClusterIdentifier, 'EndpointType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_endpoint#cluster_identifier-1">NeptuneClusterEndpoint#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: NeptuneClusterEndpointState<'ClusterEndpointIdentifier, Missing, 'EndpointType>, value: string) : NeptuneClusterEndpointState<'ClusterEndpointIdentifier, Present, 'EndpointType> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : NeptuneClusterEndpointState<'ClusterEndpointIdentifier, Present, 'EndpointType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_endpoint#endpoint_type-1">NeptuneClusterEndpoint#endpoint_type</a>.
        /// </summary>
        [<CustomOperation "endpoint_type">]
        member _.EndpointType(state: NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, Missing>, value: string) : NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, Present> =
            state.assignments.Add(fun config -> config.EndpointType <- value)
            ({ assignments = state.assignments } : NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_endpoint#excluded_members-1">NeptuneClusterEndpoint#excluded_members</a>.
        /// </summary>
        [<CustomOperation "excluded_members">]
        member _.ExcludedMembers(state: NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType>, value: seq<string>) : NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType> =
            state.assignments.Add(fun config -> config.ExcludedMembers <- (value |> Seq.toArray))
            state : NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_endpoint#id-1">NeptuneClusterEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType>, value: string) : NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_endpoint#static_members-1">NeptuneClusterEndpoint#static_members</a>.
        /// </summary>
        [<CustomOperation "static_members">]
        member _.StaticMembers(state: NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType>, value: seq<string>) : NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType> =
            state.assignments.Add(fun config -> config.StaticMembers <- (value |> Seq.toArray))
            state : NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_endpoint#tags-1">NeptuneClusterEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType>, value: seq<string * string>) : NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_endpoint#tags_all-1">NeptuneClusterEndpoint#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType>, value: seq<string * string>) : NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NeptuneClusterEndpointState<'ClusterEndpointIdentifier, 'ClusterIdentifier, 'EndpointType>

        member _.Run(state: NeptuneClusterEndpointState<Present, Present, Present>) : aws.NeptuneClusterEndpoint.NeptuneClusterEndpoint =
            let config = aws.NeptuneClusterEndpoint.NeptuneClusterEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.NeptuneClusterEndpoint.NeptuneClusterEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.neptuneClusterEndpoint: missing required arguments. Must call: cluster_endpoint_identifier, cluster_identifier, endpoint_type.", 9999, IsError = true)>]
        member _.Run(_: NeptuneClusterEndpointState<_, _, _>) : aws.NeptuneClusterEndpoint.NeptuneClusterEndpoint =
            Unchecked.defaultof<aws.NeptuneClusterEndpoint.NeptuneClusterEndpoint>
