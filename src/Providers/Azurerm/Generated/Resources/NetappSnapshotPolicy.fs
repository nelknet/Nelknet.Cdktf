namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy">azurerm_netapp_snapshot_policy</a>.
    /// </summary>
    type NetappSnapshotPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetappSnapshotPolicyState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappSnapshotPolicyState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetappSnapshotPolicyState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappSnapshotPolicyState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#account_name-1">NetappSnapshotPolicy#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: NetappSnapshotPolicyState<Missing, 'Enabled, 'Location, 'Name, 'ResourceGroupName>, value: string) : NetappSnapshotPolicyState<Present, 'Enabled, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : NetappSnapshotPolicyState<Present, 'Enabled, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#enabled-1">NetappSnapshotPolicy#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: NetappSnapshotPolicyState<'AccountName, Missing, 'Location, 'Name, 'ResourceGroupName>, value: bool) : NetappSnapshotPolicyState<'AccountName, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : NetappSnapshotPolicyState<'AccountName, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#enabled-1">NetappSnapshotPolicy#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: NetappSnapshotPolicyState<'AccountName, Missing, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : NetappSnapshotPolicyState<'AccountName, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : NetappSnapshotPolicyState<'AccountName, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#location-1">NetappSnapshotPolicy#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetappSnapshotPolicyState<'AccountName, 'Enabled, Missing, 'Name, 'ResourceGroupName>, value: string) : NetappSnapshotPolicyState<'AccountName, 'Enabled, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetappSnapshotPolicyState<'AccountName, 'Enabled, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#name-1">NetappSnapshotPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, Missing, 'ResourceGroupName>, value: string) : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#resource_group_name-1">NetappSnapshotPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, Missing>, value: string) : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, Present>)

        /// <summary>
        /// daily_schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#daily_schedule-1">NetappSnapshotPolicy#daily_schedule</a>
        /// </summary>
        [<CustomOperation "daily_schedule">]
        member _.DailySchedule(state: NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyDailySchedule) : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DailySchedule <- value)
            state : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// hourly_schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#hourly_schedule-1">NetappSnapshotPolicy#hourly_schedule</a>
        /// </summary>
        [<CustomOperation "hourly_schedule">]
        member _.HourlySchedule(state: NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyHourlySchedule) : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HourlySchedule <- value)
            state : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#id-1">NetappSnapshotPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName>, value: string) : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// monthly_schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#monthly_schedule-1">NetappSnapshotPolicy#monthly_schedule</a>
        /// </summary>
        [<CustomOperation "monthly_schedule">]
        member _.MonthlySchedule(state: NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyMonthlySchedule) : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MonthlySchedule <- value)
            state : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#tags-1">NetappSnapshotPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#timeouts-1">NetappSnapshotPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyTimeouts) : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// weekly_schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#weekly_schedule-1">NetappSnapshotPolicy#weekly_schedule</a>
        /// </summary>
        [<CustomOperation "weekly_schedule">]
        member _.WeeklySchedule(state: NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyWeeklySchedule) : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.WeeklySchedule <- value)
            state : NetappSnapshotPolicyState<'AccountName, 'Enabled, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: NetappSnapshotPolicyState<Present, Present, Present, Present, Present>) : azurerm.NetappSnapshotPolicy.NetappSnapshotPolicy =
            let config = azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetappSnapshotPolicy.NetappSnapshotPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.netappSnapshotPolicy: missing required arguments. Must call: account_name, enabled, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: NetappSnapshotPolicyState<_, _, _, _, _>) : azurerm.NetappSnapshotPolicy.NetappSnapshotPolicy =
            Unchecked.defaultof<azurerm.NetappSnapshotPolicy.NetappSnapshotPolicy>
