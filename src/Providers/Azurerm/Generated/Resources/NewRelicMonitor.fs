namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User> = { assignments: ResizeArray<azurerm.NewRelicMonitor.NewRelicMonitorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor">azurerm_new_relic_monitor</a>.
    /// </summary>
    type NewRelicMonitorBuilder(logicalId: string) =
        member _.Yield(_: unit) : NewRelicMonitorState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NewRelicMonitorState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NewRelicMonitorState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NewRelicMonitorState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#location-1">NewRelicMonitor#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NewRelicMonitorState<Missing, 'Name, 'Plan, 'ResourceGroupName, 'User>, value: string) : NewRelicMonitorState<Present, 'Name, 'Plan, 'ResourceGroupName, 'User> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NewRelicMonitorState<Present, 'Name, 'Plan, 'ResourceGroupName, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#name-1">NewRelicMonitor#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NewRelicMonitorState<'Location, Missing, 'Plan, 'ResourceGroupName, 'User>, value: string) : NewRelicMonitorState<'Location, Present, 'Plan, 'ResourceGroupName, 'User> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NewRelicMonitorState<'Location, Present, 'Plan, 'ResourceGroupName, 'User>)

        /// <summary>
        /// plan block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#plan-1">NewRelicMonitor#plan</a>
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: NewRelicMonitorState<'Location, 'Name, Missing, 'ResourceGroupName, 'User>, value: azurerm.NewRelicMonitor.NewRelicMonitorPlan) : NewRelicMonitorState<'Location, 'Name, Present, 'ResourceGroupName, 'User> =
            state.assignments.Add(fun config -> config.Plan <- value)
            ({ assignments = state.assignments } : NewRelicMonitorState<'Location, 'Name, Present, 'ResourceGroupName, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#resource_group_name-1">NewRelicMonitor#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NewRelicMonitorState<'Location, 'Name, 'Plan, Missing, 'User>, value: string) : NewRelicMonitorState<'Location, 'Name, 'Plan, Present, 'User> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NewRelicMonitorState<'Location, 'Name, 'Plan, Present, 'User>)

        /// <summary>
        /// user block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#user-1">NewRelicMonitor#user</a>
        /// </summary>
        [<CustomOperation "user">]
        member _.User(state: NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, Missing>, value: azurerm.NewRelicMonitor.NewRelicMonitorUser) : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.User <- value)
            ({ assignments = state.assignments } : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#account_creation_source-1">NewRelicMonitor#account_creation_source</a>.
        /// </summary>
        [<CustomOperation "account_creation_source">]
        member _.AccountCreationSource(state: NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>, value: string) : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User> =
            state.assignments.Add(fun config -> config.AccountCreationSource <- value)
            state : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#account_id-1">NewRelicMonitor#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>, value: string) : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#id-1">NewRelicMonitor#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>, value: string) : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#identity-1">NewRelicMonitor#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>, value: azurerm.NewRelicMonitor.NewRelicMonitorIdentity) : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#ingestion_key-1">NewRelicMonitor#ingestion_key</a>.
        /// </summary>
        [<CustomOperation "ingestion_key">]
        member _.IngestionKey(state: NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>, value: string) : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User> =
            state.assignments.Add(fun config -> config.IngestionKey <- value)
            state : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#organization_id-1">NewRelicMonitor#organization_id</a>.
        /// </summary>
        [<CustomOperation "organization_id">]
        member _.OrganizationId(state: NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>, value: string) : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User> =
            state.assignments.Add(fun config -> config.OrganizationId <- value)
            state : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#org_creation_source-1">NewRelicMonitor#org_creation_source</a>.
        /// </summary>
        [<CustomOperation "org_creation_source">]
        member _.OrgCreationSource(state: NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>, value: string) : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User> =
            state.assignments.Add(fun config -> config.OrgCreationSource <- value)
            state : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#timeouts-1">NewRelicMonitor#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>, value: azurerm.NewRelicMonitor.NewRelicMonitorTimeouts) : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#user_id-1">NewRelicMonitor#user_id</a>.
        /// </summary>
        [<CustomOperation "user_id">]
        member _.UserId(state: NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>, value: string) : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User> =
            state.assignments.Add(fun config -> config.UserId <- value)
            state : NewRelicMonitorState<'Location, 'Name, 'Plan, 'ResourceGroupName, 'User>

        member _.Run(state: NewRelicMonitorState<Present, Present, Present, Present, Present>) : azurerm.NewRelicMonitor.NewRelicMonitor =
            let config = azurerm.NewRelicMonitor.NewRelicMonitorConfig()
            for setter in state.assignments do
                setter config
            azurerm.NewRelicMonitor.NewRelicMonitor(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.newRelicMonitor: missing required arguments. Must call: location, name, plan, resource_group_name, user.", 9999, IsError = true)>]
        member _.Run(_: NewRelicMonitorState<_, _, _, _, _>) : azurerm.NewRelicMonitor.NewRelicMonitor =
            Unchecked.defaultof<azurerm.NewRelicMonitor.NewRelicMonitor>
