namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamPolicyAttachmentState<'Name, 'PolicyArn> = { assignments: ResizeArray<aws.IamPolicyAttachment.IamPolicyAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy_attachment">aws_iam_policy_attachment</a>.
    /// </summary>
    type IamPolicyAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamPolicyAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamPolicyAttachmentState<Missing, Missing>)

        member _.Zero(()) : IamPolicyAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamPolicyAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy_attachment#name-1">IamPolicyAttachment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IamPolicyAttachmentState<Missing, 'PolicyArn>, value: string) : IamPolicyAttachmentState<Present, 'PolicyArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IamPolicyAttachmentState<Present, 'PolicyArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy_attachment#policy_arn-1">IamPolicyAttachment#policy_arn</a>.
        /// </summary>
        [<CustomOperation "policy_arn">]
        member _.PolicyArn(state: IamPolicyAttachmentState<'Name, Missing>, value: string) : IamPolicyAttachmentState<'Name, Present> =
            state.assignments.Add(fun config -> config.PolicyArn <- value)
            ({ assignments = state.assignments } : IamPolicyAttachmentState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy_attachment#groups-1">IamPolicyAttachment#groups</a>.
        /// </summary>
        [<CustomOperation "groups">]
        member _.Groups(state: IamPolicyAttachmentState<'Name, 'PolicyArn>, value: seq<string>) : IamPolicyAttachmentState<'Name, 'PolicyArn> =
            state.assignments.Add(fun config -> config.Groups <- (value |> Seq.toArray))
            state : IamPolicyAttachmentState<'Name, 'PolicyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy_attachment#id-1">IamPolicyAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamPolicyAttachmentState<'Name, 'PolicyArn>, value: string) : IamPolicyAttachmentState<'Name, 'PolicyArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamPolicyAttachmentState<'Name, 'PolicyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy_attachment#roles-1">IamPolicyAttachment#roles</a>.
        /// </summary>
        [<CustomOperation "roles">]
        member _.Roles(state: IamPolicyAttachmentState<'Name, 'PolicyArn>, value: seq<string>) : IamPolicyAttachmentState<'Name, 'PolicyArn> =
            state.assignments.Add(fun config -> config.Roles <- (value |> Seq.toArray))
            state : IamPolicyAttachmentState<'Name, 'PolicyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy_attachment#users-1">IamPolicyAttachment#users</a>.
        /// </summary>
        [<CustomOperation "users">]
        member _.Users(state: IamPolicyAttachmentState<'Name, 'PolicyArn>, value: seq<string>) : IamPolicyAttachmentState<'Name, 'PolicyArn> =
            state.assignments.Add(fun config -> config.Users <- (value |> Seq.toArray))
            state : IamPolicyAttachmentState<'Name, 'PolicyArn>

        member _.Run(state: IamPolicyAttachmentState<Present, Present>) : aws.IamPolicyAttachment.IamPolicyAttachment =
            let config = aws.IamPolicyAttachment.IamPolicyAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.IamPolicyAttachment.IamPolicyAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamPolicyAttachment: missing required arguments. Must call: name, policy_arn.", 9999, IsError = true)>]
        member _.Run(_: IamPolicyAttachmentState<_, _>) : aws.IamPolicyAttachment.IamPolicyAttachment =
            Unchecked.defaultof<aws.IamPolicyAttachment.IamPolicyAttachment>
