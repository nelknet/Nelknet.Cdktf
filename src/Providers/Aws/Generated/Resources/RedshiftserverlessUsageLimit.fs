namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftserverlessUsageLimitState<'Amount, 'ResourceArn, 'UsageType> = { assignments: ResizeArray<aws.RedshiftserverlessUsageLimit.RedshiftserverlessUsageLimitConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_usage_limit">aws_redshiftserverless_usage_limit</a>.
    /// </summary>
    type RedshiftserverlessUsageLimitBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftserverlessUsageLimitState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftserverlessUsageLimitState<Missing, Missing, Missing>)

        member _.Zero(()) : RedshiftserverlessUsageLimitState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftserverlessUsageLimitState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_usage_limit#amount-1">RedshiftserverlessUsageLimit#amount</a>.
        /// </summary>
        [<CustomOperation "amount">]
        member _.Amount(state: RedshiftserverlessUsageLimitState<Missing, 'ResourceArn, 'UsageType>, value: double) : RedshiftserverlessUsageLimitState<Present, 'ResourceArn, 'UsageType> =
            state.assignments.Add(fun config -> config.Amount <- value)
            ({ assignments = state.assignments } : RedshiftserverlessUsageLimitState<Present, 'ResourceArn, 'UsageType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_usage_limit#resource_arn-1">RedshiftserverlessUsageLimit#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: RedshiftserverlessUsageLimitState<'Amount, Missing, 'UsageType>, value: string) : RedshiftserverlessUsageLimitState<'Amount, Present, 'UsageType> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : RedshiftserverlessUsageLimitState<'Amount, Present, 'UsageType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_usage_limit#usage_type-1">RedshiftserverlessUsageLimit#usage_type</a>.
        /// </summary>
        [<CustomOperation "usage_type">]
        member _.UsageType(state: RedshiftserverlessUsageLimitState<'Amount, 'ResourceArn, Missing>, value: string) : RedshiftserverlessUsageLimitState<'Amount, 'ResourceArn, Present> =
            state.assignments.Add(fun config -> config.UsageType <- value)
            ({ assignments = state.assignments } : RedshiftserverlessUsageLimitState<'Amount, 'ResourceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_usage_limit#breach_action-1">RedshiftserverlessUsageLimit#breach_action</a>.
        /// </summary>
        [<CustomOperation "breach_action">]
        member _.BreachAction(state: RedshiftserverlessUsageLimitState<'Amount, 'ResourceArn, 'UsageType>, value: string) : RedshiftserverlessUsageLimitState<'Amount, 'ResourceArn, 'UsageType> =
            state.assignments.Add(fun config -> config.BreachAction <- value)
            state : RedshiftserverlessUsageLimitState<'Amount, 'ResourceArn, 'UsageType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_usage_limit#id-1">RedshiftserverlessUsageLimit#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftserverlessUsageLimitState<'Amount, 'ResourceArn, 'UsageType>, value: string) : RedshiftserverlessUsageLimitState<'Amount, 'ResourceArn, 'UsageType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftserverlessUsageLimitState<'Amount, 'ResourceArn, 'UsageType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_usage_limit#period-1">RedshiftserverlessUsageLimit#period</a>.
        /// </summary>
        [<CustomOperation "period">]
        member _.Period(state: RedshiftserverlessUsageLimitState<'Amount, 'ResourceArn, 'UsageType>, value: string) : RedshiftserverlessUsageLimitState<'Amount, 'ResourceArn, 'UsageType> =
            state.assignments.Add(fun config -> config.Period <- value)
            state : RedshiftserverlessUsageLimitState<'Amount, 'ResourceArn, 'UsageType>

        member _.Run(state: RedshiftserverlessUsageLimitState<Present, Present, Present>) : aws.RedshiftserverlessUsageLimit.RedshiftserverlessUsageLimit =
            let config = aws.RedshiftserverlessUsageLimit.RedshiftserverlessUsageLimitConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftserverlessUsageLimit.RedshiftserverlessUsageLimit(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftserverlessUsageLimit: missing required arguments. Must call: amount, resource_arn, usage_type.", 9999, IsError = true)>]
        member _.Run(_: RedshiftserverlessUsageLimitState<_, _, _>) : aws.RedshiftserverlessUsageLimit.RedshiftserverlessUsageLimit =
            Unchecked.defaultof<aws.RedshiftserverlessUsageLimit.RedshiftserverlessUsageLimit>
