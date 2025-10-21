namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds> = { assignments: ResizeArray<aws.DbProxyEndpoint.DbProxyEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_endpoint">aws_db_proxy_endpoint</a>.
    /// </summary>
    type DbProxyEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DbProxyEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DbProxyEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : DbProxyEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DbProxyEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_endpoint#db_proxy_endpoint_name-1">DbProxyEndpoint#db_proxy_endpoint_name</a>.
        /// </summary>
        [<CustomOperation "db_proxy_endpoint_name">]
        member _.DbProxyEndpointName(state: DbProxyEndpointState<Missing, 'DbProxyName, 'VpcSubnetIds>, value: string) : DbProxyEndpointState<Present, 'DbProxyName, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.DbProxyEndpointName <- value)
            ({ assignments = state.assignments } : DbProxyEndpointState<Present, 'DbProxyName, 'VpcSubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_endpoint#db_proxy_name-1">DbProxyEndpoint#db_proxy_name</a>.
        /// </summary>
        [<CustomOperation "db_proxy_name">]
        member _.DbProxyName(state: DbProxyEndpointState<'DbProxyEndpointName, Missing, 'VpcSubnetIds>, value: string) : DbProxyEndpointState<'DbProxyEndpointName, Present, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.DbProxyName <- value)
            ({ assignments = state.assignments } : DbProxyEndpointState<'DbProxyEndpointName, Present, 'VpcSubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_endpoint#vpc_subnet_ids-1">DbProxyEndpoint#vpc_subnet_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_subnet_ids">]
        member _.VpcSubnetIds(state: DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, Missing>, value: seq<string>) : DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, Present> =
            state.assignments.Add(fun config -> config.VpcSubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_endpoint#id-1">DbProxyEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds>, value: string) : DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_endpoint#tags-1">DbProxyEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds>, value: seq<string * string>) : DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_endpoint#tags_all-1">DbProxyEndpoint#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds>, value: seq<string * string>) : DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_endpoint#target_role-1">DbProxyEndpoint#target_role</a>.
        /// </summary>
        [<CustomOperation "target_role">]
        member _.TargetRole(state: DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds>, value: string) : DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.TargetRole <- value)
            state : DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_endpoint#timeouts-1">DbProxyEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds>, value: aws.DbProxyEndpoint.DbProxyEndpointTimeouts) : DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_endpoint#vpc_security_group_ids-1">DbProxyEndpoint#vpc_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds>, value: seq<string>) : DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            state : DbProxyEndpointState<'DbProxyEndpointName, 'DbProxyName, 'VpcSubnetIds>

        member _.Run(state: DbProxyEndpointState<Present, Present, Present>) : aws.DbProxyEndpoint.DbProxyEndpoint =
            let config = aws.DbProxyEndpoint.DbProxyEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.DbProxyEndpoint.DbProxyEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dbProxyEndpoint: missing required arguments. Must call: db_proxy_endpoint_name, db_proxy_name, vpc_subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: DbProxyEndpointState<_, _, _>) : aws.DbProxyEndpoint.DbProxyEndpoint =
            Unchecked.defaultof<aws.DbProxyEndpoint.DbProxyEndpoint>
