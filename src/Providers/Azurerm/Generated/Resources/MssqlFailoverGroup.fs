namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId> = { assignments: ResizeArray<azurerm.MssqlFailoverGroup.MssqlFailoverGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group">azurerm_mssql_failover_group</a>.
    /// </summary>
    type MssqlFailoverGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlFailoverGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlFailoverGroupState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MssqlFailoverGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlFailoverGroupState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#name-1">MssqlFailoverGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlFailoverGroupState<Missing, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId>, value: string) : MssqlFailoverGroupState<Present, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlFailoverGroupState<Present, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId>)

        /// <summary>
        /// partner_server block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#partner_server-1">MssqlFailoverGroup#partner_server</a> Accepts: azurerm.IResolvable | azurerm.MssqlFailoverGroup.MssqlFailoverGroupPartnerServer[]
        /// </summary>
        [<CustomOperation "partner_server">]
        member _.PartnerServer(state: MssqlFailoverGroupState<'Name, Missing, 'ReadWriteEndpointFailoverPolicy, 'ServerId>, value: HashiCorp.Cdktf.IResolvable) : MssqlFailoverGroupState<'Name, Present, 'ReadWriteEndpointFailoverPolicy, 'ServerId> =
            state.assignments.Add(fun config -> config.PartnerServer <- value)
            ({ assignments = state.assignments } : MssqlFailoverGroupState<'Name, Present, 'ReadWriteEndpointFailoverPolicy, 'ServerId>)

        /// <summary>
        /// read_write_endpoint_failover_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#read_write_endpoint_failover_policy-1">MssqlFailoverGroup#read_write_endpoint_failover_policy</a>
        /// </summary>
        [<CustomOperation "read_write_endpoint_failover_policy">]
        member _.ReadWriteEndpointFailoverPolicy(state: MssqlFailoverGroupState<'Name, 'PartnerServer, Missing, 'ServerId>, value: azurerm.MssqlFailoverGroup.MssqlFailoverGroupReadWriteEndpointFailoverPolicy) : MssqlFailoverGroupState<'Name, 'PartnerServer, Present, 'ServerId> =
            state.assignments.Add(fun config -> config.ReadWriteEndpointFailoverPolicy <- value)
            ({ assignments = state.assignments } : MssqlFailoverGroupState<'Name, 'PartnerServer, Present, 'ServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#server_id-1">MssqlFailoverGroup#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, Missing>, value: string) : MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, Present> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#databases-1">MssqlFailoverGroup#databases</a>.
        /// </summary>
        [<CustomOperation "databases">]
        member _.Databases(state: MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId>, value: seq<string>) : MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId> =
            state.assignments.Add(fun config -> config.Databases <- (value |> Seq.toArray))
            state : MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#id-1">MssqlFailoverGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId>, value: string) : MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#readonly_endpoint_failover_policy_enabled-1">MssqlFailoverGroup#readonly_endpoint_failover_policy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "readonly_endpoint_failover_policy_enabled">]
        member _.ReadonlyEndpointFailoverPolicyEnabled(state: MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId>, value: bool) : MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId> =
            state.assignments.Add(fun config -> config.ReadonlyEndpointFailoverPolicyEnabled <- value)
            state : MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#readonly_endpoint_failover_policy_enabled-1">MssqlFailoverGroup#readonly_endpoint_failover_policy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "readonly_endpoint_failover_policy_enabled">]
        member _.ReadonlyEndpointFailoverPolicyEnabled(state: MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId>, value: HashiCorp.Cdktf.IResolvable) : MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId> =
            state.assignments.Add(fun config -> config.ReadonlyEndpointFailoverPolicyEnabled <- value)
            state : MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#tags-1">MssqlFailoverGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId>, value: seq<string * string>) : MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_failover_group#timeouts-1">MssqlFailoverGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId>, value: azurerm.MssqlFailoverGroup.MssqlFailoverGroupTimeouts) : MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlFailoverGroupState<'Name, 'PartnerServer, 'ReadWriteEndpointFailoverPolicy, 'ServerId>

        member _.Run(state: MssqlFailoverGroupState<Present, Present, Present, Present>) : azurerm.MssqlFailoverGroup.MssqlFailoverGroup =
            let config = azurerm.MssqlFailoverGroup.MssqlFailoverGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlFailoverGroup.MssqlFailoverGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlFailoverGroup: missing required arguments. Must call: name, partner_server, read_write_endpoint_failover_policy, server_id.", 9999, IsError = true)>]
        member _.Run(_: MssqlFailoverGroupState<_, _, _, _>) : azurerm.MssqlFailoverGroup.MssqlFailoverGroup =
            Unchecked.defaultof<azurerm.MssqlFailoverGroup.MssqlFailoverGroup>
