namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelDataConnectorAwsCloudTrailState<'AwsRoleArn, 'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelDataConnectorAwsCloudTrail.SentinelDataConnectorAwsCloudTrailConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_aws_cloud_trail">azurerm_sentinel_data_connector_aws_cloud_trail</a>.
    /// </summary>
    type SentinelDataConnectorAwsCloudTrailBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelDataConnectorAwsCloudTrailState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorAwsCloudTrailState<Missing, Missing, Missing>)

        member _.Zero(()) : SentinelDataConnectorAwsCloudTrailState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelDataConnectorAwsCloudTrailState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_aws_cloud_trail#aws_role_arn-1">SentinelDataConnectorAwsCloudTrail#aws_role_arn</a>.
        /// </summary>
        [<CustomOperation "aws_role_arn">]
        member _.AwsRoleArn(state: SentinelDataConnectorAwsCloudTrailState<Missing, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorAwsCloudTrailState<Present, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.AwsRoleArn <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorAwsCloudTrailState<Present, 'LogAnalyticsWorkspaceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_aws_cloud_trail#log_analytics_workspace_id-1">SentinelDataConnectorAwsCloudTrail#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelDataConnectorAwsCloudTrailState<'AwsRoleArn, Missing, 'Name>, value: string) : SentinelDataConnectorAwsCloudTrailState<'AwsRoleArn, Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorAwsCloudTrailState<'AwsRoleArn, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_aws_cloud_trail#name-1">SentinelDataConnectorAwsCloudTrail#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelDataConnectorAwsCloudTrailState<'AwsRoleArn, 'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelDataConnectorAwsCloudTrailState<'AwsRoleArn, 'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelDataConnectorAwsCloudTrailState<'AwsRoleArn, 'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_aws_cloud_trail#id-1">SentinelDataConnectorAwsCloudTrail#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelDataConnectorAwsCloudTrailState<'AwsRoleArn, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelDataConnectorAwsCloudTrailState<'AwsRoleArn, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelDataConnectorAwsCloudTrailState<'AwsRoleArn, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_aws_cloud_trail#timeouts-1">SentinelDataConnectorAwsCloudTrail#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelDataConnectorAwsCloudTrailState<'AwsRoleArn, 'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelDataConnectorAwsCloudTrail.SentinelDataConnectorAwsCloudTrailTimeouts) : SentinelDataConnectorAwsCloudTrailState<'AwsRoleArn, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelDataConnectorAwsCloudTrailState<'AwsRoleArn, 'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelDataConnectorAwsCloudTrailState<Present, Present, Present>) : azurerm.SentinelDataConnectorAwsCloudTrail.SentinelDataConnectorAwsCloudTrail =
            let config = azurerm.SentinelDataConnectorAwsCloudTrail.SentinelDataConnectorAwsCloudTrailConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelDataConnectorAwsCloudTrail.SentinelDataConnectorAwsCloudTrail(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelDataConnectorAwsCloudTrail: missing required arguments. Must call: aws_role_arn, log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelDataConnectorAwsCloudTrailState<_, _, _>) : azurerm.SentinelDataConnectorAwsCloudTrail.SentinelDataConnectorAwsCloudTrail =
            Unchecked.defaultof<azurerm.SentinelDataConnectorAwsCloudTrail.SentinelDataConnectorAwsCloudTrail>
