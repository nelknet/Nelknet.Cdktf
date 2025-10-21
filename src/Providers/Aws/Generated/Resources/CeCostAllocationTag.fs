namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CeCostAllocationTagState<'Status, 'TagKey> = { assignments: ResizeArray<aws.CeCostAllocationTag.CeCostAllocationTagConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_allocation_tag">aws_ce_cost_allocation_tag</a>.
    /// </summary>
    type CeCostAllocationTagBuilder(logicalId: string) =
        member _.Yield(_: unit) : CeCostAllocationTagState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CeCostAllocationTagState<Missing, Missing>)

        member _.Zero(()) : CeCostAllocationTagState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CeCostAllocationTagState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_allocation_tag#status-1">CeCostAllocationTag#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: CeCostAllocationTagState<Missing, 'TagKey>, value: string) : CeCostAllocationTagState<Present, 'TagKey> =
            state.assignments.Add(fun config -> config.Status <- value)
            ({ assignments = state.assignments } : CeCostAllocationTagState<Present, 'TagKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_allocation_tag#tag_key-1">CeCostAllocationTag#tag_key</a>.
        /// </summary>
        [<CustomOperation "tag_key">]
        member _.TagKey(state: CeCostAllocationTagState<'Status, Missing>, value: string) : CeCostAllocationTagState<'Status, Present> =
            state.assignments.Add(fun config -> config.TagKey <- value)
            ({ assignments = state.assignments } : CeCostAllocationTagState<'Status, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_allocation_tag#id-1">CeCostAllocationTag#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CeCostAllocationTagState<'Status, 'TagKey>, value: string) : CeCostAllocationTagState<'Status, 'TagKey> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CeCostAllocationTagState<'Status, 'TagKey>

        member _.Run(state: CeCostAllocationTagState<Present, Present>) : aws.CeCostAllocationTag.CeCostAllocationTag =
            let config = aws.CeCostAllocationTag.CeCostAllocationTagConfig()
            for setter in state.assignments do
                setter config
            aws.CeCostAllocationTag.CeCostAllocationTag(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ceCostAllocationTag: missing required arguments. Must call: status, tag_key.", 9999, IsError = true)>]
        member _.Run(_: CeCostAllocationTagState<_, _>) : aws.CeCostAllocationTag.CeCostAllocationTag =
            Unchecked.defaultof<aws.CeCostAllocationTag.CeCostAllocationTag>
