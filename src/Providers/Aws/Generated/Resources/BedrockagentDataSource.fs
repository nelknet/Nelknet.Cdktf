namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BedrockagentDataSourceState<'KnowledgeBaseId, 'Name> = { assignments: ResizeArray<aws.BedrockagentDataSource.BedrockagentDataSourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source">aws_bedrockagent_data_source</a>.
    /// </summary>
    type BedrockagentDataSourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : BedrockagentDataSourceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockagentDataSourceState<Missing, Missing>)

        member _.Zero(()) : BedrockagentDataSourceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockagentDataSourceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#knowledge_base_id-1">BedrockagentDataSource#knowledge_base_id</a>.
        /// </summary>
        [<CustomOperation "knowledge_base_id">]
        member _.KnowledgeBaseId(state: BedrockagentDataSourceState<Missing, 'Name>, value: string) : BedrockagentDataSourceState<Present, 'Name> =
            state.assignments.Add(fun config -> config.KnowledgeBaseId <- value)
            ({ assignments = state.assignments } : BedrockagentDataSourceState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#name-1">BedrockagentDataSource#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BedrockagentDataSourceState<'KnowledgeBaseId, Missing>, value: string) : BedrockagentDataSourceState<'KnowledgeBaseId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BedrockagentDataSourceState<'KnowledgeBaseId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#data_deletion_policy-1">BedrockagentDataSource#data_deletion_policy</a>.
        /// </summary>
        [<CustomOperation "data_deletion_policy">]
        member _.DataDeletionPolicy(state: BedrockagentDataSourceState<'KnowledgeBaseId, 'Name>, value: string) : BedrockagentDataSourceState<'KnowledgeBaseId, 'Name> =
            state.assignments.Add(fun config -> config.DataDeletionPolicy <- value)
            state : BedrockagentDataSourceState<'KnowledgeBaseId, 'Name>

        /// <summary>
        /// data_source_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#data_source_configuration-1">BedrockagentDataSource#data_source_configuration</a> Accepts: aws.IResolvable | aws.BedrockagentDataSource.BedrockagentDataSourceDataSourceConfiguration[]
        /// </summary>
        [<CustomOperation "data_source_configuration">]
        member _.DataSourceConfiguration(state: BedrockagentDataSourceState<'KnowledgeBaseId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentDataSourceState<'KnowledgeBaseId, 'Name> =
            state.assignments.Add(fun config -> config.DataSourceConfiguration <- value)
            state : BedrockagentDataSourceState<'KnowledgeBaseId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#description-1">BedrockagentDataSource#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: BedrockagentDataSourceState<'KnowledgeBaseId, 'Name>, value: string) : BedrockagentDataSourceState<'KnowledgeBaseId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : BedrockagentDataSourceState<'KnowledgeBaseId, 'Name>

        /// <summary>
        /// server_side_encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#server_side_encryption_configuration-1">BedrockagentDataSource#server_side_encryption_configuration</a> Accepts: aws.IResolvable | aws.BedrockagentDataSource.BedrockagentDataSourceServerSideEncryptionConfiguration[]
        /// </summary>
        [<CustomOperation "server_side_encryption_configuration">]
        member _.ServerSideEncryptionConfiguration(state: BedrockagentDataSourceState<'KnowledgeBaseId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentDataSourceState<'KnowledgeBaseId, 'Name> =
            state.assignments.Add(fun config -> config.ServerSideEncryptionConfiguration <- value)
            state : BedrockagentDataSourceState<'KnowledgeBaseId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#timeouts-1">BedrockagentDataSource#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BedrockagentDataSourceState<'KnowledgeBaseId, 'Name>, value: aws.BedrockagentDataSource.BedrockagentDataSourceTimeouts) : BedrockagentDataSourceState<'KnowledgeBaseId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BedrockagentDataSourceState<'KnowledgeBaseId, 'Name>

        /// <summary>
        /// vector_ingestion_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#vector_ingestion_configuration-1">BedrockagentDataSource#vector_ingestion_configuration</a> Accepts: aws.IResolvable | aws.BedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfiguration[]
        /// </summary>
        [<CustomOperation "vector_ingestion_configuration">]
        member _.VectorIngestionConfiguration(state: BedrockagentDataSourceState<'KnowledgeBaseId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentDataSourceState<'KnowledgeBaseId, 'Name> =
            state.assignments.Add(fun config -> config.VectorIngestionConfiguration <- value)
            state : BedrockagentDataSourceState<'KnowledgeBaseId, 'Name>

        member _.Run(state: BedrockagentDataSourceState<Present, Present>) : aws.BedrockagentDataSource.BedrockagentDataSource =
            let config = aws.BedrockagentDataSource.BedrockagentDataSourceConfig()
            for setter in state.assignments do
                setter config
            aws.BedrockagentDataSource.BedrockagentDataSource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.bedrockagentDataSource: missing required arguments. Must call: knowledge_base_id, name.", 9999, IsError = true)>]
        member _.Run(_: BedrockagentDataSourceState<_, _>) : aws.BedrockagentDataSource.BedrockagentDataSource =
            Unchecked.defaultof<aws.BedrockagentDataSource.BedrockagentDataSource>
