namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OrganizationsOrganizationalUnitState<'Name, 'ParentId> = { assignments: ResizeArray<aws.OrganizationsOrganizationalUnit.OrganizationsOrganizationalUnitConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_organizational_unit">aws_organizations_organizational_unit</a>.
    /// </summary>
    type OrganizationsOrganizationalUnitBuilder(logicalId: string) =
        member _.Yield(_: unit) : OrganizationsOrganizationalUnitState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OrganizationsOrganizationalUnitState<Missing, Missing>)

        member _.Zero(()) : OrganizationsOrganizationalUnitState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OrganizationsOrganizationalUnitState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_organizational_unit#name-1">OrganizationsOrganizationalUnit#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OrganizationsOrganizationalUnitState<Missing, 'ParentId>, value: string) : OrganizationsOrganizationalUnitState<Present, 'ParentId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OrganizationsOrganizationalUnitState<Present, 'ParentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_organizational_unit#parent_id-1">OrganizationsOrganizationalUnit#parent_id</a>.
        /// </summary>
        [<CustomOperation "parent_id">]
        member _.ParentId(state: OrganizationsOrganizationalUnitState<'Name, Missing>, value: string) : OrganizationsOrganizationalUnitState<'Name, Present> =
            state.assignments.Add(fun config -> config.ParentId <- value)
            ({ assignments = state.assignments } : OrganizationsOrganizationalUnitState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_organizational_unit#id-1">OrganizationsOrganizationalUnit#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OrganizationsOrganizationalUnitState<'Name, 'ParentId>, value: string) : OrganizationsOrganizationalUnitState<'Name, 'ParentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OrganizationsOrganizationalUnitState<'Name, 'ParentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_organizational_unit#tags-1">OrganizationsOrganizationalUnit#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OrganizationsOrganizationalUnitState<'Name, 'ParentId>, value: seq<string * string>) : OrganizationsOrganizationalUnitState<'Name, 'ParentId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OrganizationsOrganizationalUnitState<'Name, 'ParentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_organizational_unit#tags_all-1">OrganizationsOrganizationalUnit#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OrganizationsOrganizationalUnitState<'Name, 'ParentId>, value: seq<string * string>) : OrganizationsOrganizationalUnitState<'Name, 'ParentId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OrganizationsOrganizationalUnitState<'Name, 'ParentId>

        member _.Run(state: OrganizationsOrganizationalUnitState<Present, Present>) : aws.OrganizationsOrganizationalUnit.OrganizationsOrganizationalUnit =
            let config = aws.OrganizationsOrganizationalUnit.OrganizationsOrganizationalUnitConfig()
            for setter in state.assignments do
                setter config
            aws.OrganizationsOrganizationalUnit.OrganizationsOrganizationalUnit(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.organizationsOrganizationalUnit: missing required arguments. Must call: name, parent_id.", 9999, IsError = true)>]
        member _.Run(_: OrganizationsOrganizationalUnitState<_, _>) : aws.OrganizationsOrganizationalUnit.OrganizationsOrganizationalUnit =
            Unchecked.defaultof<aws.OrganizationsOrganizationalUnit.OrganizationsOrganizationalUnit>
