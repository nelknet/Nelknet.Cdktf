namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId> = { assignments: ResizeArray<aws.ChatbotSlackChannelConfiguration.ChatbotSlackChannelConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_slack_channel_configuration">aws_chatbot_slack_channel_configuration</a>.
    /// </summary>
    type ChatbotSlackChannelConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChatbotSlackChannelConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChatbotSlackChannelConfigurationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ChatbotSlackChannelConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChatbotSlackChannelConfigurationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_slack_channel_configuration#configuration_name-1">ChatbotSlackChannelConfiguration#configuration_name</a>.
        /// </summary>
        [<CustomOperation "configuration_name">]
        member _.ConfigurationName(state: ChatbotSlackChannelConfigurationState<Missing, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>, value: string) : ChatbotSlackChannelConfigurationState<Present, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId> =
            state.assignments.Add(fun config -> config.ConfigurationName <- value)
            ({ assignments = state.assignments } : ChatbotSlackChannelConfigurationState<Present, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_slack_channel_configuration#iam_role_arn-1">ChatbotSlackChannelConfiguration#iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "iam_role_arn">]
        member _.IamRoleArn(state: ChatbotSlackChannelConfigurationState<'ConfigurationName, Missing, 'SlackChannelId, 'SlackTeamId>, value: string) : ChatbotSlackChannelConfigurationState<'ConfigurationName, Present, 'SlackChannelId, 'SlackTeamId> =
            state.assignments.Add(fun config -> config.IamRoleArn <- value)
            ({ assignments = state.assignments } : ChatbotSlackChannelConfigurationState<'ConfigurationName, Present, 'SlackChannelId, 'SlackTeamId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_slack_channel_configuration#slack_channel_id-1">ChatbotSlackChannelConfiguration#slack_channel_id</a>.
        /// </summary>
        [<CustomOperation "slack_channel_id">]
        member _.SlackChannelId(state: ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, Missing, 'SlackTeamId>, value: string) : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, Present, 'SlackTeamId> =
            state.assignments.Add(fun config -> config.SlackChannelId <- value)
            ({ assignments = state.assignments } : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, Present, 'SlackTeamId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_slack_channel_configuration#slack_team_id-1">ChatbotSlackChannelConfiguration#slack_team_id</a>.
        /// </summary>
        [<CustomOperation "slack_team_id">]
        member _.SlackTeamId(state: ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, Missing>, value: string) : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, Present> =
            state.assignments.Add(fun config -> config.SlackTeamId <- value)
            ({ assignments = state.assignments } : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_slack_channel_configuration#guardrail_policy_arns-1">ChatbotSlackChannelConfiguration#guardrail_policy_arns</a>.
        /// </summary>
        [<CustomOperation "guardrail_policy_arns">]
        member _.GuardrailPolicyArns(state: ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>, value: seq<string>) : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId> =
            state.assignments.Add(fun config -> config.GuardrailPolicyArns <- (value |> Seq.toArray))
            state : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_slack_channel_configuration#logging_level-1">ChatbotSlackChannelConfiguration#logging_level</a>.
        /// </summary>
        [<CustomOperation "logging_level">]
        member _.LoggingLevel(state: ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>, value: string) : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId> =
            state.assignments.Add(fun config -> config.LoggingLevel <- value)
            state : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_slack_channel_configuration#sns_topic_arns-1">ChatbotSlackChannelConfiguration#sns_topic_arns</a>.
        /// </summary>
        [<CustomOperation "sns_topic_arns">]
        member _.SnsTopicArns(state: ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>, value: seq<string>) : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId> =
            state.assignments.Add(fun config -> config.SnsTopicArns <- (value |> Seq.toArray))
            state : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_slack_channel_configuration#tags-1">ChatbotSlackChannelConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>, value: seq<string * string>) : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_slack_channel_configuration#timeouts-1">ChatbotSlackChannelConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>, value: aws.ChatbotSlackChannelConfiguration.ChatbotSlackChannelConfigurationTimeouts) : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_slack_channel_configuration#user_authorization_required-1">ChatbotSlackChannelConfiguration#user_authorization_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "user_authorization_required">]
        member _.UserAuthorizationRequired(state: ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>, value: bool) : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId> =
            state.assignments.Add(fun config -> config.UserAuthorizationRequired <- value)
            state : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_slack_channel_configuration#user_authorization_required-1">ChatbotSlackChannelConfiguration#user_authorization_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "user_authorization_required">]
        member _.UserAuthorizationRequired(state: ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>, value: HashiCorp.Cdktf.IResolvable) : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId> =
            state.assignments.Add(fun config -> config.UserAuthorizationRequired <- value)
            state : ChatbotSlackChannelConfigurationState<'ConfigurationName, 'IamRoleArn, 'SlackChannelId, 'SlackTeamId>

        member _.Run(state: ChatbotSlackChannelConfigurationState<Present, Present, Present, Present>) : aws.ChatbotSlackChannelConfiguration.ChatbotSlackChannelConfiguration =
            let config = aws.ChatbotSlackChannelConfiguration.ChatbotSlackChannelConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.ChatbotSlackChannelConfiguration.ChatbotSlackChannelConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.chatbotSlackChannelConfiguration: missing required arguments. Must call: configuration_name, iam_role_arn, slack_channel_id, slack_team_id.", 9999, IsError = true)>]
        member _.Run(_: ChatbotSlackChannelConfigurationState<_, _, _, _>) : aws.ChatbotSlackChannelConfiguration.ChatbotSlackChannelConfiguration =
            Unchecked.defaultof<aws.ChatbotSlackChannelConfiguration.ChatbotSlackChannelConfiguration>
