namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TimestreamwriteDatabaseState<'DatabaseName> = { assignments: ResizeArray<aws.TimestreamwriteDatabase.TimestreamwriteDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_database">aws_timestreamwrite_database</a>.
    /// </summary>
    type TimestreamwriteDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : TimestreamwriteDatabaseState<Missing> =
            ({ assignments = ResizeArray() } : TimestreamwriteDatabaseState<Missing>)

        member _.Zero(()) : TimestreamwriteDatabaseState<Missing> =
            ({ assignments = ResizeArray() } : TimestreamwriteDatabaseState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_database#database_name-1">TimestreamwriteDatabase#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: TimestreamwriteDatabaseState<Missing>, value: string) : TimestreamwriteDatabaseState<Present> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : TimestreamwriteDatabaseState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_database#id-1">TimestreamwriteDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TimestreamwriteDatabaseState<'DatabaseName>, value: string) : TimestreamwriteDatabaseState<'DatabaseName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TimestreamwriteDatabaseState<'DatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_database#kms_key_id-1">TimestreamwriteDatabase#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: TimestreamwriteDatabaseState<'DatabaseName>, value: string) : TimestreamwriteDatabaseState<'DatabaseName> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : TimestreamwriteDatabaseState<'DatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_database#tags-1">TimestreamwriteDatabase#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TimestreamwriteDatabaseState<'DatabaseName>, value: seq<string * string>) : TimestreamwriteDatabaseState<'DatabaseName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TimestreamwriteDatabaseState<'DatabaseName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_database#tags_all-1">TimestreamwriteDatabase#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: TimestreamwriteDatabaseState<'DatabaseName>, value: seq<string * string>) : TimestreamwriteDatabaseState<'DatabaseName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : TimestreamwriteDatabaseState<'DatabaseName>

        member _.Run(state: TimestreamwriteDatabaseState<Present>) : aws.TimestreamwriteDatabase.TimestreamwriteDatabase =
            let config = aws.TimestreamwriteDatabase.TimestreamwriteDatabaseConfig()
            for setter in state.assignments do
                setter config
            aws.TimestreamwriteDatabase.TimestreamwriteDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.timestreamwriteDatabase: missing required arguments. Must call: database_name.", 9999, IsError = true)>]
        member _.Run(_: TimestreamwriteDatabaseState<_>) : aws.TimestreamwriteDatabase.TimestreamwriteDatabase =
            Unchecked.defaultof<aws.TimestreamwriteDatabase.TimestreamwriteDatabase>
