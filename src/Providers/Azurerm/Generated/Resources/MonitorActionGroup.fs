namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> = { assignments: ResizeArray<azurerm.MonitorActionGroup.MonitorActionGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group">azurerm_monitor_action_group</a>.
    /// </summary>
    type MonitorActionGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorActionGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorActionGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : MonitorActionGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorActionGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#name-1">MonitorActionGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorActionGroupState<Missing, 'ResourceGroupName, 'ShortName>, value: string) : MonitorActionGroupState<Present, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorActionGroupState<Present, 'ResourceGroupName, 'ShortName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#resource_group_name-1">MonitorActionGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorActionGroupState<'Name, Missing, 'ShortName>, value: string) : MonitorActionGroupState<'Name, Present, 'ShortName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorActionGroupState<'Name, Present, 'ShortName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#short_name-1">MonitorActionGroup#short_name</a>.
        /// </summary>
        [<CustomOperation "short_name">]
        member _.ShortName(state: MonitorActionGroupState<'Name, 'ResourceGroupName, Missing>, value: string) : MonitorActionGroupState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ShortName <- value)
            ({ assignments = state.assignments } : MonitorActionGroupState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// arm_role_receiver block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#arm_role_receiver-1">MonitorActionGroup#arm_role_receiver</a> Accepts: azurerm.IResolvable | azurerm.MonitorActionGroup.MonitorActionGroupArmRoleReceiver[]
        /// </summary>
        [<CustomOperation "arm_role_receiver">]
        member _.ArmRoleReceiver(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: HashiCorp.Cdktf.IResolvable) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.ArmRoleReceiver <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// automation_runbook_receiver block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#automation_runbook_receiver-1">MonitorActionGroup#automation_runbook_receiver</a> Accepts: azurerm.IResolvable | azurerm.MonitorActionGroup.MonitorActionGroupAutomationRunbookReceiver[]
        /// </summary>
        [<CustomOperation "automation_runbook_receiver">]
        member _.AutomationRunbookReceiver(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: HashiCorp.Cdktf.IResolvable) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.AutomationRunbookReceiver <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// azure_app_push_receiver block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#azure_app_push_receiver-1">MonitorActionGroup#azure_app_push_receiver</a> Accepts: azurerm.IResolvable | azurerm.MonitorActionGroup.MonitorActionGroupAzureAppPushReceiver[]
        /// </summary>
        [<CustomOperation "azure_app_push_receiver">]
        member _.AzureAppPushReceiver(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: HashiCorp.Cdktf.IResolvable) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.AzureAppPushReceiver <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// azure_function_receiver block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#azure_function_receiver-1">MonitorActionGroup#azure_function_receiver</a> Accepts: azurerm.IResolvable | azurerm.MonitorActionGroup.MonitorActionGroupAzureFunctionReceiver[]
        /// </summary>
        [<CustomOperation "azure_function_receiver">]
        member _.AzureFunctionReceiver(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: HashiCorp.Cdktf.IResolvable) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.AzureFunctionReceiver <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// email_receiver block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#email_receiver-1">MonitorActionGroup#email_receiver</a> Accepts: azurerm.IResolvable | azurerm.MonitorActionGroup.MonitorActionGroupEmailReceiver[]
        /// </summary>
        [<CustomOperation "email_receiver">]
        member _.EmailReceiver(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: HashiCorp.Cdktf.IResolvable) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.EmailReceiver <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#enabled-1">MonitorActionGroup#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: bool) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#enabled-1">MonitorActionGroup#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: HashiCorp.Cdktf.IResolvable) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// event_hub_receiver block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#event_hub_receiver-1">MonitorActionGroup#event_hub_receiver</a> Accepts: azurerm.IResolvable | azurerm.MonitorActionGroup.MonitorActionGroupEventHubReceiver[]
        /// </summary>
        [<CustomOperation "event_hub_receiver">]
        member _.EventHubReceiver(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: HashiCorp.Cdktf.IResolvable) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.EventHubReceiver <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#id-1">MonitorActionGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: string) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// itsm_receiver block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#itsm_receiver-1">MonitorActionGroup#itsm_receiver</a> Accepts: azurerm.IResolvable | azurerm.MonitorActionGroup.MonitorActionGroupItsmReceiver[]
        /// </summary>
        [<CustomOperation "itsm_receiver">]
        member _.ItsmReceiver(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: HashiCorp.Cdktf.IResolvable) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.ItsmReceiver <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#location-1">MonitorActionGroup#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: string) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.Location <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// logic_app_receiver block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#logic_app_receiver-1">MonitorActionGroup#logic_app_receiver</a> Accepts: azurerm.IResolvable | azurerm.MonitorActionGroup.MonitorActionGroupLogicAppReceiver[]
        /// </summary>
        [<CustomOperation "logic_app_receiver">]
        member _.LogicAppReceiver(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: HashiCorp.Cdktf.IResolvable) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.LogicAppReceiver <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// sms_receiver block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#sms_receiver-1">MonitorActionGroup#sms_receiver</a> Accepts: azurerm.IResolvable | azurerm.MonitorActionGroup.MonitorActionGroupSmsReceiver[]
        /// </summary>
        [<CustomOperation "sms_receiver">]
        member _.SmsReceiver(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: HashiCorp.Cdktf.IResolvable) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.SmsReceiver <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#tags-1">MonitorActionGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: seq<string * string>) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#timeouts-1">MonitorActionGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: azurerm.MonitorActionGroup.MonitorActionGroupTimeouts) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// voice_receiver block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#voice_receiver-1">MonitorActionGroup#voice_receiver</a> Accepts: azurerm.IResolvable | azurerm.MonitorActionGroup.MonitorActionGroupVoiceReceiver[]
        /// </summary>
        [<CustomOperation "voice_receiver">]
        member _.VoiceReceiver(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: HashiCorp.Cdktf.IResolvable) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.VoiceReceiver <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        /// <summary>
        /// webhook_receiver block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#webhook_receiver-1">MonitorActionGroup#webhook_receiver</a> Accepts: azurerm.IResolvable | azurerm.MonitorActionGroup.MonitorActionGroupWebhookReceiver[]
        /// </summary>
        [<CustomOperation "webhook_receiver">]
        member _.WebhookReceiver(state: MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>, value: HashiCorp.Cdktf.IResolvable) : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName> =
            state.assignments.Add(fun config -> config.WebhookReceiver <- value)
            state : MonitorActionGroupState<'Name, 'ResourceGroupName, 'ShortName>

        member _.Run(state: MonitorActionGroupState<Present, Present, Present>) : azurerm.MonitorActionGroup.MonitorActionGroup =
            let config = azurerm.MonitorActionGroup.MonitorActionGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorActionGroup.MonitorActionGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorActionGroup: missing required arguments. Must call: name, resource_group_name, short_name.", 9999, IsError = true)>]
        member _.Run(_: MonitorActionGroupState<_, _, _>) : azurerm.MonitorActionGroup.MonitorActionGroup =
            Unchecked.defaultof<azurerm.MonitorActionGroup.MonitorActionGroup>
