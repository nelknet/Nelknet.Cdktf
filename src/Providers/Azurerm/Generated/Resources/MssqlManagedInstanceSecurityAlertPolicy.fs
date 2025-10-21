namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.MssqlManagedInstanceSecurityAlertPolicy.MssqlManagedInstanceSecurityAlertPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_security_alert_policy">azurerm_mssql_managed_instance_security_alert_policy</a>.
    /// </summary>
    type MssqlManagedInstanceSecurityAlertPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlManagedInstanceSecurityAlertPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlManagedInstanceSecurityAlertPolicyState<Missing, Missing>)

        member _.Zero(()) : MssqlManagedInstanceSecurityAlertPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlManagedInstanceSecurityAlertPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_security_alert_policy#managed_instance_name-1">MssqlManagedInstanceSecurityAlertPolicy#managed_instance_name</a>.
        /// </summary>
        [<CustomOperation "managed_instance_name">]
        member _.ManagedInstanceName(state: MssqlManagedInstanceSecurityAlertPolicyState<Missing, 'ResourceGroupName>, value: string) : MssqlManagedInstanceSecurityAlertPolicyState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ManagedInstanceName <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceSecurityAlertPolicyState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_security_alert_policy#resource_group_name-1">MssqlManagedInstanceSecurityAlertPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, Missing>, value: string) : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_security_alert_policy#disabled_alerts-1">MssqlManagedInstanceSecurityAlertPolicy#disabled_alerts</a>.
        /// </summary>
        [<CustomOperation "disabled_alerts">]
        member _.DisabledAlerts(state: MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>, value: seq<string>) : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisabledAlerts <- (value |> Seq.toArray))
            state : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_security_alert_policy#email_account_admins_enabled-1">MssqlManagedInstanceSecurityAlertPolicy#email_account_admins_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "email_account_admins_enabled">]
        member _.EmailAccountAdminsEnabled(state: MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>, value: bool) : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EmailAccountAdminsEnabled <- value)
            state : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_security_alert_policy#email_account_admins_enabled-1">MssqlManagedInstanceSecurityAlertPolicy#email_account_admins_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "email_account_admins_enabled">]
        member _.EmailAccountAdminsEnabled(state: MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EmailAccountAdminsEnabled <- value)
            state : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_security_alert_policy#email_addresses-1">MssqlManagedInstanceSecurityAlertPolicy#email_addresses</a>.
        /// </summary>
        [<CustomOperation "email_addresses">]
        member _.EmailAddresses(state: MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>, value: seq<string>) : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EmailAddresses <- (value |> Seq.toArray))
            state : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_security_alert_policy#enabled-1">MssqlManagedInstanceSecurityAlertPolicy#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>, value: bool) : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_security_alert_policy#enabled-1">MssqlManagedInstanceSecurityAlertPolicy#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_security_alert_policy#id-1">MssqlManagedInstanceSecurityAlertPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>, value: string) : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_security_alert_policy#retention_days-1">MssqlManagedInstanceSecurityAlertPolicy#retention_days</a>.
        /// </summary>
        [<CustomOperation "retention_days">]
        member _.RetentionDays(state: MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>, value: double) : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RetentionDays <- value)
            state : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_security_alert_policy#storage_account_access_key-1">MssqlManagedInstanceSecurityAlertPolicy#storage_account_access_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_access_key">]
        member _.StorageAccountAccessKey(state: MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>, value: string) : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKey <- value)
            state : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_security_alert_policy#storage_endpoint-1">MssqlManagedInstanceSecurityAlertPolicy#storage_endpoint</a>.
        /// </summary>
        [<CustomOperation "storage_endpoint">]
        member _.StorageEndpoint(state: MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>, value: string) : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StorageEndpoint <- value)
            state : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_security_alert_policy#timeouts-1">MssqlManagedInstanceSecurityAlertPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>, value: azurerm.MssqlManagedInstanceSecurityAlertPolicy.MssqlManagedInstanceSecurityAlertPolicyTimeouts) : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlManagedInstanceSecurityAlertPolicyState<'ManagedInstanceName, 'ResourceGroupName>

        member _.Run(state: MssqlManagedInstanceSecurityAlertPolicyState<Present, Present>) : azurerm.MssqlManagedInstanceSecurityAlertPolicy.MssqlManagedInstanceSecurityAlertPolicy =
            let config = azurerm.MssqlManagedInstanceSecurityAlertPolicy.MssqlManagedInstanceSecurityAlertPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlManagedInstanceSecurityAlertPolicy.MssqlManagedInstanceSecurityAlertPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlManagedInstanceSecurityAlertPolicy: missing required arguments. Must call: managed_instance_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: MssqlManagedInstanceSecurityAlertPolicyState<_, _>) : azurerm.MssqlManagedInstanceSecurityAlertPolicy.MssqlManagedInstanceSecurityAlertPolicy =
            Unchecked.defaultof<azurerm.MssqlManagedInstanceSecurityAlertPolicy.MssqlManagedInstanceSecurityAlertPolicy>
