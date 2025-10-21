namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCodestarconnectionsConnectionState = { assignments: ResizeArray<aws.DataAwsCodestarconnectionsConnection.DataAwsCodestarconnectionsConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codestarconnections_connection">aws_codestarconnections_connection</a>.
    /// </summary>
    type DataAwsCodestarconnectionsConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCodestarconnectionsConnectionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsCodestarconnectionsConnectionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codestarconnections_connection#arn-1">DataAwsCodestarconnectionsConnection#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsCodestarconnectionsConnectionState, value: string) : DataAwsCodestarconnectionsConnectionState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsCodestarconnectionsConnectionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codestarconnections_connection#id-1">DataAwsCodestarconnectionsConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCodestarconnectionsConnectionState, value: string) : DataAwsCodestarconnectionsConnectionState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCodestarconnectionsConnectionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codestarconnections_connection#name-1">DataAwsCodestarconnectionsConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCodestarconnectionsConnectionState, value: string) : DataAwsCodestarconnectionsConnectionState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsCodestarconnectionsConnectionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codestarconnections_connection#tags-1">DataAwsCodestarconnectionsConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsCodestarconnectionsConnectionState, value: seq<string * string>) : DataAwsCodestarconnectionsConnectionState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsCodestarconnectionsConnectionState

        member _.Run(state: DataAwsCodestarconnectionsConnectionState) : aws.DataAwsCodestarconnectionsConnection.DataAwsCodestarconnectionsConnection =
            let config = aws.DataAwsCodestarconnectionsConnection.DataAwsCodestarconnectionsConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCodestarconnectionsConnection.DataAwsCodestarconnectionsConnection(StackContext.get (), logicalId, config)
