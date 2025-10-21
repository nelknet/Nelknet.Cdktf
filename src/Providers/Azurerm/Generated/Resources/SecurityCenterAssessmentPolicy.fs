namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityCenterAssessmentPolicyState<'Description, 'DisplayName> = { assignments: ResizeArray<azurerm.SecurityCenterAssessmentPolicy.SecurityCenterAssessmentPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment_policy">azurerm_security_center_assessment_policy</a>.
    /// </summary>
    type SecurityCenterAssessmentPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityCenterAssessmentPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterAssessmentPolicyState<Missing, Missing>)

        member _.Zero(()) : SecurityCenterAssessmentPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterAssessmentPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment_policy#description-1">SecurityCenterAssessmentPolicy#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SecurityCenterAssessmentPolicyState<Missing, 'DisplayName>, value: string) : SecurityCenterAssessmentPolicyState<Present, 'DisplayName> =
            state.assignments.Add(fun config -> config.Description <- value)
            ({ assignments = state.assignments } : SecurityCenterAssessmentPolicyState<Present, 'DisplayName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment_policy#display_name-1">SecurityCenterAssessmentPolicy#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SecurityCenterAssessmentPolicyState<'Description, Missing>, value: string) : SecurityCenterAssessmentPolicyState<'Description, Present> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : SecurityCenterAssessmentPolicyState<'Description, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment_policy#categories-1">SecurityCenterAssessmentPolicy#categories</a>.
        /// </summary>
        [<CustomOperation "categories">]
        member _.Categories(state: SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>, value: seq<string>) : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName> =
            state.assignments.Add(fun config -> config.Categories <- (value |> Seq.toArray))
            state : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment_policy#id-1">SecurityCenterAssessmentPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>, value: string) : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment_policy#implementation_effort-1">SecurityCenterAssessmentPolicy#implementation_effort</a>.
        /// </summary>
        [<CustomOperation "implementation_effort">]
        member _.ImplementationEffort(state: SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>, value: string) : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName> =
            state.assignments.Add(fun config -> config.ImplementationEffort <- value)
            state : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment_policy#remediation_description-1">SecurityCenterAssessmentPolicy#remediation_description</a>.
        /// </summary>
        [<CustomOperation "remediation_description">]
        member _.RemediationDescription(state: SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>, value: string) : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName> =
            state.assignments.Add(fun config -> config.RemediationDescription <- value)
            state : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment_policy#severity-1">SecurityCenterAssessmentPolicy#severity</a>.
        /// </summary>
        [<CustomOperation "severity">]
        member _.Severity(state: SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>, value: string) : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName> =
            state.assignments.Add(fun config -> config.Severity <- value)
            state : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment_policy#threats-1">SecurityCenterAssessmentPolicy#threats</a>.
        /// </summary>
        [<CustomOperation "threats">]
        member _.Threats(state: SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>, value: seq<string>) : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName> =
            state.assignments.Add(fun config -> config.Threats <- (value |> Seq.toArray))
            state : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment_policy#timeouts-1">SecurityCenterAssessmentPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>, value: azurerm.SecurityCenterAssessmentPolicy.SecurityCenterAssessmentPolicyTimeouts) : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment_policy#user_impact-1">SecurityCenterAssessmentPolicy#user_impact</a>.
        /// </summary>
        [<CustomOperation "user_impact">]
        member _.UserImpact(state: SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>, value: string) : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName> =
            state.assignments.Add(fun config -> config.UserImpact <- value)
            state : SecurityCenterAssessmentPolicyState<'Description, 'DisplayName>

        member _.Run(state: SecurityCenterAssessmentPolicyState<Present, Present>) : azurerm.SecurityCenterAssessmentPolicy.SecurityCenterAssessmentPolicy =
            let config = azurerm.SecurityCenterAssessmentPolicy.SecurityCenterAssessmentPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.SecurityCenterAssessmentPolicy.SecurityCenterAssessmentPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.securityCenterAssessmentPolicy: missing required arguments. Must call: description, display_name.", 9999, IsError = true)>]
        member _.Run(_: SecurityCenterAssessmentPolicyState<_, _>) : azurerm.SecurityCenterAssessmentPolicy.SecurityCenterAssessmentPolicy =
            Unchecked.defaultof<azurerm.SecurityCenterAssessmentPolicy.SecurityCenterAssessmentPolicy>
