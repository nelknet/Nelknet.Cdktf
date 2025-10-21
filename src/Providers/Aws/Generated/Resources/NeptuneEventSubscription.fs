namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NeptuneEventSubscriptionState<'SnsTopicArn> = { assignments: ResizeArray<aws.NeptuneEventSubscription.NeptuneEventSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_event_subscription">aws_neptune_event_subscription</a>.
    /// </summary>
    type NeptuneEventSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : NeptuneEventSubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : NeptuneEventSubscriptionState<Missing>)

        member _.Zero(()) : NeptuneEventSubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : NeptuneEventSubscriptionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_event_subscription#sns_topic_arn-1">NeptuneEventSubscription#sns_topic_arn</a>.
        /// </summary>
        [<CustomOperation "sns_topic_arn">]
        member _.SnsTopicArn(state: NeptuneEventSubscriptionState<Missing>, value: string) : NeptuneEventSubscriptionState<Present> =
            state.assignments.Add(fun config -> config.SnsTopicArn <- value)
            ({ assignments = state.assignments } : NeptuneEventSubscriptionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_event_subscription#enabled-1">NeptuneEventSubscription#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: NeptuneEventSubscriptionState<'SnsTopicArn>, value: bool) : NeptuneEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : NeptuneEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_event_subscription#enabled-1">NeptuneEventSubscription#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: NeptuneEventSubscriptionState<'SnsTopicArn>, value: HashiCorp.Cdktf.IResolvable) : NeptuneEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : NeptuneEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_event_subscription#event_categories-1">NeptuneEventSubscription#event_categories</a>.
        /// </summary>
        [<CustomOperation "event_categories">]
        member _.EventCategories(state: NeptuneEventSubscriptionState<'SnsTopicArn>, value: seq<string>) : NeptuneEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.EventCategories <- (value |> Seq.toArray))
            state : NeptuneEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_event_subscription#id-1">NeptuneEventSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NeptuneEventSubscriptionState<'SnsTopicArn>, value: string) : NeptuneEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NeptuneEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_event_subscription#name-1">NeptuneEventSubscription#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NeptuneEventSubscriptionState<'SnsTopicArn>, value: string) : NeptuneEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : NeptuneEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_event_subscription#name_prefix-1">NeptuneEventSubscription#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: NeptuneEventSubscriptionState<'SnsTopicArn>, value: string) : NeptuneEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : NeptuneEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_event_subscription#source_ids-1">NeptuneEventSubscription#source_ids</a>.
        /// </summary>
        [<CustomOperation "source_ids">]
        member _.SourceIds(state: NeptuneEventSubscriptionState<'SnsTopicArn>, value: seq<string>) : NeptuneEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.SourceIds <- (value |> Seq.toArray))
            state : NeptuneEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_event_subscription#source_type-1">NeptuneEventSubscription#source_type</a>.
        /// </summary>
        [<CustomOperation "source_type">]
        member _.SourceType(state: NeptuneEventSubscriptionState<'SnsTopicArn>, value: string) : NeptuneEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.SourceType <- value)
            state : NeptuneEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_event_subscription#tags-1">NeptuneEventSubscription#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NeptuneEventSubscriptionState<'SnsTopicArn>, value: seq<string * string>) : NeptuneEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NeptuneEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_event_subscription#tags_all-1">NeptuneEventSubscription#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NeptuneEventSubscriptionState<'SnsTopicArn>, value: seq<string * string>) : NeptuneEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NeptuneEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_event_subscription#timeouts-1">NeptuneEventSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NeptuneEventSubscriptionState<'SnsTopicArn>, value: aws.NeptuneEventSubscription.NeptuneEventSubscriptionTimeouts) : NeptuneEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NeptuneEventSubscriptionState<'SnsTopicArn>

        member _.Run(state: NeptuneEventSubscriptionState<Present>) : aws.NeptuneEventSubscription.NeptuneEventSubscription =
            let config = aws.NeptuneEventSubscription.NeptuneEventSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.NeptuneEventSubscription.NeptuneEventSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.neptuneEventSubscription: missing required arguments. Must call: sns_topic_arn.", 9999, IsError = true)>]
        member _.Run(_: NeptuneEventSubscriptionState<_>) : aws.NeptuneEventSubscription.NeptuneEventSubscription =
            Unchecked.defaultof<aws.NeptuneEventSubscription.NeptuneEventSubscription>
