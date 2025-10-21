namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamPolicyDocumentState = { assignments: ResizeArray<aws.DataAwsIamPolicyDocument.DataAwsIamPolicyDocumentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document">aws_iam_policy_document</a>.
    /// </summary>
    type DataAwsIamPolicyDocumentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamPolicyDocumentState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsIamPolicyDocumentState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#id-1">DataAwsIamPolicyDocument#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamPolicyDocumentState, value: string) : DataAwsIamPolicyDocumentState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamPolicyDocumentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#override_json-1">DataAwsIamPolicyDocument#override_json</a>.
        /// </summary>
        [<CustomOperation "override_json">]
        member _.OverrideJson(state: DataAwsIamPolicyDocumentState, value: string) : DataAwsIamPolicyDocumentState =
            state.assignments.Add(fun config -> config.OverrideJson <- value)
            state : DataAwsIamPolicyDocumentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#override_policy_documents-1">DataAwsIamPolicyDocument#override_policy_documents</a>.
        /// </summary>
        [<CustomOperation "override_policy_documents">]
        member _.OverridePolicyDocuments(state: DataAwsIamPolicyDocumentState, value: seq<string>) : DataAwsIamPolicyDocumentState =
            state.assignments.Add(fun config -> config.OverridePolicyDocuments <- (value |> Seq.toArray))
            state : DataAwsIamPolicyDocumentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#policy_id-1">DataAwsIamPolicyDocument#policy_id</a>.
        /// </summary>
        [<CustomOperation "policy_id">]
        member _.PolicyId(state: DataAwsIamPolicyDocumentState, value: string) : DataAwsIamPolicyDocumentState =
            state.assignments.Add(fun config -> config.PolicyId <- value)
            state : DataAwsIamPolicyDocumentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#source_json-1">DataAwsIamPolicyDocument#source_json</a>.
        /// </summary>
        [<CustomOperation "source_json">]
        member _.SourceJson(state: DataAwsIamPolicyDocumentState, value: string) : DataAwsIamPolicyDocumentState =
            state.assignments.Add(fun config -> config.SourceJson <- value)
            state : DataAwsIamPolicyDocumentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#source_policy_documents-1">DataAwsIamPolicyDocument#source_policy_documents</a>.
        /// </summary>
        [<CustomOperation "source_policy_documents">]
        member _.SourcePolicyDocuments(state: DataAwsIamPolicyDocumentState, value: seq<string>) : DataAwsIamPolicyDocumentState =
            state.assignments.Add(fun config -> config.SourcePolicyDocuments <- (value |> Seq.toArray))
            state : DataAwsIamPolicyDocumentState

        /// <summary>
        /// statement block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#statement-1">DataAwsIamPolicyDocument#statement</a> Accepts: aws.IResolvable | aws.DataAwsIamPolicyDocument.DataAwsIamPolicyDocumentStatement[]
        /// </summary>
        [<CustomOperation "statement">]
        member _.Statement(state: DataAwsIamPolicyDocumentState, value: HashiCorp.Cdktf.IResolvable) : DataAwsIamPolicyDocumentState =
            state.assignments.Add(fun config -> config.Statement <- value)
            state : DataAwsIamPolicyDocumentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#version-1">DataAwsIamPolicyDocument#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAwsIamPolicyDocumentState, value: string) : DataAwsIamPolicyDocumentState =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAwsIamPolicyDocumentState

        member _.Run(state: DataAwsIamPolicyDocumentState) : aws.DataAwsIamPolicyDocument.DataAwsIamPolicyDocument =
            let config = aws.DataAwsIamPolicyDocument.DataAwsIamPolicyDocumentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamPolicyDocument.DataAwsIamPolicyDocument(StackContext.get (), logicalId, config)
