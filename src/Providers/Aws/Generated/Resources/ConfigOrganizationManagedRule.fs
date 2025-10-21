namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier> = { assignments: ResizeArray<aws.ConfigOrganizationManagedRule.ConfigOrganizationManagedRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_managed_rule">aws_config_organization_managed_rule</a>.
    /// </summary>
    type ConfigOrganizationManagedRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConfigOrganizationManagedRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConfigOrganizationManagedRuleState<Missing, Missing>)

        member _.Zero(()) : ConfigOrganizationManagedRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConfigOrganizationManagedRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_managed_rule#name-1">ConfigOrganizationManagedRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConfigOrganizationManagedRuleState<Missing, 'RuleIdentifier>, value: string) : ConfigOrganizationManagedRuleState<Present, 'RuleIdentifier> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConfigOrganizationManagedRuleState<Present, 'RuleIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_managed_rule#rule_identifier-1">ConfigOrganizationManagedRule#rule_identifier</a>.
        /// </summary>
        [<CustomOperation "rule_identifier">]
        member _.RuleIdentifier(state: ConfigOrganizationManagedRuleState<'Name, Missing>, value: string) : ConfigOrganizationManagedRuleState<'Name, Present> =
            state.assignments.Add(fun config -> config.RuleIdentifier <- value)
            ({ assignments = state.assignments } : ConfigOrganizationManagedRuleState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_managed_rule#description-1">ConfigOrganizationManagedRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>, value: string) : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_managed_rule#excluded_accounts-1">ConfigOrganizationManagedRule#excluded_accounts</a>.
        /// </summary>
        [<CustomOperation "excluded_accounts">]
        member _.ExcludedAccounts(state: ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>, value: seq<string>) : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier> =
            state.assignments.Add(fun config -> config.ExcludedAccounts <- (value |> Seq.toArray))
            state : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_managed_rule#id-1">ConfigOrganizationManagedRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>, value: string) : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_managed_rule#input_parameters-1">ConfigOrganizationManagedRule#input_parameters</a>.
        /// </summary>
        [<CustomOperation "input_parameters">]
        member _.InputParameters(state: ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>, value: string) : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier> =
            state.assignments.Add(fun config -> config.InputParameters <- value)
            state : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_managed_rule#maximum_execution_frequency-1">ConfigOrganizationManagedRule#maximum_execution_frequency</a>.
        /// </summary>
        [<CustomOperation "maximum_execution_frequency">]
        member _.MaximumExecutionFrequency(state: ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>, value: string) : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier> =
            state.assignments.Add(fun config -> config.MaximumExecutionFrequency <- value)
            state : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_managed_rule#resource_id_scope-1">ConfigOrganizationManagedRule#resource_id_scope</a>.
        /// </summary>
        [<CustomOperation "resource_id_scope">]
        member _.ResourceIdScope(state: ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>, value: string) : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier> =
            state.assignments.Add(fun config -> config.ResourceIdScope <- value)
            state : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_managed_rule#resource_types_scope-1">ConfigOrganizationManagedRule#resource_types_scope</a>.
        /// </summary>
        [<CustomOperation "resource_types_scope">]
        member _.ResourceTypesScope(state: ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>, value: seq<string>) : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier> =
            state.assignments.Add(fun config -> config.ResourceTypesScope <- (value |> Seq.toArray))
            state : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_managed_rule#tag_key_scope-1">ConfigOrganizationManagedRule#tag_key_scope</a>.
        /// </summary>
        [<CustomOperation "tag_key_scope">]
        member _.TagKeyScope(state: ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>, value: string) : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier> =
            state.assignments.Add(fun config -> config.TagKeyScope <- value)
            state : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_managed_rule#tag_value_scope-1">ConfigOrganizationManagedRule#tag_value_scope</a>.
        /// </summary>
        [<CustomOperation "tag_value_scope">]
        member _.TagValueScope(state: ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>, value: string) : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier> =
            state.assignments.Add(fun config -> config.TagValueScope <- value)
            state : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_managed_rule#timeouts-1">ConfigOrganizationManagedRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>, value: aws.ConfigOrganizationManagedRule.ConfigOrganizationManagedRuleTimeouts) : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ConfigOrganizationManagedRuleState<'Name, 'RuleIdentifier>

        member _.Run(state: ConfigOrganizationManagedRuleState<Present, Present>) : aws.ConfigOrganizationManagedRule.ConfigOrganizationManagedRule =
            let config = aws.ConfigOrganizationManagedRule.ConfigOrganizationManagedRuleConfig()
            for setter in state.assignments do
                setter config
            aws.ConfigOrganizationManagedRule.ConfigOrganizationManagedRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.configOrganizationManagedRule: missing required arguments. Must call: name, rule_identifier.", 9999, IsError = true)>]
        member _.Run(_: ConfigOrganizationManagedRuleState<_, _>) : aws.ConfigOrganizationManagedRule.ConfigOrganizationManagedRule =
            Unchecked.defaultof<aws.ConfigOrganizationManagedRule.ConfigOrganizationManagedRule>
