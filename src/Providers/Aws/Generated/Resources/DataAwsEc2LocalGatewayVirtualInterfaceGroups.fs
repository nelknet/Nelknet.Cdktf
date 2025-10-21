namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2LocalGatewayVirtualInterfaceGroupsState = { assignments: ResizeArray<aws.DataAwsEc2LocalGatewayVirtualInterfaceGroups.DataAwsEc2LocalGatewayVirtualInterfaceGroupsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface_groups">aws_ec2_local_gateway_virtual_interface_groups</a>.
    /// </summary>
    type DataAwsEc2LocalGatewayVirtualInterfaceGroupsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2LocalGatewayVirtualInterfaceGroupsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2LocalGatewayVirtualInterfaceGroupsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface_groups#filter-1">DataAwsEc2LocalGatewayVirtualInterfaceGroups#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2LocalGatewayVirtualInterfaceGroups.DataAwsEc2LocalGatewayVirtualInterfaceGroupsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2LocalGatewayVirtualInterfaceGroupsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2LocalGatewayVirtualInterfaceGroupsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2LocalGatewayVirtualInterfaceGroupsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface_groups#id-1">DataAwsEc2LocalGatewayVirtualInterfaceGroups#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2LocalGatewayVirtualInterfaceGroupsState, value: string) : DataAwsEc2LocalGatewayVirtualInterfaceGroupsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2LocalGatewayVirtualInterfaceGroupsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface_groups#tags-1">DataAwsEc2LocalGatewayVirtualInterfaceGroups#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2LocalGatewayVirtualInterfaceGroupsState, value: seq<string * string>) : DataAwsEc2LocalGatewayVirtualInterfaceGroupsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2LocalGatewayVirtualInterfaceGroupsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface_groups#timeouts-1">DataAwsEc2LocalGatewayVirtualInterfaceGroups#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2LocalGatewayVirtualInterfaceGroupsState, value: aws.DataAwsEc2LocalGatewayVirtualInterfaceGroups.DataAwsEc2LocalGatewayVirtualInterfaceGroupsTimeouts) : DataAwsEc2LocalGatewayVirtualInterfaceGroupsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2LocalGatewayVirtualInterfaceGroupsState

        member _.Run(state: DataAwsEc2LocalGatewayVirtualInterfaceGroupsState) : aws.DataAwsEc2LocalGatewayVirtualInterfaceGroups.DataAwsEc2LocalGatewayVirtualInterfaceGroups =
            let config = aws.DataAwsEc2LocalGatewayVirtualInterfaceGroups.DataAwsEc2LocalGatewayVirtualInterfaceGroupsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2LocalGatewayVirtualInterfaceGroups.DataAwsEc2LocalGatewayVirtualInterfaceGroups(StackContext.get (), logicalId, config)
