namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageMoverState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.StorageMover.StorageMoverConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover">azurerm_storage_mover</a>.
    /// </summary>
    type StorageMoverBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageMoverState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageMoverState<Missing, Missing, Missing>)

        member _.Zero(()) : StorageMoverState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageMoverState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover#location-1">StorageMover#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: StorageMoverState<Missing, 'Name, 'ResourceGroupName>, value: string) : StorageMoverState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : StorageMoverState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover#name-1">StorageMover#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageMoverState<'Location, Missing, 'ResourceGroupName>, value: string) : StorageMoverState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageMoverState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover#resource_group_name-1">StorageMover#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StorageMoverState<'Location, 'Name, Missing>, value: string) : StorageMoverState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StorageMoverState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover#description-1">StorageMover#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: StorageMoverState<'Location, 'Name, 'ResourceGroupName>, value: string) : StorageMoverState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : StorageMoverState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover#id-1">StorageMover#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageMoverState<'Location, 'Name, 'ResourceGroupName>, value: string) : StorageMoverState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageMoverState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover#tags-1">StorageMover#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StorageMoverState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : StorageMoverState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StorageMoverState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover#timeouts-1">StorageMover#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageMoverState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageMover.StorageMoverTimeouts) : StorageMoverState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageMoverState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: StorageMoverState<Present, Present, Present>) : azurerm.StorageMover.StorageMover =
            let config = azurerm.StorageMover.StorageMoverConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageMover.StorageMover(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageMover: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: StorageMoverState<_, _, _>) : azurerm.StorageMover.StorageMover =
            Unchecked.defaultof<azurerm.StorageMover.StorageMover>
