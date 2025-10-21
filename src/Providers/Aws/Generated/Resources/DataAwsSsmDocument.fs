namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsmDocumentState<'Name> = { assignments: ResizeArray<aws.DataAwsSsmDocument.DataAwsSsmDocumentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_document">aws_ssm_document</a>.
    /// </summary>
    type DataAwsSsmDocumentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsmDocumentState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmDocumentState<Missing>)

        member _.Zero(()) : DataAwsSsmDocumentState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmDocumentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_document#name-1">DataAwsSsmDocument#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsSsmDocumentState<Missing>, value: string) : DataAwsSsmDocumentState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsSsmDocumentState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_document#document_format-1">DataAwsSsmDocument#document_format</a>.
        /// </summary>
        [<CustomOperation "document_format">]
        member _.DocumentFormat(state: DataAwsSsmDocumentState<'Name>, value: string) : DataAwsSsmDocumentState<'Name> =
            state.assignments.Add(fun config -> config.DocumentFormat <- value)
            state : DataAwsSsmDocumentState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_document#document_version-1">DataAwsSsmDocument#document_version</a>.
        /// </summary>
        [<CustomOperation "document_version">]
        member _.DocumentVersion(state: DataAwsSsmDocumentState<'Name>, value: string) : DataAwsSsmDocumentState<'Name> =
            state.assignments.Add(fun config -> config.DocumentVersion <- value)
            state : DataAwsSsmDocumentState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_document#id-1">DataAwsSsmDocument#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSsmDocumentState<'Name>, value: string) : DataAwsSsmDocumentState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSsmDocumentState<'Name>

        member _.Run(state: DataAwsSsmDocumentState<Present>) : aws.DataAwsSsmDocument.DataAwsSsmDocument =
            let config = aws.DataAwsSsmDocument.DataAwsSsmDocumentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsmDocument.DataAwsSsmDocument(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSsmDocument: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSsmDocumentState<_>) : aws.DataAwsSsmDocument.DataAwsSsmDocument =
            Unchecked.defaultof<aws.DataAwsSsmDocument.DataAwsSsmDocument>
