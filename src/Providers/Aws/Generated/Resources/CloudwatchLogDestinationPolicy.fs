namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogDestinationPolicyState<'AccessPolicy, 'DestinationName> = { assignments: ResizeArray<aws.CloudwatchLogDestinationPolicy.CloudwatchLogDestinationPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_destination_policy">aws_cloudwatch_log_destination_policy</a>.
    /// </summary>
    type CloudwatchLogDestinationPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogDestinationPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogDestinationPolicyState<Missing, Missing>)

        member _.Zero(()) : CloudwatchLogDestinationPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogDestinationPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_destination_policy#access_policy-1">CloudwatchLogDestinationPolicy#access_policy</a>.
        /// </summary>
        [<CustomOperation "access_policy">]
        member _.AccessPolicy(state: CloudwatchLogDestinationPolicyState<Missing, 'DestinationName>, value: string) : CloudwatchLogDestinationPolicyState<Present, 'DestinationName> =
            state.assignments.Add(fun config -> config.AccessPolicy <- value)
            ({ assignments = state.assignments } : CloudwatchLogDestinationPolicyState<Present, 'DestinationName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_destination_policy#destination_name-1">CloudwatchLogDestinationPolicy#destination_name</a>.
        /// </summary>
        [<CustomOperation "destination_name">]
        member _.DestinationName(state: CloudwatchLogDestinationPolicyState<'AccessPolicy, Missing>, value: string) : CloudwatchLogDestinationPolicyState<'AccessPolicy, Present> =
            state.assignments.Add(fun config -> config.DestinationName <- value)
            ({ assignments = state.assignments } : CloudwatchLogDestinationPolicyState<'AccessPolicy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_destination_policy#force_update-1">CloudwatchLogDestinationPolicy#force_update</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_update">]
        member _.ForceUpdate(state: CloudwatchLogDestinationPolicyState<'AccessPolicy, 'DestinationName>, value: bool) : CloudwatchLogDestinationPolicyState<'AccessPolicy, 'DestinationName> =
            state.assignments.Add(fun config -> config.ForceUpdate <- value)
            state : CloudwatchLogDestinationPolicyState<'AccessPolicy, 'DestinationName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_destination_policy#force_update-1">CloudwatchLogDestinationPolicy#force_update</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_update">]
        member _.ForceUpdate(state: CloudwatchLogDestinationPolicyState<'AccessPolicy, 'DestinationName>, value: HashiCorp.Cdktf.IResolvable) : CloudwatchLogDestinationPolicyState<'AccessPolicy, 'DestinationName> =
            state.assignments.Add(fun config -> config.ForceUpdate <- value)
            state : CloudwatchLogDestinationPolicyState<'AccessPolicy, 'DestinationName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_destination_policy#id-1">CloudwatchLogDestinationPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchLogDestinationPolicyState<'AccessPolicy, 'DestinationName>, value: string) : CloudwatchLogDestinationPolicyState<'AccessPolicy, 'DestinationName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchLogDestinationPolicyState<'AccessPolicy, 'DestinationName>

        member _.Run(state: CloudwatchLogDestinationPolicyState<Present, Present>) : aws.CloudwatchLogDestinationPolicy.CloudwatchLogDestinationPolicy =
            let config = aws.CloudwatchLogDestinationPolicy.CloudwatchLogDestinationPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogDestinationPolicy.CloudwatchLogDestinationPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchLogDestinationPolicy: missing required arguments. Must call: access_policy, destination_name.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchLogDestinationPolicyState<_, _>) : aws.CloudwatchLogDestinationPolicy.CloudwatchLogDestinationPolicy =
            Unchecked.defaultof<aws.CloudwatchLogDestinationPolicy.CloudwatchLogDestinationPolicy>
