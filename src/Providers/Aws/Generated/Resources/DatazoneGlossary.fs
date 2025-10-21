namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatazoneGlossaryState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier> = { assignments: ResizeArray<aws.DatazoneGlossary.DatazoneGlossaryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary">aws_datazone_glossary</a>.
    /// </summary>
    type DatazoneGlossaryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatazoneGlossaryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneGlossaryState<Missing, Missing, Missing>)

        member _.Zero(()) : DatazoneGlossaryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneGlossaryState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary#domain_identifier-1">DatazoneGlossary#domain_identifier</a>.
        /// </summary>
        [<CustomOperation "domain_identifier">]
        member _.DomainIdentifier(state: DatazoneGlossaryState<Missing, 'Name, 'OwningProjectIdentifier>, value: string) : DatazoneGlossaryState<Present, 'Name, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.DomainIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneGlossaryState<Present, 'Name, 'OwningProjectIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary#name-1">DatazoneGlossary#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatazoneGlossaryState<'DomainIdentifier, Missing, 'OwningProjectIdentifier>, value: string) : DatazoneGlossaryState<'DomainIdentifier, Present, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatazoneGlossaryState<'DomainIdentifier, Present, 'OwningProjectIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary#owning_project_identifier-1">DatazoneGlossary#owning_project_identifier</a>.
        /// </summary>
        [<CustomOperation "owning_project_identifier">]
        member _.OwningProjectIdentifier(state: DatazoneGlossaryState<'DomainIdentifier, 'Name, Missing>, value: string) : DatazoneGlossaryState<'DomainIdentifier, 'Name, Present> =
            state.assignments.Add(fun config -> config.OwningProjectIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneGlossaryState<'DomainIdentifier, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary#description-1">DatazoneGlossary#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DatazoneGlossaryState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>, value: string) : DatazoneGlossaryState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DatazoneGlossaryState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary#status-1">DatazoneGlossary#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: DatazoneGlossaryState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>, value: string) : DatazoneGlossaryState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : DatazoneGlossaryState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>

        member _.Run(state: DatazoneGlossaryState<Present, Present, Present>) : aws.DatazoneGlossary.DatazoneGlossary =
            let config = aws.DatazoneGlossary.DatazoneGlossaryConfig()
            for setter in state.assignments do
                setter config
            aws.DatazoneGlossary.DatazoneGlossary(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datazoneGlossary: missing required arguments. Must call: domain_identifier, name, owning_project_identifier.", 9999, IsError = true)>]
        member _.Run(_: DatazoneGlossaryState<_, _, _>) : aws.DatazoneGlossary.DatazoneGlossary =
            Unchecked.defaultof<aws.DatazoneGlossary.DatazoneGlossary>
