namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username> = { assignments: ResizeArray<azurerm.SystemCenterVirtualMachineManagerServer.SystemCenterVirtualMachineManagerServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_server">azurerm_system_center_virtual_machine_manager_server</a>.
    /// </summary>
    type SystemCenterVirtualMachineManagerServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : SystemCenterVirtualMachineManagerServerState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SystemCenterVirtualMachineManagerServerState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SystemCenterVirtualMachineManagerServerState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SystemCenterVirtualMachineManagerServerState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_server#custom_location_id-1">SystemCenterVirtualMachineManagerServer#custom_location_id</a>.
        /// </summary>
        [<CustomOperation "custom_location_id">]
        member _.CustomLocationId(state: SystemCenterVirtualMachineManagerServerState<Missing, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username>, value: string) : SystemCenterVirtualMachineManagerServerState<Present, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.CustomLocationId <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerServerState<Present, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_server#fqdn-1">SystemCenterVirtualMachineManagerServer#fqdn</a>.
        /// </summary>
        [<CustomOperation "fqdn">]
        member _.Fqdn(state: SystemCenterVirtualMachineManagerServerState<'CustomLocationId, Missing, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username>, value: string) : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, Present, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.Fqdn <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, Present, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_server#location-1">SystemCenterVirtualMachineManagerServer#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, Missing, 'Name, 'Password, 'ResourceGroupName, 'Username>, value: string) : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, Present, 'Name, 'Password, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, Present, 'Name, 'Password, 'ResourceGroupName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_server#name-1">SystemCenterVirtualMachineManagerServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, Missing, 'Password, 'ResourceGroupName, 'Username>, value: string) : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, Present, 'Password, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, Present, 'Password, 'ResourceGroupName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_server#password-1">SystemCenterVirtualMachineManagerServer#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, Missing, 'ResourceGroupName, 'Username>, value: string) : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, Present, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, Present, 'ResourceGroupName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_server#resource_group_name-1">SystemCenterVirtualMachineManagerServer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, Missing, 'Username>, value: string) : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, Present, 'Username> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, Present, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_server#username-1">SystemCenterVirtualMachineManagerServer#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, Missing>, value: string) : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_server#id-1">SystemCenterVirtualMachineManagerServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username>, value: string) : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_server#port-1">SystemCenterVirtualMachineManagerServer#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username>, value: double) : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_server#tags-1">SystemCenterVirtualMachineManagerServer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username>, value: seq<string * string>) : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_server#timeouts-1">SystemCenterVirtualMachineManagerServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username>, value: azurerm.SystemCenterVirtualMachineManagerServer.SystemCenterVirtualMachineManagerServerTimeouts) : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SystemCenterVirtualMachineManagerServerState<'CustomLocationId, 'Fqdn, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Username>

        member _.Run(state: SystemCenterVirtualMachineManagerServerState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.SystemCenterVirtualMachineManagerServer.SystemCenterVirtualMachineManagerServer =
            let config = azurerm.SystemCenterVirtualMachineManagerServer.SystemCenterVirtualMachineManagerServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.SystemCenterVirtualMachineManagerServer.SystemCenterVirtualMachineManagerServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.systemCenterVirtualMachineManagerServer: missing required arguments. Must call: custom_location_id, fqdn, location, name, password, resource_group_name, username.", 9999, IsError = true)>]
        member _.Run(_: SystemCenterVirtualMachineManagerServerState<_, _, _, _, _, _, _>) : azurerm.SystemCenterVirtualMachineManagerServer.SystemCenterVirtualMachineManagerServer =
            Unchecked.defaultof<azurerm.SystemCenterVirtualMachineManagerServer.SystemCenterVirtualMachineManagerServer>
