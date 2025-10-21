namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEcrLifecyclePolicyDocumentState = { assignments: ResizeArray<aws.DataAwsEcrLifecyclePolicyDocument.DataAwsEcrLifecyclePolicyDocumentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_lifecycle_policy_document">aws_ecr_lifecycle_policy_document</a>.
    /// </summary>
    type DataAwsEcrLifecyclePolicyDocumentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEcrLifecyclePolicyDocumentState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEcrLifecyclePolicyDocumentState =
            { assignments = ResizeArray() }

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_lifecycle_policy_document#rule-1">DataAwsEcrLifecyclePolicyDocument#rule</a> Accepts: aws.IResolvable | aws.DataAwsEcrLifecyclePolicyDocument.DataAwsEcrLifecyclePolicyDocumentRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: DataAwsEcrLifecyclePolicyDocumentState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEcrLifecyclePolicyDocumentState =
            state.assignments.Add(fun config -> config.Rule <- value)
            state : DataAwsEcrLifecyclePolicyDocumentState

        member _.Run(state: DataAwsEcrLifecyclePolicyDocumentState) : aws.DataAwsEcrLifecyclePolicyDocument.DataAwsEcrLifecyclePolicyDocument =
            let config = aws.DataAwsEcrLifecyclePolicyDocument.DataAwsEcrLifecyclePolicyDocumentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEcrLifecyclePolicyDocument.DataAwsEcrLifecyclePolicyDocument(StackContext.get (), logicalId, config)
