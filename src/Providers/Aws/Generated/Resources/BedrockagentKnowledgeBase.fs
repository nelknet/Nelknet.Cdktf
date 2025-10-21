namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BedrockagentKnowledgeBaseState<'Name, 'RoleArn> = { assignments: ResizeArray<aws.BedrockagentKnowledgeBase.BedrockagentKnowledgeBaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_knowledge_base">aws_bedrockagent_knowledge_base</a>.
    /// </summary>
    type BedrockagentKnowledgeBaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : BedrockagentKnowledgeBaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockagentKnowledgeBaseState<Missing, Missing>)

        member _.Zero(()) : BedrockagentKnowledgeBaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockagentKnowledgeBaseState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_knowledge_base#name-1">BedrockagentKnowledgeBase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BedrockagentKnowledgeBaseState<Missing, 'RoleArn>, value: string) : BedrockagentKnowledgeBaseState<Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BedrockagentKnowledgeBaseState<Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_knowledge_base#role_arn-1">BedrockagentKnowledgeBase#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: BedrockagentKnowledgeBaseState<'Name, Missing>, value: string) : BedrockagentKnowledgeBaseState<'Name, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : BedrockagentKnowledgeBaseState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_knowledge_base#description-1">BedrockagentKnowledgeBase#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: BedrockagentKnowledgeBaseState<'Name, 'RoleArn>, value: string) : BedrockagentKnowledgeBaseState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : BedrockagentKnowledgeBaseState<'Name, 'RoleArn>

        /// <summary>
        /// knowledge_base_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_knowledge_base#knowledge_base_configuration-1">BedrockagentKnowledgeBase#knowledge_base_configuration</a> Accepts: aws.IResolvable | aws.BedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfiguration[]
        /// </summary>
        [<CustomOperation "knowledge_base_configuration">]
        member _.KnowledgeBaseConfiguration(state: BedrockagentKnowledgeBaseState<'Name, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentKnowledgeBaseState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.KnowledgeBaseConfiguration <- value)
            state : BedrockagentKnowledgeBaseState<'Name, 'RoleArn>

        /// <summary>
        /// storage_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_knowledge_base#storage_configuration-1">BedrockagentKnowledgeBase#storage_configuration</a> Accepts: aws.IResolvable | aws.BedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfiguration[]
        /// </summary>
        [<CustomOperation "storage_configuration">]
        member _.StorageConfiguration(state: BedrockagentKnowledgeBaseState<'Name, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentKnowledgeBaseState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.StorageConfiguration <- value)
            state : BedrockagentKnowledgeBaseState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_knowledge_base#tags-1">BedrockagentKnowledgeBase#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BedrockagentKnowledgeBaseState<'Name, 'RoleArn>, value: seq<string * string>) : BedrockagentKnowledgeBaseState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BedrockagentKnowledgeBaseState<'Name, 'RoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_knowledge_base#timeouts-1">BedrockagentKnowledgeBase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BedrockagentKnowledgeBaseState<'Name, 'RoleArn>, value: aws.BedrockagentKnowledgeBase.BedrockagentKnowledgeBaseTimeouts) : BedrockagentKnowledgeBaseState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BedrockagentKnowledgeBaseState<'Name, 'RoleArn>

        member _.Run(state: BedrockagentKnowledgeBaseState<Present, Present>) : aws.BedrockagentKnowledgeBase.BedrockagentKnowledgeBase =
            let config = aws.BedrockagentKnowledgeBase.BedrockagentKnowledgeBaseConfig()
            for setter in state.assignments do
                setter config
            aws.BedrockagentKnowledgeBase.BedrockagentKnowledgeBase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.bedrockagentKnowledgeBase: missing required arguments. Must call: name, role_arn.", 9999, IsError = true)>]
        member _.Run(_: BedrockagentKnowledgeBaseState<_, _>) : aws.BedrockagentKnowledgeBase.BedrockagentKnowledgeBase =
            Unchecked.defaultof<aws.BedrockagentKnowledgeBase.BedrockagentKnowledgeBase>
