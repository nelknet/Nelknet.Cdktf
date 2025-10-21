namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId> = { assignments: ResizeArray<aws.QuicksightVpcConnection.QuicksightVpcConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_vpc_connection">aws_quicksight_vpc_connection</a>.
    /// </summary>
    type QuicksightVpcConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightVpcConnectionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightVpcConnectionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : QuicksightVpcConnectionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightVpcConnectionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_vpc_connection#name-1">QuicksightVpcConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: QuicksightVpcConnectionState<Missing, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId>, value: string) : QuicksightVpcConnectionState<Present, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : QuicksightVpcConnectionState<Present, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_vpc_connection#role_arn-1">QuicksightVpcConnection#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: QuicksightVpcConnectionState<'Name, Missing, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId>, value: string) : QuicksightVpcConnectionState<'Name, Present, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : QuicksightVpcConnectionState<'Name, Present, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_vpc_connection#security_group_ids-1">QuicksightVpcConnection#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: QuicksightVpcConnectionState<'Name, 'RoleArn, Missing, 'SubnetIds, 'VpcConnectionId>, value: seq<string>) : QuicksightVpcConnectionState<'Name, 'RoleArn, Present, 'SubnetIds, 'VpcConnectionId> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : QuicksightVpcConnectionState<'Name, 'RoleArn, Present, 'SubnetIds, 'VpcConnectionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_vpc_connection#subnet_ids-1">QuicksightVpcConnection#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, Missing, 'VpcConnectionId>, value: seq<string>) : QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, Present, 'VpcConnectionId> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, Present, 'VpcConnectionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_vpc_connection#vpc_connection_id-1">QuicksightVpcConnection#vpc_connection_id</a>.
        /// </summary>
        [<CustomOperation "vpc_connection_id">]
        member _.VpcConnectionId(state: QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, Missing>, value: string) : QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, Present> =
            state.assignments.Add(fun config -> config.VpcConnectionId <- value)
            ({ assignments = state.assignments } : QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_vpc_connection#aws_account_id-1">QuicksightVpcConnection#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId>, value: string) : QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_vpc_connection#dns_resolvers-1">QuicksightVpcConnection#dns_resolvers</a>.
        /// </summary>
        [<CustomOperation "dns_resolvers">]
        member _.DnsResolvers(state: QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId>, value: seq<string>) : QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId> =
            state.assignments.Add(fun config -> config.DnsResolvers <- (value |> Seq.toArray))
            state : QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_vpc_connection#tags-1">QuicksightVpcConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId>, value: seq<string * string>) : QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_vpc_connection#timeouts-1">QuicksightVpcConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId>, value: aws.QuicksightVpcConnection.QuicksightVpcConnectionTimeouts) : QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : QuicksightVpcConnectionState<'Name, 'RoleArn, 'SecurityGroupIds, 'SubnetIds, 'VpcConnectionId>

        member _.Run(state: QuicksightVpcConnectionState<Present, Present, Present, Present, Present>) : aws.QuicksightVpcConnection.QuicksightVpcConnection =
            let config = aws.QuicksightVpcConnection.QuicksightVpcConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightVpcConnection.QuicksightVpcConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightVpcConnection: missing required arguments. Must call: name, role_arn, security_group_ids, subnet_ids, vpc_connection_id.", 9999, IsError = true)>]
        member _.Run(_: QuicksightVpcConnectionState<_, _, _, _, _>) : aws.QuicksightVpcConnection.QuicksightVpcConnection =
            Unchecked.defaultof<aws.QuicksightVpcConnection.QuicksightVpcConnection>
