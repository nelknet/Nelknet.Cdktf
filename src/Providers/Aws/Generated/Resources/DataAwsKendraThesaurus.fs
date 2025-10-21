namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKendraThesaurusState<'IndexId, 'ThesaurusId> = { assignments: ResizeArray<aws.DataAwsKendraThesaurus.DataAwsKendraThesaurusConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_thesaurus">aws_kendra_thesaurus</a>.
    /// </summary>
    type DataAwsKendraThesaurusBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKendraThesaurusState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsKendraThesaurusState<Missing, Missing>)

        member _.Zero(()) : DataAwsKendraThesaurusState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsKendraThesaurusState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_thesaurus#index_id-1">DataAwsKendraThesaurus#index_id</a>.
        /// </summary>
        [<CustomOperation "index_id">]
        member _.IndexId(state: DataAwsKendraThesaurusState<Missing, 'ThesaurusId>, value: string) : DataAwsKendraThesaurusState<Present, 'ThesaurusId> =
            state.assignments.Add(fun config -> config.IndexId <- value)
            ({ assignments = state.assignments } : DataAwsKendraThesaurusState<Present, 'ThesaurusId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_thesaurus#thesaurus_id-1">DataAwsKendraThesaurus#thesaurus_id</a>.
        /// </summary>
        [<CustomOperation "thesaurus_id">]
        member _.ThesaurusId(state: DataAwsKendraThesaurusState<'IndexId, Missing>, value: string) : DataAwsKendraThesaurusState<'IndexId, Present> =
            state.assignments.Add(fun config -> config.ThesaurusId <- value)
            ({ assignments = state.assignments } : DataAwsKendraThesaurusState<'IndexId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_thesaurus#id-1">DataAwsKendraThesaurus#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKendraThesaurusState<'IndexId, 'ThesaurusId>, value: string) : DataAwsKendraThesaurusState<'IndexId, 'ThesaurusId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKendraThesaurusState<'IndexId, 'ThesaurusId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_thesaurus#tags-1">DataAwsKendraThesaurus#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsKendraThesaurusState<'IndexId, 'ThesaurusId>, value: seq<string * string>) : DataAwsKendraThesaurusState<'IndexId, 'ThesaurusId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsKendraThesaurusState<'IndexId, 'ThesaurusId>

        member _.Run(state: DataAwsKendraThesaurusState<Present, Present>) : aws.DataAwsKendraThesaurus.DataAwsKendraThesaurus =
            let config = aws.DataAwsKendraThesaurus.DataAwsKendraThesaurusConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKendraThesaurus.DataAwsKendraThesaurus(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsKendraThesaurus: missing required arguments. Must call: index_id, thesaurus_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsKendraThesaurusState<_, _>) : aws.DataAwsKendraThesaurus.DataAwsKendraThesaurus =
            Unchecked.defaultof<aws.DataAwsKendraThesaurus.DataAwsKendraThesaurus>
