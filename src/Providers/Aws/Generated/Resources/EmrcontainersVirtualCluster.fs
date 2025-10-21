namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EmrcontainersVirtualClusterState<'ContainerProvider, 'Name> = { assignments: ResizeArray<aws.EmrcontainersVirtualCluster.EmrcontainersVirtualClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_virtual_cluster">aws_emrcontainers_virtual_cluster</a>.
    /// </summary>
    type EmrcontainersVirtualClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : EmrcontainersVirtualClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrcontainersVirtualClusterState<Missing, Missing>)

        member _.Zero(()) : EmrcontainersVirtualClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrcontainersVirtualClusterState<Missing, Missing>)

        /// <summary>
        /// container_provider block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_virtual_cluster#container_provider-1">EmrcontainersVirtualCluster#container_provider</a>
        /// </summary>
        [<CustomOperation "container_provider">]
        member _.ContainerProvider(state: EmrcontainersVirtualClusterState<Missing, 'Name>, value: aws.EmrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProvider) : EmrcontainersVirtualClusterState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ContainerProvider <- value)
            ({ assignments = state.assignments } : EmrcontainersVirtualClusterState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_virtual_cluster#name-1">EmrcontainersVirtualCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EmrcontainersVirtualClusterState<'ContainerProvider, Missing>, value: string) : EmrcontainersVirtualClusterState<'ContainerProvider, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EmrcontainersVirtualClusterState<'ContainerProvider, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_virtual_cluster#id-1">EmrcontainersVirtualCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EmrcontainersVirtualClusterState<'ContainerProvider, 'Name>, value: string) : EmrcontainersVirtualClusterState<'ContainerProvider, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EmrcontainersVirtualClusterState<'ContainerProvider, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_virtual_cluster#tags-1">EmrcontainersVirtualCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EmrcontainersVirtualClusterState<'ContainerProvider, 'Name>, value: seq<string * string>) : EmrcontainersVirtualClusterState<'ContainerProvider, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EmrcontainersVirtualClusterState<'ContainerProvider, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_virtual_cluster#tags_all-1">EmrcontainersVirtualCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EmrcontainersVirtualClusterState<'ContainerProvider, 'Name>, value: seq<string * string>) : EmrcontainersVirtualClusterState<'ContainerProvider, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EmrcontainersVirtualClusterState<'ContainerProvider, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_virtual_cluster#timeouts-1">EmrcontainersVirtualCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EmrcontainersVirtualClusterState<'ContainerProvider, 'Name>, value: aws.EmrcontainersVirtualCluster.EmrcontainersVirtualClusterTimeouts) : EmrcontainersVirtualClusterState<'ContainerProvider, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EmrcontainersVirtualClusterState<'ContainerProvider, 'Name>

        member _.Run(state: EmrcontainersVirtualClusterState<Present, Present>) : aws.EmrcontainersVirtualCluster.EmrcontainersVirtualCluster =
            let config = aws.EmrcontainersVirtualCluster.EmrcontainersVirtualClusterConfig()
            for setter in state.assignments do
                setter config
            aws.EmrcontainersVirtualCluster.EmrcontainersVirtualCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.emrcontainersVirtualCluster: missing required arguments. Must call: container_provider, name.", 9999, IsError = true)>]
        member _.Run(_: EmrcontainersVirtualClusterState<_, _>) : aws.EmrcontainersVirtualCluster.EmrcontainersVirtualCluster =
            Unchecked.defaultof<aws.EmrcontainersVirtualCluster.EmrcontainersVirtualCluster>
