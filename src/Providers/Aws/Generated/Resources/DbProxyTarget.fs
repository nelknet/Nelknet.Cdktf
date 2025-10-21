namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DbProxyTargetState<'DbProxyName, 'TargetGroupName> = { assignments: ResizeArray<aws.DbProxyTarget.DbProxyTargetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_target">aws_db_proxy_target</a>.
    /// </summary>
    type DbProxyTargetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DbProxyTargetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DbProxyTargetState<Missing, Missing>)

        member _.Zero(()) : DbProxyTargetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DbProxyTargetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_target#db_proxy_name-1">DbProxyTarget#db_proxy_name</a>.
        /// </summary>
        [<CustomOperation "db_proxy_name">]
        member _.DbProxyName(state: DbProxyTargetState<Missing, 'TargetGroupName>, value: string) : DbProxyTargetState<Present, 'TargetGroupName> =
            state.assignments.Add(fun config -> config.DbProxyName <- value)
            ({ assignments = state.assignments } : DbProxyTargetState<Present, 'TargetGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_target#target_group_name-1">DbProxyTarget#target_group_name</a>.
        /// </summary>
        [<CustomOperation "target_group_name">]
        member _.TargetGroupName(state: DbProxyTargetState<'DbProxyName, Missing>, value: string) : DbProxyTargetState<'DbProxyName, Present> =
            state.assignments.Add(fun config -> config.TargetGroupName <- value)
            ({ assignments = state.assignments } : DbProxyTargetState<'DbProxyName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_target#db_cluster_identifier-1">DbProxyTarget#db_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "db_cluster_identifier">]
        member _.DbClusterIdentifier(state: DbProxyTargetState<'DbProxyName, 'TargetGroupName>, value: string) : DbProxyTargetState<'DbProxyName, 'TargetGroupName> =
            state.assignments.Add(fun config -> config.DbClusterIdentifier <- value)
            state : DbProxyTargetState<'DbProxyName, 'TargetGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_target#db_instance_identifier-1">DbProxyTarget#db_instance_identifier</a>.
        /// </summary>
        [<CustomOperation "db_instance_identifier">]
        member _.DbInstanceIdentifier(state: DbProxyTargetState<'DbProxyName, 'TargetGroupName>, value: string) : DbProxyTargetState<'DbProxyName, 'TargetGroupName> =
            state.assignments.Add(fun config -> config.DbInstanceIdentifier <- value)
            state : DbProxyTargetState<'DbProxyName, 'TargetGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_target#id-1">DbProxyTarget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DbProxyTargetState<'DbProxyName, 'TargetGroupName>, value: string) : DbProxyTargetState<'DbProxyName, 'TargetGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DbProxyTargetState<'DbProxyName, 'TargetGroupName>

        member _.Run(state: DbProxyTargetState<Present, Present>) : aws.DbProxyTarget.DbProxyTarget =
            let config = aws.DbProxyTarget.DbProxyTargetConfig()
            for setter in state.assignments do
                setter config
            aws.DbProxyTarget.DbProxyTarget(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dbProxyTarget: missing required arguments. Must call: db_proxy_name, target_group_name.", 9999, IsError = true)>]
        member _.Run(_: DbProxyTargetState<_, _>) : aws.DbProxyTarget.DbProxyTarget =
            Unchecked.defaultof<aws.DbProxyTarget.DbProxyTarget>
