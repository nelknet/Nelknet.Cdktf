namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SesTemplateState<'Name> = { assignments: ResizeArray<aws.SesTemplate.SesTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_template">aws_ses_template</a>.
    /// </summary>
    type SesTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : SesTemplateState<Missing> =
            ({ assignments = ResizeArray() } : SesTemplateState<Missing>)

        member _.Zero(()) : SesTemplateState<Missing> =
            ({ assignments = ResizeArray() } : SesTemplateState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_template#name-1">SesTemplate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SesTemplateState<Missing>, value: string) : SesTemplateState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SesTemplateState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_template#html-1">SesTemplate#html</a>.
        /// </summary>
        [<CustomOperation "html">]
        member _.Html(state: SesTemplateState<'Name>, value: string) : SesTemplateState<'Name> =
            state.assignments.Add(fun config -> config.Html <- value)
            state : SesTemplateState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_template#id-1">SesTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SesTemplateState<'Name>, value: string) : SesTemplateState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SesTemplateState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_template#subject-1">SesTemplate#subject</a>.
        /// </summary>
        [<CustomOperation "subject">]
        member _.Subject(state: SesTemplateState<'Name>, value: string) : SesTemplateState<'Name> =
            state.assignments.Add(fun config -> config.Subject <- value)
            state : SesTemplateState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_template#text-1">SesTemplate#text</a>.
        /// </summary>
        [<CustomOperation "text">]
        member _.Text(state: SesTemplateState<'Name>, value: string) : SesTemplateState<'Name> =
            state.assignments.Add(fun config -> config.Text <- value)
            state : SesTemplateState<'Name>

        member _.Run(state: SesTemplateState<Present>) : aws.SesTemplate.SesTemplate =
            let config = aws.SesTemplate.SesTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.SesTemplate.SesTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesTemplate: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: SesTemplateState<_>) : aws.SesTemplate.SesTemplate =
            Unchecked.defaultof<aws.SesTemplate.SesTemplate>
