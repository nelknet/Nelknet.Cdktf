namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevTestLabState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DevTestLab.DevTestLabConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_lab">azurerm_dev_test_lab</a>.
    /// </summary>
    type DevTestLabBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevTestLabState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevTestLabState<Missing, Missing, Missing>)

        member _.Zero(()) : DevTestLabState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevTestLabState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_lab#location-1">DevTestLab#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DevTestLabState<Missing, 'Name, 'ResourceGroupName>, value: string) : DevTestLabState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DevTestLabState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_lab#name-1">DevTestLab#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevTestLabState<'Location, Missing, 'ResourceGroupName>, value: string) : DevTestLabState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevTestLabState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_lab#resource_group_name-1">DevTestLab#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DevTestLabState<'Location, 'Name, Missing>, value: string) : DevTestLabState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DevTestLabState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_lab#id-1">DevTestLab#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevTestLabState<'Location, 'Name, 'ResourceGroupName>, value: string) : DevTestLabState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevTestLabState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_lab#tags-1">DevTestLab#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevTestLabState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : DevTestLabState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevTestLabState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_lab#timeouts-1">DevTestLab#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevTestLabState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.DevTestLab.DevTestLabTimeouts) : DevTestLabState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevTestLabState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: DevTestLabState<Present, Present, Present>) : azurerm.DevTestLab.DevTestLab =
            let config = azurerm.DevTestLab.DevTestLabConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevTestLab.DevTestLab(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devTestLab: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DevTestLabState<_, _, _>) : azurerm.DevTestLab.DevTestLab =
            Unchecked.defaultof<azurerm.DevTestLab.DevTestLab>
