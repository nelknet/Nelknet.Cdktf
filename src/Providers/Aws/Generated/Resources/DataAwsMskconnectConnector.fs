namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMskconnectConnectorState<'Name> = { assignments: ResizeArray<aws.DataAwsMskconnectConnector.DataAwsMskconnectConnectorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mskconnect_connector">aws_mskconnect_connector</a>.
    /// </summary>
    type DataAwsMskconnectConnectorBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMskconnectConnectorState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskconnectConnectorState<Missing>)

        member _.Zero(()) : DataAwsMskconnectConnectorState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskconnectConnectorState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mskconnect_connector#name-1">DataAwsMskconnectConnector#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsMskconnectConnectorState<Missing>, value: string) : DataAwsMskconnectConnectorState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsMskconnectConnectorState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mskconnect_connector#id-1">DataAwsMskconnectConnector#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMskconnectConnectorState<'Name>, value: string) : DataAwsMskconnectConnectorState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMskconnectConnectorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mskconnect_connector#tags-1">DataAwsMskconnectConnector#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsMskconnectConnectorState<'Name>, value: seq<string * string>) : DataAwsMskconnectConnectorState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsMskconnectConnectorState<'Name>

        member _.Run(state: DataAwsMskconnectConnectorState<Present>) : aws.DataAwsMskconnectConnector.DataAwsMskconnectConnector =
            let config = aws.DataAwsMskconnectConnector.DataAwsMskconnectConnectorConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMskconnectConnector.DataAwsMskconnectConnector(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMskconnectConnector: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMskconnectConnectorState<_>) : aws.DataAwsMskconnectConnector.DataAwsMskconnectConnector =
            Unchecked.defaultof<aws.DataAwsMskconnectConnector.DataAwsMskconnectConnector>
