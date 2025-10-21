namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy> = { assignments: ResizeArray<azurerm.MssqlManagedInstanceFailoverGroup.MssqlManagedInstanceFailoverGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_failover_group">azurerm_mssql_managed_instance_failover_group</a>.
    /// </summary>
    type MssqlManagedInstanceFailoverGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlManagedInstanceFailoverGroupState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlManagedInstanceFailoverGroupState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MssqlManagedInstanceFailoverGroupState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlManagedInstanceFailoverGroupState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_failover_group#location-1">MssqlManagedInstanceFailoverGroup#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MssqlManagedInstanceFailoverGroupState<Missing, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy>, value: string) : MssqlManagedInstanceFailoverGroupState<Present, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceFailoverGroupState<Present, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_failover_group#managed_instance_id-1">MssqlManagedInstanceFailoverGroup#managed_instance_id</a>.
        /// </summary>
        [<CustomOperation "managed_instance_id">]
        member _.ManagedInstanceId(state: MssqlManagedInstanceFailoverGroupState<'Location, Missing, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy>, value: string) : MssqlManagedInstanceFailoverGroupState<'Location, Present, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy> =
            state.assignments.Add(fun config -> config.ManagedInstanceId <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceFailoverGroupState<'Location, Present, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_failover_group#name-1">MssqlManagedInstanceFailoverGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, Missing, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy>, value: string) : MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, Present, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, Present, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_failover_group#partner_managed_instance_id-1">MssqlManagedInstanceFailoverGroup#partner_managed_instance_id</a>.
        /// </summary>
        [<CustomOperation "partner_managed_instance_id">]
        member _.PartnerManagedInstanceId(state: MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, Missing, 'ReadWriteEndpointFailoverPolicy>, value: string) : MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, Present, 'ReadWriteEndpointFailoverPolicy> =
            state.assignments.Add(fun config -> config.PartnerManagedInstanceId <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, Present, 'ReadWriteEndpointFailoverPolicy>)

        /// <summary>
        /// read_write_endpoint_failover_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_failover_group#read_write_endpoint_failover_policy-1">MssqlManagedInstanceFailoverGroup#read_write_endpoint_failover_policy</a>
        /// </summary>
        [<CustomOperation "read_write_endpoint_failover_policy">]
        member _.ReadWriteEndpointFailoverPolicy(state: MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, Missing>, value: azurerm.MssqlManagedInstanceFailoverGroup.MssqlManagedInstanceFailoverGroupReadWriteEndpointFailoverPolicy) : MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, Present> =
            state.assignments.Add(fun config -> config.ReadWriteEndpointFailoverPolicy <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_failover_group#id-1">MssqlManagedInstanceFailoverGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy>, value: string) : MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_failover_group#readonly_endpoint_failover_policy_enabled-1">MssqlManagedInstanceFailoverGroup#readonly_endpoint_failover_policy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "readonly_endpoint_failover_policy_enabled">]
        member _.ReadonlyEndpointFailoverPolicyEnabled(state: MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy>, value: bool) : MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy> =
            state.assignments.Add(fun config -> config.ReadonlyEndpointFailoverPolicyEnabled <- value)
            state : MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_failover_group#readonly_endpoint_failover_policy_enabled-1">MssqlManagedInstanceFailoverGroup#readonly_endpoint_failover_policy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "readonly_endpoint_failover_policy_enabled">]
        member _.ReadonlyEndpointFailoverPolicyEnabled(state: MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy>, value: HashiCorp.Cdktf.IResolvable) : MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy> =
            state.assignments.Add(fun config -> config.ReadonlyEndpointFailoverPolicyEnabled <- value)
            state : MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_failover_group#timeouts-1">MssqlManagedInstanceFailoverGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy>, value: azurerm.MssqlManagedInstanceFailoverGroup.MssqlManagedInstanceFailoverGroupTimeouts) : MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlManagedInstanceFailoverGroupState<'Location, 'ManagedInstanceId, 'Name, 'PartnerManagedInstanceId, 'ReadWriteEndpointFailoverPolicy>

        member _.Run(state: MssqlManagedInstanceFailoverGroupState<Present, Present, Present, Present, Present>) : azurerm.MssqlManagedInstanceFailoverGroup.MssqlManagedInstanceFailoverGroup =
            let config = azurerm.MssqlManagedInstanceFailoverGroup.MssqlManagedInstanceFailoverGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlManagedInstanceFailoverGroup.MssqlManagedInstanceFailoverGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlManagedInstanceFailoverGroup: missing required arguments. Must call: location, managed_instance_id, name, partner_managed_instance_id, read_write_endpoint_failover_policy.", 9999, IsError = true)>]
        member _.Run(_: MssqlManagedInstanceFailoverGroupState<_, _, _, _, _>) : azurerm.MssqlManagedInstanceFailoverGroup.MssqlManagedInstanceFailoverGroup =
            Unchecked.defaultof<azurerm.MssqlManagedInstanceFailoverGroup.MssqlManagedInstanceFailoverGroup>
