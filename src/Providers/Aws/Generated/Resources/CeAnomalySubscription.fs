namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber> = { assignments: ResizeArray<aws.CeAnomalySubscription.CeAnomalySubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription">aws_ce_anomaly_subscription</a>.
    /// </summary>
    type CeAnomalySubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CeAnomalySubscriptionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CeAnomalySubscriptionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CeAnomalySubscriptionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CeAnomalySubscriptionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#frequency-1">CeAnomalySubscription#frequency</a>.
        /// </summary>
        [<CustomOperation "frequency">]
        member _.Frequency(state: CeAnomalySubscriptionState<Missing, 'MonitorArnList, 'Name, 'Subscriber>, value: string) : CeAnomalySubscriptionState<Present, 'MonitorArnList, 'Name, 'Subscriber> =
            state.assignments.Add(fun config -> config.Frequency <- value)
            ({ assignments = state.assignments } : CeAnomalySubscriptionState<Present, 'MonitorArnList, 'Name, 'Subscriber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#monitor_arn_list-1">CeAnomalySubscription#monitor_arn_list</a>.
        /// </summary>
        [<CustomOperation "monitor_arn_list">]
        member _.MonitorArnList(state: CeAnomalySubscriptionState<'Frequency, Missing, 'Name, 'Subscriber>, value: seq<string>) : CeAnomalySubscriptionState<'Frequency, Present, 'Name, 'Subscriber> =
            state.assignments.Add(fun config -> config.MonitorArnList <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CeAnomalySubscriptionState<'Frequency, Present, 'Name, 'Subscriber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#name-1">CeAnomalySubscription#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, Missing, 'Subscriber>, value: string) : CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, Present, 'Subscriber> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, Present, 'Subscriber>)

        /// <summary>
        /// subscriber block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#subscriber-1">CeAnomalySubscription#subscriber</a> Accepts: aws.IResolvable | aws.CeAnomalySubscription.CeAnomalySubscriptionSubscriber[]
        /// </summary>
        [<CustomOperation "subscriber">]
        member _.Subscriber(state: CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, Missing>, value: HashiCorp.Cdktf.IResolvable) : CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, Present> =
            state.assignments.Add(fun config -> config.Subscriber <- value)
            ({ assignments = state.assignments } : CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#account_id-1">CeAnomalySubscription#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber>, value: string) : CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#id-1">CeAnomalySubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber>, value: string) : CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#tags-1">CeAnomalySubscription#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber>, value: seq<string * string>) : CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#tags_all-1">CeAnomalySubscription#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber>, value: seq<string * string>) : CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber>

        /// <summary>
        /// threshold_expression block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#threshold_expression-1">CeAnomalySubscription#threshold_expression</a>
        /// </summary>
        [<CustomOperation "threshold_expression">]
        member _.ThresholdExpression(state: CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber>, value: aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpression) : CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber> =
            state.assignments.Add(fun config -> config.ThresholdExpression <- value)
            state : CeAnomalySubscriptionState<'Frequency, 'MonitorArnList, 'Name, 'Subscriber>

        member _.Run(state: CeAnomalySubscriptionState<Present, Present, Present, Present>) : aws.CeAnomalySubscription.CeAnomalySubscription =
            let config = aws.CeAnomalySubscription.CeAnomalySubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.CeAnomalySubscription.CeAnomalySubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ceAnomalySubscription: missing required arguments. Must call: frequency, monitor_arn_list, name, subscriber.", 9999, IsError = true)>]
        member _.Run(_: CeAnomalySubscriptionState<_, _, _, _>) : aws.CeAnomalySubscription.CeAnomalySubscription =
            Unchecked.defaultof<aws.CeAnomalySubscription.CeAnomalySubscription>
