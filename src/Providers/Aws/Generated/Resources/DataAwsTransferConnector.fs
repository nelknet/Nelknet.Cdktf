namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsTransferConnectorState<'Id> = { assignments: ResizeArray<aws.DataAwsTransferConnector.DataAwsTransferConnectorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/transfer_connector">aws_transfer_connector</a>.
    /// </summary>
    type DataAwsTransferConnectorBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsTransferConnectorState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsTransferConnectorState<Missing>)

        member _.Zero(()) : DataAwsTransferConnectorState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsTransferConnectorState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/transfer_connector#id-1">DataAwsTransferConnector#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsTransferConnectorState<Missing>, value: string) : DataAwsTransferConnectorState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsTransferConnectorState<Present>)

        member _.Run(state: DataAwsTransferConnectorState<Present>) : aws.DataAwsTransferConnector.DataAwsTransferConnector =
            let config = aws.DataAwsTransferConnector.DataAwsTransferConnectorConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsTransferConnector.DataAwsTransferConnector(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsTransferConnector: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsTransferConnectorState<_>) : aws.DataAwsTransferConnector.DataAwsTransferConnector =
            Unchecked.defaultof<aws.DataAwsTransferConnector.DataAwsTransferConnector>
