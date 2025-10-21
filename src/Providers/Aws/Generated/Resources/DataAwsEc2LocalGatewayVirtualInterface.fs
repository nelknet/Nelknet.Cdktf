namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2LocalGatewayVirtualInterfaceState = { assignments: ResizeArray<aws.DataAwsEc2LocalGatewayVirtualInterface.DataAwsEc2LocalGatewayVirtualInterfaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface">aws_ec2_local_gateway_virtual_interface</a>.
    /// </summary>
    type DataAwsEc2LocalGatewayVirtualInterfaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2LocalGatewayVirtualInterfaceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2LocalGatewayVirtualInterfaceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface#filter-1">DataAwsEc2LocalGatewayVirtualInterface#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2LocalGatewayVirtualInterface.DataAwsEc2LocalGatewayVirtualInterfaceFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2LocalGatewayVirtualInterfaceState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2LocalGatewayVirtualInterfaceState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2LocalGatewayVirtualInterfaceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface#id-1">DataAwsEc2LocalGatewayVirtualInterface#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2LocalGatewayVirtualInterfaceState, value: string) : DataAwsEc2LocalGatewayVirtualInterfaceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2LocalGatewayVirtualInterfaceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface#tags-1">DataAwsEc2LocalGatewayVirtualInterface#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2LocalGatewayVirtualInterfaceState, value: seq<string * string>) : DataAwsEc2LocalGatewayVirtualInterfaceState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2LocalGatewayVirtualInterfaceState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface#timeouts-1">DataAwsEc2LocalGatewayVirtualInterface#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2LocalGatewayVirtualInterfaceState, value: aws.DataAwsEc2LocalGatewayVirtualInterface.DataAwsEc2LocalGatewayVirtualInterfaceTimeouts) : DataAwsEc2LocalGatewayVirtualInterfaceState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2LocalGatewayVirtualInterfaceState

        member _.Run(state: DataAwsEc2LocalGatewayVirtualInterfaceState) : aws.DataAwsEc2LocalGatewayVirtualInterface.DataAwsEc2LocalGatewayVirtualInterface =
            let config = aws.DataAwsEc2LocalGatewayVirtualInterface.DataAwsEc2LocalGatewayVirtualInterfaceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2LocalGatewayVirtualInterface.DataAwsEc2LocalGatewayVirtualInterface(StackContext.get (), logicalId, config)
