namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEmrcontainersVirtualClusterState<'VirtualClusterId> = { assignments: ResizeArray<aws.DataAwsEmrcontainersVirtualCluster.DataAwsEmrcontainersVirtualClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emrcontainers_virtual_cluster">aws_emrcontainers_virtual_cluster</a>.
    /// </summary>
    type DataAwsEmrcontainersVirtualClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEmrcontainersVirtualClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEmrcontainersVirtualClusterState<Missing>)

        member _.Zero(()) : DataAwsEmrcontainersVirtualClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEmrcontainersVirtualClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emrcontainers_virtual_cluster#virtual_cluster_id-1">DataAwsEmrcontainersVirtualCluster#virtual_cluster_id</a>.
        /// </summary>
        [<CustomOperation "virtual_cluster_id">]
        member _.VirtualClusterId(state: DataAwsEmrcontainersVirtualClusterState<Missing>, value: string) : DataAwsEmrcontainersVirtualClusterState<Present> =
            state.assignments.Add(fun config -> config.VirtualClusterId <- value)
            ({ assignments = state.assignments } : DataAwsEmrcontainersVirtualClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emrcontainers_virtual_cluster#id-1">DataAwsEmrcontainersVirtualCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEmrcontainersVirtualClusterState<'VirtualClusterId>, value: string) : DataAwsEmrcontainersVirtualClusterState<'VirtualClusterId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEmrcontainersVirtualClusterState<'VirtualClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emrcontainers_virtual_cluster#tags-1">DataAwsEmrcontainersVirtualCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEmrcontainersVirtualClusterState<'VirtualClusterId>, value: seq<string * string>) : DataAwsEmrcontainersVirtualClusterState<'VirtualClusterId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEmrcontainersVirtualClusterState<'VirtualClusterId>

        member _.Run(state: DataAwsEmrcontainersVirtualClusterState<Present>) : aws.DataAwsEmrcontainersVirtualCluster.DataAwsEmrcontainersVirtualCluster =
            let config = aws.DataAwsEmrcontainersVirtualCluster.DataAwsEmrcontainersVirtualClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEmrcontainersVirtualCluster.DataAwsEmrcontainersVirtualCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEmrcontainersVirtualCluster: missing required arguments. Must call: virtual_cluster_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEmrcontainersVirtualClusterState<_>) : aws.DataAwsEmrcontainersVirtualCluster.DataAwsEmrcontainersVirtualCluster =
            Unchecked.defaultof<aws.DataAwsEmrcontainersVirtualCluster.DataAwsEmrcontainersVirtualCluster>
