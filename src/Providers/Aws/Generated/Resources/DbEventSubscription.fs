namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DbEventSubscriptionState<'SnsTopic> = { assignments: ResizeArray<aws.DbEventSubscription.DbEventSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_event_subscription">aws_db_event_subscription</a>.
    /// </summary>
    type DbEventSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DbEventSubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : DbEventSubscriptionState<Missing>)

        member _.Zero(()) : DbEventSubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : DbEventSubscriptionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_event_subscription#sns_topic-1">DbEventSubscription#sns_topic</a>.
        /// </summary>
        [<CustomOperation "sns_topic">]
        member _.SnsTopic(state: DbEventSubscriptionState<Missing>, value: string) : DbEventSubscriptionState<Present> =
            state.assignments.Add(fun config -> config.SnsTopic <- value)
            ({ assignments = state.assignments } : DbEventSubscriptionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_event_subscription#enabled-1">DbEventSubscription#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: DbEventSubscriptionState<'SnsTopic>, value: bool) : DbEventSubscriptionState<'SnsTopic> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : DbEventSubscriptionState<'SnsTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_event_subscription#enabled-1">DbEventSubscription#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: DbEventSubscriptionState<'SnsTopic>, value: HashiCorp.Cdktf.IResolvable) : DbEventSubscriptionState<'SnsTopic> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : DbEventSubscriptionState<'SnsTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_event_subscription#event_categories-1">DbEventSubscription#event_categories</a>.
        /// </summary>
        [<CustomOperation "event_categories">]
        member _.EventCategories(state: DbEventSubscriptionState<'SnsTopic>, value: seq<string>) : DbEventSubscriptionState<'SnsTopic> =
            state.assignments.Add(fun config -> config.EventCategories <- (value |> Seq.toArray))
            state : DbEventSubscriptionState<'SnsTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_event_subscription#id-1">DbEventSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DbEventSubscriptionState<'SnsTopic>, value: string) : DbEventSubscriptionState<'SnsTopic> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DbEventSubscriptionState<'SnsTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_event_subscription#name-1">DbEventSubscription#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DbEventSubscriptionState<'SnsTopic>, value: string) : DbEventSubscriptionState<'SnsTopic> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DbEventSubscriptionState<'SnsTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_event_subscription#name_prefix-1">DbEventSubscription#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: DbEventSubscriptionState<'SnsTopic>, value: string) : DbEventSubscriptionState<'SnsTopic> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : DbEventSubscriptionState<'SnsTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_event_subscription#source_ids-1">DbEventSubscription#source_ids</a>.
        /// </summary>
        [<CustomOperation "source_ids">]
        member _.SourceIds(state: DbEventSubscriptionState<'SnsTopic>, value: seq<string>) : DbEventSubscriptionState<'SnsTopic> =
            state.assignments.Add(fun config -> config.SourceIds <- (value |> Seq.toArray))
            state : DbEventSubscriptionState<'SnsTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_event_subscription#source_type-1">DbEventSubscription#source_type</a>.
        /// </summary>
        [<CustomOperation "source_type">]
        member _.SourceType(state: DbEventSubscriptionState<'SnsTopic>, value: string) : DbEventSubscriptionState<'SnsTopic> =
            state.assignments.Add(fun config -> config.SourceType <- value)
            state : DbEventSubscriptionState<'SnsTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_event_subscription#tags-1">DbEventSubscription#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DbEventSubscriptionState<'SnsTopic>, value: seq<string * string>) : DbEventSubscriptionState<'SnsTopic> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DbEventSubscriptionState<'SnsTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_event_subscription#tags_all-1">DbEventSubscription#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DbEventSubscriptionState<'SnsTopic>, value: seq<string * string>) : DbEventSubscriptionState<'SnsTopic> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DbEventSubscriptionState<'SnsTopic>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_event_subscription#timeouts-1">DbEventSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DbEventSubscriptionState<'SnsTopic>, value: aws.DbEventSubscription.DbEventSubscriptionTimeouts) : DbEventSubscriptionState<'SnsTopic> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DbEventSubscriptionState<'SnsTopic>

        member _.Run(state: DbEventSubscriptionState<Present>) : aws.DbEventSubscription.DbEventSubscription =
            let config = aws.DbEventSubscription.DbEventSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.DbEventSubscription.DbEventSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dbEventSubscription: missing required arguments. Must call: sns_topic.", 9999, IsError = true)>]
        member _.Run(_: DbEventSubscriptionState<_>) : aws.DbEventSubscription.DbEventSubscription =
            Unchecked.defaultof<aws.DbEventSubscription.DbEventSubscription>
