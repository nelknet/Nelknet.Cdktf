namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotBillingGroupState<'Name> = { assignments: ResizeArray<aws.IotBillingGroup.IotBillingGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_billing_group">aws_iot_billing_group</a>.
    /// </summary>
    type IotBillingGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotBillingGroupState<Missing> =
            ({ assignments = ResizeArray() } : IotBillingGroupState<Missing>)

        member _.Zero(()) : IotBillingGroupState<Missing> =
            ({ assignments = ResizeArray() } : IotBillingGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_billing_group#name-1">IotBillingGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IotBillingGroupState<Missing>, value: string) : IotBillingGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IotBillingGroupState<Present>)

        /// <summary>
        /// properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_billing_group#properties-1">IotBillingGroup#properties</a> Accepts: aws.IResolvable | aws.IotBillingGroup.IotBillingGroupProperties[]
        /// </summary>
        [<CustomOperation "properties">]
        member _.Properties(state: IotBillingGroupState<'Name>, value: HashiCorp.Cdktf.IResolvable) : IotBillingGroupState<'Name> =
            state.assignments.Add(fun config -> config.Properties <- value)
            state : IotBillingGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_billing_group#tags-1">IotBillingGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IotBillingGroupState<'Name>, value: seq<string * string>) : IotBillingGroupState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IotBillingGroupState<'Name>

        member _.Run(state: IotBillingGroupState<Present>) : aws.IotBillingGroup.IotBillingGroup =
            let config = aws.IotBillingGroup.IotBillingGroupConfig()
            for setter in state.assignments do
                setter config
            aws.IotBillingGroup.IotBillingGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotBillingGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: IotBillingGroupState<_>) : aws.IotBillingGroup.IotBillingGroup =
            Unchecked.defaultof<aws.IotBillingGroup.IotBillingGroup>
