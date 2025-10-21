namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksRdsDbInstanceState<'DbPassword, 'DbUser, 'RdsDbInstanceArn, 'StackId> = { assignments: ResizeArray<aws.OpsworksRdsDbInstance.OpsworksRdsDbInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rds_db_instance">aws_opsworks_rds_db_instance</a>.
    /// </summary>
    type OpsworksRdsDbInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksRdsDbInstanceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksRdsDbInstanceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : OpsworksRdsDbInstanceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksRdsDbInstanceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rds_db_instance#db_password-1">OpsworksRdsDbInstance#db_password</a>.
        /// </summary>
        [<CustomOperation "db_password">]
        member _.DbPassword(state: OpsworksRdsDbInstanceState<Missing, 'DbUser, 'RdsDbInstanceArn, 'StackId>, value: string) : OpsworksRdsDbInstanceState<Present, 'DbUser, 'RdsDbInstanceArn, 'StackId> =
            state.assignments.Add(fun config -> config.DbPassword <- value)
            ({ assignments = state.assignments } : OpsworksRdsDbInstanceState<Present, 'DbUser, 'RdsDbInstanceArn, 'StackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rds_db_instance#db_user-1">OpsworksRdsDbInstance#db_user</a>.
        /// </summary>
        [<CustomOperation "db_user">]
        member _.DbUser(state: OpsworksRdsDbInstanceState<'DbPassword, Missing, 'RdsDbInstanceArn, 'StackId>, value: string) : OpsworksRdsDbInstanceState<'DbPassword, Present, 'RdsDbInstanceArn, 'StackId> =
            state.assignments.Add(fun config -> config.DbUser <- value)
            ({ assignments = state.assignments } : OpsworksRdsDbInstanceState<'DbPassword, Present, 'RdsDbInstanceArn, 'StackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rds_db_instance#rds_db_instance_arn-1">OpsworksRdsDbInstance#rds_db_instance_arn</a>.
        /// </summary>
        [<CustomOperation "rds_db_instance_arn">]
        member _.RdsDbInstanceArn(state: OpsworksRdsDbInstanceState<'DbPassword, 'DbUser, Missing, 'StackId>, value: string) : OpsworksRdsDbInstanceState<'DbPassword, 'DbUser, Present, 'StackId> =
            state.assignments.Add(fun config -> config.RdsDbInstanceArn <- value)
            ({ assignments = state.assignments } : OpsworksRdsDbInstanceState<'DbPassword, 'DbUser, Present, 'StackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rds_db_instance#stack_id-1">OpsworksRdsDbInstance#stack_id</a>.
        /// </summary>
        [<CustomOperation "stack_id">]
        member _.StackId(state: OpsworksRdsDbInstanceState<'DbPassword, 'DbUser, 'RdsDbInstanceArn, Missing>, value: string) : OpsworksRdsDbInstanceState<'DbPassword, 'DbUser, 'RdsDbInstanceArn, Present> =
            state.assignments.Add(fun config -> config.StackId <- value)
            ({ assignments = state.assignments } : OpsworksRdsDbInstanceState<'DbPassword, 'DbUser, 'RdsDbInstanceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_rds_db_instance#id-1">OpsworksRdsDbInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksRdsDbInstanceState<'DbPassword, 'DbUser, 'RdsDbInstanceArn, 'StackId>, value: string) : OpsworksRdsDbInstanceState<'DbPassword, 'DbUser, 'RdsDbInstanceArn, 'StackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksRdsDbInstanceState<'DbPassword, 'DbUser, 'RdsDbInstanceArn, 'StackId>

        member _.Run(state: OpsworksRdsDbInstanceState<Present, Present, Present, Present>) : aws.OpsworksRdsDbInstance.OpsworksRdsDbInstance =
            let config = aws.OpsworksRdsDbInstance.OpsworksRdsDbInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksRdsDbInstance.OpsworksRdsDbInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksRdsDbInstance: missing required arguments. Must call: db_password, db_user, rds_db_instance_arn, stack_id.", 9999, IsError = true)>]
        member _.Run(_: OpsworksRdsDbInstanceState<_, _, _, _>) : aws.OpsworksRdsDbInstance.OpsworksRdsDbInstance =
            Unchecked.defaultof<aws.OpsworksRdsDbInstance.OpsworksRdsDbInstance>
