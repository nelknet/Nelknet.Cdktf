namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlobalacceleratorCrossAccountAttachmentState<'Name> = { assignments: ResizeArray<aws.GlobalacceleratorCrossAccountAttachment.GlobalacceleratorCrossAccountAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_cross_account_attachment">aws_globalaccelerator_cross_account_attachment</a>.
    /// </summary>
    type GlobalacceleratorCrossAccountAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlobalacceleratorCrossAccountAttachmentState<Missing> =
            ({ assignments = ResizeArray() } : GlobalacceleratorCrossAccountAttachmentState<Missing>)

        member _.Zero(()) : GlobalacceleratorCrossAccountAttachmentState<Missing> =
            ({ assignments = ResizeArray() } : GlobalacceleratorCrossAccountAttachmentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_cross_account_attachment#name-1">GlobalacceleratorCrossAccountAttachment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlobalacceleratorCrossAccountAttachmentState<Missing>, value: string) : GlobalacceleratorCrossAccountAttachmentState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlobalacceleratorCrossAccountAttachmentState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_cross_account_attachment#principals-1">GlobalacceleratorCrossAccountAttachment#principals</a>.
        /// </summary>
        [<CustomOperation "principals">]
        member _.Principals(state: GlobalacceleratorCrossAccountAttachmentState<'Name>, value: seq<string>) : GlobalacceleratorCrossAccountAttachmentState<'Name> =
            state.assignments.Add(fun config -> config.Principals <- (value |> Seq.toArray))
            state : GlobalacceleratorCrossAccountAttachmentState<'Name>

        /// <summary>
        /// resource block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_cross_account_attachment#resource-1">GlobalacceleratorCrossAccountAttachment#resource</a> Accepts: aws.IResolvable | aws.GlobalacceleratorCrossAccountAttachment.GlobalacceleratorCrossAccountAttachmentResource[]
        /// </summary>
        [<CustomOperation "resource">]
        member _.Resource(state: GlobalacceleratorCrossAccountAttachmentState<'Name>, value: HashiCorp.Cdktf.IResolvable) : GlobalacceleratorCrossAccountAttachmentState<'Name> =
            state.assignments.Add(fun config -> config.Resource <- value)
            state : GlobalacceleratorCrossAccountAttachmentState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_cross_account_attachment#tags-1">GlobalacceleratorCrossAccountAttachment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlobalacceleratorCrossAccountAttachmentState<'Name>, value: seq<string * string>) : GlobalacceleratorCrossAccountAttachmentState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlobalacceleratorCrossAccountAttachmentState<'Name>

        member _.Run(state: GlobalacceleratorCrossAccountAttachmentState<Present>) : aws.GlobalacceleratorCrossAccountAttachment.GlobalacceleratorCrossAccountAttachment =
            let config = aws.GlobalacceleratorCrossAccountAttachment.GlobalacceleratorCrossAccountAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.GlobalacceleratorCrossAccountAttachment.GlobalacceleratorCrossAccountAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.globalacceleratorCrossAccountAttachment: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: GlobalacceleratorCrossAccountAttachmentState<_>) : aws.GlobalacceleratorCrossAccountAttachment.GlobalacceleratorCrossAccountAttachment =
            Unchecked.defaultof<aws.GlobalacceleratorCrossAccountAttachment.GlobalacceleratorCrossAccountAttachment>
