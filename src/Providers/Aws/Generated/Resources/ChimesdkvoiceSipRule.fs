namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, 'TriggerType, 'TriggerValue> = { assignments: ResizeArray<aws.ChimesdkvoiceSipRule.ChimesdkvoiceSipRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_rule">aws_chimesdkvoice_sip_rule</a>.
    /// </summary>
    type ChimesdkvoiceSipRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChimesdkvoiceSipRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimesdkvoiceSipRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ChimesdkvoiceSipRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimesdkvoiceSipRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_rule#name-1">ChimesdkvoiceSipRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ChimesdkvoiceSipRuleState<Missing, 'TargetApplications, 'TriggerType, 'TriggerValue>, value: string) : ChimesdkvoiceSipRuleState<Present, 'TargetApplications, 'TriggerType, 'TriggerValue> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ChimesdkvoiceSipRuleState<Present, 'TargetApplications, 'TriggerType, 'TriggerValue>)

        /// <summary>
        /// target_applications block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_rule#target_applications-1">ChimesdkvoiceSipRule#target_applications</a> Accepts: aws.IResolvable | aws.ChimesdkvoiceSipRule.ChimesdkvoiceSipRuleTargetApplications[]
        /// </summary>
        [<CustomOperation "target_applications">]
        member _.TargetApplications(state: ChimesdkvoiceSipRuleState<'Name, Missing, 'TriggerType, 'TriggerValue>, value: HashiCorp.Cdktf.IResolvable) : ChimesdkvoiceSipRuleState<'Name, Present, 'TriggerType, 'TriggerValue> =
            state.assignments.Add(fun config -> config.TargetApplications <- value)
            ({ assignments = state.assignments } : ChimesdkvoiceSipRuleState<'Name, Present, 'TriggerType, 'TriggerValue>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_rule#trigger_type-1">ChimesdkvoiceSipRule#trigger_type</a>.
        /// </summary>
        [<CustomOperation "trigger_type">]
        member _.TriggerType(state: ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, Missing, 'TriggerValue>, value: string) : ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, Present, 'TriggerValue> =
            state.assignments.Add(fun config -> config.TriggerType <- value)
            ({ assignments = state.assignments } : ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, Present, 'TriggerValue>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_rule#trigger_value-1">ChimesdkvoiceSipRule#trigger_value</a>.
        /// </summary>
        [<CustomOperation "trigger_value">]
        member _.TriggerValue(state: ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, 'TriggerType, Missing>, value: string) : ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, 'TriggerType, Present> =
            state.assignments.Add(fun config -> config.TriggerValue <- value)
            ({ assignments = state.assignments } : ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, 'TriggerType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_rule#disabled-1">ChimesdkvoiceSipRule#disabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disabled">]
        member _.Disabled(state: ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, 'TriggerType, 'TriggerValue>, value: bool) : ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, 'TriggerType, 'TriggerValue> =
            state.assignments.Add(fun config -> config.Disabled <- value)
            state : ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, 'TriggerType, 'TriggerValue>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_rule#disabled-1">ChimesdkvoiceSipRule#disabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disabled">]
        member _.Disabled(state: ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, 'TriggerType, 'TriggerValue>, value: HashiCorp.Cdktf.IResolvable) : ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, 'TriggerType, 'TriggerValue> =
            state.assignments.Add(fun config -> config.Disabled <- value)
            state : ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, 'TriggerType, 'TriggerValue>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_rule#id-1">ChimesdkvoiceSipRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, 'TriggerType, 'TriggerValue>, value: string) : ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, 'TriggerType, 'TriggerValue> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ChimesdkvoiceSipRuleState<'Name, 'TargetApplications, 'TriggerType, 'TriggerValue>

        member _.Run(state: ChimesdkvoiceSipRuleState<Present, Present, Present, Present>) : aws.ChimesdkvoiceSipRule.ChimesdkvoiceSipRule =
            let config = aws.ChimesdkvoiceSipRule.ChimesdkvoiceSipRuleConfig()
            for setter in state.assignments do
                setter config
            aws.ChimesdkvoiceSipRule.ChimesdkvoiceSipRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.chimesdkvoiceSipRule: missing required arguments. Must call: name, target_applications, trigger_type, trigger_value.", 9999, IsError = true)>]
        member _.Run(_: ChimesdkvoiceSipRuleState<_, _, _, _>) : aws.ChimesdkvoiceSipRule.ChimesdkvoiceSipRule =
            Unchecked.defaultof<aws.ChimesdkvoiceSipRule.ChimesdkvoiceSipRule>
