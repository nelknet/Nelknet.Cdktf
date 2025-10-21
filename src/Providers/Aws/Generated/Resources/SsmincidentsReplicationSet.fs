namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmincidentsReplicationSetState<'Region> = { assignments: ResizeArray<aws.SsmincidentsReplicationSet.SsmincidentsReplicationSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_replication_set">aws_ssmincidents_replication_set</a>.
    /// </summary>
    type SsmincidentsReplicationSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmincidentsReplicationSetState<Missing> =
            ({ assignments = ResizeArray() } : SsmincidentsReplicationSetState<Missing>)

        member _.Zero(()) : SsmincidentsReplicationSetState<Missing> =
            ({ assignments = ResizeArray() } : SsmincidentsReplicationSetState<Missing>)

        /// <summary>
        /// region block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_replication_set#region-1">SsmincidentsReplicationSet#region</a> Accepts: aws.IResolvable | aws.SsmincidentsReplicationSet.SsmincidentsReplicationSetRegion[]
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: SsmincidentsReplicationSetState<Missing>, value: HashiCorp.Cdktf.IResolvable) : SsmincidentsReplicationSetState<Present> =
            state.assignments.Add(fun config -> config.Region <- value)
            ({ assignments = state.assignments } : SsmincidentsReplicationSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_replication_set#id-1">SsmincidentsReplicationSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmincidentsReplicationSetState<'Region>, value: string) : SsmincidentsReplicationSetState<'Region> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmincidentsReplicationSetState<'Region>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_replication_set#tags-1">SsmincidentsReplicationSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SsmincidentsReplicationSetState<'Region>, value: seq<string * string>) : SsmincidentsReplicationSetState<'Region> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SsmincidentsReplicationSetState<'Region>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_replication_set#tags_all-1">SsmincidentsReplicationSet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SsmincidentsReplicationSetState<'Region>, value: seq<string * string>) : SsmincidentsReplicationSetState<'Region> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SsmincidentsReplicationSetState<'Region>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_replication_set#timeouts-1">SsmincidentsReplicationSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SsmincidentsReplicationSetState<'Region>, value: aws.SsmincidentsReplicationSet.SsmincidentsReplicationSetTimeouts) : SsmincidentsReplicationSetState<'Region> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SsmincidentsReplicationSetState<'Region>

        member _.Run(state: SsmincidentsReplicationSetState<Present>) : aws.SsmincidentsReplicationSet.SsmincidentsReplicationSet =
            let config = aws.SsmincidentsReplicationSet.SsmincidentsReplicationSetConfig()
            for setter in state.assignments do
                setter config
            aws.SsmincidentsReplicationSet.SsmincidentsReplicationSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmincidentsReplicationSet: missing required arguments. Must call: region.", 9999, IsError = true)>]
        member _.Run(_: SsmincidentsReplicationSetState<_>) : aws.SsmincidentsReplicationSet.SsmincidentsReplicationSet =
            Unchecked.defaultof<aws.SsmincidentsReplicationSet.SsmincidentsReplicationSet>
