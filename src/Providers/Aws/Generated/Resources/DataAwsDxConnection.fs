namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDxConnectionState<'Name> = { assignments: ResizeArray<aws.DataAwsDxConnection.DataAwsDxConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dx_connection">aws_dx_connection</a>.
    /// </summary>
    type DataAwsDxConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDxConnectionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDxConnectionState<Missing>)

        member _.Zero(()) : DataAwsDxConnectionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDxConnectionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dx_connection#name-1">DataAwsDxConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsDxConnectionState<Missing>, value: string) : DataAwsDxConnectionState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsDxConnectionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dx_connection#id-1">DataAwsDxConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDxConnectionState<'Name>, value: string) : DataAwsDxConnectionState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDxConnectionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dx_connection#tags-1">DataAwsDxConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsDxConnectionState<'Name>, value: seq<string * string>) : DataAwsDxConnectionState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsDxConnectionState<'Name>

        member _.Run(state: DataAwsDxConnectionState<Present>) : aws.DataAwsDxConnection.DataAwsDxConnection =
            let config = aws.DataAwsDxConnection.DataAwsDxConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDxConnection.DataAwsDxConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDxConnection: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDxConnectionState<_>) : aws.DataAwsDxConnection.DataAwsDxConnection =
            Unchecked.defaultof<aws.DataAwsDxConnection.DataAwsDxConnection>
