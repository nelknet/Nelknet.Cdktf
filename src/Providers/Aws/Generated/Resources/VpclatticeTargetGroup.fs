namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpclatticeTargetGroupState<'Name, 'Type> = { assignments: ResizeArray<aws.VpclatticeTargetGroup.VpclatticeTargetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group">aws_vpclattice_target_group</a>.
    /// </summary>
    type VpclatticeTargetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpclatticeTargetGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeTargetGroupState<Missing, Missing>)

        member _.Zero(()) : VpclatticeTargetGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeTargetGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#name-1">VpclatticeTargetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VpclatticeTargetGroupState<Missing, 'Type>, value: string) : VpclatticeTargetGroupState<Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VpclatticeTargetGroupState<Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#type-1">VpclatticeTargetGroup#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: VpclatticeTargetGroupState<'Name, Missing>, value: string) : VpclatticeTargetGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : VpclatticeTargetGroupState<'Name, Present>)

        /// <summary>
        /// config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#config-1">VpclatticeTargetGroup#config</a>
        /// </summary>
        [<CustomOperation "config">]
        member _.Config(state: VpclatticeTargetGroupState<'Name, 'Type>, value: aws.VpclatticeTargetGroup.VpclatticeTargetGroupConfigA) : VpclatticeTargetGroupState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Config <- value)
            state : VpclatticeTargetGroupState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#id-1">VpclatticeTargetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpclatticeTargetGroupState<'Name, 'Type>, value: string) : VpclatticeTargetGroupState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpclatticeTargetGroupState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#tags-1">VpclatticeTargetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpclatticeTargetGroupState<'Name, 'Type>, value: seq<string * string>) : VpclatticeTargetGroupState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpclatticeTargetGroupState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#tags_all-1">VpclatticeTargetGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpclatticeTargetGroupState<'Name, 'Type>, value: seq<string * string>) : VpclatticeTargetGroupState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpclatticeTargetGroupState<'Name, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#timeouts-1">VpclatticeTargetGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpclatticeTargetGroupState<'Name, 'Type>, value: aws.VpclatticeTargetGroup.VpclatticeTargetGroupTimeouts) : VpclatticeTargetGroupState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpclatticeTargetGroupState<'Name, 'Type>

        member _.Run(state: VpclatticeTargetGroupState<Present, Present>) : aws.VpclatticeTargetGroup.VpclatticeTargetGroup =
            let config = aws.VpclatticeTargetGroup.VpclatticeTargetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.VpclatticeTargetGroup.VpclatticeTargetGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpclatticeTargetGroup: missing required arguments. Must call: name, type.", 9999, IsError = true)>]
        member _.Run(_: VpclatticeTargetGroupState<_, _>) : aws.VpclatticeTargetGroup.VpclatticeTargetGroup =
            Unchecked.defaultof<aws.VpclatticeTargetGroup.VpclatticeTargetGroup>
