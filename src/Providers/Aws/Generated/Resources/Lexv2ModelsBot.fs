namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn> = { assignments: ResizeArray<aws.Lexv2ModelsBot.Lexv2ModelsBotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot">aws_lexv2models_bot</a>.
    /// </summary>
    type Lexv2ModelsBotBuilder(logicalId: string) =
        member _.Yield(_: unit) : Lexv2ModelsBotState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Lexv2ModelsBotState<Missing, Missing, Missing>)

        member _.Zero(()) : Lexv2ModelsBotState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Lexv2ModelsBotState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot#idle_session_ttl_in_seconds-1">Lexv2ModelsBot#idle_session_ttl_in_seconds</a>.
        /// </summary>
        [<CustomOperation "idle_session_ttl_in_seconds">]
        member _.IdleSessionTtlInSeconds(state: Lexv2ModelsBotState<Missing, 'Name, 'RoleArn>, value: double) : Lexv2ModelsBotState<Present, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.IdleSessionTtlInSeconds <- value)
            ({ assignments = state.assignments } : Lexv2ModelsBotState<Present, 'Name, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot#name-1">Lexv2ModelsBot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Lexv2ModelsBotState<'IdleSessionTtlInSeconds, Missing, 'RoleArn>, value: string) : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot#role_arn-1">Lexv2ModelsBot#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, Missing>, value: string) : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, Present>)

        /// <summary>
        /// data_privacy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot#data_privacy-1">Lexv2ModelsBot#data_privacy</a> Accepts: aws.IResolvable | aws.Lexv2ModelsBot.Lexv2ModelsBotDataPrivacy[]
        /// </summary>
        [<CustomOperation "data_privacy">]
        member _.DataPrivacy(state: Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.DataPrivacy <- value)
            state : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot#description-1">Lexv2ModelsBot#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn>, value: string) : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn>

        /// <summary>
        /// members block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot#members-1">Lexv2ModelsBot#members</a> Accepts: aws.IResolvable | aws.Lexv2ModelsBot.Lexv2ModelsBotMembers[]
        /// </summary>
        [<CustomOperation "members">]
        member _.Members(state: Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Members <- value)
            state : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot#tags-1">Lexv2ModelsBot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn>, value: seq<string * string>) : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot#test_bot_alias_tags-1">Lexv2ModelsBot#test_bot_alias_tags</a>.
        /// </summary>
        [<CustomOperation "test_bot_alias_tags">]
        member _.TestBotAliasTags(state: Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn>, value: seq<string * string>) : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.TestBotAliasTags <- dict value)
            state : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot#timeouts-1">Lexv2ModelsBot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn>, value: aws.Lexv2ModelsBot.Lexv2ModelsBotTimeouts) : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot#type-1">Lexv2ModelsBot#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn>, value: string) : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : Lexv2ModelsBotState<'IdleSessionTtlInSeconds, 'Name, 'RoleArn>

        member _.Run(state: Lexv2ModelsBotState<Present, Present, Present>) : aws.Lexv2ModelsBot.Lexv2ModelsBot =
            let config = aws.Lexv2ModelsBot.Lexv2ModelsBotConfig()
            for setter in state.assignments do
                setter config
            aws.Lexv2ModelsBot.Lexv2ModelsBot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lexv2ModelsBot: missing required arguments. Must call: idle_session_ttl_in_seconds, name, role_arn.", 9999, IsError = true)>]
        member _.Run(_: Lexv2ModelsBotState<_, _, _>) : aws.Lexv2ModelsBot.Lexv2ModelsBot =
            Unchecked.defaultof<aws.Lexv2ModelsBot.Lexv2ModelsBot>
