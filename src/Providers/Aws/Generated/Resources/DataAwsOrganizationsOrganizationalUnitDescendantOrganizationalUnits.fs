namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsState<'ParentId> = { assignments: ResizeArray<aws.DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnits.DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_unit_descendant_organizational_units">aws_organizations_organizational_unit_descendant_organizational_units</a>.
    /// </summary>
    type DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsState<Missing>)

        member _.Zero(()) : DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_unit_descendant_organizational_units#parent_id-1">DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnits#parent_id</a>.
        /// </summary>
        [<CustomOperation "parent_id">]
        member _.ParentId(state: DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsState<Missing>, value: string) : DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsState<Present> =
            state.assignments.Add(fun config -> config.ParentId <- value)
            ({ assignments = state.assignments } : DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_unit_descendant_organizational_units#id-1">DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnits#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsState<'ParentId>, value: string) : DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsState<'ParentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsState<'ParentId>

        member _.Run(state: DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsState<Present>) : aws.DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnits.DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnits =
            let config = aws.DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnits.DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnits.DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnits(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnits: missing required arguments. Must call: parent_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsState<_>) : aws.DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnits.DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnits =
            Unchecked.defaultof<aws.DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnits.DataAwsOrganizationsOrganizationalUnitDescendantOrganizationalUnits>
