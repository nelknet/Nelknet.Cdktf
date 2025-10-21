namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes> = { assignments: ResizeArray<aws.ConfigOrganizationCustomRule.ConfigOrganizationCustomRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_rule">aws_config_organization_custom_rule</a>.
    /// </summary>
    type ConfigOrganizationCustomRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConfigOrganizationCustomRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConfigOrganizationCustomRuleState<Missing, Missing, Missing>)

        member _.Zero(()) : ConfigOrganizationCustomRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConfigOrganizationCustomRuleState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_rule#lambda_function_arn-1">ConfigOrganizationCustomRule#lambda_function_arn</a>.
        /// </summary>
        [<CustomOperation "lambda_function_arn">]
        member _.LambdaFunctionArn(state: ConfigOrganizationCustomRuleState<Missing, 'Name, 'TriggerTypes>, value: string) : ConfigOrganizationCustomRuleState<Present, 'Name, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.LambdaFunctionArn <- value)
            ({ assignments = state.assignments } : ConfigOrganizationCustomRuleState<Present, 'Name, 'TriggerTypes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_rule#name-1">ConfigOrganizationCustomRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConfigOrganizationCustomRuleState<'LambdaFunctionArn, Missing, 'TriggerTypes>, value: string) : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, Present, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, Present, 'TriggerTypes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_rule#trigger_types-1">ConfigOrganizationCustomRule#trigger_types</a>.
        /// </summary>
        [<CustomOperation "trigger_types">]
        member _.TriggerTypes(state: ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, Missing>, value: seq<string>) : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, Present> =
            state.assignments.Add(fun config -> config.TriggerTypes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_rule#description-1">ConfigOrganizationCustomRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>, value: string) : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_rule#excluded_accounts-1">ConfigOrganizationCustomRule#excluded_accounts</a>.
        /// </summary>
        [<CustomOperation "excluded_accounts">]
        member _.ExcludedAccounts(state: ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>, value: seq<string>) : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.ExcludedAccounts <- (value |> Seq.toArray))
            state : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_rule#id-1">ConfigOrganizationCustomRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>, value: string) : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_rule#input_parameters-1">ConfigOrganizationCustomRule#input_parameters</a>.
        /// </summary>
        [<CustomOperation "input_parameters">]
        member _.InputParameters(state: ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>, value: string) : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.InputParameters <- value)
            state : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_rule#maximum_execution_frequency-1">ConfigOrganizationCustomRule#maximum_execution_frequency</a>.
        /// </summary>
        [<CustomOperation "maximum_execution_frequency">]
        member _.MaximumExecutionFrequency(state: ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>, value: string) : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.MaximumExecutionFrequency <- value)
            state : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_rule#resource_id_scope-1">ConfigOrganizationCustomRule#resource_id_scope</a>.
        /// </summary>
        [<CustomOperation "resource_id_scope">]
        member _.ResourceIdScope(state: ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>, value: string) : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.ResourceIdScope <- value)
            state : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_rule#resource_types_scope-1">ConfigOrganizationCustomRule#resource_types_scope</a>.
        /// </summary>
        [<CustomOperation "resource_types_scope">]
        member _.ResourceTypesScope(state: ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>, value: seq<string>) : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.ResourceTypesScope <- (value |> Seq.toArray))
            state : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_rule#tag_key_scope-1">ConfigOrganizationCustomRule#tag_key_scope</a>.
        /// </summary>
        [<CustomOperation "tag_key_scope">]
        member _.TagKeyScope(state: ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>, value: string) : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.TagKeyScope <- value)
            state : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_rule#tag_value_scope-1">ConfigOrganizationCustomRule#tag_value_scope</a>.
        /// </summary>
        [<CustomOperation "tag_value_scope">]
        member _.TagValueScope(state: ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>, value: string) : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.TagValueScope <- value)
            state : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_custom_rule#timeouts-1">ConfigOrganizationCustomRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>, value: aws.ConfigOrganizationCustomRule.ConfigOrganizationCustomRuleTimeouts) : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ConfigOrganizationCustomRuleState<'LambdaFunctionArn, 'Name, 'TriggerTypes>

        member _.Run(state: ConfigOrganizationCustomRuleState<Present, Present, Present>) : aws.ConfigOrganizationCustomRule.ConfigOrganizationCustomRule =
            let config = aws.ConfigOrganizationCustomRule.ConfigOrganizationCustomRuleConfig()
            for setter in state.assignments do
                setter config
            aws.ConfigOrganizationCustomRule.ConfigOrganizationCustomRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.configOrganizationCustomRule: missing required arguments. Must call: lambda_function_arn, name, trigger_types.", 9999, IsError = true)>]
        member _.Run(_: ConfigOrganizationCustomRuleState<_, _, _>) : aws.ConfigOrganizationCustomRule.ConfigOrganizationCustomRule =
            Unchecked.defaultof<aws.ConfigOrganizationCustomRule.ConfigOrganizationCustomRule>
