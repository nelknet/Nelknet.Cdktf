namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBedrockagentAgentVersionsState<'AgentId> = { assignments: ResizeArray<aws.DataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrockagent_agent_versions">aws_bedrockagent_agent_versions</a>.
    /// </summary>
    type DataAwsBedrockagentAgentVersionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBedrockagentAgentVersionsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBedrockagentAgentVersionsState<Missing>)

        member _.Zero(()) : DataAwsBedrockagentAgentVersionsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBedrockagentAgentVersionsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrockagent_agent_versions#agent_id-1">DataAwsBedrockagentAgentVersions#agent_id</a>.
        /// </summary>
        [<CustomOperation "agent_id">]
        member _.AgentId(state: DataAwsBedrockagentAgentVersionsState<Missing>, value: string) : DataAwsBedrockagentAgentVersionsState<Present> =
            state.assignments.Add(fun config -> config.AgentId <- value)
            ({ assignments = state.assignments } : DataAwsBedrockagentAgentVersionsState<Present>)

        /// <summary>
        /// agent_version_summaries block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrockagent_agent_versions#agent_version_summaries-1">DataAwsBedrockagentAgentVersions#agent_version_summaries</a> Accepts: aws.IResolvable | aws.DataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsAgentVersionSummaries[]
        /// </summary>
        [<CustomOperation "agent_version_summaries">]
        member _.AgentVersionSummaries(state: DataAwsBedrockagentAgentVersionsState<'AgentId>, value: HashiCorp.Cdktf.IResolvable) : DataAwsBedrockagentAgentVersionsState<'AgentId> =
            state.assignments.Add(fun config -> config.AgentVersionSummaries <- value)
            state : DataAwsBedrockagentAgentVersionsState<'AgentId>

        member _.Run(state: DataAwsBedrockagentAgentVersionsState<Present>) : aws.DataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersions =
            let config = aws.DataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersions(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsBedrockagentAgentVersions: missing required arguments. Must call: agent_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsBedrockagentAgentVersionsState<_>) : aws.DataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersions =
            Unchecked.defaultof<aws.DataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersions>
