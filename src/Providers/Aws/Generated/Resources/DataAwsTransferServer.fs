namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsTransferServerState<'ServerId> = { assignments: ResizeArray<aws.DataAwsTransferServer.DataAwsTransferServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/transfer_server">aws_transfer_server</a>.
    /// </summary>
    type DataAwsTransferServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsTransferServerState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsTransferServerState<Missing>)

        member _.Zero(()) : DataAwsTransferServerState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsTransferServerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/transfer_server#server_id-1">DataAwsTransferServer#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: DataAwsTransferServerState<Missing>, value: string) : DataAwsTransferServerState<Present> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : DataAwsTransferServerState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/transfer_server#id-1">DataAwsTransferServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsTransferServerState<'ServerId>, value: string) : DataAwsTransferServerState<'ServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsTransferServerState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/transfer_server#tags-1">DataAwsTransferServer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsTransferServerState<'ServerId>, value: seq<string * string>) : DataAwsTransferServerState<'ServerId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsTransferServerState<'ServerId>

        member _.Run(state: DataAwsTransferServerState<Present>) : aws.DataAwsTransferServer.DataAwsTransferServer =
            let config = aws.DataAwsTransferServer.DataAwsTransferServerConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsTransferServer.DataAwsTransferServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsTransferServer: missing required arguments. Must call: server_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsTransferServerState<_>) : aws.DataAwsTransferServer.DataAwsTransferServer =
            Unchecked.defaultof<aws.DataAwsTransferServer.DataAwsTransferServer>
