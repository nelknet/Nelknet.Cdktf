namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudhsmV2ClusterState<'HsmType, 'SubnetIds> = { assignments: ResizeArray<aws.CloudhsmV2Cluster.CloudhsmV2ClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_cluster">aws_cloudhsm_v2_cluster</a>.
    /// </summary>
    type CloudhsmV2ClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudhsmV2ClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudhsmV2ClusterState<Missing, Missing>)

        member _.Zero(()) : CloudhsmV2ClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudhsmV2ClusterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_cluster#hsm_type-1">CloudhsmV2Cluster#hsm_type</a>.
        /// </summary>
        [<CustomOperation "hsm_type">]
        member _.HsmType(state: CloudhsmV2ClusterState<Missing, 'SubnetIds>, value: string) : CloudhsmV2ClusterState<Present, 'SubnetIds> =
            state.assignments.Add(fun config -> config.HsmType <- value)
            ({ assignments = state.assignments } : CloudhsmV2ClusterState<Present, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_cluster#subnet_ids-1">CloudhsmV2Cluster#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: CloudhsmV2ClusterState<'HsmType, Missing>, value: seq<string>) : CloudhsmV2ClusterState<'HsmType, Present> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CloudhsmV2ClusterState<'HsmType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_cluster#id-1">CloudhsmV2Cluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudhsmV2ClusterState<'HsmType, 'SubnetIds>, value: string) : CloudhsmV2ClusterState<'HsmType, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudhsmV2ClusterState<'HsmType, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_cluster#mode-1">CloudhsmV2Cluster#mode</a>.
        /// </summary>
        [<CustomOperation "mode">]
        member _.Mode(state: CloudhsmV2ClusterState<'HsmType, 'SubnetIds>, value: string) : CloudhsmV2ClusterState<'HsmType, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Mode <- value)
            state : CloudhsmV2ClusterState<'HsmType, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_cluster#source_backup_identifier-1">CloudhsmV2Cluster#source_backup_identifier</a>.
        /// </summary>
        [<CustomOperation "source_backup_identifier">]
        member _.SourceBackupIdentifier(state: CloudhsmV2ClusterState<'HsmType, 'SubnetIds>, value: string) : CloudhsmV2ClusterState<'HsmType, 'SubnetIds> =
            state.assignments.Add(fun config -> config.SourceBackupIdentifier <- value)
            state : CloudhsmV2ClusterState<'HsmType, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_cluster#tags-1">CloudhsmV2Cluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudhsmV2ClusterState<'HsmType, 'SubnetIds>, value: seq<string * string>) : CloudhsmV2ClusterState<'HsmType, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudhsmV2ClusterState<'HsmType, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_cluster#tags_all-1">CloudhsmV2Cluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CloudhsmV2ClusterState<'HsmType, 'SubnetIds>, value: seq<string * string>) : CloudhsmV2ClusterState<'HsmType, 'SubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CloudhsmV2ClusterState<'HsmType, 'SubnetIds>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_cluster#timeouts-1">CloudhsmV2Cluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CloudhsmV2ClusterState<'HsmType, 'SubnetIds>, value: aws.CloudhsmV2Cluster.CloudhsmV2ClusterTimeouts) : CloudhsmV2ClusterState<'HsmType, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CloudhsmV2ClusterState<'HsmType, 'SubnetIds>

        member _.Run(state: CloudhsmV2ClusterState<Present, Present>) : aws.CloudhsmV2Cluster.CloudhsmV2Cluster =
            let config = aws.CloudhsmV2Cluster.CloudhsmV2ClusterConfig()
            for setter in state.assignments do
                setter config
            aws.CloudhsmV2Cluster.CloudhsmV2Cluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudhsmV2Cluster: missing required arguments. Must call: hsm_type, subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: CloudhsmV2ClusterState<_, _>) : aws.CloudhsmV2Cluster.CloudhsmV2Cluster =
            Unchecked.defaultof<aws.CloudhsmV2Cluster.CloudhsmV2Cluster>
