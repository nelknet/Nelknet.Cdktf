namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2LocalGatewayVirtualInterfaceGroupState = { assignments: ResizeArray<aws.DataAwsEc2LocalGatewayVirtualInterfaceGroup.DataAwsEc2LocalGatewayVirtualInterfaceGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface_group">aws_ec2_local_gateway_virtual_interface_group</a>.
    /// </summary>
    type DataAwsEc2LocalGatewayVirtualInterfaceGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2LocalGatewayVirtualInterfaceGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2LocalGatewayVirtualInterfaceGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface_group#filter-1">DataAwsEc2LocalGatewayVirtualInterfaceGroup#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2LocalGatewayVirtualInterfaceGroup.DataAwsEc2LocalGatewayVirtualInterfaceGroupFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2LocalGatewayVirtualInterfaceGroupState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2LocalGatewayVirtualInterfaceGroupState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2LocalGatewayVirtualInterfaceGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface_group#id-1">DataAwsEc2LocalGatewayVirtualInterfaceGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2LocalGatewayVirtualInterfaceGroupState, value: string) : DataAwsEc2LocalGatewayVirtualInterfaceGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2LocalGatewayVirtualInterfaceGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface_group#local_gateway_id-1">DataAwsEc2LocalGatewayVirtualInterfaceGroup#local_gateway_id</a>.
        /// </summary>
        [<CustomOperation "local_gateway_id">]
        member _.LocalGatewayId(state: DataAwsEc2LocalGatewayVirtualInterfaceGroupState, value: string) : DataAwsEc2LocalGatewayVirtualInterfaceGroupState =
            state.assignments.Add(fun config -> config.LocalGatewayId <- value)
            state : DataAwsEc2LocalGatewayVirtualInterfaceGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface_group#tags-1">DataAwsEc2LocalGatewayVirtualInterfaceGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2LocalGatewayVirtualInterfaceGroupState, value: seq<string * string>) : DataAwsEc2LocalGatewayVirtualInterfaceGroupState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2LocalGatewayVirtualInterfaceGroupState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface_group#timeouts-1">DataAwsEc2LocalGatewayVirtualInterfaceGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2LocalGatewayVirtualInterfaceGroupState, value: aws.DataAwsEc2LocalGatewayVirtualInterfaceGroup.DataAwsEc2LocalGatewayVirtualInterfaceGroupTimeouts) : DataAwsEc2LocalGatewayVirtualInterfaceGroupState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2LocalGatewayVirtualInterfaceGroupState

        member _.Run(state: DataAwsEc2LocalGatewayVirtualInterfaceGroupState) : aws.DataAwsEc2LocalGatewayVirtualInterfaceGroup.DataAwsEc2LocalGatewayVirtualInterfaceGroup =
            let config = aws.DataAwsEc2LocalGatewayVirtualInterfaceGroup.DataAwsEc2LocalGatewayVirtualInterfaceGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2LocalGatewayVirtualInterfaceGroup.DataAwsEc2LocalGatewayVirtualInterfaceGroup(StackContext.get (), logicalId, config)
