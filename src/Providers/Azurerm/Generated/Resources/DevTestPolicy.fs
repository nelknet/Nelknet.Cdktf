namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold> = { assignments: ResizeArray<azurerm.DevTestPolicy.DevTestPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_policy">azurerm_dev_test_policy</a>.
    /// </summary>
    type DevTestPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevTestPolicyState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevTestPolicyState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DevTestPolicyState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevTestPolicyState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_policy#evaluator_type-1">DevTestPolicy#evaluator_type</a>.
        /// </summary>
        [<CustomOperation "evaluator_type">]
        member _.EvaluatorType(state: DevTestPolicyState<Missing, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold>, value: string) : DevTestPolicyState<Present, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold> =
            state.assignments.Add(fun config -> config.EvaluatorType <- value)
            ({ assignments = state.assignments } : DevTestPolicyState<Present, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_policy#lab_name-1">DevTestPolicy#lab_name</a>.
        /// </summary>
        [<CustomOperation "lab_name">]
        member _.LabName(state: DevTestPolicyState<'EvaluatorType, Missing, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold>, value: string) : DevTestPolicyState<'EvaluatorType, Present, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold> =
            state.assignments.Add(fun config -> config.LabName <- value)
            ({ assignments = state.assignments } : DevTestPolicyState<'EvaluatorType, Present, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_policy#name-1">DevTestPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevTestPolicyState<'EvaluatorType, 'LabName, Missing, 'PolicySetName, 'ResourceGroupName, 'Threshold>, value: string) : DevTestPolicyState<'EvaluatorType, 'LabName, Present, 'PolicySetName, 'ResourceGroupName, 'Threshold> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevTestPolicyState<'EvaluatorType, 'LabName, Present, 'PolicySetName, 'ResourceGroupName, 'Threshold>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_policy#policy_set_name-1">DevTestPolicy#policy_set_name</a>.
        /// </summary>
        [<CustomOperation "policy_set_name">]
        member _.PolicySetName(state: DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, Missing, 'ResourceGroupName, 'Threshold>, value: string) : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, Present, 'ResourceGroupName, 'Threshold> =
            state.assignments.Add(fun config -> config.PolicySetName <- value)
            ({ assignments = state.assignments } : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, Present, 'ResourceGroupName, 'Threshold>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_policy#resource_group_name-1">DevTestPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, Missing, 'Threshold>, value: string) : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, Present, 'Threshold> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, Present, 'Threshold>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_policy#threshold-1">DevTestPolicy#threshold</a>.
        /// </summary>
        [<CustomOperation "threshold">]
        member _.Threshold(state: DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, Missing>, value: string) : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Threshold <- value)
            ({ assignments = state.assignments } : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_policy#description-1">DevTestPolicy#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold>, value: string) : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_policy#fact_data-1">DevTestPolicy#fact_data</a>.
        /// </summary>
        [<CustomOperation "fact_data">]
        member _.FactData(state: DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold>, value: string) : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold> =
            state.assignments.Add(fun config -> config.FactData <- value)
            state : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_policy#id-1">DevTestPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold>, value: string) : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_policy#tags-1">DevTestPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold>, value: seq<string * string>) : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_policy#timeouts-1">DevTestPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold>, value: azurerm.DevTestPolicy.DevTestPolicyTimeouts) : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevTestPolicyState<'EvaluatorType, 'LabName, 'Name, 'PolicySetName, 'ResourceGroupName, 'Threshold>

        member _.Run(state: DevTestPolicyState<Present, Present, Present, Present, Present, Present>) : azurerm.DevTestPolicy.DevTestPolicy =
            let config = azurerm.DevTestPolicy.DevTestPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevTestPolicy.DevTestPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devTestPolicy: missing required arguments. Must call: evaluator_type, lab_name, name, policy_set_name, resource_group_name, threshold.", 9999, IsError = true)>]
        member _.Run(_: DevTestPolicyState<_, _, _, _, _, _>) : azurerm.DevTestPolicy.DevTestPolicy =
            Unchecked.defaultof<azurerm.DevTestPolicy.DevTestPolicy>
