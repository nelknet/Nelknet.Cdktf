namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId> = { assignments: ResizeArray<aws.ChatbotTeamsChannelConfiguration.ChatbotTeamsChannelConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration">aws_chatbot_teams_channel_configuration</a>.
    /// </summary>
    type ChatbotTeamsChannelConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChatbotTeamsChannelConfigurationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChatbotTeamsChannelConfigurationState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ChatbotTeamsChannelConfigurationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChatbotTeamsChannelConfigurationState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration#channel_id-1">ChatbotTeamsChannelConfiguration#channel_id</a>.
        /// </summary>
        [<CustomOperation "channel_id">]
        member _.ChannelId(state: ChatbotTeamsChannelConfigurationState<Missing, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>, value: string) : ChatbotTeamsChannelConfigurationState<Present, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId> =
            state.assignments.Add(fun config -> config.ChannelId <- value)
            ({ assignments = state.assignments } : ChatbotTeamsChannelConfigurationState<Present, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration#configuration_name-1">ChatbotTeamsChannelConfiguration#configuration_name</a>.
        /// </summary>
        [<CustomOperation "configuration_name">]
        member _.ConfigurationName(state: ChatbotTeamsChannelConfigurationState<'ChannelId, Missing, 'IamRoleArn, 'TeamId, 'TenantId>, value: string) : ChatbotTeamsChannelConfigurationState<'ChannelId, Present, 'IamRoleArn, 'TeamId, 'TenantId> =
            state.assignments.Add(fun config -> config.ConfigurationName <- value)
            ({ assignments = state.assignments } : ChatbotTeamsChannelConfigurationState<'ChannelId, Present, 'IamRoleArn, 'TeamId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration#iam_role_arn-1">ChatbotTeamsChannelConfiguration#iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "iam_role_arn">]
        member _.IamRoleArn(state: ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, Missing, 'TeamId, 'TenantId>, value: string) : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, Present, 'TeamId, 'TenantId> =
            state.assignments.Add(fun config -> config.IamRoleArn <- value)
            ({ assignments = state.assignments } : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, Present, 'TeamId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration#team_id-1">ChatbotTeamsChannelConfiguration#team_id</a>.
        /// </summary>
        [<CustomOperation "team_id">]
        member _.TeamId(state: ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, Missing, 'TenantId>, value: string) : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.TeamId <- value)
            ({ assignments = state.assignments } : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration#tenant_id-1">ChatbotTeamsChannelConfiguration#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, Missing>, value: string) : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration#channel_name-1">ChatbotTeamsChannelConfiguration#channel_name</a>.
        /// </summary>
        [<CustomOperation "channel_name">]
        member _.ChannelName(state: ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>, value: string) : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId> =
            state.assignments.Add(fun config -> config.ChannelName <- value)
            state : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration#guardrail_policy_arns-1">ChatbotTeamsChannelConfiguration#guardrail_policy_arns</a>.
        /// </summary>
        [<CustomOperation "guardrail_policy_arns">]
        member _.GuardrailPolicyArns(state: ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>, value: seq<string>) : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId> =
            state.assignments.Add(fun config -> config.GuardrailPolicyArns <- (value |> Seq.toArray))
            state : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration#logging_level-1">ChatbotTeamsChannelConfiguration#logging_level</a>.
        /// </summary>
        [<CustomOperation "logging_level">]
        member _.LoggingLevel(state: ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>, value: string) : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId> =
            state.assignments.Add(fun config -> config.LoggingLevel <- value)
            state : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration#sns_topic_arns-1">ChatbotTeamsChannelConfiguration#sns_topic_arns</a>.
        /// </summary>
        [<CustomOperation "sns_topic_arns">]
        member _.SnsTopicArns(state: ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>, value: seq<string>) : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId> =
            state.assignments.Add(fun config -> config.SnsTopicArns <- (value |> Seq.toArray))
            state : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration#tags-1">ChatbotTeamsChannelConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>, value: seq<string * string>) : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration#team_name-1">ChatbotTeamsChannelConfiguration#team_name</a>.
        /// </summary>
        [<CustomOperation "team_name">]
        member _.TeamName(state: ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>, value: string) : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId> =
            state.assignments.Add(fun config -> config.TeamName <- value)
            state : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration#timeouts-1">ChatbotTeamsChannelConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>, value: aws.ChatbotTeamsChannelConfiguration.ChatbotTeamsChannelConfigurationTimeouts) : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration#user_authorization_required-1">ChatbotTeamsChannelConfiguration#user_authorization_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "user_authorization_required">]
        member _.UserAuthorizationRequired(state: ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>, value: bool) : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId> =
            state.assignments.Add(fun config -> config.UserAuthorizationRequired <- value)
            state : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chatbot_teams_channel_configuration#user_authorization_required-1">ChatbotTeamsChannelConfiguration#user_authorization_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "user_authorization_required">]
        member _.UserAuthorizationRequired(state: ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>, value: HashiCorp.Cdktf.IResolvable) : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId> =
            state.assignments.Add(fun config -> config.UserAuthorizationRequired <- value)
            state : ChatbotTeamsChannelConfigurationState<'ChannelId, 'ConfigurationName, 'IamRoleArn, 'TeamId, 'TenantId>

        member _.Run(state: ChatbotTeamsChannelConfigurationState<Present, Present, Present, Present, Present>) : aws.ChatbotTeamsChannelConfiguration.ChatbotTeamsChannelConfiguration =
            let config = aws.ChatbotTeamsChannelConfiguration.ChatbotTeamsChannelConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.ChatbotTeamsChannelConfiguration.ChatbotTeamsChannelConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.chatbotTeamsChannelConfiguration: missing required arguments. Must call: channel_id, configuration_name, iam_role_arn, team_id, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: ChatbotTeamsChannelConfigurationState<_, _, _, _, _>) : aws.ChatbotTeamsChannelConfiguration.ChatbotTeamsChannelConfiguration =
            Unchecked.defaultof<aws.ChatbotTeamsChannelConfiguration.ChatbotTeamsChannelConfiguration>
