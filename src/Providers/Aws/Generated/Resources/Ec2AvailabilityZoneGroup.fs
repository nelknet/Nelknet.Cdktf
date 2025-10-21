namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2AvailabilityZoneGroupState<'GroupName, 'OptInStatus> = { assignments: ResizeArray<aws.Ec2AvailabilityZoneGroup.Ec2AvailabilityZoneGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_availability_zone_group">aws_ec2_availability_zone_group</a>.
    /// </summary>
    type Ec2AvailabilityZoneGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2AvailabilityZoneGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2AvailabilityZoneGroupState<Missing, Missing>)

        member _.Zero(()) : Ec2AvailabilityZoneGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2AvailabilityZoneGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_availability_zone_group#group_name-1">Ec2AvailabilityZoneGroup#group_name</a>.
        /// </summary>
        [<CustomOperation "group_name">]
        member _.GroupName(state: Ec2AvailabilityZoneGroupState<Missing, 'OptInStatus>, value: string) : Ec2AvailabilityZoneGroupState<Present, 'OptInStatus> =
            state.assignments.Add(fun config -> config.GroupName <- value)
            ({ assignments = state.assignments } : Ec2AvailabilityZoneGroupState<Present, 'OptInStatus>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_availability_zone_group#opt_in_status-1">Ec2AvailabilityZoneGroup#opt_in_status</a>.
        /// </summary>
        [<CustomOperation "opt_in_status">]
        member _.OptInStatus(state: Ec2AvailabilityZoneGroupState<'GroupName, Missing>, value: string) : Ec2AvailabilityZoneGroupState<'GroupName, Present> =
            state.assignments.Add(fun config -> config.OptInStatus <- value)
            ({ assignments = state.assignments } : Ec2AvailabilityZoneGroupState<'GroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_availability_zone_group#id-1">Ec2AvailabilityZoneGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2AvailabilityZoneGroupState<'GroupName, 'OptInStatus>, value: string) : Ec2AvailabilityZoneGroupState<'GroupName, 'OptInStatus> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2AvailabilityZoneGroupState<'GroupName, 'OptInStatus>

        member _.Run(state: Ec2AvailabilityZoneGroupState<Present, Present>) : aws.Ec2AvailabilityZoneGroup.Ec2AvailabilityZoneGroup =
            let config = aws.Ec2AvailabilityZoneGroup.Ec2AvailabilityZoneGroupConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2AvailabilityZoneGroup.Ec2AvailabilityZoneGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2AvailabilityZoneGroup: missing required arguments. Must call: group_name, opt_in_status.", 9999, IsError = true)>]
        member _.Run(_: Ec2AvailabilityZoneGroupState<_, _>) : aws.Ec2AvailabilityZoneGroup.Ec2AvailabilityZoneGroup =
            Unchecked.defaultof<aws.Ec2AvailabilityZoneGroup.Ec2AvailabilityZoneGroup>
