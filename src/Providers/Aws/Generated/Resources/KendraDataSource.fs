namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KendraDataSourceState<'IndexId, 'Name, 'Type> = { assignments: ResizeArray<aws.KendraDataSource.KendraDataSourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source">aws_kendra_data_source</a>.
    /// </summary>
    type KendraDataSourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : KendraDataSourceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KendraDataSourceState<Missing, Missing, Missing>)

        member _.Zero(()) : KendraDataSourceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KendraDataSourceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#index_id-1">KendraDataSource#index_id</a>.
        /// </summary>
        [<CustomOperation "index_id">]
        member _.IndexId(state: KendraDataSourceState<Missing, 'Name, 'Type>, value: string) : KendraDataSourceState<Present, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.IndexId <- value)
            ({ assignments = state.assignments } : KendraDataSourceState<Present, 'Name, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#name-1">KendraDataSource#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KendraDataSourceState<'IndexId, Missing, 'Type>, value: string) : KendraDataSourceState<'IndexId, Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KendraDataSourceState<'IndexId, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#type-1">KendraDataSource#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: KendraDataSourceState<'IndexId, 'Name, Missing>, value: string) : KendraDataSourceState<'IndexId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : KendraDataSourceState<'IndexId, 'Name, Present>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#configuration-1">KendraDataSource#configuration</a>
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: KendraDataSourceState<'IndexId, 'Name, 'Type>, value: aws.KendraDataSource.KendraDataSourceConfiguration) : KendraDataSourceState<'IndexId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : KendraDataSourceState<'IndexId, 'Name, 'Type>

        /// <summary>
        /// custom_document_enrichment_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#custom_document_enrichment_configuration-1">KendraDataSource#custom_document_enrichment_configuration</a>
        /// </summary>
        [<CustomOperation "custom_document_enrichment_configuration">]
        member _.CustomDocumentEnrichmentConfiguration(state: KendraDataSourceState<'IndexId, 'Name, 'Type>, value: aws.KendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfiguration) : KendraDataSourceState<'IndexId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.CustomDocumentEnrichmentConfiguration <- value)
            state : KendraDataSourceState<'IndexId, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#description-1">KendraDataSource#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: KendraDataSourceState<'IndexId, 'Name, 'Type>, value: string) : KendraDataSourceState<'IndexId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : KendraDataSourceState<'IndexId, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#id-1">KendraDataSource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KendraDataSourceState<'IndexId, 'Name, 'Type>, value: string) : KendraDataSourceState<'IndexId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KendraDataSourceState<'IndexId, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#language_code-1">KendraDataSource#language_code</a>.
        /// </summary>
        [<CustomOperation "language_code">]
        member _.LanguageCode(state: KendraDataSourceState<'IndexId, 'Name, 'Type>, value: string) : KendraDataSourceState<'IndexId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.LanguageCode <- value)
            state : KendraDataSourceState<'IndexId, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#role_arn-1">KendraDataSource#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: KendraDataSourceState<'IndexId, 'Name, 'Type>, value: string) : KendraDataSourceState<'IndexId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : KendraDataSourceState<'IndexId, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#schedule-1">KendraDataSource#schedule</a>.
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: KendraDataSourceState<'IndexId, 'Name, 'Type>, value: string) : KendraDataSourceState<'IndexId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            state : KendraDataSourceState<'IndexId, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#tags-1">KendraDataSource#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KendraDataSourceState<'IndexId, 'Name, 'Type>, value: seq<string * string>) : KendraDataSourceState<'IndexId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KendraDataSourceState<'IndexId, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#tags_all-1">KendraDataSource#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KendraDataSourceState<'IndexId, 'Name, 'Type>, value: seq<string * string>) : KendraDataSourceState<'IndexId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KendraDataSourceState<'IndexId, 'Name, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#timeouts-1">KendraDataSource#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KendraDataSourceState<'IndexId, 'Name, 'Type>, value: aws.KendraDataSource.KendraDataSourceTimeouts) : KendraDataSourceState<'IndexId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KendraDataSourceState<'IndexId, 'Name, 'Type>

        member _.Run(state: KendraDataSourceState<Present, Present, Present>) : aws.KendraDataSource.KendraDataSource =
            let config = aws.KendraDataSource.KendraDataSourceConfig()
            for setter in state.assignments do
                setter config
            aws.KendraDataSource.KendraDataSource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kendraDataSource: missing required arguments. Must call: index_id, name, type.", 9999, IsError = true)>]
        member _.Run(_: KendraDataSourceState<_, _, _>) : aws.KendraDataSource.KendraDataSource =
            Unchecked.defaultof<aws.KendraDataSource.KendraDataSource>
