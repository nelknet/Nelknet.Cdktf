namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DbProxyDefaultTargetGroupState<'DbProxyName> = { assignments: ResizeArray<aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group">aws_db_proxy_default_target_group</a>.
    /// </summary>
    type DbProxyDefaultTargetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DbProxyDefaultTargetGroupState<Missing> =
            ({ assignments = ResizeArray() } : DbProxyDefaultTargetGroupState<Missing>)

        member _.Zero(()) : DbProxyDefaultTargetGroupState<Missing> =
            ({ assignments = ResizeArray() } : DbProxyDefaultTargetGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group#db_proxy_name-1">DbProxyDefaultTargetGroup#db_proxy_name</a>.
        /// </summary>
        [<CustomOperation "db_proxy_name">]
        member _.DbProxyName(state: DbProxyDefaultTargetGroupState<Missing>, value: string) : DbProxyDefaultTargetGroupState<Present> =
            state.assignments.Add(fun config -> config.DbProxyName <- value)
            ({ assignments = state.assignments } : DbProxyDefaultTargetGroupState<Present>)

        /// <summary>
        /// connection_pool_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group#connection_pool_config-1">DbProxyDefaultTargetGroup#connection_pool_config</a>
        /// </summary>
        [<CustomOperation "connection_pool_config">]
        member _.ConnectionPoolConfig(state: DbProxyDefaultTargetGroupState<'DbProxyName>, value: aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupConnectionPoolConfig) : DbProxyDefaultTargetGroupState<'DbProxyName> =
            state.assignments.Add(fun config -> config.ConnectionPoolConfig <- value)
            state : DbProxyDefaultTargetGroupState<'DbProxyName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group#id-1">DbProxyDefaultTargetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DbProxyDefaultTargetGroupState<'DbProxyName>, value: string) : DbProxyDefaultTargetGroupState<'DbProxyName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DbProxyDefaultTargetGroupState<'DbProxyName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group#timeouts-1">DbProxyDefaultTargetGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DbProxyDefaultTargetGroupState<'DbProxyName>, value: aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupTimeouts) : DbProxyDefaultTargetGroupState<'DbProxyName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DbProxyDefaultTargetGroupState<'DbProxyName>

        member _.Run(state: DbProxyDefaultTargetGroupState<Present>) : aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroup =
            let config = aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dbProxyDefaultTargetGroup: missing required arguments. Must call: db_proxy_name.", 9999, IsError = true)>]
        member _.Run(_: DbProxyDefaultTargetGroupState<_>) : aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroup =
            Unchecked.defaultof<aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroup>
