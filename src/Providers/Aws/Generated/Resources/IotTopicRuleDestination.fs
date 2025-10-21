namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotTopicRuleDestinationState<'VpcConfiguration> = { assignments: ResizeArray<aws.IotTopicRuleDestination.IotTopicRuleDestinationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule_destination">aws_iot_topic_rule_destination</a>.
    /// </summary>
    type IotTopicRuleDestinationBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotTopicRuleDestinationState<Missing> =
            ({ assignments = ResizeArray() } : IotTopicRuleDestinationState<Missing>)

        member _.Zero(()) : IotTopicRuleDestinationState<Missing> =
            ({ assignments = ResizeArray() } : IotTopicRuleDestinationState<Missing>)

        /// <summary>
        /// vpc_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule_destination#vpc_configuration-1">IotTopicRuleDestination#vpc_configuration</a>
        /// </summary>
        [<CustomOperation "vpc_configuration">]
        member _.VpcConfiguration(state: IotTopicRuleDestinationState<Missing>, value: aws.IotTopicRuleDestination.IotTopicRuleDestinationVpcConfiguration) : IotTopicRuleDestinationState<Present> =
            state.assignments.Add(fun config -> config.VpcConfiguration <- value)
            ({ assignments = state.assignments } : IotTopicRuleDestinationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule_destination#enabled-1">IotTopicRuleDestination#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: IotTopicRuleDestinationState<'VpcConfiguration>, value: bool) : IotTopicRuleDestinationState<'VpcConfiguration> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : IotTopicRuleDestinationState<'VpcConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule_destination#enabled-1">IotTopicRuleDestination#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: IotTopicRuleDestinationState<'VpcConfiguration>, value: HashiCorp.Cdktf.IResolvable) : IotTopicRuleDestinationState<'VpcConfiguration> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : IotTopicRuleDestinationState<'VpcConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule_destination#id-1">IotTopicRuleDestination#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotTopicRuleDestinationState<'VpcConfiguration>, value: string) : IotTopicRuleDestinationState<'VpcConfiguration> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotTopicRuleDestinationState<'VpcConfiguration>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_topic_rule_destination#timeouts-1">IotTopicRuleDestination#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IotTopicRuleDestinationState<'VpcConfiguration>, value: aws.IotTopicRuleDestination.IotTopicRuleDestinationTimeouts) : IotTopicRuleDestinationState<'VpcConfiguration> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IotTopicRuleDestinationState<'VpcConfiguration>

        member _.Run(state: IotTopicRuleDestinationState<Present>) : aws.IotTopicRuleDestination.IotTopicRuleDestination =
            let config = aws.IotTopicRuleDestination.IotTopicRuleDestinationConfig()
            for setter in state.assignments do
                setter config
            aws.IotTopicRuleDestination.IotTopicRuleDestination(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotTopicRuleDestination: missing required arguments. Must call: vpc_configuration.", 9999, IsError = true)>]
        member _.Run(_: IotTopicRuleDestinationState<_>) : aws.IotTopicRuleDestination.IotTopicRuleDestination =
            Unchecked.defaultof<aws.IotTopicRuleDestination.IotTopicRuleDestination>
