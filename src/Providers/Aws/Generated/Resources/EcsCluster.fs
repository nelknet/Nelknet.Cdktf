namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcsClusterState<'Name> = { assignments: ResizeArray<aws.EcsCluster.EcsClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster">aws_ecs_cluster</a>.
    /// </summary>
    type EcsClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcsClusterState<Missing> =
            ({ assignments = ResizeArray() } : EcsClusterState<Missing>)

        member _.Zero(()) : EcsClusterState<Missing> =
            ({ assignments = ResizeArray() } : EcsClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#name-1">EcsCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EcsClusterState<Missing>, value: string) : EcsClusterState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EcsClusterState<Present>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#configuration-1">EcsCluster#configuration</a>
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: EcsClusterState<'Name>, value: aws.EcsCluster.EcsClusterConfiguration) : EcsClusterState<'Name> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : EcsClusterState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#id-1">EcsCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcsClusterState<'Name>, value: string) : EcsClusterState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcsClusterState<'Name>

        /// <summary>
        /// service_connect_defaults block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#service_connect_defaults-1">EcsCluster#service_connect_defaults</a>
        /// </summary>
        [<CustomOperation "service_connect_defaults">]
        member _.ServiceConnectDefaults(state: EcsClusterState<'Name>, value: aws.EcsCluster.EcsClusterServiceConnectDefaults) : EcsClusterState<'Name> =
            state.assignments.Add(fun config -> config.ServiceConnectDefaults <- value)
            state : EcsClusterState<'Name>

        /// <summary>
        /// setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#setting-1">EcsCluster#setting</a> Accepts: aws.IResolvable | aws.EcsCluster.EcsClusterSetting[]
        /// </summary>
        [<CustomOperation "setting">]
        member _.Setting(state: EcsClusterState<'Name>, value: HashiCorp.Cdktf.IResolvable) : EcsClusterState<'Name> =
            state.assignments.Add(fun config -> config.Setting <- value)
            state : EcsClusterState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#tags-1">EcsCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EcsClusterState<'Name>, value: seq<string * string>) : EcsClusterState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EcsClusterState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#tags_all-1">EcsCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EcsClusterState<'Name>, value: seq<string * string>) : EcsClusterState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EcsClusterState<'Name>

        member _.Run(state: EcsClusterState<Present>) : aws.EcsCluster.EcsCluster =
            let config = aws.EcsCluster.EcsClusterConfig()
            for setter in state.assignments do
                setter config
            aws.EcsCluster.EcsCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecsCluster: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: EcsClusterState<_>) : aws.EcsCluster.EcsCluster =
            Unchecked.defaultof<aws.EcsCluster.EcsCluster>
