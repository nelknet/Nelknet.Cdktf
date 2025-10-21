namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State> = { assignments: ResizeArray<azurerm.MssqlServerSecurityAlertPolicy.MssqlServerSecurityAlertPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_security_alert_policy">azurerm_mssql_server_security_alert_policy</a>.
    /// </summary>
    type MssqlServerSecurityAlertPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlServerSecurityAlertPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlServerSecurityAlertPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : MssqlServerSecurityAlertPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlServerSecurityAlertPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_security_alert_policy#resource_group_name-1">MssqlServerSecurityAlertPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MssqlServerSecurityAlertPolicyState<Missing, 'ServerName, 'State>, value: string) : MssqlServerSecurityAlertPolicyState<Present, 'ServerName, 'State> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MssqlServerSecurityAlertPolicyState<Present, 'ServerName, 'State>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_security_alert_policy#server_name-1">MssqlServerSecurityAlertPolicy#server_name</a>.
        /// </summary>
        [<CustomOperation "server_name">]
        member _.ServerName(state: MssqlServerSecurityAlertPolicyState<'ResourceGroupName, Missing, 'State>, value: string) : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, Present, 'State> =
            state.assignments.Add(fun config -> config.ServerName <- value)
            ({ assignments = state.assignments } : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, Present, 'State>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_security_alert_policy#state-1">MssqlServerSecurityAlertPolicy#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, Missing>, value: string) : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, Present> =
            state.assignments.Add(fun config -> config.State <- value)
            ({ assignments = state.assignments } : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_security_alert_policy#disabled_alerts-1">MssqlServerSecurityAlertPolicy#disabled_alerts</a>.
        /// </summary>
        [<CustomOperation "disabled_alerts">]
        member _.DisabledAlerts(state: MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>, value: seq<string>) : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State> =
            state.assignments.Add(fun config -> config.DisabledAlerts <- (value |> Seq.toArray))
            state : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_security_alert_policy#email_account_admins-1">MssqlServerSecurityAlertPolicy#email_account_admins</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "email_account_admins">]
        member _.EmailAccountAdmins(state: MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>, value: bool) : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State> =
            state.assignments.Add(fun config -> config.EmailAccountAdmins <- value)
            state : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_security_alert_policy#email_account_admins-1">MssqlServerSecurityAlertPolicy#email_account_admins</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "email_account_admins">]
        member _.EmailAccountAdmins(state: MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>, value: HashiCorp.Cdktf.IResolvable) : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State> =
            state.assignments.Add(fun config -> config.EmailAccountAdmins <- value)
            state : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_security_alert_policy#email_addresses-1">MssqlServerSecurityAlertPolicy#email_addresses</a>.
        /// </summary>
        [<CustomOperation "email_addresses">]
        member _.EmailAddresses(state: MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>, value: seq<string>) : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State> =
            state.assignments.Add(fun config -> config.EmailAddresses <- (value |> Seq.toArray))
            state : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_security_alert_policy#id-1">MssqlServerSecurityAlertPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>, value: string) : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_security_alert_policy#retention_days-1">MssqlServerSecurityAlertPolicy#retention_days</a>.
        /// </summary>
        [<CustomOperation "retention_days">]
        member _.RetentionDays(state: MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>, value: double) : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State> =
            state.assignments.Add(fun config -> config.RetentionDays <- value)
            state : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_security_alert_policy#storage_account_access_key-1">MssqlServerSecurityAlertPolicy#storage_account_access_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_access_key">]
        member _.StorageAccountAccessKey(state: MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>, value: string) : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKey <- value)
            state : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_security_alert_policy#storage_endpoint-1">MssqlServerSecurityAlertPolicy#storage_endpoint</a>.
        /// </summary>
        [<CustomOperation "storage_endpoint">]
        member _.StorageEndpoint(state: MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>, value: string) : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State> =
            state.assignments.Add(fun config -> config.StorageEndpoint <- value)
            state : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_security_alert_policy#timeouts-1">MssqlServerSecurityAlertPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>, value: azurerm.MssqlServerSecurityAlertPolicy.MssqlServerSecurityAlertPolicyTimeouts) : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlServerSecurityAlertPolicyState<'ResourceGroupName, 'ServerName, 'State>

        member _.Run(state: MssqlServerSecurityAlertPolicyState<Present, Present, Present>) : azurerm.MssqlServerSecurityAlertPolicy.MssqlServerSecurityAlertPolicy =
            let config = azurerm.MssqlServerSecurityAlertPolicy.MssqlServerSecurityAlertPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlServerSecurityAlertPolicy.MssqlServerSecurityAlertPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlServerSecurityAlertPolicy: missing required arguments. Must call: resource_group_name, server_name, state.", 9999, IsError = true)>]
        member _.Run(_: MssqlServerSecurityAlertPolicyState<_, _, _>) : azurerm.MssqlServerSecurityAlertPolicy.MssqlServerSecurityAlertPolicy =
            Unchecked.defaultof<azurerm.MssqlServerSecurityAlertPolicy.MssqlServerSecurityAlertPolicy>
