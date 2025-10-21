namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes> = { assignments: ResizeArray<aws.ConfigOrganizationCustomPolicyRule.ConfigOrganizationCustomPolicyRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule">aws_config_organization_custom_policy_rule</a>.
    /// </summary>
    type ConfigOrganizationCustomPolicyRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConfigOrganizationCustomPolicyRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConfigOrganizationCustomPolicyRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ConfigOrganizationCustomPolicyRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConfigOrganizationCustomPolicyRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#name-1">ConfigOrganizationCustomPolicyRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConfigOrganizationCustomPolicyRuleState<Missing, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>, value: string) : ConfigOrganizationCustomPolicyRuleState<Present, 'PolicyRuntime, 'PolicyText, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConfigOrganizationCustomPolicyRuleState<Present, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#policy_runtime-1">ConfigOrganizationCustomPolicyRule#policy_runtime</a>.
        /// </summary>
        [<CustomOperation "policy_runtime">]
        member _.PolicyRuntime(state: ConfigOrganizationCustomPolicyRuleState<'Name, Missing, 'PolicyText, 'TriggerTypes>, value: string) : ConfigOrganizationCustomPolicyRuleState<'Name, Present, 'PolicyText, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.PolicyRuntime <- value)
            ({ assignments = state.assignments } : ConfigOrganizationCustomPolicyRuleState<'Name, Present, 'PolicyText, 'TriggerTypes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#policy_text-1">ConfigOrganizationCustomPolicyRule#policy_text</a>.
        /// </summary>
        [<CustomOperation "policy_text">]
        member _.PolicyText(state: ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, Missing, 'TriggerTypes>, value: string) : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, Present, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.PolicyText <- value)
            ({ assignments = state.assignments } : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, Present, 'TriggerTypes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#trigger_types-1">ConfigOrganizationCustomPolicyRule#trigger_types</a>.
        /// </summary>
        [<CustomOperation "trigger_types">]
        member _.TriggerTypes(state: ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, Missing>, value: seq<string>) : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, Present> =
            state.assignments.Add(fun config -> config.TriggerTypes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#debug_log_delivery_accounts-1">ConfigOrganizationCustomPolicyRule#debug_log_delivery_accounts</a>.
        /// </summary>
        [<CustomOperation "debug_log_delivery_accounts">]
        member _.DebugLogDeliveryAccounts(state: ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>, value: seq<string>) : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.DebugLogDeliveryAccounts <- (value |> Seq.toArray))
            state : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#description-1">ConfigOrganizationCustomPolicyRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>, value: string) : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#excluded_accounts-1">ConfigOrganizationCustomPolicyRule#excluded_accounts</a>.
        /// </summary>
        [<CustomOperation "excluded_accounts">]
        member _.ExcludedAccounts(state: ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>, value: seq<string>) : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.ExcludedAccounts <- (value |> Seq.toArray))
            state : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#id-1">ConfigOrganizationCustomPolicyRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>, value: string) : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#input_parameters-1">ConfigOrganizationCustomPolicyRule#input_parameters</a>.
        /// </summary>
        [<CustomOperation "input_parameters">]
        member _.InputParameters(state: ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>, value: string) : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.InputParameters <- value)
            state : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#maximum_execution_frequency-1">ConfigOrganizationCustomPolicyRule#maximum_execution_frequency</a>.
        /// </summary>
        [<CustomOperation "maximum_execution_frequency">]
        member _.MaximumExecutionFrequency(state: ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>, value: string) : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.MaximumExecutionFrequency <- value)
            state : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#resource_id_scope-1">ConfigOrganizationCustomPolicyRule#resource_id_scope</a>.
        /// </summary>
        [<CustomOperation "resource_id_scope">]
        member _.ResourceIdScope(state: ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>, value: string) : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.ResourceIdScope <- value)
            state : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#resource_types_scope-1">ConfigOrganizationCustomPolicyRule#resource_types_scope</a>.
        /// </summary>
        [<CustomOperation "resource_types_scope">]
        member _.ResourceTypesScope(state: ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>, value: seq<string>) : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.ResourceTypesScope <- (value |> Seq.toArray))
            state : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#tag_key_scope-1">ConfigOrganizationCustomPolicyRule#tag_key_scope</a>.
        /// </summary>
        [<CustomOperation "tag_key_scope">]
        member _.TagKeyScope(state: ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>, value: string) : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.TagKeyScope <- value)
            state : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#tag_value_scope-1">ConfigOrganizationCustomPolicyRule#tag_value_scope</a>.
        /// </summary>
        [<CustomOperation "tag_value_scope">]
        member _.TagValueScope(state: ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>, value: string) : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.TagValueScope <- value)
            state : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_policy_rule#timeouts-1">ConfigOrganizationCustomPolicyRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>, value: aws.ConfigOrganizationCustomPolicyRule.ConfigOrganizationCustomPolicyRuleTimeouts) : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ConfigOrganizationCustomPolicyRuleState<'Name, 'PolicyRuntime, 'PolicyText, 'TriggerTypes>

        member _.Run(state: ConfigOrganizationCustomPolicyRuleState<Present, Present, Present, Present>) : aws.ConfigOrganizationCustomPolicyRule.ConfigOrganizationCustomPolicyRule =
            let config = aws.ConfigOrganizationCustomPolicyRule.ConfigOrganizationCustomPolicyRuleConfig()
            for setter in state.assignments do
                setter config
            aws.ConfigOrganizationCustomPolicyRule.ConfigOrganizationCustomPolicyRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.configOrganizationCustomPolicyRule: missing required arguments. Must call: name, policy_runtime, policy_text, trigger_types.", 9999, IsError = true)>]
        member _.Run(_: ConfigOrganizationCustomPolicyRuleState<_, _, _, _>) : aws.ConfigOrganizationCustomPolicyRule.ConfigOrganizationCustomPolicyRule =
            Unchecked.defaultof<aws.ConfigOrganizationCustomPolicyRule.ConfigOrganizationCustomPolicyRule>
