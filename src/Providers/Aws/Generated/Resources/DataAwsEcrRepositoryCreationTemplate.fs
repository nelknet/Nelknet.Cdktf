namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEcrRepositoryCreationTemplateState<'Prefix> = { assignments: ResizeArray<aws.DataAwsEcrRepositoryCreationTemplate.DataAwsEcrRepositoryCreationTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_repository_creation_template">aws_ecr_repository_creation_template</a>.
    /// </summary>
    type DataAwsEcrRepositoryCreationTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEcrRepositoryCreationTemplateState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcrRepositoryCreationTemplateState<Missing>)

        member _.Zero(()) : DataAwsEcrRepositoryCreationTemplateState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcrRepositoryCreationTemplateState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_repository_creation_template#prefix-1">DataAwsEcrRepositoryCreationTemplate#prefix</a>.
        /// </summary>
        [<CustomOperation "prefix">]
        member _.Prefix(state: DataAwsEcrRepositoryCreationTemplateState<Missing>, value: string) : DataAwsEcrRepositoryCreationTemplateState<Present> =
            state.assignments.Add(fun config -> config.Prefix <- value)
            ({ assignments = state.assignments } : DataAwsEcrRepositoryCreationTemplateState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_repository_creation_template#id-1">DataAwsEcrRepositoryCreationTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEcrRepositoryCreationTemplateState<'Prefix>, value: string) : DataAwsEcrRepositoryCreationTemplateState<'Prefix> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEcrRepositoryCreationTemplateState<'Prefix>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_repository_creation_template#resource_tags-1">DataAwsEcrRepositoryCreationTemplate#resource_tags</a>.
        /// </summary>
        [<CustomOperation "resource_tags">]
        member _.ResourceTags(state: DataAwsEcrRepositoryCreationTemplateState<'Prefix>, value: seq<string * string>) : DataAwsEcrRepositoryCreationTemplateState<'Prefix> =
            state.assignments.Add(fun config -> config.ResourceTags <- dict value)
            state : DataAwsEcrRepositoryCreationTemplateState<'Prefix>

        member _.Run(state: DataAwsEcrRepositoryCreationTemplateState<Present>) : aws.DataAwsEcrRepositoryCreationTemplate.DataAwsEcrRepositoryCreationTemplate =
            let config = aws.DataAwsEcrRepositoryCreationTemplate.DataAwsEcrRepositoryCreationTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEcrRepositoryCreationTemplate.DataAwsEcrRepositoryCreationTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEcrRepositoryCreationTemplate: missing required arguments. Must call: prefix.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEcrRepositoryCreationTemplateState<_>) : aws.DataAwsEcrRepositoryCreationTemplate.DataAwsEcrRepositoryCreationTemplate =
            Unchecked.defaultof<aws.DataAwsEcrRepositoryCreationTemplate.DataAwsEcrRepositoryCreationTemplate>
