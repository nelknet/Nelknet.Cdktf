namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2ClientVpnEndpointState = { assignments: ResizeArray<aws.DataAwsEc2ClientVpnEndpoint.DataAwsEc2ClientVpnEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_client_vpn_endpoint">aws_ec2_client_vpn_endpoint</a>.
    /// </summary>
    type DataAwsEc2ClientVpnEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2ClientVpnEndpointState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2ClientVpnEndpointState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_client_vpn_endpoint#client_vpn_endpoint_id-1">DataAwsEc2ClientVpnEndpoint#client_vpn_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "client_vpn_endpoint_id">]
        member _.ClientVpnEndpointId(state: DataAwsEc2ClientVpnEndpointState, value: string) : DataAwsEc2ClientVpnEndpointState =
            state.assignments.Add(fun config -> config.ClientVpnEndpointId <- value)
            state : DataAwsEc2ClientVpnEndpointState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_client_vpn_endpoint#filter-1">DataAwsEc2ClientVpnEndpoint#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2ClientVpnEndpoint.DataAwsEc2ClientVpnEndpointFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2ClientVpnEndpointState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2ClientVpnEndpointState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2ClientVpnEndpointState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_client_vpn_endpoint#id-1">DataAwsEc2ClientVpnEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2ClientVpnEndpointState, value: string) : DataAwsEc2ClientVpnEndpointState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2ClientVpnEndpointState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_client_vpn_endpoint#tags-1">DataAwsEc2ClientVpnEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2ClientVpnEndpointState, value: seq<string * string>) : DataAwsEc2ClientVpnEndpointState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2ClientVpnEndpointState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_client_vpn_endpoint#timeouts-1">DataAwsEc2ClientVpnEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2ClientVpnEndpointState, value: aws.DataAwsEc2ClientVpnEndpoint.DataAwsEc2ClientVpnEndpointTimeouts) : DataAwsEc2ClientVpnEndpointState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2ClientVpnEndpointState

        member _.Run(state: DataAwsEc2ClientVpnEndpointState) : aws.DataAwsEc2ClientVpnEndpoint.DataAwsEc2ClientVpnEndpoint =
            let config = aws.DataAwsEc2ClientVpnEndpoint.DataAwsEc2ClientVpnEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2ClientVpnEndpoint.DataAwsEc2ClientVpnEndpoint(StackContext.get (), logicalId, config)
