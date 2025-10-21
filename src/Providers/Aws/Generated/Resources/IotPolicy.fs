namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotPolicyState<'Name, 'Policy> = { assignments: ResizeArray<aws.IotPolicy.IotPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_policy">aws_iot_policy</a>.
    /// </summary>
    type IotPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotPolicyState<Missing, Missing>)

        member _.Zero(()) : IotPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_policy#name-1">IotPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IotPolicyState<Missing, 'Policy>, value: string) : IotPolicyState<Present, 'Policy> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IotPolicyState<Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_policy#policy-1">IotPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: IotPolicyState<'Name, Missing>, value: string) : IotPolicyState<'Name, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : IotPolicyState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_policy#id-1">IotPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotPolicyState<'Name, 'Policy>, value: string) : IotPolicyState<'Name, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotPolicyState<'Name, 'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_policy#tags-1">IotPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IotPolicyState<'Name, 'Policy>, value: seq<string * string>) : IotPolicyState<'Name, 'Policy> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IotPolicyState<'Name, 'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_policy#tags_all-1">IotPolicy#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IotPolicyState<'Name, 'Policy>, value: seq<string * string>) : IotPolicyState<'Name, 'Policy> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IotPolicyState<'Name, 'Policy>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_policy#timeouts-1">IotPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IotPolicyState<'Name, 'Policy>, value: aws.IotPolicy.IotPolicyTimeouts) : IotPolicyState<'Name, 'Policy> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IotPolicyState<'Name, 'Policy>

        member _.Run(state: IotPolicyState<Present, Present>) : aws.IotPolicy.IotPolicy =
            let config = aws.IotPolicy.IotPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.IotPolicy.IotPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotPolicy: missing required arguments. Must call: name, policy.", 9999, IsError = true)>]
        member _.Run(_: IotPolicyState<_, _>) : aws.IotPolicy.IotPolicy =
            Unchecked.defaultof<aws.IotPolicy.IotPolicy>
