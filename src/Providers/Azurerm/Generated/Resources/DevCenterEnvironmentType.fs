namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevCenterEnvironmentTypeState<'DevCenterId, 'Name> = { assignments: ResizeArray<azurerm.DevCenterEnvironmentType.DevCenterEnvironmentTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_environment_type">azurerm_dev_center_environment_type</a>.
    /// </summary>
    type DevCenterEnvironmentTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevCenterEnvironmentTypeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterEnvironmentTypeState<Missing, Missing>)

        member _.Zero(()) : DevCenterEnvironmentTypeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterEnvironmentTypeState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_environment_type#dev_center_id-1">DevCenterEnvironmentType#dev_center_id</a>.
        /// </summary>
        [<CustomOperation "dev_center_id">]
        member _.DevCenterId(state: DevCenterEnvironmentTypeState<Missing, 'Name>, value: string) : DevCenterEnvironmentTypeState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DevCenterId <- value)
            ({ assignments = state.assignments } : DevCenterEnvironmentTypeState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_environment_type#name-1">DevCenterEnvironmentType#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevCenterEnvironmentTypeState<'DevCenterId, Missing>, value: string) : DevCenterEnvironmentTypeState<'DevCenterId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevCenterEnvironmentTypeState<'DevCenterId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_environment_type#id-1">DevCenterEnvironmentType#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevCenterEnvironmentTypeState<'DevCenterId, 'Name>, value: string) : DevCenterEnvironmentTypeState<'DevCenterId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevCenterEnvironmentTypeState<'DevCenterId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_environment_type#tags-1">DevCenterEnvironmentType#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevCenterEnvironmentTypeState<'DevCenterId, 'Name>, value: seq<string * string>) : DevCenterEnvironmentTypeState<'DevCenterId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevCenterEnvironmentTypeState<'DevCenterId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_environment_type#timeouts-1">DevCenterEnvironmentType#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevCenterEnvironmentTypeState<'DevCenterId, 'Name>, value: azurerm.DevCenterEnvironmentType.DevCenterEnvironmentTypeTimeouts) : DevCenterEnvironmentTypeState<'DevCenterId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevCenterEnvironmentTypeState<'DevCenterId, 'Name>

        member _.Run(state: DevCenterEnvironmentTypeState<Present, Present>) : azurerm.DevCenterEnvironmentType.DevCenterEnvironmentType =
            let config = azurerm.DevCenterEnvironmentType.DevCenterEnvironmentTypeConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevCenterEnvironmentType.DevCenterEnvironmentType(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devCenterEnvironmentType: missing required arguments. Must call: dev_center_id, name.", 9999, IsError = true)>]
        member _.Run(_: DevCenterEnvironmentTypeState<_, _>) : azurerm.DevCenterEnvironmentType.DevCenterEnvironmentType =
            Unchecked.defaultof<azurerm.DevCenterEnvironmentType.DevCenterEnvironmentType>
