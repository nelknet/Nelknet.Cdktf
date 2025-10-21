namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TransferTagState<'Key, 'ResourceArn, 'Value> = { assignments: ResizeArray<aws.TransferTag.TransferTagConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_tag">aws_transfer_tag</a>.
    /// </summary>
    type TransferTagBuilder(logicalId: string) =
        member _.Yield(_: unit) : TransferTagState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferTagState<Missing, Missing, Missing>)

        member _.Zero(()) : TransferTagState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferTagState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_tag#key-1">TransferTag#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: TransferTagState<Missing, 'ResourceArn, 'Value>, value: string) : TransferTagState<Present, 'ResourceArn, 'Value> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : TransferTagState<Present, 'ResourceArn, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_tag#resource_arn-1">TransferTag#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: TransferTagState<'Key, Missing, 'Value>, value: string) : TransferTagState<'Key, Present, 'Value> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : TransferTagState<'Key, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_tag#value-1">TransferTag#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: TransferTagState<'Key, 'ResourceArn, Missing>, value: string) : TransferTagState<'Key, 'ResourceArn, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : TransferTagState<'Key, 'ResourceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_tag#id-1">TransferTag#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TransferTagState<'Key, 'ResourceArn, 'Value>, value: string) : TransferTagState<'Key, 'ResourceArn, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TransferTagState<'Key, 'ResourceArn, 'Value>

        member _.Run(state: TransferTagState<Present, Present, Present>) : aws.TransferTag.TransferTag =
            let config = aws.TransferTag.TransferTagConfig()
            for setter in state.assignments do
                setter config
            aws.TransferTag.TransferTag(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.transferTag: missing required arguments. Must call: key, resource_arn, value.", 9999, IsError = true)>]
        member _.Run(_: TransferTagState<_, _, _>) : aws.TransferTag.TransferTag =
            Unchecked.defaultof<aws.TransferTag.TransferTag>
