namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftEventSubscriptionState<'Name, 'SnsTopicArn> = { assignments: ResizeArray<aws.RedshiftEventSubscription.RedshiftEventSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_event_subscription">aws_redshift_event_subscription</a>.
    /// </summary>
    type RedshiftEventSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftEventSubscriptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftEventSubscriptionState<Missing, Missing>)

        member _.Zero(()) : RedshiftEventSubscriptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftEventSubscriptionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_event_subscription#name-1">RedshiftEventSubscription#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RedshiftEventSubscriptionState<Missing, 'SnsTopicArn>, value: string) : RedshiftEventSubscriptionState<Present, 'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RedshiftEventSubscriptionState<Present, 'SnsTopicArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_event_subscription#sns_topic_arn-1">RedshiftEventSubscription#sns_topic_arn</a>.
        /// </summary>
        [<CustomOperation "sns_topic_arn">]
        member _.SnsTopicArn(state: RedshiftEventSubscriptionState<'Name, Missing>, value: string) : RedshiftEventSubscriptionState<'Name, Present> =
            state.assignments.Add(fun config -> config.SnsTopicArn <- value)
            ({ assignments = state.assignments } : RedshiftEventSubscriptionState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_event_subscription#enabled-1">RedshiftEventSubscription#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>, value: bool) : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_event_subscription#enabled-1">RedshiftEventSubscription#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>, value: HashiCorp.Cdktf.IResolvable) : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_event_subscription#event_categories-1">RedshiftEventSubscription#event_categories</a>.
        /// </summary>
        [<CustomOperation "event_categories">]
        member _.EventCategories(state: RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>, value: seq<string>) : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn> =
            state.assignments.Add(fun config -> config.EventCategories <- (value |> Seq.toArray))
            state : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_event_subscription#id-1">RedshiftEventSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>, value: string) : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_event_subscription#severity-1">RedshiftEventSubscription#severity</a>.
        /// </summary>
        [<CustomOperation "severity">]
        member _.Severity(state: RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>, value: string) : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Severity <- value)
            state : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_event_subscription#source_ids-1">RedshiftEventSubscription#source_ids</a>.
        /// </summary>
        [<CustomOperation "source_ids">]
        member _.SourceIds(state: RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>, value: seq<string>) : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn> =
            state.assignments.Add(fun config -> config.SourceIds <- (value |> Seq.toArray))
            state : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_event_subscription#source_type-1">RedshiftEventSubscription#source_type</a>.
        /// </summary>
        [<CustomOperation "source_type">]
        member _.SourceType(state: RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>, value: string) : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn> =
            state.assignments.Add(fun config -> config.SourceType <- value)
            state : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_event_subscription#tags-1">RedshiftEventSubscription#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>, value: seq<string * string>) : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_event_subscription#tags_all-1">RedshiftEventSubscription#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>, value: seq<string * string>) : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_event_subscription#timeouts-1">RedshiftEventSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>, value: aws.RedshiftEventSubscription.RedshiftEventSubscriptionTimeouts) : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RedshiftEventSubscriptionState<'Name, 'SnsTopicArn>

        member _.Run(state: RedshiftEventSubscriptionState<Present, Present>) : aws.RedshiftEventSubscription.RedshiftEventSubscription =
            let config = aws.RedshiftEventSubscription.RedshiftEventSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftEventSubscription.RedshiftEventSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftEventSubscription: missing required arguments. Must call: name, sns_topic_arn.", 9999, IsError = true)>]
        member _.Run(_: RedshiftEventSubscriptionState<_, _>) : aws.RedshiftEventSubscription.RedshiftEventSubscription =
            Unchecked.defaultof<aws.RedshiftEventSubscription.RedshiftEventSubscription>
