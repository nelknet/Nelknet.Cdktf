namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DevCenterProject.DevCenterProjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project">azurerm_dev_center_project</a>.
    /// </summary>
    type DevCenterProjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevCenterProjectState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterProjectState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DevCenterProjectState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterProjectState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project#dev_center_id-1">DevCenterProject#dev_center_id</a>.
        /// </summary>
        [<CustomOperation "dev_center_id">]
        member _.DevCenterId(state: DevCenterProjectState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : DevCenterProjectState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DevCenterId <- value)
            ({ assignments = state.assignments } : DevCenterProjectState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project#location-1">DevCenterProject#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DevCenterProjectState<'DevCenterId, Missing, 'Name, 'ResourceGroupName>, value: string) : DevCenterProjectState<'DevCenterId, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DevCenterProjectState<'DevCenterId, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project#name-1">DevCenterProject#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevCenterProjectState<'DevCenterId, 'Location, Missing, 'ResourceGroupName>, value: string) : DevCenterProjectState<'DevCenterId, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevCenterProjectState<'DevCenterId, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project#resource_group_name-1">DevCenterProject#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DevCenterProjectState<'DevCenterId, 'Location, 'Name, Missing>, value: string) : DevCenterProjectState<'DevCenterId, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DevCenterProjectState<'DevCenterId, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project#description-1">DevCenterProject#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName>, value: string) : DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project#id-1">DevCenterProject#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName>, value: string) : DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project#maximum_dev_boxes_per_user-1">DevCenterProject#maximum_dev_boxes_per_user</a>.
        /// </summary>
        [<CustomOperation "maximum_dev_boxes_per_user">]
        member _.MaximumDevBoxesPerUser(state: DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName>, value: double) : DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MaximumDevBoxesPerUser <- value)
            state : DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project#tags-1">DevCenterProject#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_project#timeouts-1">DevCenterProject#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.DevCenterProject.DevCenterProjectTimeouts) : DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevCenterProjectState<'DevCenterId, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: DevCenterProjectState<Present, Present, Present, Present>) : azurerm.DevCenterProject.DevCenterProject =
            let config = azurerm.DevCenterProject.DevCenterProjectConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevCenterProject.DevCenterProject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devCenterProject: missing required arguments. Must call: dev_center_id, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DevCenterProjectState<_, _, _, _>) : azurerm.DevCenterProject.DevCenterProject =
            Unchecked.defaultof<azurerm.DevCenterProject.DevCenterProject>
