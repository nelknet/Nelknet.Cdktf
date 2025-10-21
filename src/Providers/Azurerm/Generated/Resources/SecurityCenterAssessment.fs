namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityCenterAssessmentState<'AssessmentPolicyId, 'Status, 'TargetResourceId> = { assignments: ResizeArray<azurerm.SecurityCenterAssessment.SecurityCenterAssessmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment">azurerm_security_center_assessment</a>.
    /// </summary>
    type SecurityCenterAssessmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityCenterAssessmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterAssessmentState<Missing, Missing, Missing>)

        member _.Zero(()) : SecurityCenterAssessmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterAssessmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#assessment_policy_id-1">SecurityCenterAssessment#assessment_policy_id</a>.
        /// </summary>
        [<CustomOperation "assessment_policy_id">]
        member _.AssessmentPolicyId(state: SecurityCenterAssessmentState<Missing, 'Status, 'TargetResourceId>, value: string) : SecurityCenterAssessmentState<Present, 'Status, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.AssessmentPolicyId <- value)
            ({ assignments = state.assignments } : SecurityCenterAssessmentState<Present, 'Status, 'TargetResourceId>)

        /// <summary>
        /// status block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#status-1">SecurityCenterAssessment#status</a>
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: SecurityCenterAssessmentState<'AssessmentPolicyId, Missing, 'TargetResourceId>, value: azurerm.SecurityCenterAssessment.SecurityCenterAssessmentStatus) : SecurityCenterAssessmentState<'AssessmentPolicyId, Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Status <- value)
            ({ assignments = state.assignments } : SecurityCenterAssessmentState<'AssessmentPolicyId, Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#target_resource_id-1">SecurityCenterAssessment#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: SecurityCenterAssessmentState<'AssessmentPolicyId, 'Status, Missing>, value: string) : SecurityCenterAssessmentState<'AssessmentPolicyId, 'Status, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : SecurityCenterAssessmentState<'AssessmentPolicyId, 'Status, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#additional_data-1">SecurityCenterAssessment#additional_data</a>.
        /// </summary>
        [<CustomOperation "additional_data">]
        member _.AdditionalData(state: SecurityCenterAssessmentState<'AssessmentPolicyId, 'Status, 'TargetResourceId>, value: seq<string * string>) : SecurityCenterAssessmentState<'AssessmentPolicyId, 'Status, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.AdditionalData <- dict value)
            state : SecurityCenterAssessmentState<'AssessmentPolicyId, 'Status, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#id-1">SecurityCenterAssessment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityCenterAssessmentState<'AssessmentPolicyId, 'Status, 'TargetResourceId>, value: string) : SecurityCenterAssessmentState<'AssessmentPolicyId, 'Status, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityCenterAssessmentState<'AssessmentPolicyId, 'Status, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#timeouts-1">SecurityCenterAssessment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecurityCenterAssessmentState<'AssessmentPolicyId, 'Status, 'TargetResourceId>, value: azurerm.SecurityCenterAssessment.SecurityCenterAssessmentTimeouts) : SecurityCenterAssessmentState<'AssessmentPolicyId, 'Status, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecurityCenterAssessmentState<'AssessmentPolicyId, 'Status, 'TargetResourceId>

        member _.Run(state: SecurityCenterAssessmentState<Present, Present, Present>) : azurerm.SecurityCenterAssessment.SecurityCenterAssessment =
            let config = azurerm.SecurityCenterAssessment.SecurityCenterAssessmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.SecurityCenterAssessment.SecurityCenterAssessment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.securityCenterAssessment: missing required arguments. Must call: assessment_policy_id, status, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: SecurityCenterAssessmentState<_, _, _>) : azurerm.SecurityCenterAssessment.SecurityCenterAssessment =
            Unchecked.defaultof<azurerm.SecurityCenterAssessment.SecurityCenterAssessment>
