namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotThingGroupMembershipState<'ThingGroupName, 'ThingName> = { assignments: ResizeArray<aws.IotThingGroupMembership.IotThingGroupMembershipConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group_membership">aws_iot_thing_group_membership</a>.
    /// </summary>
    type IotThingGroupMembershipBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotThingGroupMembershipState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotThingGroupMembershipState<Missing, Missing>)

        member _.Zero(()) : IotThingGroupMembershipState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotThingGroupMembershipState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group_membership#thing_group_name-1">IotThingGroupMembership#thing_group_name</a>.
        /// </summary>
        [<CustomOperation "thing_group_name">]
        member _.ThingGroupName(state: IotThingGroupMembershipState<Missing, 'ThingName>, value: string) : IotThingGroupMembershipState<Present, 'ThingName> =
            state.assignments.Add(fun config -> config.ThingGroupName <- value)
            ({ assignments = state.assignments } : IotThingGroupMembershipState<Present, 'ThingName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group_membership#thing_name-1">IotThingGroupMembership#thing_name</a>.
        /// </summary>
        [<CustomOperation "thing_name">]
        member _.ThingName(state: IotThingGroupMembershipState<'ThingGroupName, Missing>, value: string) : IotThingGroupMembershipState<'ThingGroupName, Present> =
            state.assignments.Add(fun config -> config.ThingName <- value)
            ({ assignments = state.assignments } : IotThingGroupMembershipState<'ThingGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group_membership#id-1">IotThingGroupMembership#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotThingGroupMembershipState<'ThingGroupName, 'ThingName>, value: string) : IotThingGroupMembershipState<'ThingGroupName, 'ThingName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotThingGroupMembershipState<'ThingGroupName, 'ThingName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group_membership#override_dynamic_group-1">IotThingGroupMembership#override_dynamic_group</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "override_dynamic_group">]
        member _.OverrideDynamicGroup(state: IotThingGroupMembershipState<'ThingGroupName, 'ThingName>, value: bool) : IotThingGroupMembershipState<'ThingGroupName, 'ThingName> =
            state.assignments.Add(fun config -> config.OverrideDynamicGroup <- value)
            state : IotThingGroupMembershipState<'ThingGroupName, 'ThingName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group_membership#override_dynamic_group-1">IotThingGroupMembership#override_dynamic_group</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "override_dynamic_group">]
        member _.OverrideDynamicGroup(state: IotThingGroupMembershipState<'ThingGroupName, 'ThingName>, value: HashiCorp.Cdktf.IResolvable) : IotThingGroupMembershipState<'ThingGroupName, 'ThingName> =
            state.assignments.Add(fun config -> config.OverrideDynamicGroup <- value)
            state : IotThingGroupMembershipState<'ThingGroupName, 'ThingName>

        member _.Run(state: IotThingGroupMembershipState<Present, Present>) : aws.IotThingGroupMembership.IotThingGroupMembership =
            let config = aws.IotThingGroupMembership.IotThingGroupMembershipConfig()
            for setter in state.assignments do
                setter config
            aws.IotThingGroupMembership.IotThingGroupMembership(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotThingGroupMembership: missing required arguments. Must call: thing_group_name, thing_name.", 9999, IsError = true)>]
        member _.Run(_: IotThingGroupMembershipState<_, _>) : aws.IotThingGroupMembership.IotThingGroupMembership =
            Unchecked.defaultof<aws.IotThingGroupMembership.IotThingGroupMembership>
