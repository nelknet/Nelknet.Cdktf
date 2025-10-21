namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MediaConvertQueueState<'Name> = { assignments: ResizeArray<aws.MediaConvertQueue.MediaConvertQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue">aws_media_convert_queue</a>.
    /// </summary>
    type MediaConvertQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : MediaConvertQueueState<Missing> =
            ({ assignments = ResizeArray() } : MediaConvertQueueState<Missing>)

        member _.Zero(()) : MediaConvertQueueState<Missing> =
            ({ assignments = ResizeArray() } : MediaConvertQueueState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#name-1">MediaConvertQueue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MediaConvertQueueState<Missing>, value: string) : MediaConvertQueueState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MediaConvertQueueState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#concurrent_jobs-1">MediaConvertQueue#concurrent_jobs</a>.
        /// </summary>
        [<CustomOperation "concurrent_jobs">]
        member _.ConcurrentJobs(state: MediaConvertQueueState<'Name>, value: double) : MediaConvertQueueState<'Name> =
            state.assignments.Add(fun config -> config.ConcurrentJobs <- value)
            state : MediaConvertQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#description-1">MediaConvertQueue#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MediaConvertQueueState<'Name>, value: string) : MediaConvertQueueState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MediaConvertQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#id-1">MediaConvertQueue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MediaConvertQueueState<'Name>, value: string) : MediaConvertQueueState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MediaConvertQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#pricing_plan-1">MediaConvertQueue#pricing_plan</a>.
        /// </summary>
        [<CustomOperation "pricing_plan">]
        member _.PricingPlan(state: MediaConvertQueueState<'Name>, value: string) : MediaConvertQueueState<'Name> =
            state.assignments.Add(fun config -> config.PricingPlan <- value)
            state : MediaConvertQueueState<'Name>

        /// <summary>
        /// reservation_plan_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#reservation_plan_settings-1">MediaConvertQueue#reservation_plan_settings</a>
        /// </summary>
        [<CustomOperation "reservation_plan_settings">]
        member _.ReservationPlanSettings(state: MediaConvertQueueState<'Name>, value: aws.MediaConvertQueue.MediaConvertQueueReservationPlanSettings) : MediaConvertQueueState<'Name> =
            state.assignments.Add(fun config -> config.ReservationPlanSettings <- value)
            state : MediaConvertQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#status-1">MediaConvertQueue#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: MediaConvertQueueState<'Name>, value: string) : MediaConvertQueueState<'Name> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : MediaConvertQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#tags-1">MediaConvertQueue#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MediaConvertQueueState<'Name>, value: seq<string * string>) : MediaConvertQueueState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MediaConvertQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#tags_all-1">MediaConvertQueue#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MediaConvertQueueState<'Name>, value: seq<string * string>) : MediaConvertQueueState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MediaConvertQueueState<'Name>

        member _.Run(state: MediaConvertQueueState<Present>) : aws.MediaConvertQueue.MediaConvertQueue =
            let config = aws.MediaConvertQueue.MediaConvertQueueConfig()
            for setter in state.assignments do
                setter config
            aws.MediaConvertQueue.MediaConvertQueue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mediaConvertQueue: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: MediaConvertQueueState<_>) : aws.MediaConvertQueue.MediaConvertQueue =
            Unchecked.defaultof<aws.MediaConvertQueue.MediaConvertQueue>
