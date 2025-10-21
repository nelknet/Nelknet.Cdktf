namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, 'LogAnalyticsWorkspaceId, 'Name, 'SqsUrls> = { assignments: ResizeArray<azurerm.SentinelDataConnectorAwsS3.SentinelDataConnectorAwsS3Config -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_aws_s3">azurerm_sentinel_data_connector_aws_s3</a>.
    /// </summary>
    type SentinelDataConnectorAwsS3Builder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorAwsS3State<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorAwsS3State<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorAwsS3State<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorAwsS3State<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_aws_s3#aws_role_arn-1">SentinelDataConnectorAwsS3#aws_role_arn</a>.
        /// </summary>
        [<CustomOperation "aws_role_arn">]
        member _.AwsRoleArn(state: SentinelDataConnectorAwsS3State<Missing, 'DestinationTable, 'LogAnalyticsWorkspaceId, 'Name, 'SqsUrls>, value: string) : SentinelDataConnectorAwsS3State<Present, 'DestinationTable, 'LogAnalyticsWorkspaceId, 'Name, 'SqsUrls> =
            state.assignments.Add(fun config -> config.AwsRoleArn <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorAwsS3State<Present, 'DestinationTable, 'LogAnalyticsWorkspaceId, 'Name, 'SqsUrls>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_aws_s3#destination_table-1">SentinelDataConnectorAwsS3#destination_table</a>.
        /// </summary>
        [<CustomOperation "destination_table">]
        member _.DestinationTable(state: SentinelDataConnectorAwsS3State<'AwsRoleArn, Missing, 'LogAnalyticsWorkspaceId, 'Name, 'SqsUrls>, value: string) : SentinelDataConnectorAwsS3State<'AwsRoleArn, Present, 'LogAnalyticsWorkspaceId, 'Name, 'SqsUrls> =
            state.assignments.Add(fun config -> config.DestinationTable <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorAwsS3State<'AwsRoleArn, Present, 'LogAnalyticsWorkspaceId, 'Name, 'SqsUrls>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_aws_s3#log_analytics_workspace_id-1">SentinelDataConnectorAwsS3#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, Missing, 'Name, 'SqsUrls>, value: string) : SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, Present, 'Name, 'SqsUrls> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, Present, 'Name, 'SqsUrls>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_aws_s3#name-1">SentinelDataConnectorAwsS3#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, 'LogAnalyticsWorkspaceId, Missing, 'SqsUrls>, value: string) : SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, 'LogAnalyticsWorkspaceId, Present, 'SqsUrls> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, 'LogAnalyticsWorkspaceId, Present, 'SqsUrls>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_aws_s3#sqs_urls-1">SentinelDataConnectorAwsS3#sqs_urls</a>.
        /// </summary>
        [<CustomOperation "sqs_urls">]
        member _.SqsUrls(state: SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, 'LogAnalyticsWorkspaceId, 'Name, Missing>, value: seq<string>) : SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, 'LogAnalyticsWorkspaceId, 'Name, Present> =
            state.assignments.Add(fun config -> config.SqsUrls <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, 'LogAnalyticsWorkspaceId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_aws_s3#id-1">SentinelDataConnectorAwsS3#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, 'LogAnalyticsWorkspaceId, 'Name, 'SqsUrls>, value: string) : SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, 'LogAnalyticsWorkspaceId, 'Name, 'SqsUrls> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, 'LogAnalyticsWorkspaceId, 'Name, 'SqsUrls>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_aws_s3#timeouts-1">SentinelDataConnectorAwsS3#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, 'LogAnalyticsWorkspaceId, 'Name, 'SqsUrls>, value: azurerm.SentinelDataConnectorAwsS3.SentinelDataConnectorAwsS3Timeouts) : SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, 'LogAnalyticsWorkspaceId, 'Name, 'SqsUrls> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorAwsS3State<'AwsRoleArn, 'DestinationTable, 'LogAnalyticsWorkspaceId, 'Name, 'SqsUrls>

        member _.Run(state: SentinelDataConnectorAwsS3State<Present, Present, Present, Present, Present>) : azurerm.SentinelDataConnectorAwsS3.SentinelDataConnectorAwsS3 =
            let config = azurerm.SentinelDataConnectorAwsS3.SentinelDataConnectorAwsS3Config()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorAwsS3.SentinelDataConnectorAwsS3(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorAwsS3: missing required arguments. Must call: aws_role_arn, destination_table, log_analytics_workspace_id, name, sqs_urls.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorAwsS3State<_, _, _, _, _>) : azurerm.SentinelDataConnectorAwsS3.SentinelDataConnectorAwsS3 =
            Unchecked.defaultof<azurerm.SentinelDataConnectorAwsS3.SentinelDataConnectorAwsS3>
