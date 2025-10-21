namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DynamodbGlobalTableState<'Name, 'Replica> = { assignments: ResizeArray<aws.DynamodbGlobalTable.DynamodbGlobalTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_global_table">aws_dynamodb_global_table</a>.
    /// </summary>
    type DynamodbGlobalTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : DynamodbGlobalTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DynamodbGlobalTableState<Missing, Missing>)

        member _.Zero(()) : DynamodbGlobalTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DynamodbGlobalTableState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_global_table#name-1">DynamodbGlobalTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DynamodbGlobalTableState<Missing, 'Replica>, value: string) : DynamodbGlobalTableState<Present, 'Replica> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DynamodbGlobalTableState<Present, 'Replica>)

        /// <summary>
        /// replica block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_global_table#replica-1">DynamodbGlobalTable#replica</a> Accepts: aws.IResolvable | aws.DynamodbGlobalTable.DynamodbGlobalTableReplica[]
        /// </summary>
        [<CustomOperation "replica">]
        member _.Replica(state: DynamodbGlobalTableState<'Name, Missing>, value: HashiCorp.Cdktf.IResolvable) : DynamodbGlobalTableState<'Name, Present> =
            state.assignments.Add(fun config -> config.Replica <- value)
            ({ assignments = state.assignments } : DynamodbGlobalTableState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_global_table#id-1">DynamodbGlobalTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DynamodbGlobalTableState<'Name, 'Replica>, value: string) : DynamodbGlobalTableState<'Name, 'Replica> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DynamodbGlobalTableState<'Name, 'Replica>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_global_table#timeouts-1">DynamodbGlobalTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DynamodbGlobalTableState<'Name, 'Replica>, value: aws.DynamodbGlobalTable.DynamodbGlobalTableTimeouts) : DynamodbGlobalTableState<'Name, 'Replica> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DynamodbGlobalTableState<'Name, 'Replica>

        member _.Run(state: DynamodbGlobalTableState<Present, Present>) : aws.DynamodbGlobalTable.DynamodbGlobalTable =
            let config = aws.DynamodbGlobalTable.DynamodbGlobalTableConfig()
            for setter in state.assignments do
                setter config
            aws.DynamodbGlobalTable.DynamodbGlobalTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dynamodbGlobalTable: missing required arguments. Must call: name, replica.", 9999, IsError = true)>]
        member _.Run(_: DynamodbGlobalTableState<_, _>) : aws.DynamodbGlobalTable.DynamodbGlobalTable =
            Unchecked.defaultof<aws.DynamodbGlobalTable.DynamodbGlobalTable>
