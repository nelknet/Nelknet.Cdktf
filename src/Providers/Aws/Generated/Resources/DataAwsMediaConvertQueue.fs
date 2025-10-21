namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMediaConvertQueueState<'Id> = { assignments: ResizeArray<aws.DataAwsMediaConvertQueue.DataAwsMediaConvertQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/media_convert_queue">aws_media_convert_queue</a>.
    /// </summary>
    type DataAwsMediaConvertQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMediaConvertQueueState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMediaConvertQueueState<Missing>)

        member _.Zero(()) : DataAwsMediaConvertQueueState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMediaConvertQueueState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/media_convert_queue#id-1">DataAwsMediaConvertQueue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMediaConvertQueueState<Missing>, value: string) : DataAwsMediaConvertQueueState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsMediaConvertQueueState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/media_convert_queue#tags-1">DataAwsMediaConvertQueue#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsMediaConvertQueueState<'Id>, value: seq<string * string>) : DataAwsMediaConvertQueueState<'Id> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsMediaConvertQueueState<'Id>

        member _.Run(state: DataAwsMediaConvertQueueState<Present>) : aws.DataAwsMediaConvertQueue.DataAwsMediaConvertQueue =
            let config = aws.DataAwsMediaConvertQueue.DataAwsMediaConvertQueueConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMediaConvertQueue.DataAwsMediaConvertQueue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMediaConvertQueue: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMediaConvertQueueState<_>) : aws.DataAwsMediaConvertQueue.DataAwsMediaConvertQueue =
            Unchecked.defaultof<aws.DataAwsMediaConvertQueue.DataAwsMediaConvertQueue>
