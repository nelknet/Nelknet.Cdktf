namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path> = { assignments: ResizeArray<aws.KendraFaq.KendraFaqConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_faq">aws_kendra_faq</a>.
    /// </summary>
    type KendraFaqBuilder(logicalId: string) =
        member _.Yield(_: unit) : KendraFaqState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KendraFaqState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KendraFaqState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KendraFaqState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_faq#index_id-1">KendraFaq#index_id</a>.
        /// </summary>
        [<CustomOperation "index_id">]
        member _.IndexId(state: KendraFaqState<Missing, 'Name, 'RoleArn, 'S3Path>, value: string) : KendraFaqState<Present, 'Name, 'RoleArn, 'S3Path> =
            state.assignments.Add(fun config -> config.IndexId <- value)
            ({ assignments = state.assignments } : KendraFaqState<Present, 'Name, 'RoleArn, 'S3Path>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_faq#name-1">KendraFaq#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KendraFaqState<'IndexId, Missing, 'RoleArn, 'S3Path>, value: string) : KendraFaqState<'IndexId, Present, 'RoleArn, 'S3Path> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KendraFaqState<'IndexId, Present, 'RoleArn, 'S3Path>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_faq#role_arn-1">KendraFaq#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: KendraFaqState<'IndexId, 'Name, Missing, 'S3Path>, value: string) : KendraFaqState<'IndexId, 'Name, Present, 'S3Path> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : KendraFaqState<'IndexId, 'Name, Present, 'S3Path>)

        /// <summary>
        /// s3_path block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_faq#s3_path-1">KendraFaq#s3_path</a>
        /// </summary>
        [<CustomOperation "s3_path">]
        member _.S3Path(state: KendraFaqState<'IndexId, 'Name, 'RoleArn, Missing>, value: aws.KendraFaq.KendraFaqS3Path) : KendraFaqState<'IndexId, 'Name, 'RoleArn, Present> =
            state.assignments.Add(fun config -> config.S3Path <- value)
            ({ assignments = state.assignments } : KendraFaqState<'IndexId, 'Name, 'RoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_faq#description-1">KendraFaq#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path>, value: string) : KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_faq#file_format-1">KendraFaq#file_format</a>.
        /// </summary>
        [<CustomOperation "file_format">]
        member _.FileFormat(state: KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path>, value: string) : KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path> =
            state.assignments.Add(fun config -> config.FileFormat <- value)
            state : KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_faq#id-1">KendraFaq#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path>, value: string) : KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_faq#language_code-1">KendraFaq#language_code</a>.
        /// </summary>
        [<CustomOperation "language_code">]
        member _.LanguageCode(state: KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path>, value: string) : KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path> =
            state.assignments.Add(fun config -> config.LanguageCode <- value)
            state : KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_faq#tags-1">KendraFaq#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path>, value: seq<string * string>) : KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_faq#tags_all-1">KendraFaq#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path>, value: seq<string * string>) : KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_faq#timeouts-1">KendraFaq#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path>, value: aws.KendraFaq.KendraFaqTimeouts) : KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KendraFaqState<'IndexId, 'Name, 'RoleArn, 'S3Path>

        member _.Run(state: KendraFaqState<Present, Present, Present, Present>) : aws.KendraFaq.KendraFaq =
            let config = aws.KendraFaq.KendraFaqConfig()
            for setter in state.assignments do
                setter config
            aws.KendraFaq.KendraFaq(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kendraFaq: missing required arguments. Must call: index_id, name, role_arn, s3_path.", 9999, IsError = true)>]
        member _.Run(_: KendraFaqState<_, _, _, _>) : aws.KendraFaq.KendraFaq =
            Unchecked.defaultof<aws.KendraFaq.KendraFaq>
