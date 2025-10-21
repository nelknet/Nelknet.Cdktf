namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId> = { assignments: ResizeArray<azurerm.MssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_availability_group_listener">azurerm_mssql_virtual_machine_availability_group_listener</a>.
    /// </summary>
    type MssqlVirtualMachineAvailabilityGroupListenerBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlVirtualMachineAvailabilityGroupListenerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlVirtualMachineAvailabilityGroupListenerState<Missing, Missing, Missing>)

        member _.Zero(()) : MssqlVirtualMachineAvailabilityGroupListenerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlVirtualMachineAvailabilityGroupListenerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_availability_group_listener#name-1">MssqlVirtualMachineAvailabilityGroupListener#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlVirtualMachineAvailabilityGroupListenerState<Missing, 'Replica, 'SqlVirtualMachineGroupId>, value: string) : MssqlVirtualMachineAvailabilityGroupListenerState<Present, 'Replica, 'SqlVirtualMachineGroupId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlVirtualMachineAvailabilityGroupListenerState<Present, 'Replica, 'SqlVirtualMachineGroupId>)

        /// <summary>
        /// replica block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_availability_group_listener#replica-1">MssqlVirtualMachineAvailabilityGroupListener#replica</a> Accepts: azurerm.IResolvable | azurerm.MssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerReplica[]
        /// </summary>
        [<CustomOperation "replica">]
        member _.Replica(state: MssqlVirtualMachineAvailabilityGroupListenerState<'Name, Missing, 'SqlVirtualMachineGroupId>, value: HashiCorp.Cdktf.IResolvable) : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, Present, 'SqlVirtualMachineGroupId> =
            state.assignments.Add(fun config -> config.Replica <- value)
            ({ assignments = state.assignments } : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, Present, 'SqlVirtualMachineGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_availability_group_listener#sql_virtual_machine_group_id-1">MssqlVirtualMachineAvailabilityGroupListener#sql_virtual_machine_group_id</a>.
        /// </summary>
        [<CustomOperation "sql_virtual_machine_group_id">]
        member _.SqlVirtualMachineGroupId(state: MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, Missing>, value: string) : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, Present> =
            state.assignments.Add(fun config -> config.SqlVirtualMachineGroupId <- value)
            ({ assignments = state.assignments } : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_availability_group_listener#availability_group_name-1">MssqlVirtualMachineAvailabilityGroupListener#availability_group_name</a>.
        /// </summary>
        [<CustomOperation "availability_group_name">]
        member _.AvailabilityGroupName(state: MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId>, value: string) : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId> =
            state.assignments.Add(fun config -> config.AvailabilityGroupName <- value)
            state : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_availability_group_listener#id-1">MssqlVirtualMachineAvailabilityGroupListener#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId>, value: string) : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId>

        /// <summary>
        /// load_balancer_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_availability_group_listener#load_balancer_configuration-1">MssqlVirtualMachineAvailabilityGroupListener#load_balancer_configuration</a>
        /// </summary>
        [<CustomOperation "load_balancer_configuration">]
        member _.LoadBalancerConfiguration(state: MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId>, value: azurerm.MssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfiguration) : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId> =
            state.assignments.Add(fun config -> config.LoadBalancerConfiguration <- value)
            state : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId>

        /// <summary>
        /// multi_subnet_ip_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_availability_group_listener#multi_subnet_ip_configuration-1">MssqlVirtualMachineAvailabilityGroupListener#multi_subnet_ip_configuration</a> Accepts: azurerm.IResolvable | azurerm.MssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfiguration[]
        /// </summary>
        [<CustomOperation "multi_subnet_ip_configuration">]
        member _.MultiSubnetIpConfiguration(state: MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId>, value: HashiCorp.Cdktf.IResolvable) : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId> =
            state.assignments.Add(fun config -> config.MultiSubnetIpConfiguration <- value)
            state : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_availability_group_listener#port-1">MssqlVirtualMachineAvailabilityGroupListener#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId>, value: double) : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_availability_group_listener#timeouts-1">MssqlVirtualMachineAvailabilityGroupListener#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId>, value: azurerm.MssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerTimeouts) : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlVirtualMachineAvailabilityGroupListenerState<'Name, 'Replica, 'SqlVirtualMachineGroupId>

        member _.Run(state: MssqlVirtualMachineAvailabilityGroupListenerState<Present, Present, Present>) : azurerm.MssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListener =
            let config = azurerm.MssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListener(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlVirtualMachineAvailabilityGroupListener: missing required arguments. Must call: name, replica, sql_virtual_machine_group_id.", 9999, IsError = true)>]
        member _.Run(_: MssqlVirtualMachineAvailabilityGroupListenerState<_, _, _>) : azurerm.MssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListener =
            Unchecked.defaultof<azurerm.MssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListener>
