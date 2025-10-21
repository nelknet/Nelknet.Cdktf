namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name> = { assignments: ResizeArray<aws.DatazoneGlossaryTerm.DatazoneGlossaryTermConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term">aws_datazone_glossary_term</a>.
    /// </summary>
    type DatazoneGlossaryTermBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatazoneGlossaryTermState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneGlossaryTermState<Missing, Missing>)

        member _.Zero(()) : DatazoneGlossaryTermState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneGlossaryTermState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term#glossary_identifier-1">DatazoneGlossaryTerm#glossary_identifier</a>.
        /// </summary>
        [<CustomOperation "glossary_identifier">]
        member _.GlossaryIdentifier(state: DatazoneGlossaryTermState<Missing, 'Name>, value: string) : DatazoneGlossaryTermState<Present, 'Name> =
            state.assignments.Add(fun config -> config.GlossaryIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneGlossaryTermState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term#name-1">DatazoneGlossaryTerm#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatazoneGlossaryTermState<'GlossaryIdentifier, Missing>, value: string) : DatazoneGlossaryTermState<'GlossaryIdentifier, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatazoneGlossaryTermState<'GlossaryIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term#domain_identifier-1">DatazoneGlossaryTerm#domain_identifier</a>.
        /// </summary>
        [<CustomOperation "domain_identifier">]
        member _.DomainIdentifier(state: DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name>, value: string) : DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name> =
            state.assignments.Add(fun config -> config.DomainIdentifier <- value)
            state : DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term#long_description-1">DatazoneGlossaryTerm#long_description</a>.
        /// </summary>
        [<CustomOperation "long_description">]
        member _.LongDescription(state: DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name>, value: string) : DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name> =
            state.assignments.Add(fun config -> config.LongDescription <- value)
            state : DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term#short_description-1">DatazoneGlossaryTerm#short_description</a>.
        /// </summary>
        [<CustomOperation "short_description">]
        member _.ShortDescription(state: DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name>, value: string) : DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name> =
            state.assignments.Add(fun config -> config.ShortDescription <- value)
            state : DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term#status-1">DatazoneGlossaryTerm#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name>, value: string) : DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name>

        /// <summary>
        /// term_relations block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term#term_relations-1">DatazoneGlossaryTerm#term_relations</a> Accepts: aws.IResolvable | aws.DatazoneGlossaryTerm.DatazoneGlossaryTermTermRelations[]
        /// </summary>
        [<CustomOperation "term_relations">]
        member _.TermRelations(state: DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name> =
            state.assignments.Add(fun config -> config.TermRelations <- value)
            state : DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term#timeouts-1">DatazoneGlossaryTerm#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name>, value: aws.DatazoneGlossaryTerm.DatazoneGlossaryTermTimeouts) : DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatazoneGlossaryTermState<'GlossaryIdentifier, 'Name>

        member _.Run(state: DatazoneGlossaryTermState<Present, Present>) : aws.DatazoneGlossaryTerm.DatazoneGlossaryTerm =
            let config = aws.DatazoneGlossaryTerm.DatazoneGlossaryTermConfig()
            for setter in state.assignments do
                setter config
            aws.DatazoneGlossaryTerm.DatazoneGlossaryTerm(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datazoneGlossaryTerm: missing required arguments. Must call: glossary_identifier, name.", 9999, IsError = true)>]
        member _.Run(_: DatazoneGlossaryTermState<_, _>) : aws.DatazoneGlossaryTerm.DatazoneGlossaryTerm =
            Unchecked.defaultof<aws.DatazoneGlossaryTerm.DatazoneGlossaryTerm>
