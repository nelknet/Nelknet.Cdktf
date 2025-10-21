namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatazoneAssetTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier> = { assignments: ResizeArray<aws.DatazoneAssetType.DatazoneAssetTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type">aws_datazone_asset_type</a>.
    /// </summary>
    type DatazoneAssetTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatazoneAssetTypeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneAssetTypeState<Missing, Missing, Missing>)

        member _.Zero(()) : DatazoneAssetTypeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneAssetTypeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type#domain_identifier-1">DatazoneAssetType#domain_identifier</a>.
        /// </summary>
        [<CustomOperation "domain_identifier">]
        member _.DomainIdentifier(state: DatazoneAssetTypeState<Missing, 'Name, 'OwningProjectIdentifier>, value: string) : DatazoneAssetTypeState<Present, 'Name, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.DomainIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneAssetTypeState<Present, 'Name, 'OwningProjectIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type#name-1">DatazoneAssetType#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatazoneAssetTypeState<'DomainIdentifier, Missing, 'OwningProjectIdentifier>, value: string) : DatazoneAssetTypeState<'DomainIdentifier, Present, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatazoneAssetTypeState<'DomainIdentifier, Present, 'OwningProjectIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type#owning_project_identifier-1">DatazoneAssetType#owning_project_identifier</a>.
        /// </summary>
        [<CustomOperation "owning_project_identifier">]
        member _.OwningProjectIdentifier(state: DatazoneAssetTypeState<'DomainIdentifier, 'Name, Missing>, value: string) : DatazoneAssetTypeState<'DomainIdentifier, 'Name, Present> =
            state.assignments.Add(fun config -> config.OwningProjectIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneAssetTypeState<'DomainIdentifier, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type#description-1">DatazoneAssetType#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DatazoneAssetTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>, value: string) : DatazoneAssetTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DatazoneAssetTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>

        /// <summary>
        /// forms_input block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type#forms_input-1">DatazoneAssetType#forms_input</a> Accepts: aws.IResolvable | aws.DatazoneAssetType.DatazoneAssetTypeFormsInput[]
        /// </summary>
        [<CustomOperation "forms_input">]
        member _.FormsInput(state: DatazoneAssetTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>, value: HashiCorp.Cdktf.IResolvable) : DatazoneAssetTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.FormsInput <- value)
            state : DatazoneAssetTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_asset_type#timeouts-1">DatazoneAssetType#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatazoneAssetTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>, value: aws.DatazoneAssetType.DatazoneAssetTypeTimeouts) : DatazoneAssetTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatazoneAssetTypeState<'DomainIdentifier, 'Name, 'OwningProjectIdentifier>

        member _.Run(state: DatazoneAssetTypeState<Present, Present, Present>) : aws.DatazoneAssetType.DatazoneAssetType =
            let config = aws.DatazoneAssetType.DatazoneAssetTypeConfig()
            for setter in state.assignments do
                setter config
            aws.DatazoneAssetType.DatazoneAssetType(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datazoneAssetType: missing required arguments. Must call: domain_identifier, name, owning_project_identifier.", 9999, IsError = true)>]
        member _.Run(_: DatazoneAssetTypeState<_, _, _>) : aws.DatazoneAssetType.DatazoneAssetType =
            Unchecked.defaultof<aws.DatazoneAssetType.DatazoneAssetType>
