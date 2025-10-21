namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecuritylakeDataLakeState<'MetaStoreManagerRoleArn> = { assignments: ResizeArray<aws.SecuritylakeDataLake.SecuritylakeDataLakeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake">aws_securitylake_data_lake</a>.
    /// </summary>
    type SecuritylakeDataLakeBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecuritylakeDataLakeState<Missing> =
            ({ assignments = ResizeArray() } : SecuritylakeDataLakeState<Missing>)

        member _.Zero(()) : SecuritylakeDataLakeState<Missing> =
            ({ assignments = ResizeArray() } : SecuritylakeDataLakeState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake#meta_store_manager_role_arn-1">SecuritylakeDataLake#meta_store_manager_role_arn</a>.
        /// </summary>
        [<CustomOperation "meta_store_manager_role_arn">]
        member _.MetaStoreManagerRoleArn(state: SecuritylakeDataLakeState<Missing>, value: string) : SecuritylakeDataLakeState<Present> =
            state.assignments.Add(fun config -> config.MetaStoreManagerRoleArn <- value)
            ({ assignments = state.assignments } : SecuritylakeDataLakeState<Present>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake#configuration-1">SecuritylakeDataLake#configuration</a> Accepts: aws.IResolvable | aws.SecuritylakeDataLake.SecuritylakeDataLakeConfiguration[]
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: SecuritylakeDataLakeState<'MetaStoreManagerRoleArn>, value: HashiCorp.Cdktf.IResolvable) : SecuritylakeDataLakeState<'MetaStoreManagerRoleArn> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : SecuritylakeDataLakeState<'MetaStoreManagerRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake#tags-1">SecuritylakeDataLake#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SecuritylakeDataLakeState<'MetaStoreManagerRoleArn>, value: seq<string * string>) : SecuritylakeDataLakeState<'MetaStoreManagerRoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SecuritylakeDataLakeState<'MetaStoreManagerRoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake#timeouts-1">SecuritylakeDataLake#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecuritylakeDataLakeState<'MetaStoreManagerRoleArn>, value: aws.SecuritylakeDataLake.SecuritylakeDataLakeTimeouts) : SecuritylakeDataLakeState<'MetaStoreManagerRoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecuritylakeDataLakeState<'MetaStoreManagerRoleArn>

        member _.Run(state: SecuritylakeDataLakeState<Present>) : aws.SecuritylakeDataLake.SecuritylakeDataLake =
            let config = aws.SecuritylakeDataLake.SecuritylakeDataLakeConfig()
            for setter in state.assignments do
                setter config
            aws.SecuritylakeDataLake.SecuritylakeDataLake(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securitylakeDataLake: missing required arguments. Must call: meta_store_manager_role_arn.", 9999, IsError = true)>]
        member _.Run(_: SecuritylakeDataLakeState<_>) : aws.SecuritylakeDataLake.SecuritylakeDataLake =
            Unchecked.defaultof<aws.SecuritylakeDataLake.SecuritylakeDataLake>
