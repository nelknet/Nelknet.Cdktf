namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsQldbLedgerState<'Name> = { assignments: ResizeArray<aws.DataAwsQldbLedger.DataAwsQldbLedgerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/qldb_ledger">aws_qldb_ledger</a>.
    /// </summary>
    type DataAwsQldbLedgerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsQldbLedgerState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsQldbLedgerState<Missing>)

        member _.Zero(()) : DataAwsQldbLedgerState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsQldbLedgerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/qldb_ledger#name-1">DataAwsQldbLedger#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsQldbLedgerState<Missing>, value: string) : DataAwsQldbLedgerState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsQldbLedgerState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/qldb_ledger#id-1">DataAwsQldbLedger#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsQldbLedgerState<'Name>, value: string) : DataAwsQldbLedgerState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsQldbLedgerState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/qldb_ledger#tags-1">DataAwsQldbLedger#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsQldbLedgerState<'Name>, value: seq<string * string>) : DataAwsQldbLedgerState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsQldbLedgerState<'Name>

        member _.Run(state: DataAwsQldbLedgerState<Present>) : aws.DataAwsQldbLedger.DataAwsQldbLedger =
            let config = aws.DataAwsQldbLedger.DataAwsQldbLedgerConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsQldbLedger.DataAwsQldbLedger(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsQldbLedger: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsQldbLedgerState<_>) : aws.DataAwsQldbLedger.DataAwsQldbLedger =
            Unchecked.defaultof<aws.DataAwsQldbLedger.DataAwsQldbLedger>
