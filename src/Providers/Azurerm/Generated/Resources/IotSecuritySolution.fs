namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.IotSecuritySolution.IotSecuritySolutionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution">azurerm_iot_security_solution</a>.
    /// </summary>
    type IotSecuritySolutionBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotSecuritySolutionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IotSecuritySolutionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : IotSecuritySolutionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IotSecuritySolutionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#display_name-1">IotSecuritySolution#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: IotSecuritySolutionState<Missing, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: string) : IotSecuritySolutionState<Present, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : IotSecuritySolutionState<Present, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#iothub_ids-1">IotSecuritySolution#iothub_ids</a>.
        /// </summary>
        [<CustomOperation "iothub_ids">]
        member _.IothubIds(state: IotSecuritySolutionState<'DisplayName, Missing, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : IotSecuritySolutionState<'DisplayName, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IothubIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : IotSecuritySolutionState<'DisplayName, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#location-1">IotSecuritySolution#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, Missing, 'Name, 'ResourceGroupName>, value: string) : IotSecuritySolutionState<'DisplayName, 'IothubIds, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : IotSecuritySolutionState<'DisplayName, 'IothubIds, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#name-1">IotSecuritySolution#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, Missing, 'ResourceGroupName>, value: string) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#resource_group_name-1">IotSecuritySolution#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, Missing>, value: string) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, Present>)

        /// <summary>
        /// additional_workspace block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#additional_workspace-1">IotSecuritySolution#additional_workspace</a> Accepts: azurerm.IResolvable | azurerm.IotSecuritySolution.IotSecuritySolutionAdditionalWorkspace[]
        /// </summary>
        [<CustomOperation "additional_workspace">]
        member _.AdditionalWorkspace(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AdditionalWorkspace <- value)
            state : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#disabled_data_sources-1">IotSecuritySolution#disabled_data_sources</a>.
        /// </summary>
        [<CustomOperation "disabled_data_sources">]
        member _.DisabledDataSources(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisabledDataSources <- (value |> Seq.toArray))
            state : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#enabled-1">IotSecuritySolution#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: bool) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#enabled-1">IotSecuritySolution#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#events_to_export-1">IotSecuritySolution#events_to_export</a>.
        /// </summary>
        [<CustomOperation "events_to_export">]
        member _.EventsToExport(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EventsToExport <- (value |> Seq.toArray))
            state : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#id-1">IotSecuritySolution#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: string) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#log_analytics_workspace_id-1">IotSecuritySolution#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: string) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            state : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#log_unmasked_ips_enabled-1">IotSecuritySolution#log_unmasked_ips_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_unmasked_ips_enabled">]
        member _.LogUnmaskedIpsEnabled(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: bool) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogUnmaskedIpsEnabled <- value)
            state : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#log_unmasked_ips_enabled-1">IotSecuritySolution#log_unmasked_ips_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_unmasked_ips_enabled">]
        member _.LogUnmaskedIpsEnabled(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogUnmaskedIpsEnabled <- value)
            state : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#query_for_resources-1">IotSecuritySolution#query_for_resources</a>.
        /// </summary>
        [<CustomOperation "query_for_resources">]
        member _.QueryForResources(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: string) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.QueryForResources <- value)
            state : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#query_subscription_ids-1">IotSecuritySolution#query_subscription_ids</a>.
        /// </summary>
        [<CustomOperation "query_subscription_ids">]
        member _.QuerySubscriptionIds(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.QuerySubscriptionIds <- (value |> Seq.toArray))
            state : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// recommendations_enabled block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#recommendations_enabled-1">IotSecuritySolution#recommendations_enabled</a>
        /// </summary>
        [<CustomOperation "recommendations_enabled">]
        member _.RecommendationsEnabled(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.IotSecuritySolution.IotSecuritySolutionRecommendationsEnabled) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecommendationsEnabled <- value)
            state : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#tags-1">IotSecuritySolution#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#timeouts-1">IotSecuritySolution#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.IotSecuritySolution.IotSecuritySolutionTimeouts) : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IotSecuritySolutionState<'DisplayName, 'IothubIds, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: IotSecuritySolutionState<Present, Present, Present, Present, Present>) : azurerm.IotSecuritySolution.IotSecuritySolution =
            let config = azurerm.IotSecuritySolution.IotSecuritySolutionConfig()
            for setter in state.assignments do
                setter config
            azurerm.IotSecuritySolution.IotSecuritySolution(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iotSecuritySolution: missing required arguments. Must call: display_name, iothub_ids, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: IotSecuritySolutionState<_, _, _, _, _>) : azurerm.IotSecuritySolution.IotSecuritySolution =
            Unchecked.defaultof<azurerm.IotSecuritySolution.IotSecuritySolution>
