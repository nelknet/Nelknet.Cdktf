namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftdataStatementState<'Database, 'Sql> = { assignments: ResizeArray<aws.RedshiftdataStatement.RedshiftdataStatementConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement">aws_redshiftdata_statement</a>.
    /// </summary>
    type RedshiftdataStatementBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftdataStatementState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftdataStatementState<Missing, Missing>)

        member _.Zero(()) : RedshiftdataStatementState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftdataStatementState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#database-1">RedshiftdataStatement#database</a>.
        /// </summary>
        [<CustomOperation "database">]
        member _.Database(state: RedshiftdataStatementState<Missing, 'Sql>, value: string) : RedshiftdataStatementState<Present, 'Sql> =
            state.assignments.Add(fun config -> config.Database <- value)
            ({ assignments = state.assignments } : RedshiftdataStatementState<Present, 'Sql>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#sql-1">RedshiftdataStatement#sql</a>.
        /// </summary>
        [<CustomOperation "sql">]
        member _.Sql(state: RedshiftdataStatementState<'Database, Missing>, value: string) : RedshiftdataStatementState<'Database, Present> =
            state.assignments.Add(fun config -> config.Sql <- value)
            ({ assignments = state.assignments } : RedshiftdataStatementState<'Database, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#cluster_identifier-1">RedshiftdataStatement#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: RedshiftdataStatementState<'Database, 'Sql>, value: string) : RedshiftdataStatementState<'Database, 'Sql> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            state : RedshiftdataStatementState<'Database, 'Sql>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#db_user-1">RedshiftdataStatement#db_user</a>.
        /// </summary>
        [<CustomOperation "db_user">]
        member _.DbUser(state: RedshiftdataStatementState<'Database, 'Sql>, value: string) : RedshiftdataStatementState<'Database, 'Sql> =
            state.assignments.Add(fun config -> config.DbUser <- value)
            state : RedshiftdataStatementState<'Database, 'Sql>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#id-1">RedshiftdataStatement#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftdataStatementState<'Database, 'Sql>, value: string) : RedshiftdataStatementState<'Database, 'Sql> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftdataStatementState<'Database, 'Sql>

        /// <summary>
        /// parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#parameters-1">RedshiftdataStatement#parameters</a> Accepts: aws.IResolvable | aws.RedshiftdataStatement.RedshiftdataStatementParameters[]
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: RedshiftdataStatementState<'Database, 'Sql>, value: HashiCorp.Cdktf.IResolvable) : RedshiftdataStatementState<'Database, 'Sql> =
            state.assignments.Add(fun config -> config.Parameters <- value)
            state : RedshiftdataStatementState<'Database, 'Sql>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#secret_arn-1">RedshiftdataStatement#secret_arn</a>.
        /// </summary>
        [<CustomOperation "secret_arn">]
        member _.SecretArn(state: RedshiftdataStatementState<'Database, 'Sql>, value: string) : RedshiftdataStatementState<'Database, 'Sql> =
            state.assignments.Add(fun config -> config.SecretArn <- value)
            state : RedshiftdataStatementState<'Database, 'Sql>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#statement_name-1">RedshiftdataStatement#statement_name</a>.
        /// </summary>
        [<CustomOperation "statement_name">]
        member _.StatementName(state: RedshiftdataStatementState<'Database, 'Sql>, value: string) : RedshiftdataStatementState<'Database, 'Sql> =
            state.assignments.Add(fun config -> config.StatementName <- value)
            state : RedshiftdataStatementState<'Database, 'Sql>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#timeouts-1">RedshiftdataStatement#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RedshiftdataStatementState<'Database, 'Sql>, value: aws.RedshiftdataStatement.RedshiftdataStatementTimeouts) : RedshiftdataStatementState<'Database, 'Sql> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RedshiftdataStatementState<'Database, 'Sql>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#with_event-1">RedshiftdataStatement#with_event</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "with_event">]
        member _.WithEvent(state: RedshiftdataStatementState<'Database, 'Sql>, value: bool) : RedshiftdataStatementState<'Database, 'Sql> =
            state.assignments.Add(fun config -> config.WithEvent <- value)
            state : RedshiftdataStatementState<'Database, 'Sql>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#with_event-1">RedshiftdataStatement#with_event</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "with_event">]
        member _.WithEvent(state: RedshiftdataStatementState<'Database, 'Sql>, value: HashiCorp.Cdktf.IResolvable) : RedshiftdataStatementState<'Database, 'Sql> =
            state.assignments.Add(fun config -> config.WithEvent <- value)
            state : RedshiftdataStatementState<'Database, 'Sql>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#workgroup_name-1">RedshiftdataStatement#workgroup_name</a>.
        /// </summary>
        [<CustomOperation "workgroup_name">]
        member _.WorkgroupName(state: RedshiftdataStatementState<'Database, 'Sql>, value: string) : RedshiftdataStatementState<'Database, 'Sql> =
            state.assignments.Add(fun config -> config.WorkgroupName <- value)
            state : RedshiftdataStatementState<'Database, 'Sql>

        member _.Run(state: RedshiftdataStatementState<Present, Present>) : aws.RedshiftdataStatement.RedshiftdataStatement =
            let config = aws.RedshiftdataStatement.RedshiftdataStatementConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftdataStatement.RedshiftdataStatement(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftdataStatement: missing required arguments. Must call: database, sql.", 9999, IsError = true)>]
        member _.Run(_: RedshiftdataStatementState<_, _>) : aws.RedshiftdataStatement.RedshiftdataStatement =
            Unchecked.defaultof<aws.RedshiftdataStatement.RedshiftdataStatement>
