namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name> = { assignments: ResizeArray<azurerm.ApplicationInsightsSmartDetectionRule.ApplicationInsightsSmartDetectionRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_smart_detection_rule">azurerm_application_insights_smart_detection_rule</a>.
    /// </summary>
    type ApplicationInsightsSmartDetectionRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApplicationInsightsSmartDetectionRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsSmartDetectionRuleState<Missing, Missing>)

        member _.Zero(()) : ApplicationInsightsSmartDetectionRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsSmartDetectionRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_smart_detection_rule#application_insights_id-1">ApplicationInsightsSmartDetectionRule#application_insights_id</a>.
        /// </summary>
        [<CustomOperation "application_insights_id">]
        member _.ApplicationInsightsId(state: ApplicationInsightsSmartDetectionRuleState<Missing, 'Name>, value: string) : ApplicationInsightsSmartDetectionRuleState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ApplicationInsightsId <- value)
            ({ assignments = state.assignments } : ApplicationInsightsSmartDetectionRuleState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_smart_detection_rule#name-1">ApplicationInsightsSmartDetectionRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, Missing>, value: string) : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_smart_detection_rule#additional_email_recipients-1">ApplicationInsightsSmartDetectionRule#additional_email_recipients</a>.
        /// </summary>
        [<CustomOperation "additional_email_recipients">]
        member _.AdditionalEmailRecipients(state: ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name>, value: seq<string>) : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalEmailRecipients <- (value |> Seq.toArray))
            state : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_smart_detection_rule#enabled-1">ApplicationInsightsSmartDetectionRule#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name>, value: bool) : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_smart_detection_rule#enabled-1">ApplicationInsightsSmartDetectionRule#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_smart_detection_rule#id-1">ApplicationInsightsSmartDetectionRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name>, value: string) : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_smart_detection_rule#send_emails_to_subscription_owners-1">ApplicationInsightsSmartDetectionRule#send_emails_to_subscription_owners</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send_emails_to_subscription_owners">]
        member _.SendEmailsToSubscriptionOwners(state: ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name>, value: bool) : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name> =
            state.assignments.Add(fun config -> config.SendEmailsToSubscriptionOwners <- value)
            state : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_smart_detection_rule#send_emails_to_subscription_owners-1">ApplicationInsightsSmartDetectionRule#send_emails_to_subscription_owners</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send_emails_to_subscription_owners">]
        member _.SendEmailsToSubscriptionOwners(state: ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name> =
            state.assignments.Add(fun config -> config.SendEmailsToSubscriptionOwners <- value)
            state : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_smart_detection_rule#timeouts-1">ApplicationInsightsSmartDetectionRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name>, value: azurerm.ApplicationInsightsSmartDetectionRule.ApplicationInsightsSmartDetectionRuleTimeouts) : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApplicationInsightsSmartDetectionRuleState<'ApplicationInsightsId, 'Name>

        member _.Run(state: ApplicationInsightsSmartDetectionRuleState<Present, Present>) : azurerm.ApplicationInsightsSmartDetectionRule.ApplicationInsightsSmartDetectionRule =
            let config = azurerm.ApplicationInsightsSmartDetectionRule.ApplicationInsightsSmartDetectionRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApplicationInsightsSmartDetectionRule.ApplicationInsightsSmartDetectionRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.applicationInsightsSmartDetectionRule: missing required arguments. Must call: application_insights_id, name.", 9999, IsError = true)>]
        member _.Run(_: ApplicationInsightsSmartDetectionRuleState<_, _>) : azurerm.ApplicationInsightsSmartDetectionRule.ApplicationInsightsSmartDetectionRule =
            Unchecked.defaultof<azurerm.ApplicationInsightsSmartDetectionRule.ApplicationInsightsSmartDetectionRule>
