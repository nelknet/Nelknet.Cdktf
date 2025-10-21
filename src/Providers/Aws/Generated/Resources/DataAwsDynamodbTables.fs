namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDynamodbTablesState = { assignments: ResizeArray<aws.DataAwsDynamodbTables.DataAwsDynamodbTablesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_tables">aws_dynamodb_tables</a>.
    /// </summary>
    type DataAwsDynamodbTablesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDynamodbTablesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsDynamodbTablesState =
            { assignments = ResizeArray() }



        member _.Run(state: DataAwsDynamodbTablesState) : aws.DataAwsDynamodbTables.DataAwsDynamodbTables =
            let config = aws.DataAwsDynamodbTables.DataAwsDynamodbTablesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDynamodbTables.DataAwsDynamodbTables(StackContext.get (), logicalId, config)
