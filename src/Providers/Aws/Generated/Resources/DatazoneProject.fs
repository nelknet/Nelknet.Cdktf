namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatazoneProjectState<'DomainIdentifier, 'Name> = { assignments: ResizeArray<aws.DatazoneProject.DatazoneProjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_project">aws_datazone_project</a>.
    /// </summary>
    type DatazoneProjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatazoneProjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneProjectState<Missing, Missing>)

        member _.Zero(()) : DatazoneProjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneProjectState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_project#domain_identifier-1">DatazoneProject#domain_identifier</a>.
        /// </summary>
        [<CustomOperation "domain_identifier">]
        member _.DomainIdentifier(state: DatazoneProjectState<Missing, 'Name>, value: string) : DatazoneProjectState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DomainIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneProjectState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_project#name-1">DatazoneProject#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatazoneProjectState<'DomainIdentifier, Missing>, value: string) : DatazoneProjectState<'DomainIdentifier, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatazoneProjectState<'DomainIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_project#description-1">DatazoneProject#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DatazoneProjectState<'DomainIdentifier, 'Name>, value: string) : DatazoneProjectState<'DomainIdentifier, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DatazoneProjectState<'DomainIdentifier, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_project#glossary_terms-1">DatazoneProject#glossary_terms</a>.
        /// </summary>
        [<CustomOperation "glossary_terms">]
        member _.GlossaryTerms(state: DatazoneProjectState<'DomainIdentifier, 'Name>, value: seq<string>) : DatazoneProjectState<'DomainIdentifier, 'Name> =
            state.assignments.Add(fun config -> config.GlossaryTerms <- (value |> Seq.toArray))
            state : DatazoneProjectState<'DomainIdentifier, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_project#skip_deletion_check-1">DatazoneProject#skip_deletion_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_deletion_check">]
        member _.SkipDeletionCheck(state: DatazoneProjectState<'DomainIdentifier, 'Name>, value: bool) : DatazoneProjectState<'DomainIdentifier, 'Name> =
            state.assignments.Add(fun config -> config.SkipDeletionCheck <- value)
            state : DatazoneProjectState<'DomainIdentifier, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_project#skip_deletion_check-1">DatazoneProject#skip_deletion_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_deletion_check">]
        member _.SkipDeletionCheck(state: DatazoneProjectState<'DomainIdentifier, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DatazoneProjectState<'DomainIdentifier, 'Name> =
            state.assignments.Add(fun config -> config.SkipDeletionCheck <- value)
            state : DatazoneProjectState<'DomainIdentifier, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_project#timeouts-1">DatazoneProject#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatazoneProjectState<'DomainIdentifier, 'Name>, value: aws.DatazoneProject.DatazoneProjectTimeouts) : DatazoneProjectState<'DomainIdentifier, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatazoneProjectState<'DomainIdentifier, 'Name>

        member _.Run(state: DatazoneProjectState<Present, Present>) : aws.DatazoneProject.DatazoneProject =
            let config = aws.DatazoneProject.DatazoneProjectConfig()
            for setter in state.assignments do
                setter config
            aws.DatazoneProject.DatazoneProject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datazoneProject: missing required arguments. Must call: domain_identifier, name.", 9999, IsError = true)>]
        member _.Run(_: DatazoneProjectState<_, _>) : aws.DatazoneProject.DatazoneProject =
            Unchecked.defaultof<aws.DatazoneProject.DatazoneProject>
