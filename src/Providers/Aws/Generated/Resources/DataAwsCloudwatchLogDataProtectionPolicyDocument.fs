namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, 'Statement> = { assignments: ResizeArray<aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_data_protection_policy_document">aws_cloudwatch_log_data_protection_policy_document</a>.
    /// </summary>
    type DataAwsCloudwatchLogDataProtectionPolicyDocumentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<Missing, Missing>)

        member _.Zero(()) : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#name-1">DataAwsCloudwatchLogDataProtectionPolicyDocument#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCloudwatchLogDataProtectionPolicyDocumentState<Missing, 'Statement>, value: string) : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<Present, 'Statement> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<Present, 'Statement>)

        /// <summary>
        /// statement block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#statement-1">DataAwsCloudwatchLogDataProtectionPolicyDocument#statement</a> Accepts: aws.IResolvable | aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatement[]
        /// </summary>
        [<CustomOperation "statement">]
        member _.Statement(state: DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, Missing>, value: HashiCorp.Cdktf.IResolvable) : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, Present> =
            state.assignments.Add(fun config -> config.Statement <- value)
            ({ assignments = state.assignments } : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, Present>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#configuration-1">DataAwsCloudwatchLogDataProtectionPolicyDocument#configuration</a>
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, 'Statement>, value: aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentConfiguration) : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, 'Statement> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, 'Statement>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#description-1">DataAwsCloudwatchLogDataProtectionPolicyDocument#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, 'Statement>, value: string) : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, 'Statement> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, 'Statement>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#id-1">DataAwsCloudwatchLogDataProtectionPolicyDocument#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, 'Statement>, value: string) : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, 'Statement> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, 'Statement>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#version-1">DataAwsCloudwatchLogDataProtectionPolicyDocument#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, 'Statement>, value: string) : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, 'Statement> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAwsCloudwatchLogDataProtectionPolicyDocumentState<'Name, 'Statement>

        member _.Run(state: DataAwsCloudwatchLogDataProtectionPolicyDocumentState<Present, Present>) : aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocument =
            let config = aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocument(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCloudwatchLogDataProtectionPolicyDocument: missing required arguments. Must call: name, statement.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCloudwatchLogDataProtectionPolicyDocumentState<_, _>) : aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocument =
            Unchecked.defaultof<aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocument>
