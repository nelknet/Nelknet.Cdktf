namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QldbLedgerState<'PermissionsMode> = { assignments: ResizeArray<aws.QldbLedger.QldbLedgerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_ledger">aws_qldb_ledger</a>.
    /// </summary>
    type QldbLedgerBuilder(logicalId: string) =
        member _.Yield(_: unit) : QldbLedgerState<Missing> =
            ({ assignments = ResizeArray() } : QldbLedgerState<Missing>)

        member _.Zero(()) : QldbLedgerState<Missing> =
            ({ assignments = ResizeArray() } : QldbLedgerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_ledger#permissions_mode-1">QldbLedger#permissions_mode</a>.
        /// </summary>
        [<CustomOperation "permissions_mode">]
        member _.PermissionsMode(state: QldbLedgerState<Missing>, value: string) : QldbLedgerState<Present> =
            state.assignments.Add(fun config -> config.PermissionsMode <- value)
            ({ assignments = state.assignments } : QldbLedgerState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_ledger#deletion_protection-1">QldbLedger#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: QldbLedgerState<'PermissionsMode>, value: bool) : QldbLedgerState<'PermissionsMode> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : QldbLedgerState<'PermissionsMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_ledger#deletion_protection-1">QldbLedger#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: QldbLedgerState<'PermissionsMode>, value: HashiCorp.Cdktf.IResolvable) : QldbLedgerState<'PermissionsMode> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : QldbLedgerState<'PermissionsMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_ledger#id-1">QldbLedger#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: QldbLedgerState<'PermissionsMode>, value: string) : QldbLedgerState<'PermissionsMode> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : QldbLedgerState<'PermissionsMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_ledger#kms_key-1">QldbLedger#kms_key</a>.
        /// </summary>
        [<CustomOperation "kms_key">]
        member _.KmsKey(state: QldbLedgerState<'PermissionsMode>, value: string) : QldbLedgerState<'PermissionsMode> =
            state.assignments.Add(fun config -> config.KmsKey <- value)
            state : QldbLedgerState<'PermissionsMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_ledger#name-1">QldbLedger#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: QldbLedgerState<'PermissionsMode>, value: string) : QldbLedgerState<'PermissionsMode> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : QldbLedgerState<'PermissionsMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_ledger#tags-1">QldbLedger#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: QldbLedgerState<'PermissionsMode>, value: seq<string * string>) : QldbLedgerState<'PermissionsMode> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : QldbLedgerState<'PermissionsMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_ledger#tags_all-1">QldbLedger#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: QldbLedgerState<'PermissionsMode>, value: seq<string * string>) : QldbLedgerState<'PermissionsMode> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : QldbLedgerState<'PermissionsMode>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_ledger#timeouts-1">QldbLedger#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: QldbLedgerState<'PermissionsMode>, value: aws.QldbLedger.QldbLedgerTimeouts) : QldbLedgerState<'PermissionsMode> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : QldbLedgerState<'PermissionsMode>

        member _.Run(state: QldbLedgerState<Present>) : aws.QldbLedger.QldbLedger =
            let config = aws.QldbLedger.QldbLedgerConfig()
            for setter in state.assignments do
                setter config
            aws.QldbLedger.QldbLedger(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.qldbLedger: missing required arguments. Must call: permissions_mode.", 9999, IsError = true)>]
        member _.Run(_: QldbLedgerState<_>) : aws.QldbLedger.QldbLedger =
            Unchecked.defaultof<aws.QldbLedger.QldbLedger>
