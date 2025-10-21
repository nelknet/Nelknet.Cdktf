namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PinpointEmailTemplateState<'TemplateName> = { assignments: ResizeArray<aws.PinpointEmailTemplate.PinpointEmailTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template">aws_pinpoint_email_template</a>.
    /// </summary>
    type PinpointEmailTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : PinpointEmailTemplateState<Missing> =
            ({ assignments = ResizeArray() } : PinpointEmailTemplateState<Missing>)

        member _.Zero(()) : PinpointEmailTemplateState<Missing> =
            ({ assignments = ResizeArray() } : PinpointEmailTemplateState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#template_name-1">PinpointEmailTemplate#template_name</a>.
        /// </summary>
        [<CustomOperation "template_name">]
        member _.TemplateName(state: PinpointEmailTemplateState<Missing>, value: string) : PinpointEmailTemplateState<Present> =
            state.assignments.Add(fun config -> config.TemplateName <- value)
            ({ assignments = state.assignments } : PinpointEmailTemplateState<Present>)

        /// <summary>
        /// email_template block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#email_template-1">PinpointEmailTemplate#email_template</a> Accepts: aws.IResolvable | aws.PinpointEmailTemplate.PinpointEmailTemplateEmailTemplate[]
        /// </summary>
        [<CustomOperation "email_template">]
        member _.EmailTemplate(state: PinpointEmailTemplateState<'TemplateName>, value: HashiCorp.Cdktf.IResolvable) : PinpointEmailTemplateState<'TemplateName> =
            state.assignments.Add(fun config -> config.EmailTemplate <- value)
            state : PinpointEmailTemplateState<'TemplateName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#tags-1">PinpointEmailTemplate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PinpointEmailTemplateState<'TemplateName>, value: seq<string * string>) : PinpointEmailTemplateState<'TemplateName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PinpointEmailTemplateState<'TemplateName>

        member _.Run(state: PinpointEmailTemplateState<Present>) : aws.PinpointEmailTemplate.PinpointEmailTemplate =
            let config = aws.PinpointEmailTemplate.PinpointEmailTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.PinpointEmailTemplate.PinpointEmailTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pinpointEmailTemplate: missing required arguments. Must call: template_name.", 9999, IsError = true)>]
        member _.Run(_: PinpointEmailTemplateState<_>) : aws.PinpointEmailTemplate.PinpointEmailTemplate =
            Unchecked.defaultof<aws.PinpointEmailTemplate.PinpointEmailTemplate>
