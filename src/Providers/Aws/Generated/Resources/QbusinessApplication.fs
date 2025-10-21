namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn> = { assignments: ResizeArray<aws.QbusinessApplication.QbusinessApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qbusiness_application">aws_qbusiness_application</a>.
    /// </summary>
    type QbusinessApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : QbusinessApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QbusinessApplicationState<Missing, Missing, Missing>)

        member _.Zero(()) : QbusinessApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QbusinessApplicationState<Missing, Missing, Missing>)

        /// <summary>
        /// The display name of the Amazon Q application. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qbusiness_application#display_name-1">QbusinessApplication#display_name</a>
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: QbusinessApplicationState<Missing, 'IamServiceRoleArn, 'IdentityCenterInstanceArn>, value: string) : QbusinessApplicationState<Present, 'IamServiceRoleArn, 'IdentityCenterInstanceArn> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : QbusinessApplicationState<Present, 'IamServiceRoleArn, 'IdentityCenterInstanceArn>)

        /// <summary>
        /// The Amazon Resource Name (ARN) of the IAM service role that provides permissions for the Amazon Q application. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qbusiness_application#iam_service_role_arn-1">QbusinessApplication#iam_service_role_arn</a>
        /// </summary>
        [<CustomOperation "iam_service_role_arn">]
        member _.IamServiceRoleArn(state: QbusinessApplicationState<'DisplayName, Missing, 'IdentityCenterInstanceArn>, value: string) : QbusinessApplicationState<'DisplayName, Present, 'IdentityCenterInstanceArn> =
            state.assignments.Add(fun config -> config.IamServiceRoleArn <- value)
            ({ assignments = state.assignments } : QbusinessApplicationState<'DisplayName, Present, 'IdentityCenterInstanceArn>)

        /// <summary>
        /// ARN of the IAM Identity Center instance you are either creating for—or connecting to—your Amazon Q Business application. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qbusiness_application#identity_center_instance_arn-1">QbusinessApplication#identity_center_instance_arn</a>
        /// </summary>
        [<CustomOperation "identity_center_instance_arn">]
        member _.IdentityCenterInstanceArn(state: QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, Missing>, value: string) : QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, Present> =
            state.assignments.Add(fun config -> config.IdentityCenterInstanceArn <- value)
            ({ assignments = state.assignments } : QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, Present>)

        /// <summary>
        /// attachments_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qbusiness_application#attachments_configuration-1">QbusinessApplication#attachments_configuration</a> Accepts: aws.IResolvable | aws.QbusinessApplication.QbusinessApplicationAttachmentsConfiguration[]
        /// </summary>
        [<CustomOperation "attachments_configuration">]
        member _.AttachmentsConfiguration(state: QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn>, value: HashiCorp.Cdktf.IResolvable) : QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn> =
            state.assignments.Add(fun config -> config.AttachmentsConfiguration <- value)
            state : QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn>

        /// <summary>
        /// A description of the Amazon Q application. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qbusiness_application#description-1">QbusinessApplication#description</a>
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn>, value: string) : QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn>

        /// <summary>
        /// encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qbusiness_application#encryption_configuration-1">QbusinessApplication#encryption_configuration</a> Accepts: aws.IResolvable | aws.QbusinessApplication.QbusinessApplicationEncryptionConfiguration[]
        /// </summary>
        [<CustomOperation "encryption_configuration">]
        member _.EncryptionConfiguration(state: QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn>, value: HashiCorp.Cdktf.IResolvable) : QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn> =
            state.assignments.Add(fun config -> config.EncryptionConfiguration <- value)
            state : QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qbusiness_application#tags-1">QbusinessApplication#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn>, value: seq<string * string>) : QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qbusiness_application#timeouts-1">QbusinessApplication#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn>, value: aws.QbusinessApplication.QbusinessApplicationTimeouts) : QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : QbusinessApplicationState<'DisplayName, 'IamServiceRoleArn, 'IdentityCenterInstanceArn>

        member _.Run(state: QbusinessApplicationState<Present, Present, Present>) : aws.QbusinessApplication.QbusinessApplication =
            let config = aws.QbusinessApplication.QbusinessApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.QbusinessApplication.QbusinessApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.qbusinessApplication: missing required arguments. Must call: display_name, iam_service_role_arn, identity_center_instance_arn.", 9999, IsError = true)>]
        member _.Run(_: QbusinessApplicationState<_, _, _>) : aws.QbusinessApplication.QbusinessApplication =
            Unchecked.defaultof<aws.QbusinessApplication.QbusinessApplication>
