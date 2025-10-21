namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsGlueConnectionState<'Id> = { assignments: ResizeArray<aws.DataAwsGlueConnection.DataAwsGlueConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_connection">aws_glue_connection</a>.
    /// </summary>
    type DataAwsGlueConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsGlueConnectionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsGlueConnectionState<Missing>)

        member _.Zero(()) : DataAwsGlueConnectionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsGlueConnectionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_connection#id-1">DataAwsGlueConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsGlueConnectionState<Missing>, value: string) : DataAwsGlueConnectionState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsGlueConnectionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_connection#tags-1">DataAwsGlueConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsGlueConnectionState<'Id>, value: seq<string * string>) : DataAwsGlueConnectionState<'Id> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsGlueConnectionState<'Id>

        member _.Run(state: DataAwsGlueConnectionState<Present>) : aws.DataAwsGlueConnection.DataAwsGlueConnection =
            let config = aws.DataAwsGlueConnection.DataAwsGlueConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsGlueConnection.DataAwsGlueConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsGlueConnection: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsGlueConnectionState<_>) : aws.DataAwsGlueConnection.DataAwsGlueConnection =
            Unchecked.defaultof<aws.DataAwsGlueConnection.DataAwsGlueConnection>
