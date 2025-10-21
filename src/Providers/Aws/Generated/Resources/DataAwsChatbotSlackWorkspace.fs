namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsChatbotSlackWorkspaceState<'SlackTeamName> = { assignments: ResizeArray<aws.DataAwsChatbotSlackWorkspace.DataAwsChatbotSlackWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/chatbot_slack_workspace">aws_chatbot_slack_workspace</a>.
    /// </summary>
    type DataAwsChatbotSlackWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsChatbotSlackWorkspaceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsChatbotSlackWorkspaceState<Missing>)

        member _.Zero(()) : DataAwsChatbotSlackWorkspaceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsChatbotSlackWorkspaceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/chatbot_slack_workspace#slack_team_name-1">DataAwsChatbotSlackWorkspace#slack_team_name</a>.
        /// </summary>
        [<CustomOperation "slack_team_name">]
        member _.SlackTeamName(state: DataAwsChatbotSlackWorkspaceState<Missing>, value: string) : DataAwsChatbotSlackWorkspaceState<Present> =
            state.assignments.Add(fun config -> config.SlackTeamName <- value)
            ({ assignments = state.assignments } : DataAwsChatbotSlackWorkspaceState<Present>)

        member _.Run(state: DataAwsChatbotSlackWorkspaceState<Present>) : aws.DataAwsChatbotSlackWorkspace.DataAwsChatbotSlackWorkspace =
            let config = aws.DataAwsChatbotSlackWorkspace.DataAwsChatbotSlackWorkspaceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsChatbotSlackWorkspace.DataAwsChatbotSlackWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsChatbotSlackWorkspace: missing required arguments. Must call: slack_team_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsChatbotSlackWorkspaceState<_>) : aws.DataAwsChatbotSlackWorkspace.DataAwsChatbotSlackWorkspace =
            Unchecked.defaultof<aws.DataAwsChatbotSlackWorkspace.DataAwsChatbotSlackWorkspace>
