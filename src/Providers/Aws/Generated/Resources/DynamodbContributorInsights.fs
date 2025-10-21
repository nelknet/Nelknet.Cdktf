namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DynamodbContributorInsightsState<'TableName> = { assignments: ResizeArray<aws.DynamodbContributorInsights.DynamodbContributorInsightsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_contributor_insights">aws_dynamodb_contributor_insights</a>.
    /// </summary>
    type DynamodbContributorInsightsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DynamodbContributorInsightsState<Missing> =
            ({ assignments = ResizeArray() } : DynamodbContributorInsightsState<Missing>)

        member _.Zero(()) : DynamodbContributorInsightsState<Missing> =
            ({ assignments = ResizeArray() } : DynamodbContributorInsightsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_contributor_insights#table_name-1">DynamodbContributorInsights#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: DynamodbContributorInsightsState<Missing>, value: string) : DynamodbContributorInsightsState<Present> =
            state.assignments.Add(fun config -> config.TableName <- value)
            ({ assignments = state.assignments } : DynamodbContributorInsightsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_contributor_insights#id-1">DynamodbContributorInsights#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DynamodbContributorInsightsState<'TableName>, value: string) : DynamodbContributorInsightsState<'TableName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DynamodbContributorInsightsState<'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_contributor_insights#index_name-1">DynamodbContributorInsights#index_name</a>.
        /// </summary>
        [<CustomOperation "index_name">]
        member _.IndexName(state: DynamodbContributorInsightsState<'TableName>, value: string) : DynamodbContributorInsightsState<'TableName> =
            state.assignments.Add(fun config -> config.IndexName <- value)
            state : DynamodbContributorInsightsState<'TableName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_contributor_insights#timeouts-1">DynamodbContributorInsights#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DynamodbContributorInsightsState<'TableName>, value: aws.DynamodbContributorInsights.DynamodbContributorInsightsTimeouts) : DynamodbContributorInsightsState<'TableName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DynamodbContributorInsightsState<'TableName>

        member _.Run(state: DynamodbContributorInsightsState<Present>) : aws.DynamodbContributorInsights.DynamodbContributorInsights =
            let config = aws.DynamodbContributorInsights.DynamodbContributorInsightsConfig()
            for setter in state.assignments do
                setter config
            aws.DynamodbContributorInsights.DynamodbContributorInsights(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dynamodbContributorInsights: missing required arguments. Must call: table_name.", 9999, IsError = true)>]
        member _.Run(_: DynamodbContributorInsightsState<_>) : aws.DynamodbContributorInsights.DynamodbContributorInsights =
            Unchecked.defaultof<aws.DynamodbContributorInsights.DynamodbContributorInsights>
