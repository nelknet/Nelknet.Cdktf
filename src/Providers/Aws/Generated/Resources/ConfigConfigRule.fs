namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConfigConfigRuleState<'Name, 'Source> = { assignments: ResizeArray<aws.ConfigConfigRule.ConfigConfigRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule">aws_config_config_rule</a>.
    /// </summary>
    type ConfigConfigRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConfigConfigRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConfigConfigRuleState<Missing, Missing>)

        member _.Zero(()) : ConfigConfigRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConfigConfigRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#name-1">ConfigConfigRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConfigConfigRuleState<Missing, 'Source>, value: string) : ConfigConfigRuleState<Present, 'Source> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConfigConfigRuleState<Present, 'Source>)

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#source-1">ConfigConfigRule#source</a>
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: ConfigConfigRuleState<'Name, Missing>, value: aws.ConfigConfigRule.ConfigConfigRuleSource) : ConfigConfigRuleState<'Name, Present> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : ConfigConfigRuleState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#description-1">ConfigConfigRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ConfigConfigRuleState<'Name, 'Source>, value: string) : ConfigConfigRuleState<'Name, 'Source> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ConfigConfigRuleState<'Name, 'Source>

        /// <summary>
        /// evaluation_mode block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#evaluation_mode-1">ConfigConfigRule#evaluation_mode</a> Accepts: aws.IResolvable | aws.ConfigConfigRule.ConfigConfigRuleEvaluationMode[]
        /// </summary>
        [<CustomOperation "evaluation_mode">]
        member _.EvaluationMode(state: ConfigConfigRuleState<'Name, 'Source>, value: HashiCorp.Cdktf.IResolvable) : ConfigConfigRuleState<'Name, 'Source> =
            state.assignments.Add(fun config -> config.EvaluationMode <- value)
            state : ConfigConfigRuleState<'Name, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#id-1">ConfigConfigRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConfigConfigRuleState<'Name, 'Source>, value: string) : ConfigConfigRuleState<'Name, 'Source> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConfigConfigRuleState<'Name, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#input_parameters-1">ConfigConfigRule#input_parameters</a>.
        /// </summary>
        [<CustomOperation "input_parameters">]
        member _.InputParameters(state: ConfigConfigRuleState<'Name, 'Source>, value: string) : ConfigConfigRuleState<'Name, 'Source> =
            state.assignments.Add(fun config -> config.InputParameters <- value)
            state : ConfigConfigRuleState<'Name, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#maximum_execution_frequency-1">ConfigConfigRule#maximum_execution_frequency</a>.
        /// </summary>
        [<CustomOperation "maximum_execution_frequency">]
        member _.MaximumExecutionFrequency(state: ConfigConfigRuleState<'Name, 'Source>, value: string) : ConfigConfigRuleState<'Name, 'Source> =
            state.assignments.Add(fun config -> config.MaximumExecutionFrequency <- value)
            state : ConfigConfigRuleState<'Name, 'Source>

        /// <summary>
        /// scope block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#scope-1">ConfigConfigRule#scope</a>
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: ConfigConfigRuleState<'Name, 'Source>, value: aws.ConfigConfigRule.ConfigConfigRuleScope) : ConfigConfigRuleState<'Name, 'Source> =
            state.assignments.Add(fun config -> config.Scope <- value)
            state : ConfigConfigRuleState<'Name, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#tags-1">ConfigConfigRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConfigConfigRuleState<'Name, 'Source>, value: seq<string * string>) : ConfigConfigRuleState<'Name, 'Source> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConfigConfigRuleState<'Name, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#tags_all-1">ConfigConfigRule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConfigConfigRuleState<'Name, 'Source>, value: seq<string * string>) : ConfigConfigRuleState<'Name, 'Source> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConfigConfigRuleState<'Name, 'Source>

        member _.Run(state: ConfigConfigRuleState<Present, Present>) : aws.ConfigConfigRule.ConfigConfigRule =
            let config = aws.ConfigConfigRule.ConfigConfigRuleConfig()
            for setter in state.assignments do
                setter config
            aws.ConfigConfigRule.ConfigConfigRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.configConfigRule: missing required arguments. Must call: name, source.", 9999, IsError = true)>]
        member _.Run(_: ConfigConfigRuleState<_, _>) : aws.ConfigConfigRule.ConfigConfigRule =
            Unchecked.defaultof<aws.ConfigConfigRule.ConfigConfigRule>
