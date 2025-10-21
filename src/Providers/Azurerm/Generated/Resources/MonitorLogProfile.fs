namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorLogProfileState<'Categories, 'Locations, 'Name, 'RetentionPolicy> = { assignments: ResizeArray<azurerm.MonitorLogProfile.MonitorLogProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_log_profile">azurerm_monitor_log_profile</a>.
    /// </summary>
    type MonitorLogProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorLogProfileState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorLogProfileState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MonitorLogProfileState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorLogProfileState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_log_profile#categories-1">MonitorLogProfile#categories</a>.
        /// </summary>
        [<CustomOperation "categories">]
        member _.Categories(state: MonitorLogProfileState<Missing, 'Locations, 'Name, 'RetentionPolicy>, value: seq<string>) : MonitorLogProfileState<Present, 'Locations, 'Name, 'RetentionPolicy> =
            state.assignments.Add(fun config -> config.Categories <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MonitorLogProfileState<Present, 'Locations, 'Name, 'RetentionPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_log_profile#locations-1">MonitorLogProfile#locations</a>.
        /// </summary>
        [<CustomOperation "locations">]
        member _.Locations(state: MonitorLogProfileState<'Categories, Missing, 'Name, 'RetentionPolicy>, value: seq<string>) : MonitorLogProfileState<'Categories, Present, 'Name, 'RetentionPolicy> =
            state.assignments.Add(fun config -> config.Locations <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MonitorLogProfileState<'Categories, Present, 'Name, 'RetentionPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_log_profile#name-1">MonitorLogProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorLogProfileState<'Categories, 'Locations, Missing, 'RetentionPolicy>, value: string) : MonitorLogProfileState<'Categories, 'Locations, Present, 'RetentionPolicy> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorLogProfileState<'Categories, 'Locations, Present, 'RetentionPolicy>)

        /// <summary>
        /// retention_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_log_profile#retention_policy-1">MonitorLogProfile#retention_policy</a>
        /// </summary>
        [<CustomOperation "retention_policy">]
        member _.RetentionPolicy(state: MonitorLogProfileState<'Categories, 'Locations, 'Name, Missing>, value: azurerm.MonitorLogProfile.MonitorLogProfileRetentionPolicy) : MonitorLogProfileState<'Categories, 'Locations, 'Name, Present> =
            state.assignments.Add(fun config -> config.RetentionPolicy <- value)
            ({ assignments = state.assignments } : MonitorLogProfileState<'Categories, 'Locations, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_log_profile#id-1">MonitorLogProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorLogProfileState<'Categories, 'Locations, 'Name, 'RetentionPolicy>, value: string) : MonitorLogProfileState<'Categories, 'Locations, 'Name, 'RetentionPolicy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorLogProfileState<'Categories, 'Locations, 'Name, 'RetentionPolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_log_profile#servicebus_rule_id-1">MonitorLogProfile#servicebus_rule_id</a>.
        /// </summary>
        [<CustomOperation "servicebus_rule_id">]
        member _.ServicebusRuleId(state: MonitorLogProfileState<'Categories, 'Locations, 'Name, 'RetentionPolicy>, value: string) : MonitorLogProfileState<'Categories, 'Locations, 'Name, 'RetentionPolicy> =
            state.assignments.Add(fun config -> config.ServicebusRuleId <- value)
            state : MonitorLogProfileState<'Categories, 'Locations, 'Name, 'RetentionPolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_log_profile#storage_account_id-1">MonitorLogProfile#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: MonitorLogProfileState<'Categories, 'Locations, 'Name, 'RetentionPolicy>, value: string) : MonitorLogProfileState<'Categories, 'Locations, 'Name, 'RetentionPolicy> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            state : MonitorLogProfileState<'Categories, 'Locations, 'Name, 'RetentionPolicy>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_log_profile#timeouts-1">MonitorLogProfile#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorLogProfileState<'Categories, 'Locations, 'Name, 'RetentionPolicy>, value: azurerm.MonitorLogProfile.MonitorLogProfileTimeouts) : MonitorLogProfileState<'Categories, 'Locations, 'Name, 'RetentionPolicy> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorLogProfileState<'Categories, 'Locations, 'Name, 'RetentionPolicy>

        member _.Run(state: MonitorLogProfileState<Present, Present, Present, Present>) : azurerm.MonitorLogProfile.MonitorLogProfile =
            let config = azurerm.MonitorLogProfile.MonitorLogProfileConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorLogProfile.MonitorLogProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorLogProfile: missing required arguments. Must call: categories, locations, name, retention_policy.", 9999, IsError = true)>]
        member _.Run(_: MonitorLogProfileState<_, _, _, _>) : azurerm.MonitorLogProfile.MonitorLogProfile =
            Unchecked.defaultof<azurerm.MonitorLogProfile.MonitorLogProfile>
