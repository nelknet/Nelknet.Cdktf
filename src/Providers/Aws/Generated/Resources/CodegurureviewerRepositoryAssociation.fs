namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodegurureviewerRepositoryAssociationState<'Repository> = { assignments: ResizeArray<aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association">aws_codegurureviewer_repository_association</a>.
    /// </summary>
    type CodegurureviewerRepositoryAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodegurureviewerRepositoryAssociationState<Missing> =
            ({ assignments = ResizeArray() } : CodegurureviewerRepositoryAssociationState<Missing>)

        member _.Zero(()) : CodegurureviewerRepositoryAssociationState<Missing> =
            ({ assignments = ResizeArray() } : CodegurureviewerRepositoryAssociationState<Missing>)

        /// <summary>
        /// repository block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#repository-1">CodegurureviewerRepositoryAssociation#repository</a>
        /// </summary>
        [<CustomOperation "repository">]
        member _.Repository(state: CodegurureviewerRepositoryAssociationState<Missing>, value: aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepository) : CodegurureviewerRepositoryAssociationState<Present> =
            state.assignments.Add(fun config -> config.Repository <- value)
            ({ assignments = state.assignments } : CodegurureviewerRepositoryAssociationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#id-1">CodegurureviewerRepositoryAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodegurureviewerRepositoryAssociationState<'Repository>, value: string) : CodegurureviewerRepositoryAssociationState<'Repository> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodegurureviewerRepositoryAssociationState<'Repository>

        /// <summary>
        /// kms_key_details block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#kms_key_details-1">CodegurureviewerRepositoryAssociation#kms_key_details</a>
        /// </summary>
        [<CustomOperation "kms_key_details">]
        member _.KmsKeyDetails(state: CodegurureviewerRepositoryAssociationState<'Repository>, value: aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationKmsKeyDetails) : CodegurureviewerRepositoryAssociationState<'Repository> =
            state.assignments.Add(fun config -> config.KmsKeyDetails <- value)
            state : CodegurureviewerRepositoryAssociationState<'Repository>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#tags-1">CodegurureviewerRepositoryAssociation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodegurureviewerRepositoryAssociationState<'Repository>, value: seq<string * string>) : CodegurureviewerRepositoryAssociationState<'Repository> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodegurureviewerRepositoryAssociationState<'Repository>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#tags_all-1">CodegurureviewerRepositoryAssociation#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CodegurureviewerRepositoryAssociationState<'Repository>, value: seq<string * string>) : CodegurureviewerRepositoryAssociationState<'Repository> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CodegurureviewerRepositoryAssociationState<'Repository>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#timeouts-1">CodegurureviewerRepositoryAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CodegurureviewerRepositoryAssociationState<'Repository>, value: aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationTimeouts) : CodegurureviewerRepositoryAssociationState<'Repository> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CodegurureviewerRepositoryAssociationState<'Repository>

        member _.Run(state: CodegurureviewerRepositoryAssociationState<Present>) : aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociation =
            let config = aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codegurureviewerRepositoryAssociation: missing required arguments. Must call: repository.", 9999, IsError = true)>]
        member _.Run(_: CodegurureviewerRepositoryAssociationState<_>) : aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociation =
            Unchecked.defaultof<aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociation>
