namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDatazoneEnvironmentBlueprintState<'DomainId, 'Managed, 'Name> = { assignments: ResizeArray<aws.DataAwsDatazoneEnvironmentBlueprint.DataAwsDatazoneEnvironmentBlueprintConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datazone_environment_blueprint">aws_datazone_environment_blueprint</a>.
    /// </summary>
    type DataAwsDatazoneEnvironmentBlueprintBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDatazoneEnvironmentBlueprintState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsDatazoneEnvironmentBlueprintState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAwsDatazoneEnvironmentBlueprintState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsDatazoneEnvironmentBlueprintState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datazone_environment_blueprint#domain_id-1">DataAwsDatazoneEnvironmentBlueprint#domain_id</a>.
        /// </summary>
        [<CustomOperation "domain_id">]
        member _.DomainId(state: DataAwsDatazoneEnvironmentBlueprintState<Missing, 'Managed, 'Name>, value: string) : DataAwsDatazoneEnvironmentBlueprintState<Present, 'Managed, 'Name> =
            state.assignments.Add(fun config -> config.DomainId <- value)
            ({ assignments = state.assignments } : DataAwsDatazoneEnvironmentBlueprintState<Present, 'Managed, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datazone_environment_blueprint#managed-1">DataAwsDatazoneEnvironmentBlueprint#managed</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "managed">]
        member _.Managed(state: DataAwsDatazoneEnvironmentBlueprintState<'DomainId, Missing, 'Name>, value: bool) : DataAwsDatazoneEnvironmentBlueprintState<'DomainId, Present, 'Name> =
            state.assignments.Add(fun config -> config.Managed <- value)
            ({ assignments = state.assignments } : DataAwsDatazoneEnvironmentBlueprintState<'DomainId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datazone_environment_blueprint#managed-1">DataAwsDatazoneEnvironmentBlueprint#managed</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "managed">]
        member _.Managed(state: DataAwsDatazoneEnvironmentBlueprintState<'DomainId, Missing, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataAwsDatazoneEnvironmentBlueprintState<'DomainId, Present, 'Name> =
            state.assignments.Add(fun config -> config.Managed <- value)
            ({ assignments = state.assignments } : DataAwsDatazoneEnvironmentBlueprintState<'DomainId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datazone_environment_blueprint#name-1">DataAwsDatazoneEnvironmentBlueprint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsDatazoneEnvironmentBlueprintState<'DomainId, 'Managed, Missing>, value: string) : DataAwsDatazoneEnvironmentBlueprintState<'DomainId, 'Managed, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsDatazoneEnvironmentBlueprintState<'DomainId, 'Managed, Present>)

        member _.Run(state: DataAwsDatazoneEnvironmentBlueprintState<Present, Present, Present>) : aws.DataAwsDatazoneEnvironmentBlueprint.DataAwsDatazoneEnvironmentBlueprint =
            let config = aws.DataAwsDatazoneEnvironmentBlueprint.DataAwsDatazoneEnvironmentBlueprintConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDatazoneEnvironmentBlueprint.DataAwsDatazoneEnvironmentBlueprint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDatazoneEnvironmentBlueprint: missing required arguments. Must call: domain_id, managed, name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDatazoneEnvironmentBlueprintState<_, _, _>) : aws.DataAwsDatazoneEnvironmentBlueprint.DataAwsDatazoneEnvironmentBlueprint =
            Unchecked.defaultof<aws.DataAwsDatazoneEnvironmentBlueprint.DataAwsDatazoneEnvironmentBlueprint>
