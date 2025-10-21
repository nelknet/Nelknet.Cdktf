namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightTemplateAliasState<'AliasName, 'TemplateId, 'TemplateVersionNumber> = { assignments: ResizeArray<aws.QuicksightTemplateAlias.QuicksightTemplateAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template_alias">aws_quicksight_template_alias</a>.
    /// </summary>
    type QuicksightTemplateAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightTemplateAliasState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightTemplateAliasState<Missing, Missing, Missing>)

        member _.Zero(()) : QuicksightTemplateAliasState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightTemplateAliasState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template_alias#alias_name-1">QuicksightTemplateAlias#alias_name</a>.
        /// </summary>
        [<CustomOperation "alias_name">]
        member _.AliasName(state: QuicksightTemplateAliasState<Missing, 'TemplateId, 'TemplateVersionNumber>, value: string) : QuicksightTemplateAliasState<Present, 'TemplateId, 'TemplateVersionNumber> =
            state.assignments.Add(fun config -> config.AliasName <- value)
            ({ assignments = state.assignments } : QuicksightTemplateAliasState<Present, 'TemplateId, 'TemplateVersionNumber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template_alias#template_id-1">QuicksightTemplateAlias#template_id</a>.
        /// </summary>
        [<CustomOperation "template_id">]
        member _.TemplateId(state: QuicksightTemplateAliasState<'AliasName, Missing, 'TemplateVersionNumber>, value: string) : QuicksightTemplateAliasState<'AliasName, Present, 'TemplateVersionNumber> =
            state.assignments.Add(fun config -> config.TemplateId <- value)
            ({ assignments = state.assignments } : QuicksightTemplateAliasState<'AliasName, Present, 'TemplateVersionNumber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template_alias#template_version_number-1">QuicksightTemplateAlias#template_version_number</a>.
        /// </summary>
        [<CustomOperation "template_version_number">]
        member _.TemplateVersionNumber(state: QuicksightTemplateAliasState<'AliasName, 'TemplateId, Missing>, value: double) : QuicksightTemplateAliasState<'AliasName, 'TemplateId, Present> =
            state.assignments.Add(fun config -> config.TemplateVersionNumber <- value)
            ({ assignments = state.assignments } : QuicksightTemplateAliasState<'AliasName, 'TemplateId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template_alias#aws_account_id-1">QuicksightTemplateAlias#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightTemplateAliasState<'AliasName, 'TemplateId, 'TemplateVersionNumber>, value: string) : QuicksightTemplateAliasState<'AliasName, 'TemplateId, 'TemplateVersionNumber> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightTemplateAliasState<'AliasName, 'TemplateId, 'TemplateVersionNumber>

        member _.Run(state: QuicksightTemplateAliasState<Present, Present, Present>) : aws.QuicksightTemplateAlias.QuicksightTemplateAlias =
            let config = aws.QuicksightTemplateAlias.QuicksightTemplateAliasConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightTemplateAlias.QuicksightTemplateAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightTemplateAlias: missing required arguments. Must call: alias_name, template_id, template_version_number.", 9999, IsError = true)>]
        member _.Run(_: QuicksightTemplateAliasState<_, _, _>) : aws.QuicksightTemplateAlias.QuicksightTemplateAlias =
            Unchecked.defaultof<aws.QuicksightTemplateAlias.QuicksightTemplateAlias>
