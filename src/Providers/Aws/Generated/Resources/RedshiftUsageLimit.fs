namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType> = { assignments: ResizeArray<aws.RedshiftUsageLimit.RedshiftUsageLimitConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_usage_limit">aws_redshift_usage_limit</a>.
    /// </summary>
    type RedshiftUsageLimitBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftUsageLimitState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftUsageLimitState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RedshiftUsageLimitState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftUsageLimitState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_usage_limit#amount-1">RedshiftUsageLimit#amount</a>.
        /// </summary>
        [<CustomOperation "amount">]
        member _.Amount(state: RedshiftUsageLimitState<Missing, 'ClusterIdentifier, 'FeatureType, 'LimitType>, value: double) : RedshiftUsageLimitState<Present, 'ClusterIdentifier, 'FeatureType, 'LimitType> =
            state.assignments.Add(fun config -> config.Amount <- value)
            ({ assignments = state.assignments } : RedshiftUsageLimitState<Present, 'ClusterIdentifier, 'FeatureType, 'LimitType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_usage_limit#cluster_identifier-1">RedshiftUsageLimit#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: RedshiftUsageLimitState<'Amount, Missing, 'FeatureType, 'LimitType>, value: string) : RedshiftUsageLimitState<'Amount, Present, 'FeatureType, 'LimitType> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftUsageLimitState<'Amount, Present, 'FeatureType, 'LimitType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_usage_limit#feature_type-1">RedshiftUsageLimit#feature_type</a>.
        /// </summary>
        [<CustomOperation "feature_type">]
        member _.FeatureType(state: RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, Missing, 'LimitType>, value: string) : RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, Present, 'LimitType> =
            state.assignments.Add(fun config -> config.FeatureType <- value)
            ({ assignments = state.assignments } : RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, Present, 'LimitType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_usage_limit#limit_type-1">RedshiftUsageLimit#limit_type</a>.
        /// </summary>
        [<CustomOperation "limit_type">]
        member _.LimitType(state: RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, Missing>, value: string) : RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, Present> =
            state.assignments.Add(fun config -> config.LimitType <- value)
            ({ assignments = state.assignments } : RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_usage_limit#breach_action-1">RedshiftUsageLimit#breach_action</a>.
        /// </summary>
        [<CustomOperation "breach_action">]
        member _.BreachAction(state: RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType>, value: string) : RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType> =
            state.assignments.Add(fun config -> config.BreachAction <- value)
            state : RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_usage_limit#id-1">RedshiftUsageLimit#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType>, value: string) : RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_usage_limit#period-1">RedshiftUsageLimit#period</a>.
        /// </summary>
        [<CustomOperation "period">]
        member _.Period(state: RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType>, value: string) : RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType> =
            state.assignments.Add(fun config -> config.Period <- value)
            state : RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_usage_limit#tags-1">RedshiftUsageLimit#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType>, value: seq<string * string>) : RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_usage_limit#tags_all-1">RedshiftUsageLimit#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType>, value: seq<string * string>) : RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RedshiftUsageLimitState<'Amount, 'ClusterIdentifier, 'FeatureType, 'LimitType>

        member _.Run(state: RedshiftUsageLimitState<Present, Present, Present, Present>) : aws.RedshiftUsageLimit.RedshiftUsageLimit =
            let config = aws.RedshiftUsageLimit.RedshiftUsageLimitConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftUsageLimit.RedshiftUsageLimit(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftUsageLimit: missing required arguments. Must call: amount, cluster_identifier, feature_type, limit_type.", 9999, IsError = true)>]
        member _.Run(_: RedshiftUsageLimitState<_, _, _, _>) : aws.RedshiftUsageLimit.RedshiftUsageLimit =
            Unchecked.defaultof<aws.RedshiftUsageLimit.RedshiftUsageLimit>
