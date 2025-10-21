namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier> = { assignments: ResizeArray<aws.DatazoneEnvironment.DatazoneEnvironmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment">aws_datazone_environment</a>.
    /// </summary>
    type DatazoneEnvironmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatazoneEnvironmentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneEnvironmentState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DatazoneEnvironmentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneEnvironmentState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment#domain_identifier-1">DatazoneEnvironment#domain_identifier</a>.
        /// </summary>
        [<CustomOperation "domain_identifier">]
        member _.DomainIdentifier(state: DatazoneEnvironmentState<Missing, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>, value: string) : DatazoneEnvironmentState<Present, 'Name, 'ProfileIdentifier, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.DomainIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneEnvironmentState<Present, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment#name-1">DatazoneEnvironment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatazoneEnvironmentState<'DomainIdentifier, Missing, 'ProfileIdentifier, 'ProjectIdentifier>, value: string) : DatazoneEnvironmentState<'DomainIdentifier, Present, 'ProfileIdentifier, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatazoneEnvironmentState<'DomainIdentifier, Present, 'ProfileIdentifier, 'ProjectIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment#profile_identifier-1">DatazoneEnvironment#profile_identifier</a>.
        /// </summary>
        [<CustomOperation "profile_identifier">]
        member _.ProfileIdentifier(state: DatazoneEnvironmentState<'DomainIdentifier, 'Name, Missing, 'ProjectIdentifier>, value: string) : DatazoneEnvironmentState<'DomainIdentifier, 'Name, Present, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.ProfileIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneEnvironmentState<'DomainIdentifier, 'Name, Present, 'ProjectIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment#project_identifier-1">DatazoneEnvironment#project_identifier</a>.
        /// </summary>
        [<CustomOperation "project_identifier">]
        member _.ProjectIdentifier(state: DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, Missing>, value: string) : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, Present> =
            state.assignments.Add(fun config -> config.ProjectIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment#account_identifier-1">DatazoneEnvironment#account_identifier</a>.
        /// </summary>
        [<CustomOperation "account_identifier">]
        member _.AccountIdentifier(state: DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>, value: string) : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.AccountIdentifier <- value)
            state : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment#account_region-1">DatazoneEnvironment#account_region</a>.
        /// </summary>
        [<CustomOperation "account_region">]
        member _.AccountRegion(state: DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>, value: string) : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.AccountRegion <- value)
            state : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment#blueprint_identifier-1">DatazoneEnvironment#blueprint_identifier</a>.
        /// </summary>
        [<CustomOperation "blueprint_identifier">]
        member _.BlueprintIdentifier(state: DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>, value: string) : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.BlueprintIdentifier <- value)
            state : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment#description-1">DatazoneEnvironment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>, value: string) : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment#glossary_terms-1">DatazoneEnvironment#glossary_terms</a>.
        /// </summary>
        [<CustomOperation "glossary_terms">]
        member _.GlossaryTerms(state: DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>, value: seq<string>) : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.GlossaryTerms <- (value |> Seq.toArray))
            state : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment#timeouts-1">DatazoneEnvironment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>, value: aws.DatazoneEnvironment.DatazoneEnvironmentTimeouts) : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>

        /// <summary>
        /// user_parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment#user_parameters-1">DatazoneEnvironment#user_parameters</a> Accepts: aws.IResolvable | aws.DatazoneEnvironment.DatazoneEnvironmentUserParameters[]
        /// </summary>
        [<CustomOperation "user_parameters">]
        member _.UserParameters(state: DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>, value: HashiCorp.Cdktf.IResolvable) : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.UserParameters <- value)
            state : DatazoneEnvironmentState<'DomainIdentifier, 'Name, 'ProfileIdentifier, 'ProjectIdentifier>

        member _.Run(state: DatazoneEnvironmentState<Present, Present, Present, Present>) : aws.DatazoneEnvironment.DatazoneEnvironment =
            let config = aws.DatazoneEnvironment.DatazoneEnvironmentConfig()
            for setter in state.assignments do
                setter config
            aws.DatazoneEnvironment.DatazoneEnvironment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datazoneEnvironment: missing required arguments. Must call: domain_identifier, name, profile_identifier, project_identifier.", 9999, IsError = true)>]
        member _.Run(_: DatazoneEnvironmentState<_, _, _, _>) : aws.DatazoneEnvironment.DatazoneEnvironment =
            Unchecked.defaultof<aws.DatazoneEnvironment.DatazoneEnvironment>
