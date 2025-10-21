namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchserverlessVpcEndpointState<'Name, 'SubnetIds, 'VpcId> = { assignments: ResizeArray<aws.OpensearchserverlessVpcEndpoint.OpensearchserverlessVpcEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_vpc_endpoint">aws_opensearchserverless_vpc_endpoint</a>.
    /// </summary>
    type OpensearchserverlessVpcEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchserverlessVpcEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchserverlessVpcEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : OpensearchserverlessVpcEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchserverlessVpcEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Name of the interface endpoint. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_vpc_endpoint#name-1">OpensearchserverlessVpcEndpoint#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpensearchserverlessVpcEndpointState<Missing, 'SubnetIds, 'VpcId>, value: string) : OpensearchserverlessVpcEndpointState<Present, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OpensearchserverlessVpcEndpointState<Present, 'SubnetIds, 'VpcId>)

        /// <summary>
        /// One or more subnet IDs from which you'll access OpenSearch Serverless. Up to 6 subnets can be provided. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_vpc_endpoint#subnet_ids-1">OpensearchserverlessVpcEndpoint#subnet_ids</a>
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: OpensearchserverlessVpcEndpointState<'Name, Missing, 'VpcId>, value: seq<string>) : OpensearchserverlessVpcEndpointState<'Name, Present, 'VpcId> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : OpensearchserverlessVpcEndpointState<'Name, Present, 'VpcId>)

        /// <summary>
        /// ID of the VPC from which you'll access OpenSearch Serverless. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_vpc_endpoint#vpc_id-1">OpensearchserverlessVpcEndpoint#vpc_id</a>
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: OpensearchserverlessVpcEndpointState<'Name, 'SubnetIds, Missing>, value: string) : OpensearchserverlessVpcEndpointState<'Name, 'SubnetIds, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : OpensearchserverlessVpcEndpointState<'Name, 'SubnetIds, Present>)

        /// <summary>
        /// One or more security groups that define the ports, protocols, and sources for inbound traffic that you are authorizing into your endpoint. Up to 5 security groups can be provided. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_vpc_endpoint#security_group_ids-1">OpensearchserverlessVpcEndpoint#security_group_ids</a>
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: OpensearchserverlessVpcEndpointState<'Name, 'SubnetIds, 'VpcId>, value: seq<string>) : OpensearchserverlessVpcEndpointState<'Name, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : OpensearchserverlessVpcEndpointState<'Name, 'SubnetIds, 'VpcId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_vpc_endpoint#timeouts-1">OpensearchserverlessVpcEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OpensearchserverlessVpcEndpointState<'Name, 'SubnetIds, 'VpcId>, value: aws.OpensearchserverlessVpcEndpoint.OpensearchserverlessVpcEndpointTimeouts) : OpensearchserverlessVpcEndpointState<'Name, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OpensearchserverlessVpcEndpointState<'Name, 'SubnetIds, 'VpcId>

        member _.Run(state: OpensearchserverlessVpcEndpointState<Present, Present, Present>) : aws.OpensearchserverlessVpcEndpoint.OpensearchserverlessVpcEndpoint =
            let config = aws.OpensearchserverlessVpcEndpoint.OpensearchserverlessVpcEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchserverlessVpcEndpoint.OpensearchserverlessVpcEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchserverlessVpcEndpoint: missing required arguments. Must call: name, subnet_ids, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: OpensearchserverlessVpcEndpointState<_, _, _>) : aws.OpensearchserverlessVpcEndpoint.OpensearchserverlessVpcEndpoint =
            Unchecked.defaultof<aws.OpensearchserverlessVpcEndpoint.OpensearchserverlessVpcEndpoint>
