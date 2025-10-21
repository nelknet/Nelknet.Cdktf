namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevCenterState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DevCenter.DevCenterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center">azurerm_dev_center</a>.
    /// </summary>
    type DevCenterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevCenterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterState<Missing, Missing, Missing>)

        member _.Zero(()) : DevCenterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center#location-1">DevCenter#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DevCenterState<Missing, 'Name, 'ResourceGroupName>, value: string) : DevCenterState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DevCenterState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center#name-1">DevCenter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevCenterState<'Location, Missing, 'ResourceGroupName>, value: string) : DevCenterState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevCenterState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center#resource_group_name-1">DevCenter#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DevCenterState<'Location, 'Name, Missing>, value: string) : DevCenterState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DevCenterState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center#id-1">DevCenter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevCenterState<'Location, 'Name, 'ResourceGroupName>, value: string) : DevCenterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevCenterState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center#identity-1">DevCenter#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: DevCenterState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.DevCenter.DevCenterIdentity) : DevCenterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : DevCenterState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center#tags-1">DevCenter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevCenterState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : DevCenterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevCenterState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center#timeouts-1">DevCenter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevCenterState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.DevCenter.DevCenterTimeouts) : DevCenterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevCenterState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: DevCenterState<Present, Present, Present>) : azurerm.DevCenter.DevCenter =
            let config = azurerm.DevCenter.DevCenterConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevCenter.DevCenter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devCenter: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DevCenterState<_, _, _>) : azurerm.DevCenter.DevCenter =
            Unchecked.defaultof<azurerm.DevCenter.DevCenter>
