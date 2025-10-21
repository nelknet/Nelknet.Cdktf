namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId> = { assignments: ResizeArray<aws.ShieldProtectionGroup.ShieldProtectionGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection_group">aws_shield_protection_group</a>.
    /// </summary>
    type ShieldProtectionGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ShieldProtectionGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ShieldProtectionGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : ShieldProtectionGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ShieldProtectionGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection_group#aggregation-1">ShieldProtectionGroup#aggregation</a>.
        /// </summary>
        [<CustomOperation "aggregation">]
        member _.Aggregation(state: ShieldProtectionGroupState<Missing, 'Pattern, 'ProtectionGroupId>, value: string) : ShieldProtectionGroupState<Present, 'Pattern, 'ProtectionGroupId> =
            state.assignments.Add(fun config -> config.Aggregation <- value)
            ({ assignments = state.assignments } : ShieldProtectionGroupState<Present, 'Pattern, 'ProtectionGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection_group#pattern-1">ShieldProtectionGroup#pattern</a>.
        /// </summary>
        [<CustomOperation "pattern">]
        member _.Pattern(state: ShieldProtectionGroupState<'Aggregation, Missing, 'ProtectionGroupId>, value: string) : ShieldProtectionGroupState<'Aggregation, Present, 'ProtectionGroupId> =
            state.assignments.Add(fun config -> config.Pattern <- value)
            ({ assignments = state.assignments } : ShieldProtectionGroupState<'Aggregation, Present, 'ProtectionGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection_group#protection_group_id-1">ShieldProtectionGroup#protection_group_id</a>.
        /// </summary>
        [<CustomOperation "protection_group_id">]
        member _.ProtectionGroupId(state: ShieldProtectionGroupState<'Aggregation, 'Pattern, Missing>, value: string) : ShieldProtectionGroupState<'Aggregation, 'Pattern, Present> =
            state.assignments.Add(fun config -> config.ProtectionGroupId <- value)
            ({ assignments = state.assignments } : ShieldProtectionGroupState<'Aggregation, 'Pattern, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection_group#id-1">ShieldProtectionGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId>, value: string) : ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection_group#members-1">ShieldProtectionGroup#members</a>.
        /// </summary>
        [<CustomOperation "members">]
        member _.Members(state: ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId>, value: seq<string>) : ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId> =
            state.assignments.Add(fun config -> config.Members <- (value |> Seq.toArray))
            state : ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection_group#resource_type-1">ShieldProtectionGroup#resource_type</a>.
        /// </summary>
        [<CustomOperation "resource_type">]
        member _.ResourceType(state: ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId>, value: string) : ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId> =
            state.assignments.Add(fun config -> config.ResourceType <- value)
            state : ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection_group#tags-1">ShieldProtectionGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId>, value: seq<string * string>) : ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection_group#tags_all-1">ShieldProtectionGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId>, value: seq<string * string>) : ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ShieldProtectionGroupState<'Aggregation, 'Pattern, 'ProtectionGroupId>

        member _.Run(state: ShieldProtectionGroupState<Present, Present, Present>) : aws.ShieldProtectionGroup.ShieldProtectionGroup =
            let config = aws.ShieldProtectionGroup.ShieldProtectionGroupConfig()
            for setter in state.assignments do
                setter config
            aws.ShieldProtectionGroup.ShieldProtectionGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.shieldProtectionGroup: missing required arguments. Must call: aggregation, pattern, protection_group_id.", 9999, IsError = true)>]
        member _.Run(_: ShieldProtectionGroupState<_, _, _>) : aws.ShieldProtectionGroup.ShieldProtectionGroup =
            Unchecked.defaultof<aws.ShieldProtectionGroup.ShieldProtectionGroup>
