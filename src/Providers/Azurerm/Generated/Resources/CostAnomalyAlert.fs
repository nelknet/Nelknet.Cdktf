namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, 'Name> = { assignments: ResizeArray<azurerm.CostAnomalyAlert.CostAnomalyAlertConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_anomaly_alert">azurerm_cost_anomaly_alert</a>.
    /// </summary>
    type CostAnomalyAlertBuilder(logicalId: string) =
        member _.Yield(_: unit) : CostAnomalyAlertState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CostAnomalyAlertState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CostAnomalyAlertState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CostAnomalyAlertState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_anomaly_alert#display_name-1">CostAnomalyAlert#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: CostAnomalyAlertState<Missing, 'EmailAddresses, 'EmailSubject, 'Name>, value: string) : CostAnomalyAlertState<Present, 'EmailAddresses, 'EmailSubject, 'Name> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : CostAnomalyAlertState<Present, 'EmailAddresses, 'EmailSubject, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_anomaly_alert#email_addresses-1">CostAnomalyAlert#email_addresses</a>.
        /// </summary>
        [<CustomOperation "email_addresses">]
        member _.EmailAddresses(state: CostAnomalyAlertState<'DisplayName, Missing, 'EmailSubject, 'Name>, value: seq<string>) : CostAnomalyAlertState<'DisplayName, Present, 'EmailSubject, 'Name> =
            state.assignments.Add(fun config -> config.EmailAddresses <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CostAnomalyAlertState<'DisplayName, Present, 'EmailSubject, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_anomaly_alert#email_subject-1">CostAnomalyAlert#email_subject</a>.
        /// </summary>
        [<CustomOperation "email_subject">]
        member _.EmailSubject(state: CostAnomalyAlertState<'DisplayName, 'EmailAddresses, Missing, 'Name>, value: string) : CostAnomalyAlertState<'DisplayName, 'EmailAddresses, Present, 'Name> =
            state.assignments.Add(fun config -> config.EmailSubject <- value)
            ({ assignments = state.assignments } : CostAnomalyAlertState<'DisplayName, 'EmailAddresses, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_anomaly_alert#name-1">CostAnomalyAlert#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, Missing>, value: string) : CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_anomaly_alert#id-1">CostAnomalyAlert#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, 'Name>, value: string) : CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_anomaly_alert#message-1">CostAnomalyAlert#message</a>.
        /// </summary>
        [<CustomOperation "message">]
        member _.Message(state: CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, 'Name>, value: string) : CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, 'Name> =
            state.assignments.Add(fun config -> config.Message <- value)
            state : CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_anomaly_alert#subscription_id-1">CostAnomalyAlert#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, 'Name>, value: string) : CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, 'Name> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            state : CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_anomaly_alert#timeouts-1">CostAnomalyAlert#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, 'Name>, value: azurerm.CostAnomalyAlert.CostAnomalyAlertTimeouts) : CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CostAnomalyAlertState<'DisplayName, 'EmailAddresses, 'EmailSubject, 'Name>

        member _.Run(state: CostAnomalyAlertState<Present, Present, Present, Present>) : azurerm.CostAnomalyAlert.CostAnomalyAlert =
            let config = azurerm.CostAnomalyAlert.CostAnomalyAlertConfig()
            for setter in state.assignments do
                setter config
            azurerm.CostAnomalyAlert.CostAnomalyAlert(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.costAnomalyAlert: missing required arguments. Must call: display_name, email_addresses, email_subject, name.", 9999, IsError = true)>]
        member _.Run(_: CostAnomalyAlertState<_, _, _, _>) : azurerm.CostAnomalyAlert.CostAnomalyAlert =
            Unchecked.defaultof<azurerm.CostAnomalyAlert.CostAnomalyAlert>
