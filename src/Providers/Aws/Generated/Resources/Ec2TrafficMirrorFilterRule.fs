namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId> = { assignments: ResizeArray<aws.Ec2TrafficMirrorFilterRule.Ec2TrafficMirrorFilterRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter_rule">aws_ec2_traffic_mirror_filter_rule</a>.
    /// </summary>
    type Ec2TrafficMirrorFilterRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TrafficMirrorFilterRuleState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TrafficMirrorFilterRuleState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Ec2TrafficMirrorFilterRuleState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TrafficMirrorFilterRuleState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter_rule#destination_cidr_block-1">Ec2TrafficMirrorFilterRule#destination_cidr_block</a>.
        /// </summary>
        [<CustomOperation "destination_cidr_block">]
        member _.DestinationCidrBlock(state: Ec2TrafficMirrorFilterRuleState<Missing, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>, value: string) : Ec2TrafficMirrorFilterRuleState<Present, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId> =
            state.assignments.Add(fun config -> config.DestinationCidrBlock <- value)
            ({ assignments = state.assignments } : Ec2TrafficMirrorFilterRuleState<Present, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter_rule#rule_action-1">Ec2TrafficMirrorFilterRule#rule_action</a>.
        /// </summary>
        [<CustomOperation "rule_action">]
        member _.RuleAction(state: Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, Missing, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>, value: string) : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, Present, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId> =
            state.assignments.Add(fun config -> config.RuleAction <- value)
            ({ assignments = state.assignments } : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, Present, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter_rule#rule_number-1">Ec2TrafficMirrorFilterRule#rule_number</a>.
        /// </summary>
        [<CustomOperation "rule_number">]
        member _.RuleNumber(state: Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, Missing, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>, value: double) : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, Present, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId> =
            state.assignments.Add(fun config -> config.RuleNumber <- value)
            ({ assignments = state.assignments } : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, Present, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter_rule#source_cidr_block-1">Ec2TrafficMirrorFilterRule#source_cidr_block</a>.
        /// </summary>
        [<CustomOperation "source_cidr_block">]
        member _.SourceCidrBlock(state: Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, Missing, 'TrafficDirection, 'TrafficMirrorFilterId>, value: string) : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, Present, 'TrafficDirection, 'TrafficMirrorFilterId> =
            state.assignments.Add(fun config -> config.SourceCidrBlock <- value)
            ({ assignments = state.assignments } : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, Present, 'TrafficDirection, 'TrafficMirrorFilterId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter_rule#traffic_direction-1">Ec2TrafficMirrorFilterRule#traffic_direction</a>.
        /// </summary>
        [<CustomOperation "traffic_direction">]
        member _.TrafficDirection(state: Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, Missing, 'TrafficMirrorFilterId>, value: string) : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, Present, 'TrafficMirrorFilterId> =
            state.assignments.Add(fun config -> config.TrafficDirection <- value)
            ({ assignments = state.assignments } : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, Present, 'TrafficMirrorFilterId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter_rule#traffic_mirror_filter_id-1">Ec2TrafficMirrorFilterRule#traffic_mirror_filter_id</a>.
        /// </summary>
        [<CustomOperation "traffic_mirror_filter_id">]
        member _.TrafficMirrorFilterId(state: Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, Missing>, value: string) : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, Present> =
            state.assignments.Add(fun config -> config.TrafficMirrorFilterId <- value)
            ({ assignments = state.assignments } : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter_rule#description-1">Ec2TrafficMirrorFilterRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>, value: string) : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>

        /// <summary>
        /// destination_port_range block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter_rule#destination_port_range-1">Ec2TrafficMirrorFilterRule#destination_port_range</a>
        /// </summary>
        [<CustomOperation "destination_port_range">]
        member _.DestinationPortRange(state: Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>, value: aws.Ec2TrafficMirrorFilterRule.Ec2TrafficMirrorFilterRuleDestinationPortRange) : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId> =
            state.assignments.Add(fun config -> config.DestinationPortRange <- value)
            state : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter_rule#id-1">Ec2TrafficMirrorFilterRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>, value: string) : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter_rule#protocol-1">Ec2TrafficMirrorFilterRule#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>, value: double) : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            state : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>

        /// <summary>
        /// source_port_range block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_traffic_mirror_filter_rule#source_port_range-1">Ec2TrafficMirrorFilterRule#source_port_range</a>
        /// </summary>
        [<CustomOperation "source_port_range">]
        member _.SourcePortRange(state: Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>, value: aws.Ec2TrafficMirrorFilterRule.Ec2TrafficMirrorFilterRuleSourcePortRange) : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId> =
            state.assignments.Add(fun config -> config.SourcePortRange <- value)
            state : Ec2TrafficMirrorFilterRuleState<'DestinationCidrBlock, 'RuleAction, 'RuleNumber, 'SourceCidrBlock, 'TrafficDirection, 'TrafficMirrorFilterId>

        member _.Run(state: Ec2TrafficMirrorFilterRuleState<Present, Present, Present, Present, Present, Present>) : aws.Ec2TrafficMirrorFilterRule.Ec2TrafficMirrorFilterRule =
            let config = aws.Ec2TrafficMirrorFilterRule.Ec2TrafficMirrorFilterRuleConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TrafficMirrorFilterRule.Ec2TrafficMirrorFilterRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TrafficMirrorFilterRule: missing required arguments. Must call: destination_cidr_block, rule_action, rule_number, source_cidr_block, traffic_direction, traffic_mirror_filter_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TrafficMirrorFilterRuleState<_, _, _, _, _, _>) : aws.Ec2TrafficMirrorFilterRule.Ec2TrafficMirrorFilterRule =
            Unchecked.defaultof<aws.Ec2TrafficMirrorFilterRule.Ec2TrafficMirrorFilterRule>
