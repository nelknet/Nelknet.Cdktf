namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path> = { assignments: ResizeArray<aws.KendraThesaurus.KendraThesaurusConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_thesaurus">aws_kendra_thesaurus</a>.
    /// </summary>
    type KendraThesaurusBuilder(logicalId: string) =
        member _.Yield(_: unit) : KendraThesaurusState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KendraThesaurusState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KendraThesaurusState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KendraThesaurusState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_thesaurus#index_id-1">KendraThesaurus#index_id</a>.
        /// </summary>
        [<CustomOperation "index_id">]
        member _.IndexId(state: KendraThesaurusState<Missing, 'Name, 'RoleArn, 'SourceS3Path>, value: string) : KendraThesaurusState<Present, 'Name, 'RoleArn, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.IndexId <- value)
            ({ assignments = state.assignments } : KendraThesaurusState<Present, 'Name, 'RoleArn, 'SourceS3Path>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_thesaurus#name-1">KendraThesaurus#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KendraThesaurusState<'IndexId, Missing, 'RoleArn, 'SourceS3Path>, value: string) : KendraThesaurusState<'IndexId, Present, 'RoleArn, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KendraThesaurusState<'IndexId, Present, 'RoleArn, 'SourceS3Path>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_thesaurus#role_arn-1">KendraThesaurus#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: KendraThesaurusState<'IndexId, 'Name, Missing, 'SourceS3Path>, value: string) : KendraThesaurusState<'IndexId, 'Name, Present, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : KendraThesaurusState<'IndexId, 'Name, Present, 'SourceS3Path>)

        /// <summary>
        /// source_s3_path block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_thesaurus#source_s3_path-1">KendraThesaurus#source_s3_path</a>
        /// </summary>
        [<CustomOperation "source_s3_path">]
        member _.SourceS3Path(state: KendraThesaurusState<'IndexId, 'Name, 'RoleArn, Missing>, value: aws.KendraThesaurus.KendraThesaurusSourceS3Path) : KendraThesaurusState<'IndexId, 'Name, 'RoleArn, Present> =
            state.assignments.Add(fun config -> config.SourceS3Path <- value)
            ({ assignments = state.assignments } : KendraThesaurusState<'IndexId, 'Name, 'RoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_thesaurus#description-1">KendraThesaurus#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>, value: string) : KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_thesaurus#id-1">KendraThesaurus#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>, value: string) : KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_thesaurus#tags-1">KendraThesaurus#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>, value: seq<string * string>) : KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_thesaurus#tags_all-1">KendraThesaurus#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>, value: seq<string * string>) : KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_thesaurus#timeouts-1">KendraThesaurus#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>, value: aws.KendraThesaurus.KendraThesaurusTimeouts) : KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KendraThesaurusState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>

        member _.Run(state: KendraThesaurusState<Present, Present, Present, Present>) : aws.KendraThesaurus.KendraThesaurus =
            let config = aws.KendraThesaurus.KendraThesaurusConfig()
            for setter in state.assignments do
                setter config
            aws.KendraThesaurus.KendraThesaurus(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kendraThesaurus: missing required arguments. Must call: index_id, name, role_arn, source_s3_path.", 9999, IsError = true)>]
        member _.Run(_: KendraThesaurusState<_, _, _, _>) : aws.KendraThesaurus.KendraThesaurus =
            Unchecked.defaultof<aws.KendraThesaurus.KendraThesaurus>
