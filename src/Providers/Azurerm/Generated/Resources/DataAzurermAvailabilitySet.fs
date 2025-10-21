namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAvailabilitySetState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAvailabilitySet.DataAzurermAvailabilitySetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/availability_set">azurerm_availability_set</a>.
    /// </summary>
    type DataAzurermAvailabilitySetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAvailabilitySetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAvailabilitySetState<Missing, Missing>)

        member _.Zero(()) : DataAzurermAvailabilitySetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAvailabilitySetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/availability_set#name-1">DataAzurermAvailabilitySet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermAvailabilitySetState<Missing, 'ResourceGroupName>, value: string) : DataAzurermAvailabilitySetState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermAvailabilitySetState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/availability_set#resource_group_name-1">DataAzurermAvailabilitySet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAvailabilitySetState<'Name, Missing>, value: string) : DataAzurermAvailabilitySetState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAvailabilitySetState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/availability_set#id-1">DataAzurermAvailabilitySet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAvailabilitySetState<'Name, 'ResourceGroupName>, value: string) : DataAzurermAvailabilitySetState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAvailabilitySetState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/availability_set#timeouts-1">DataAzurermAvailabilitySet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAvailabilitySetState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermAvailabilitySet.DataAzurermAvailabilitySetTimeouts) : DataAzurermAvailabilitySetState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAvailabilitySetState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermAvailabilitySetState<Present, Present>) : azurerm.DataAzurermAvailabilitySet.DataAzurermAvailabilitySet =
            let config = azurerm.DataAzurermAvailabilitySet.DataAzurermAvailabilitySetConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAvailabilitySet.DataAzurermAvailabilitySet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAvailabilitySet: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAvailabilitySetState<_, _>) : azurerm.DataAzurermAvailabilitySet.DataAzurermAvailabilitySet =
            Unchecked.defaultof<azurerm.DataAzurermAvailabilitySet.DataAzurermAvailabilitySet>
