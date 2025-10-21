namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId> = { assignments: ResizeArray<azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting">azurerm_monitor_autoscale_setting</a>.
    /// </summary>
    type MonitorAutoscaleSettingBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorAutoscaleSettingState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorAutoscaleSettingState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MonitorAutoscaleSettingState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorAutoscaleSettingState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#location-1">MonitorAutoscaleSetting#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MonitorAutoscaleSettingState<Missing, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>, value: string) : MonitorAutoscaleSettingState<Present, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MonitorAutoscaleSettingState<Present, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#name-1">MonitorAutoscaleSetting#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorAutoscaleSettingState<'Location, Missing, 'Profile, 'ResourceGroupName, 'TargetResourceId>, value: string) : MonitorAutoscaleSettingState<'Location, Present, 'Profile, 'ResourceGroupName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorAutoscaleSettingState<'Location, Present, 'Profile, 'ResourceGroupName, 'TargetResourceId>)

        /// <summary>
        /// profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#profile-1">MonitorAutoscaleSetting#profile</a> Accepts: azurerm.IResolvable | azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfile[]
        /// </summary>
        [<CustomOperation "profile">]
        member _.Profile(state: MonitorAutoscaleSettingState<'Location, 'Name, Missing, 'ResourceGroupName, 'TargetResourceId>, value: HashiCorp.Cdktf.IResolvable) : MonitorAutoscaleSettingState<'Location, 'Name, Present, 'ResourceGroupName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Profile <- value)
            ({ assignments = state.assignments } : MonitorAutoscaleSettingState<'Location, 'Name, Present, 'ResourceGroupName, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#resource_group_name-1">MonitorAutoscaleSetting#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, Missing, 'TargetResourceId>, value: string) : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#target_resource_id-1">MonitorAutoscaleSetting#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, Missing>, value: string) : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#enabled-1">MonitorAutoscaleSetting#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>, value: bool) : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#enabled-1">MonitorAutoscaleSetting#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>, value: HashiCorp.Cdktf.IResolvable) : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#id-1">MonitorAutoscaleSetting#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>, value: string) : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>

        /// <summary>
        /// notification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#notification-1">MonitorAutoscaleSetting#notification</a>
        /// </summary>
        [<CustomOperation "notification">]
        member _.Notification(state: MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>, value: azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingNotification) : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Notification <- value)
            state : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>

        /// <summary>
        /// predictive block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#predictive-1">MonitorAutoscaleSetting#predictive</a>
        /// </summary>
        [<CustomOperation "predictive">]
        member _.Predictive(state: MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>, value: azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingPredictive) : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Predictive <- value)
            state : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#tags-1">MonitorAutoscaleSetting#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>, value: seq<string * string>) : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#timeouts-1">MonitorAutoscaleSetting#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>, value: azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingTimeouts) : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorAutoscaleSettingState<'Location, 'Name, 'Profile, 'ResourceGroupName, 'TargetResourceId>

        member _.Run(state: MonitorAutoscaleSettingState<Present, Present, Present, Present, Present>) : azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSetting =
            let config = azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSetting(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorAutoscaleSetting: missing required arguments. Must call: location, name, profile, resource_group_name, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: MonitorAutoscaleSettingState<_, _, _, _, _>) : azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSetting =
            Unchecked.defaultof<azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSetting>
