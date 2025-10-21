namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataexchangeRevisionState<'DataSetId> = { assignments: ResizeArray<aws.DataexchangeRevision.DataexchangeRevisionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision">aws_dataexchange_revision</a>.
    /// </summary>
    type DataexchangeRevisionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataexchangeRevisionState<Missing> =
            ({ assignments = ResizeArray() } : DataexchangeRevisionState<Missing>)

        member _.Zero(()) : DataexchangeRevisionState<Missing> =
            ({ assignments = ResizeArray() } : DataexchangeRevisionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision#data_set_id-1">DataexchangeRevision#data_set_id</a>.
        /// </summary>
        [<CustomOperation "data_set_id">]
        member _.DataSetId(state: DataexchangeRevisionState<Missing>, value: string) : DataexchangeRevisionState<Present> =
            state.assignments.Add(fun config -> config.DataSetId <- value)
            ({ assignments = state.assignments } : DataexchangeRevisionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision#comment-1">DataexchangeRevision#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: DataexchangeRevisionState<'DataSetId>, value: string) : DataexchangeRevisionState<'DataSetId> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : DataexchangeRevisionState<'DataSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision#id-1">DataexchangeRevision#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataexchangeRevisionState<'DataSetId>, value: string) : DataexchangeRevisionState<'DataSetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataexchangeRevisionState<'DataSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision#tags-1">DataexchangeRevision#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataexchangeRevisionState<'DataSetId>, value: seq<string * string>) : DataexchangeRevisionState<'DataSetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataexchangeRevisionState<'DataSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_revision#tags_all-1">DataexchangeRevision#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DataexchangeRevisionState<'DataSetId>, value: seq<string * string>) : DataexchangeRevisionState<'DataSetId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DataexchangeRevisionState<'DataSetId>

        member _.Run(state: DataexchangeRevisionState<Present>) : aws.DataexchangeRevision.DataexchangeRevision =
            let config = aws.DataexchangeRevision.DataexchangeRevisionConfig()
            for setter in state.assignments do
                setter config
            aws.DataexchangeRevision.DataexchangeRevision(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataexchangeRevision: missing required arguments. Must call: data_set_id.", 9999, IsError = true)>]
        member _.Run(_: DataexchangeRevisionState<_>) : aws.DataexchangeRevision.DataexchangeRevision =
            Unchecked.defaultof<aws.DataexchangeRevision.DataexchangeRevision>
