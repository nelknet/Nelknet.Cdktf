namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name> = { assignments: ResizeArray<azurerm.DevCenterProjectEnvironmentType.DevCenterProjectEnvironmentTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type">azurerm_dev_center_project_environment_type</a>.
    /// </summary>
    type DevCenterProjectEnvironmentTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevCenterProjectEnvironmentTypeState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterProjectEnvironmentTypeState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DevCenterProjectEnvironmentTypeState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterProjectEnvironmentTypeState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type#deployment_target_id-1">DevCenterProjectEnvironmentType#deployment_target_id</a>.
        /// </summary>
        [<CustomOperation "deployment_target_id">]
        member _.DeploymentTargetId(state: DevCenterProjectEnvironmentTypeState<Missing, 'DevCenterProjectId, 'Identity, 'Location, 'Name>, value: string) : DevCenterProjectEnvironmentTypeState<Present, 'DevCenterProjectId, 'Identity, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.DeploymentTargetId <- value)
            ({ assignments = state.assignments } : DevCenterProjectEnvironmentTypeState<Present, 'DevCenterProjectId, 'Identity, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type#dev_center_project_id-1">DevCenterProjectEnvironmentType#dev_center_project_id</a>.
        /// </summary>
        [<CustomOperation "dev_center_project_id">]
        member _.DevCenterProjectId(state: DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, Missing, 'Identity, 'Location, 'Name>, value: string) : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, Present, 'Identity, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.DevCenterProjectId <- value)
            ({ assignments = state.assignments } : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, Present, 'Identity, 'Location, 'Name>)

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type#identity-1">DevCenterProjectEnvironmentType#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, Missing, 'Location, 'Name>, value: azurerm.DevCenterProjectEnvironmentType.DevCenterProjectEnvironmentTypeIdentity) : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, Present, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Identity <- value)
            ({ assignments = state.assignments } : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, Present, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type#location-1">DevCenterProjectEnvironmentType#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, Missing, 'Name>, value: string) : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, Present, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type#name-1">DevCenterProjectEnvironmentType#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, Missing>, value: string) : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type#creator_role_assignment_roles-1">DevCenterProjectEnvironmentType#creator_role_assignment_roles</a>.
        /// </summary>
        [<CustomOperation "creator_role_assignment_roles">]
        member _.CreatorRoleAssignmentRoles(state: DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name>, value: seq<string>) : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.CreatorRoleAssignmentRoles <- (value |> Seq.toArray))
            state : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type#id-1">DevCenterProjectEnvironmentType#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name>, value: string) : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type#tags-1">DevCenterProjectEnvironmentType#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name>, value: seq<string * string>) : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type#timeouts-1">DevCenterProjectEnvironmentType#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name>, value: azurerm.DevCenterProjectEnvironmentType.DevCenterProjectEnvironmentTypeTimeouts) : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name>

        /// <summary>
        /// user_role_assignment block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project_environment_type#user_role_assignment-1">DevCenterProjectEnvironmentType#user_role_assignment</a> Accepts: azurerm.IResolvable | azurerm.DevCenterProjectEnvironmentType.DevCenterProjectEnvironmentTypeUserRoleAssignment[]
        /// </summary>
        [<CustomOperation "user_role_assignment">]
        member _.UserRoleAssignment(state: DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.UserRoleAssignment <- value)
            state : DevCenterProjectEnvironmentTypeState<'DeploymentTargetId, 'DevCenterProjectId, 'Identity, 'Location, 'Name>

        member _.Run(state: DevCenterProjectEnvironmentTypeState<Present, Present, Present, Present, Present>) : azurerm.DevCenterProjectEnvironmentType.DevCenterProjectEnvironmentType =
            let config = azurerm.DevCenterProjectEnvironmentType.DevCenterProjectEnvironmentTypeConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevCenterProjectEnvironmentType.DevCenterProjectEnvironmentType(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devCenterProjectEnvironmentType: missing required arguments. Must call: deployment_target_id, dev_center_project_id, identity, location, name.", 9999, IsError = true)>]
        member _.Run(_: DevCenterProjectEnvironmentTypeState<_, _, _, _, _>) : azurerm.DevCenterProjectEnvironmentType.DevCenterProjectEnvironmentType =
            Unchecked.defaultof<azurerm.DevCenterProjectEnvironmentType.DevCenterProjectEnvironmentType>
