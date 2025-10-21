namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds> = { assignments: ResizeArray<aws.DbProxy.DbProxyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy">aws_db_proxy</a>.
    /// </summary>
    type DbProxyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DbProxyState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DbProxyState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DbProxyState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DbProxyState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// auth block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#auth-1">DbProxy#auth</a> Accepts: aws.IResolvable | aws.DbProxy.DbProxyAuth[]
        /// </summary>
        [<CustomOperation "auth">]
        member _.Auth(state: DbProxyState<Missing, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>, value: HashiCorp.Cdktf.IResolvable) : DbProxyState<Present, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Auth <- value)
            ({ assignments = state.assignments } : DbProxyState<Present, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#engine_family-1">DbProxy#engine_family</a>.
        /// </summary>
        [<CustomOperation "engine_family">]
        member _.EngineFamily(state: DbProxyState<'Auth, Missing, 'Name, 'RoleArn, 'VpcSubnetIds>, value: string) : DbProxyState<'Auth, Present, 'Name, 'RoleArn, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.EngineFamily <- value)
            ({ assignments = state.assignments } : DbProxyState<'Auth, Present, 'Name, 'RoleArn, 'VpcSubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#name-1">DbProxy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DbProxyState<'Auth, 'EngineFamily, Missing, 'RoleArn, 'VpcSubnetIds>, value: string) : DbProxyState<'Auth, 'EngineFamily, Present, 'RoleArn, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DbProxyState<'Auth, 'EngineFamily, Present, 'RoleArn, 'VpcSubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#role_arn-1">DbProxy#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: DbProxyState<'Auth, 'EngineFamily, 'Name, Missing, 'VpcSubnetIds>, value: string) : DbProxyState<'Auth, 'EngineFamily, 'Name, Present, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : DbProxyState<'Auth, 'EngineFamily, 'Name, Present, 'VpcSubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#vpc_subnet_ids-1">DbProxy#vpc_subnet_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_subnet_ids">]
        member _.VpcSubnetIds(state: DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, Missing>, value: seq<string>) : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, Present> =
            state.assignments.Add(fun config -> config.VpcSubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#debug_logging-1">DbProxy#debug_logging</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "debug_logging">]
        member _.DebugLogging(state: DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>, value: bool) : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.DebugLogging <- value)
            state : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#debug_logging-1">DbProxy#debug_logging</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "debug_logging">]
        member _.DebugLogging(state: DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>, value: HashiCorp.Cdktf.IResolvable) : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.DebugLogging <- value)
            state : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#id-1">DbProxy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>, value: string) : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#idle_client_timeout-1">DbProxy#idle_client_timeout</a>.
        /// </summary>
        [<CustomOperation "idle_client_timeout">]
        member _.IdleClientTimeout(state: DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>, value: double) : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.IdleClientTimeout <- value)
            state : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#require_tls-1">DbProxy#require_tls</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_tls">]
        member _.RequireTls(state: DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>, value: bool) : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.RequireTls <- value)
            state : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#require_tls-1">DbProxy#require_tls</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_tls">]
        member _.RequireTls(state: DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>, value: HashiCorp.Cdktf.IResolvable) : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.RequireTls <- value)
            state : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#tags-1">DbProxy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>, value: seq<string * string>) : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#tags_all-1">DbProxy#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>, value: seq<string * string>) : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#timeouts-1">DbProxy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>, value: aws.DbProxy.DbProxyTimeouts) : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#vpc_security_group_ids-1">DbProxy#vpc_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>, value: seq<string>) : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds> =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            state : DbProxyState<'Auth, 'EngineFamily, 'Name, 'RoleArn, 'VpcSubnetIds>

        member _.Run(state: DbProxyState<Present, Present, Present, Present, Present>) : aws.DbProxy.DbProxy =
            let config = aws.DbProxy.DbProxyConfig()
            for setter in state.assignments do
                setter config
            aws.DbProxy.DbProxy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dbProxy: missing required arguments. Must call: auth, engine_family, name, role_arn, vpc_subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: DbProxyState<_, _, _, _, _>) : aws.DbProxy.DbProxy =
            Unchecked.defaultof<aws.DbProxy.DbProxy>
