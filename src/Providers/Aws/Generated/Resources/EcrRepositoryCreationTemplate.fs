namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix> = { assignments: ResizeArray<aws.EcrRepositoryCreationTemplate.EcrRepositoryCreationTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_creation_template">aws_ecr_repository_creation_template</a>.
    /// </summary>
    type EcrRepositoryCreationTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcrRepositoryCreationTemplateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcrRepositoryCreationTemplateState<Missing, Missing>)

        member _.Zero(()) : EcrRepositoryCreationTemplateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcrRepositoryCreationTemplateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_creation_template#applied_for-1">EcrRepositoryCreationTemplate#applied_for</a>.
        /// </summary>
        [<CustomOperation "applied_for">]
        member _.AppliedFor(state: EcrRepositoryCreationTemplateState<Missing, 'Prefix>, value: seq<string>) : EcrRepositoryCreationTemplateState<Present, 'Prefix> =
            state.assignments.Add(fun config -> config.AppliedFor <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : EcrRepositoryCreationTemplateState<Present, 'Prefix>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_creation_template#prefix-1">EcrRepositoryCreationTemplate#prefix</a>.
        /// </summary>
        [<CustomOperation "prefix">]
        member _.Prefix(state: EcrRepositoryCreationTemplateState<'AppliedFor, Missing>, value: string) : EcrRepositoryCreationTemplateState<'AppliedFor, Present> =
            state.assignments.Add(fun config -> config.Prefix <- value)
            ({ assignments = state.assignments } : EcrRepositoryCreationTemplateState<'AppliedFor, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_creation_template#custom_role_arn-1">EcrRepositoryCreationTemplate#custom_role_arn</a>.
        /// </summary>
        [<CustomOperation "custom_role_arn">]
        member _.CustomRoleArn(state: EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>, value: string) : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix> =
            state.assignments.Add(fun config -> config.CustomRoleArn <- value)
            state : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_creation_template#description-1">EcrRepositoryCreationTemplate#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>, value: string) : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>

        /// <summary>
        /// encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_creation_template#encryption_configuration-1">EcrRepositoryCreationTemplate#encryption_configuration</a> Accepts: aws.IResolvable | aws.EcrRepositoryCreationTemplate.EcrRepositoryCreationTemplateEncryptionConfiguration[]
        /// </summary>
        [<CustomOperation "encryption_configuration">]
        member _.EncryptionConfiguration(state: EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>, value: HashiCorp.Cdktf.IResolvable) : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix> =
            state.assignments.Add(fun config -> config.EncryptionConfiguration <- value)
            state : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_creation_template#id-1">EcrRepositoryCreationTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>, value: string) : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_creation_template#image_tag_mutability-1">EcrRepositoryCreationTemplate#image_tag_mutability</a>.
        /// </summary>
        [<CustomOperation "image_tag_mutability">]
        member _.ImageTagMutability(state: EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>, value: string) : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix> =
            state.assignments.Add(fun config -> config.ImageTagMutability <- value)
            state : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_creation_template#lifecycle_policy-1">EcrRepositoryCreationTemplate#lifecycle_policy</a>.
        /// </summary>
        [<CustomOperation "lifecycle_policy">]
        member _.LifecyclePolicy(state: EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>, value: string) : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix> =
            state.assignments.Add(fun config -> config.LifecyclePolicy <- value)
            state : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_creation_template#repository_policy-1">EcrRepositoryCreationTemplate#repository_policy</a>.
        /// </summary>
        [<CustomOperation "repository_policy">]
        member _.RepositoryPolicy(state: EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>, value: string) : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix> =
            state.assignments.Add(fun config -> config.RepositoryPolicy <- value)
            state : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_creation_template#resource_tags-1">EcrRepositoryCreationTemplate#resource_tags</a>.
        /// </summary>
        [<CustomOperation "resource_tags">]
        member _.ResourceTags(state: EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>, value: seq<string * string>) : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix> =
            state.assignments.Add(fun config -> config.ResourceTags <- dict value)
            state : EcrRepositoryCreationTemplateState<'AppliedFor, 'Prefix>

        member _.Run(state: EcrRepositoryCreationTemplateState<Present, Present>) : aws.EcrRepositoryCreationTemplate.EcrRepositoryCreationTemplate =
            let config = aws.EcrRepositoryCreationTemplate.EcrRepositoryCreationTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.EcrRepositoryCreationTemplate.EcrRepositoryCreationTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecrRepositoryCreationTemplate: missing required arguments. Must call: applied_for, prefix.", 9999, IsError = true)>]
        member _.Run(_: EcrRepositoryCreationTemplateState<_, _>) : aws.EcrRepositoryCreationTemplate.EcrRepositoryCreationTemplate =
            Unchecked.defaultof<aws.EcrRepositoryCreationTemplate.EcrRepositoryCreationTemplate>
