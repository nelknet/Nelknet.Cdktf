namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType> = { assignments: ResizeArray<aws.DmsEventSubscription.DmsEventSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_event_subscription">aws_dms_event_subscription</a>.
    /// </summary>
    type DmsEventSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DmsEventSubscriptionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DmsEventSubscriptionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DmsEventSubscriptionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DmsEventSubscriptionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_event_subscription#event_categories-1">DmsEventSubscription#event_categories</a>.
        /// </summary>
        [<CustomOperation "event_categories">]
        member _.EventCategories(state: DmsEventSubscriptionState<Missing, 'Name, 'SnsTopicArn, 'SourceType>, value: seq<string>) : DmsEventSubscriptionState<Present, 'Name, 'SnsTopicArn, 'SourceType> =
            state.assignments.Add(fun config -> config.EventCategories <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DmsEventSubscriptionState<Present, 'Name, 'SnsTopicArn, 'SourceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_event_subscription#name-1">DmsEventSubscription#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DmsEventSubscriptionState<'EventCategories, Missing, 'SnsTopicArn, 'SourceType>, value: string) : DmsEventSubscriptionState<'EventCategories, Present, 'SnsTopicArn, 'SourceType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DmsEventSubscriptionState<'EventCategories, Present, 'SnsTopicArn, 'SourceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_event_subscription#sns_topic_arn-1">DmsEventSubscription#sns_topic_arn</a>.
        /// </summary>
        [<CustomOperation "sns_topic_arn">]
        member _.SnsTopicArn(state: DmsEventSubscriptionState<'EventCategories, 'Name, Missing, 'SourceType>, value: string) : DmsEventSubscriptionState<'EventCategories, 'Name, Present, 'SourceType> =
            state.assignments.Add(fun config -> config.SnsTopicArn <- value)
            ({ assignments = state.assignments } : DmsEventSubscriptionState<'EventCategories, 'Name, Present, 'SourceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_event_subscription#source_type-1">DmsEventSubscription#source_type</a>.
        /// </summary>
        [<CustomOperation "source_type">]
        member _.SourceType(state: DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, Missing>, value: string) : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, Present> =
            state.assignments.Add(fun config -> config.SourceType <- value)
            ({ assignments = state.assignments } : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_event_subscription#enabled-1">DmsEventSubscription#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType>, value: bool) : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_event_subscription#enabled-1">DmsEventSubscription#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType>, value: HashiCorp.Cdktf.IResolvable) : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_event_subscription#id-1">DmsEventSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType>, value: string) : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_event_subscription#source_ids-1">DmsEventSubscription#source_ids</a>.
        /// </summary>
        [<CustomOperation "source_ids">]
        member _.SourceIds(state: DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType>, value: seq<string>) : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType> =
            state.assignments.Add(fun config -> config.SourceIds <- (value |> Seq.toArray))
            state : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_event_subscription#tags-1">DmsEventSubscription#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType>, value: seq<string * string>) : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_event_subscription#tags_all-1">DmsEventSubscription#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType>, value: seq<string * string>) : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_event_subscription#timeouts-1">DmsEventSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType>, value: aws.DmsEventSubscription.DmsEventSubscriptionTimeouts) : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DmsEventSubscriptionState<'EventCategories, 'Name, 'SnsTopicArn, 'SourceType>

        member _.Run(state: DmsEventSubscriptionState<Present, Present, Present, Present>) : aws.DmsEventSubscription.DmsEventSubscription =
            let config = aws.DmsEventSubscription.DmsEventSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.DmsEventSubscription.DmsEventSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dmsEventSubscription: missing required arguments. Must call: event_categories, name, sns_topic_arn, source_type.", 9999, IsError = true)>]
        member _.Run(_: DmsEventSubscriptionState<_, _, _, _>) : aws.DmsEventSubscription.DmsEventSubscription =
            Unchecked.defaultof<aws.DmsEventSubscription.DmsEventSubscription>
