namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DiskAccessState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DiskAccess.DiskAccessConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_access">azurerm_disk_access</a>.
    /// </summary>
    type DiskAccessBuilder(logicalId: string) =
        member _.Yield(_: unit) : DiskAccessState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DiskAccessState<Missing, Missing, Missing>)

        member _.Zero(()) : DiskAccessState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DiskAccessState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_access#location-1">DiskAccess#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DiskAccessState<Missing, 'Name, 'ResourceGroupName>, value: string) : DiskAccessState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DiskAccessState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_access#name-1">DiskAccess#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DiskAccessState<'Location, Missing, 'ResourceGroupName>, value: string) : DiskAccessState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DiskAccessState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_access#resource_group_name-1">DiskAccess#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DiskAccessState<'Location, 'Name, Missing>, value: string) : DiskAccessState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DiskAccessState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_access#id-1">DiskAccess#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DiskAccessState<'Location, 'Name, 'ResourceGroupName>, value: string) : DiskAccessState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DiskAccessState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_access#tags-1">DiskAccess#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DiskAccessState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : DiskAccessState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DiskAccessState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/disk_access#timeouts-1">DiskAccess#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DiskAccessState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.DiskAccess.DiskAccessTimeouts) : DiskAccessState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DiskAccessState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: DiskAccessState<Present, Present, Present>) : azurerm.DiskAccess.DiskAccess =
            let config = azurerm.DiskAccess.DiskAccessConfig()
            for setter in state.assignments do
                setter config
            azurerm.DiskAccess.DiskAccess(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.diskAccess: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DiskAccessState<_, _, _>) : azurerm.DiskAccess.DiskAccess =
            Unchecked.defaultof<azurerm.DiskAccess.DiskAccess>
