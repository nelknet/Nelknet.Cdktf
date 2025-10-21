namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmDocumentState<'Content, 'DocumentType, 'Name> = { assignments: ResizeArray<aws.SsmDocument.SsmDocumentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_document">aws_ssm_document</a>.
    /// </summary>
    type SsmDocumentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmDocumentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmDocumentState<Missing, Missing, Missing>)

        member _.Zero(()) : SsmDocumentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmDocumentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_document#content-1">SsmDocument#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: SsmDocumentState<Missing, 'DocumentType, 'Name>, value: string) : SsmDocumentState<Present, 'DocumentType, 'Name> =
            state.assignments.Add(fun config -> config.Content <- value)
            ({ assignments = state.assignments } : SsmDocumentState<Present, 'DocumentType, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_document#document_type-1">SsmDocument#document_type</a>.
        /// </summary>
        [<CustomOperation "document_type">]
        member _.DocumentType(state: SsmDocumentState<'Content, Missing, 'Name>, value: string) : SsmDocumentState<'Content, Present, 'Name> =
            state.assignments.Add(fun config -> config.DocumentType <- value)
            ({ assignments = state.assignments } : SsmDocumentState<'Content, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_document#name-1">SsmDocument#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsmDocumentState<'Content, 'DocumentType, Missing>, value: string) : SsmDocumentState<'Content, 'DocumentType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SsmDocumentState<'Content, 'DocumentType, Present>)

        /// <summary>
        /// attachments_source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_document#attachments_source-1">SsmDocument#attachments_source</a> Accepts: aws.IResolvable | aws.SsmDocument.SsmDocumentAttachmentsSource[]
        /// </summary>
        [<CustomOperation "attachments_source">]
        member _.AttachmentsSource(state: SsmDocumentState<'Content, 'DocumentType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SsmDocumentState<'Content, 'DocumentType, 'Name> =
            state.assignments.Add(fun config -> config.AttachmentsSource <- value)
            state : SsmDocumentState<'Content, 'DocumentType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_document#document_format-1">SsmDocument#document_format</a>.
        /// </summary>
        [<CustomOperation "document_format">]
        member _.DocumentFormat(state: SsmDocumentState<'Content, 'DocumentType, 'Name>, value: string) : SsmDocumentState<'Content, 'DocumentType, 'Name> =
            state.assignments.Add(fun config -> config.DocumentFormat <- value)
            state : SsmDocumentState<'Content, 'DocumentType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_document#id-1">SsmDocument#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmDocumentState<'Content, 'DocumentType, 'Name>, value: string) : SsmDocumentState<'Content, 'DocumentType, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmDocumentState<'Content, 'DocumentType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_document#permissions-1">SsmDocument#permissions</a>.
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: SsmDocumentState<'Content, 'DocumentType, 'Name>, value: seq<string * string>) : SsmDocumentState<'Content, 'DocumentType, 'Name> =
            state.assignments.Add(fun config -> config.Permissions <- dict value)
            state : SsmDocumentState<'Content, 'DocumentType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_document#tags-1">SsmDocument#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SsmDocumentState<'Content, 'DocumentType, 'Name>, value: seq<string * string>) : SsmDocumentState<'Content, 'DocumentType, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SsmDocumentState<'Content, 'DocumentType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_document#tags_all-1">SsmDocument#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SsmDocumentState<'Content, 'DocumentType, 'Name>, value: seq<string * string>) : SsmDocumentState<'Content, 'DocumentType, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SsmDocumentState<'Content, 'DocumentType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_document#target_type-1">SsmDocument#target_type</a>.
        /// </summary>
        [<CustomOperation "target_type">]
        member _.TargetType(state: SsmDocumentState<'Content, 'DocumentType, 'Name>, value: string) : SsmDocumentState<'Content, 'DocumentType, 'Name> =
            state.assignments.Add(fun config -> config.TargetType <- value)
            state : SsmDocumentState<'Content, 'DocumentType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_document#version_name-1">SsmDocument#version_name</a>.
        /// </summary>
        [<CustomOperation "version_name">]
        member _.VersionName(state: SsmDocumentState<'Content, 'DocumentType, 'Name>, value: string) : SsmDocumentState<'Content, 'DocumentType, 'Name> =
            state.assignments.Add(fun config -> config.VersionName <- value)
            state : SsmDocumentState<'Content, 'DocumentType, 'Name>

        member _.Run(state: SsmDocumentState<Present, Present, Present>) : aws.SsmDocument.SsmDocument =
            let config = aws.SsmDocument.SsmDocumentConfig()
            for setter in state.assignments do
                setter config
            aws.SsmDocument.SsmDocument(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmDocument: missing required arguments. Must call: content, document_type, name.", 9999, IsError = true)>]
        member _.Run(_: SsmDocumentState<_, _, _>) : aws.SsmDocument.SsmDocument =
            Unchecked.defaultof<aws.SsmDocument.SsmDocument>
