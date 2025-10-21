namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatazoneFormTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier> = { assignments: ResizeArray<aws.DatazoneFormType.DatazoneFormTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_form_type">aws_datazone_form_type</a>.
    /// </summary>
    type DatazoneFormTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatazoneFormTypeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneFormTypeState<Missing, Missing, Missing>)

        member _.Zero(()) : DatazoneFormTypeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneFormTypeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_form_type#domain_identifier-1">DatazoneFormType#domain_identifier</a>.
        /// </summary>
        [<CustomOperation "domain_identifier">]
        member _.DomainIdentifier(state: DatazoneFormTypeState<Missing, 'Name, 'OwningProjectIdentifier>, value: string) : DatazoneFormTypeState<Present, 'Name, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.DomainIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneFormTypeState<Present, 'Name, 'OwningProjectIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_form_type#name-1">DatazoneFormType#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatazoneFormTypeState<'DomainIdentifier, Missing, 'OwningProjectIdentifier>, value: string) : DatazoneFormTypeState<'DomainIdentifier, Present, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatazoneFormTypeState<'DomainIdentifier, Present, 'OwningProjectIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_form_type#owning_project_identifier-1">DatazoneFormType#owning_project_identifier</a>.
        /// </summary>
        [<CustomOperation "owning_project_identifier">]
        member _.OwningProjectIdentifier(state: DatazoneFormTypeState<'DomainIdentifier, 'Name, Missing>, value: string) : DatazoneFormTypeState<'DomainIdentifier, 'Name, Present> =
            state.assignments.Add(fun config -> config.OwningProjectIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneFormTypeState<'DomainIdentifier, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_form_type#description-1">DatazoneFormType#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DatazoneFormTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>, value: string) : DatazoneFormTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DatazoneFormTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>

        /// <summary>
        /// model block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_form_type#model-1">DatazoneFormType#model</a> Accepts: aws.IResolvable | aws.DatazoneFormType.DatazoneFormTypeModel[]
        /// </summary>
        [<CustomOperation "model">]
        member _.Model(state: DatazoneFormTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>, value: HashiCorp.Cdktf.IResolvable) : DatazoneFormTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.Model <- value)
            state : DatazoneFormTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_form_type#status-1">DatazoneFormType#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: DatazoneFormTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>, value: string) : DatazoneFormTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : DatazoneFormTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_form_type#timeouts-1">DatazoneFormType#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatazoneFormTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>, value: aws.DatazoneFormType.DatazoneFormTypeTimeouts) : DatazoneFormTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatazoneFormTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>

        member _.Run(state: DatazoneFormTypeState<Present, Present, Present>) : aws.DatazoneFormType.DatazoneFormType =
            let config = aws.DatazoneFormType.DatazoneFormTypeConfig()
            for setter in state.assignments do
                setter config
            aws.DatazoneFormType.DatazoneFormType(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datazoneFormType: missing required arguments. Must call: domain_identifier, name, owning_project_identifier.", 9999, IsError = true)>]
        member _.Run(_: DatazoneFormTypeState<_, _, _>) : aws.DatazoneFormType.DatazoneFormType =
            Unchecked.defaultof<aws.DatazoneFormType.DatazoneFormType>
