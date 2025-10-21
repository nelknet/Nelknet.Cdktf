namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DocdbEventSubscriptionState<'SnsTopicArn> = { assignments: ResizeArray<aws.DocdbEventSubscription.DocdbEventSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_event_subscription">aws_docdb_event_subscription</a>.
    /// </summary>
    type DocdbEventSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DocdbEventSubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : DocdbEventSubscriptionState<Missing>)

        member _.Zero(()) : DocdbEventSubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : DocdbEventSubscriptionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_event_subscription#sns_topic_arn-1">DocdbEventSubscription#sns_topic_arn</a>.
        /// </summary>
        [<CustomOperation "sns_topic_arn">]
        member _.SnsTopicArn(state: DocdbEventSubscriptionState<Missing>, value: string) : DocdbEventSubscriptionState<Present> =
            state.assignments.Add(fun config -> config.SnsTopicArn <- value)
            ({ assignments = state.assignments } : DocdbEventSubscriptionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_event_subscription#enabled-1">DocdbEventSubscription#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: DocdbEventSubscriptionState<'SnsTopicArn>, value: bool) : DocdbEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : DocdbEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_event_subscription#enabled-1">DocdbEventSubscription#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: DocdbEventSubscriptionState<'SnsTopicArn>, value: HashiCorp.Cdktf.IResolvable) : DocdbEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : DocdbEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_event_subscription#event_categories-1">DocdbEventSubscription#event_categories</a>.
        /// </summary>
        [<CustomOperation "event_categories">]
        member _.EventCategories(state: DocdbEventSubscriptionState<'SnsTopicArn>, value: seq<string>) : DocdbEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.EventCategories <- (value |> Seq.toArray))
            state : DocdbEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_event_subscription#id-1">DocdbEventSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DocdbEventSubscriptionState<'SnsTopicArn>, value: string) : DocdbEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DocdbEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_event_subscription#name-1">DocdbEventSubscription#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DocdbEventSubscriptionState<'SnsTopicArn>, value: string) : DocdbEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DocdbEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_event_subscription#name_prefix-1">DocdbEventSubscription#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: DocdbEventSubscriptionState<'SnsTopicArn>, value: string) : DocdbEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : DocdbEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_event_subscription#source_ids-1">DocdbEventSubscription#source_ids</a>.
        /// </summary>
        [<CustomOperation "source_ids">]
        member _.SourceIds(state: DocdbEventSubscriptionState<'SnsTopicArn>, value: seq<string>) : DocdbEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.SourceIds <- (value |> Seq.toArray))
            state : DocdbEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_event_subscription#source_type-1">DocdbEventSubscription#source_type</a>.
        /// </summary>
        [<CustomOperation "source_type">]
        member _.SourceType(state: DocdbEventSubscriptionState<'SnsTopicArn>, value: string) : DocdbEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.SourceType <- value)
            state : DocdbEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_event_subscription#tags-1">DocdbEventSubscription#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DocdbEventSubscriptionState<'SnsTopicArn>, value: seq<string * string>) : DocdbEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DocdbEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_event_subscription#tags_all-1">DocdbEventSubscription#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DocdbEventSubscriptionState<'SnsTopicArn>, value: seq<string * string>) : DocdbEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DocdbEventSubscriptionState<'SnsTopicArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_event_subscription#timeouts-1">DocdbEventSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DocdbEventSubscriptionState<'SnsTopicArn>, value: aws.DocdbEventSubscription.DocdbEventSubscriptionTimeouts) : DocdbEventSubscriptionState<'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DocdbEventSubscriptionState<'SnsTopicArn>

        member _.Run(state: DocdbEventSubscriptionState<Present>) : aws.DocdbEventSubscription.DocdbEventSubscription =
            let config = aws.DocdbEventSubscription.DocdbEventSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.DocdbEventSubscription.DocdbEventSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.docdbEventSubscription: missing required arguments. Must call: sns_topic_arn.", 9999, IsError = true)>]
        member _.Run(_: DocdbEventSubscriptionState<_>) : aws.DocdbEventSubscription.DocdbEventSubscription =
            Unchecked.defaultof<aws.DocdbEventSubscription.DocdbEventSubscription>
