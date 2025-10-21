namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsmincidentsReplicationSetState = { assignments: ResizeArray<aws.DataAwsSsmincidentsReplicationSet.DataAwsSsmincidentsReplicationSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmincidents_replication_set">aws_ssmincidents_replication_set</a>.
    /// </summary>
    type DataAwsSsmincidentsReplicationSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsmincidentsReplicationSetState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSsmincidentsReplicationSetState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmincidents_replication_set#id-1">DataAwsSsmincidentsReplicationSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSsmincidentsReplicationSetState, value: string) : DataAwsSsmincidentsReplicationSetState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSsmincidentsReplicationSetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmincidents_replication_set#tags-1">DataAwsSsmincidentsReplicationSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsSsmincidentsReplicationSetState, value: seq<string * string>) : DataAwsSsmincidentsReplicationSetState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsSsmincidentsReplicationSetState

        member _.Run(state: DataAwsSsmincidentsReplicationSetState) : aws.DataAwsSsmincidentsReplicationSet.DataAwsSsmincidentsReplicationSet =
            let config = aws.DataAwsSsmincidentsReplicationSet.DataAwsSsmincidentsReplicationSetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsmincidentsReplicationSet.DataAwsSsmincidentsReplicationSet(StackContext.get (), logicalId, config)
