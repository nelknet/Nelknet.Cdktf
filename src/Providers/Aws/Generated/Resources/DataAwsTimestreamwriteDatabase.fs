namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsTimestreamwriteDatabaseState<'Name> = { assignments: ResizeArray<aws.DataAwsTimestreamwriteDatabase.DataAwsTimestreamwriteDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/timestreamwrite_database">aws_timestreamwrite_database</a>.
    /// </summary>
    type DataAwsTimestreamwriteDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsTimestreamwriteDatabaseState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsTimestreamwriteDatabaseState<Missing>)

        member _.Zero(()) : DataAwsTimestreamwriteDatabaseState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsTimestreamwriteDatabaseState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/timestreamwrite_database#name-1">DataAwsTimestreamwriteDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsTimestreamwriteDatabaseState<Missing>, value: string) : DataAwsTimestreamwriteDatabaseState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsTimestreamwriteDatabaseState<Present>)

        member _.Run(state: DataAwsTimestreamwriteDatabaseState<Present>) : aws.DataAwsTimestreamwriteDatabase.DataAwsTimestreamwriteDatabase =
            let config = aws.DataAwsTimestreamwriteDatabase.DataAwsTimestreamwriteDatabaseConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsTimestreamwriteDatabase.DataAwsTimestreamwriteDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsTimestreamwriteDatabase: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsTimestreamwriteDatabaseState<_>) : aws.DataAwsTimestreamwriteDatabase.DataAwsTimestreamwriteDatabase =
            Unchecked.defaultof<aws.DataAwsTimestreamwriteDatabase.DataAwsTimestreamwriteDatabase>
