namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2InstanceConnectEndpointState<'SubnetId> = { assignments: ResizeArray<aws.Ec2InstanceConnectEndpoint.Ec2InstanceConnectEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_connect_endpoint">aws_ec2_instance_connect_endpoint</a>.
    /// </summary>
    type Ec2InstanceConnectEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2InstanceConnectEndpointState<Missing> =
            ({ assignments = ResizeArray() } : Ec2InstanceConnectEndpointState<Missing>)

        member _.Zero(()) : Ec2InstanceConnectEndpointState<Missing> =
            ({ assignments = ResizeArray() } : Ec2InstanceConnectEndpointState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_connect_endpoint#subnet_id-1">Ec2InstanceConnectEndpoint#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: Ec2InstanceConnectEndpointState<Missing>, value: string) : Ec2InstanceConnectEndpointState<Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : Ec2InstanceConnectEndpointState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_connect_endpoint#preserve_client_ip-1">Ec2InstanceConnectEndpoint#preserve_client_ip</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "preserve_client_ip">]
        member _.PreserveClientIp(state: Ec2InstanceConnectEndpointState<'SubnetId>, value: bool) : Ec2InstanceConnectEndpointState<'SubnetId> =
            state.assignments.Add(fun config -> config.PreserveClientIp <- value)
            state : Ec2InstanceConnectEndpointState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_connect_endpoint#preserve_client_ip-1">Ec2InstanceConnectEndpoint#preserve_client_ip</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "preserve_client_ip">]
        member _.PreserveClientIp(state: Ec2InstanceConnectEndpointState<'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : Ec2InstanceConnectEndpointState<'SubnetId> =
            state.assignments.Add(fun config -> config.PreserveClientIp <- value)
            state : Ec2InstanceConnectEndpointState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_connect_endpoint#security_group_ids-1">Ec2InstanceConnectEndpoint#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: Ec2InstanceConnectEndpointState<'SubnetId>, value: seq<string>) : Ec2InstanceConnectEndpointState<'SubnetId> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : Ec2InstanceConnectEndpointState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_connect_endpoint#tags-1">Ec2InstanceConnectEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2InstanceConnectEndpointState<'SubnetId>, value: seq<string * string>) : Ec2InstanceConnectEndpointState<'SubnetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2InstanceConnectEndpointState<'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_connect_endpoint#timeouts-1">Ec2InstanceConnectEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2InstanceConnectEndpointState<'SubnetId>, value: aws.Ec2InstanceConnectEndpoint.Ec2InstanceConnectEndpointTimeouts) : Ec2InstanceConnectEndpointState<'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2InstanceConnectEndpointState<'SubnetId>

        member _.Run(state: Ec2InstanceConnectEndpointState<Present>) : aws.Ec2InstanceConnectEndpoint.Ec2InstanceConnectEndpoint =
            let config = aws.Ec2InstanceConnectEndpoint.Ec2InstanceConnectEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2InstanceConnectEndpoint.Ec2InstanceConnectEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2InstanceConnectEndpoint: missing required arguments. Must call: subnet_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2InstanceConnectEndpointState<_>) : aws.Ec2InstanceConnectEndpoint.Ec2InstanceConnectEndpoint =
            Unchecked.defaultof<aws.Ec2InstanceConnectEndpoint.Ec2InstanceConnectEndpoint>
