namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontVpcOriginState = { assignments: ResizeArray<aws.CloudfrontVpcOrigin.CloudfrontVpcOriginConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_vpc_origin">aws_cloudfront_vpc_origin</a>.
    /// </summary>
    type CloudfrontVpcOriginBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontVpcOriginState =
            { assignments = ResizeArray() }

        member _.Zero(()) : CloudfrontVpcOriginState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_vpc_origin#tags-1">CloudfrontVpcOrigin#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudfrontVpcOriginState, value: seq<string * string>) : CloudfrontVpcOriginState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudfrontVpcOriginState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_vpc_origin#timeouts-1">CloudfrontVpcOrigin#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CloudfrontVpcOriginState, value: aws.CloudfrontVpcOrigin.CloudfrontVpcOriginTimeouts) : CloudfrontVpcOriginState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CloudfrontVpcOriginState

        /// <summary>
        /// vpc_origin_endpoint_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_vpc_origin#vpc_origin_endpoint_config-1">CloudfrontVpcOrigin#vpc_origin_endpoint_config</a> Accepts: aws.IResolvable | aws.CloudfrontVpcOrigin.CloudfrontVpcOriginVpcOriginEndpointConfig[]
        /// </summary>
        [<CustomOperation "vpc_origin_endpoint_config">]
        member _.VpcOriginEndpointConfig(state: CloudfrontVpcOriginState, value: HashiCorp.Cdktf.IResolvable) : CloudfrontVpcOriginState =
            state.assignments.Add(fun config -> config.VpcOriginEndpointConfig <- value)
            state : CloudfrontVpcOriginState

        member _.Run(state: CloudfrontVpcOriginState) : aws.CloudfrontVpcOrigin.CloudfrontVpcOrigin =
            let config = aws.CloudfrontVpcOrigin.CloudfrontVpcOriginConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontVpcOrigin.CloudfrontVpcOrigin(StackContext.get (), logicalId, config)
