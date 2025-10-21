namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOrganizationsOrganizationalUnitsState<'ParentId> = { assignments: ResizeArray<aws.DataAwsOrganizationsOrganizationalUnits.DataAwsOrganizationsOrganizationalUnitsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_units">aws_organizations_organizational_units</a>.
    /// </summary>
    type DataAwsOrganizationsOrganizationalUnitsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOrganizationsOrganizationalUnitsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsOrganizationalUnitsState<Missing>)

        member _.Zero(()) : DataAwsOrganizationsOrganizationalUnitsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsOrganizationalUnitsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_units#parent_id-1">DataAwsOrganizationsOrganizationalUnits#parent_id</a>.
        /// </summary>
        [<CustomOperation "parent_id">]
        member _.ParentId(state: DataAwsOrganizationsOrganizationalUnitsState<Missing>, value: string) : DataAwsOrganizationsOrganizationalUnitsState<Present> =
            state.assignments.Add(fun config -> config.ParentId <- value)
            ({ assignments = state.assignments } : DataAwsOrganizationsOrganizationalUnitsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_units#id-1">DataAwsOrganizationsOrganizationalUnits#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOrganizationsOrganizationalUnitsState<'ParentId>, value: string) : DataAwsOrganizationsOrganizationalUnitsState<'ParentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOrganizationsOrganizationalUnitsState<'ParentId>

        member _.Run(state: DataAwsOrganizationsOrganizationalUnitsState<Present>) : aws.DataAwsOrganizationsOrganizationalUnits.DataAwsOrganizationsOrganizationalUnits =
            let config = aws.DataAwsOrganizationsOrganizationalUnits.DataAwsOrganizationsOrganizationalUnitsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOrganizationsOrganizationalUnits.DataAwsOrganizationsOrganizationalUnits(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOrganizationsOrganizationalUnits: missing required arguments. Must call: parent_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOrganizationsOrganizationalUnitsState<_>) : aws.DataAwsOrganizationsOrganizationalUnits.DataAwsOrganizationsOrganizationalUnits =
            Unchecked.defaultof<aws.DataAwsOrganizationsOrganizationalUnits.DataAwsOrganizationsOrganizationalUnits>
