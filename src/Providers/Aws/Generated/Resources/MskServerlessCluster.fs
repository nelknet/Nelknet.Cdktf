namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MskServerlessClusterState<'ClientAuthentication, 'ClusterName, 'VpcConfig> = { assignments: ResizeArray<aws.MskServerlessCluster.MskServerlessClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster">aws_msk_serverless_cluster</a>.
    /// </summary>
    type MskServerlessClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : MskServerlessClusterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MskServerlessClusterState<Missing, Missing, Missing>)

        member _.Zero(()) : MskServerlessClusterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MskServerlessClusterState<Missing, Missing, Missing>)

        /// <summary>
        /// client_authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#client_authentication-1">MskServerlessCluster#client_authentication</a>
        /// </summary>
        [<CustomOperation "client_authentication">]
        member _.ClientAuthentication(state: MskServerlessClusterState<Missing, 'ClusterName, 'VpcConfig>, value: aws.MskServerlessCluster.MskServerlessClusterClientAuthentication) : MskServerlessClusterState<Present, 'ClusterName, 'VpcConfig> =
            state.assignments.Add(fun config -> config.ClientAuthentication <- value)
            ({ assignments = state.assignments } : MskServerlessClusterState<Present, 'ClusterName, 'VpcConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#cluster_name-1">MskServerlessCluster#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: MskServerlessClusterState<'ClientAuthentication, Missing, 'VpcConfig>, value: string) : MskServerlessClusterState<'ClientAuthentication, Present, 'VpcConfig> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : MskServerlessClusterState<'ClientAuthentication, Present, 'VpcConfig>)

        /// <summary>
        /// vpc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#vpc_config-1">MskServerlessCluster#vpc_config</a> Accepts: aws.IResolvable | aws.MskServerlessCluster.MskServerlessClusterVpcConfig[]
        /// </summary>
        [<CustomOperation "vpc_config">]
        member _.VpcConfig(state: MskServerlessClusterState<'ClientAuthentication, 'ClusterName, Missing>, value: HashiCorp.Cdktf.IResolvable) : MskServerlessClusterState<'ClientAuthentication, 'ClusterName, Present> =
            state.assignments.Add(fun config -> config.VpcConfig <- value)
            ({ assignments = state.assignments } : MskServerlessClusterState<'ClientAuthentication, 'ClusterName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#id-1">MskServerlessCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MskServerlessClusterState<'ClientAuthentication, 'ClusterName, 'VpcConfig>, value: string) : MskServerlessClusterState<'ClientAuthentication, 'ClusterName, 'VpcConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MskServerlessClusterState<'ClientAuthentication, 'ClusterName, 'VpcConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#tags-1">MskServerlessCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MskServerlessClusterState<'ClientAuthentication, 'ClusterName, 'VpcConfig>, value: seq<string * string>) : MskServerlessClusterState<'ClientAuthentication, 'ClusterName, 'VpcConfig> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MskServerlessClusterState<'ClientAuthentication, 'ClusterName, 'VpcConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#tags_all-1">MskServerlessCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MskServerlessClusterState<'ClientAuthentication, 'ClusterName, 'VpcConfig>, value: seq<string * string>) : MskServerlessClusterState<'ClientAuthentication, 'ClusterName, 'VpcConfig> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MskServerlessClusterState<'ClientAuthentication, 'ClusterName, 'VpcConfig>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_serverless_cluster#timeouts-1">MskServerlessCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MskServerlessClusterState<'ClientAuthentication, 'ClusterName, 'VpcConfig>, value: aws.MskServerlessCluster.MskServerlessClusterTimeouts) : MskServerlessClusterState<'ClientAuthentication, 'ClusterName, 'VpcConfig> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MskServerlessClusterState<'ClientAuthentication, 'ClusterName, 'VpcConfig>

        member _.Run(state: MskServerlessClusterState<Present, Present, Present>) : aws.MskServerlessCluster.MskServerlessCluster =
            let config = aws.MskServerlessCluster.MskServerlessClusterConfig()
            for setter in state.assignments do
                setter config
            aws.MskServerlessCluster.MskServerlessCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mskServerlessCluster: missing required arguments. Must call: client_authentication, cluster_name, vpc_config.", 9999, IsError = true)>]
        member _.Run(_: MskServerlessClusterState<_, _, _>) : aws.MskServerlessCluster.MskServerlessCluster =
            Unchecked.defaultof<aws.MskServerlessCluster.MskServerlessCluster>
