namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOrganizationsOrganizationalUnitState<'Name, 'ParentId> = { assignments: ResizeArray<aws.DataAwsOrganizationsOrganizationalUnit.DataAwsOrganizationsOrganizationalUnitConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_unit">aws_organizations_organizational_unit</a>.
    /// </summary>
    type DataAwsOrganizationsOrganizationalUnitBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOrganizationsOrganizationalUnitState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsOrganizationalUnitState<Missing, Missing>)

        member _.Zero(()) : DataAwsOrganizationsOrganizationalUnitState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsOrganizationalUnitState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_unit#name-1">DataAwsOrganizationsOrganizationalUnit#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsOrganizationsOrganizationalUnitState<Missing, 'ParentId>, value: string) : DataAwsOrganizationsOrganizationalUnitState<Present, 'ParentId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsOrganizationsOrganizationalUnitState<Present, 'ParentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_unit#parent_id-1">DataAwsOrganizationsOrganizationalUnit#parent_id</a>.
        /// </summary>
        [<CustomOperation "parent_id">]
        member _.ParentId(state: DataAwsOrganizationsOrganizationalUnitState<'Name, Missing>, value: string) : DataAwsOrganizationsOrganizationalUnitState<'Name, Present> =
            state.assignments.Add(fun config -> config.ParentId <- value)
            ({ assignments = state.assignments } : DataAwsOrganizationsOrganizationalUnitState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_unit#id-1">DataAwsOrganizationsOrganizationalUnit#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOrganizationsOrganizationalUnitState<'Name, 'ParentId>, value: string) : DataAwsOrganizationsOrganizationalUnitState<'Name, 'ParentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOrganizationsOrganizationalUnitState<'Name, 'ParentId>

        member _.Run(state: DataAwsOrganizationsOrganizationalUnitState<Present, Present>) : aws.DataAwsOrganizationsOrganizationalUnit.DataAwsOrganizationsOrganizationalUnit =
            let config = aws.DataAwsOrganizationsOrganizationalUnit.DataAwsOrganizationsOrganizationalUnitConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOrganizationsOrganizationalUnit.DataAwsOrganizationsOrganizationalUnit(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOrganizationsOrganizationalUnit: missing required arguments. Must call: name, parent_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOrganizationsOrganizationalUnitState<_, _>) : aws.DataAwsOrganizationsOrganizationalUnit.DataAwsOrganizationsOrganizationalUnit =
            Unchecked.defaultof<aws.DataAwsOrganizationsOrganizationalUnit.DataAwsOrganizationsOrganizationalUnit>
