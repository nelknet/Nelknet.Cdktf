namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription> = { assignments: ResizeArray<aws.QuicksightTemplate.QuicksightTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template">aws_quicksight_template</a>.
    /// </summary>
    type QuicksightTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightTemplateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightTemplateState<Missing, Missing, Missing>)

        member _.Zero(()) : QuicksightTemplateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightTemplateState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#name-1">QuicksightTemplate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: QuicksightTemplateState<Missing, 'TemplateId, 'VersionDescription>, value: string) : QuicksightTemplateState<Present, 'TemplateId, 'VersionDescription> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : QuicksightTemplateState<Present, 'TemplateId, 'VersionDescription>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#template_id-1">QuicksightTemplate#template_id</a>.
        /// </summary>
        [<CustomOperation "template_id">]
        member _.TemplateId(state: QuicksightTemplateState<'Name, Missing, 'VersionDescription>, value: string) : QuicksightTemplateState<'Name, Present, 'VersionDescription> =
            state.assignments.Add(fun config -> config.TemplateId <- value)
            ({ assignments = state.assignments } : QuicksightTemplateState<'Name, Present, 'VersionDescription>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#version_description-1">QuicksightTemplate#version_description</a>.
        /// </summary>
        [<CustomOperation "version_description">]
        member _.VersionDescription(state: QuicksightTemplateState<'Name, 'TemplateId, Missing>, value: string) : QuicksightTemplateState<'Name, 'TemplateId, Present> =
            state.assignments.Add(fun config -> config.VersionDescription <- value)
            ({ assignments = state.assignments } : QuicksightTemplateState<'Name, 'TemplateId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#aws_account_id-1">QuicksightTemplate#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>, value: string) : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>

        /// <summary>
        /// definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#definition-1">QuicksightTemplate#definition</a>
        /// </summary>
        [<CustomOperation "definition">]
        member _.Definition(state: QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>, value: obj) : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription> =
            state.assignments.Add(fun config -> config.Definition <- value)
            state : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#id-1">QuicksightTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>, value: string) : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>

        /// <summary>
        /// permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#permissions-1">QuicksightTemplate#permissions</a> Accepts: aws.IResolvable | aws.QuicksightTemplate.QuicksightTemplatePermissions[]
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>, value: HashiCorp.Cdktf.IResolvable) : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription> =
            state.assignments.Add(fun config -> config.Permissions <- value)
            state : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>

        /// <summary>
        /// source_entity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#source_entity-1">QuicksightTemplate#source_entity</a>
        /// </summary>
        [<CustomOperation "source_entity">]
        member _.SourceEntity(state: QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>, value: aws.QuicksightTemplate.QuicksightTemplateSourceEntity) : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription> =
            state.assignments.Add(fun config -> config.SourceEntity <- value)
            state : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#tags-1">QuicksightTemplate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>, value: seq<string * string>) : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#tags_all-1">QuicksightTemplate#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>, value: seq<string * string>) : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#timeouts-1">QuicksightTemplate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>, value: aws.QuicksightTemplate.QuicksightTemplateTimeouts) : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : QuicksightTemplateState<'Name, 'TemplateId, 'VersionDescription>

        member _.Run(state: QuicksightTemplateState<Present, Present, Present>) : aws.QuicksightTemplate.QuicksightTemplate =
            let config = aws.QuicksightTemplate.QuicksightTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightTemplate.QuicksightTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightTemplate: missing required arguments. Must call: name, template_id, version_description.", 9999, IsError = true)>]
        member _.Run(_: QuicksightTemplateState<_, _, _>) : aws.QuicksightTemplate.QuicksightTemplate =
            Unchecked.defaultof<aws.QuicksightTemplate.QuicksightTemplate>
