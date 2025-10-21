namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudwatchEventConnectionState<'Name> = { assignments: ResizeArray<aws.DataAwsCloudwatchEventConnection.DataAwsCloudwatchEventConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_event_connection">aws_cloudwatch_event_connection</a>.
    /// </summary>
    type DataAwsCloudwatchEventConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudwatchEventConnectionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudwatchEventConnectionState<Missing>)

        member _.Zero(()) : DataAwsCloudwatchEventConnectionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudwatchEventConnectionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_event_connection#name-1">DataAwsCloudwatchEventConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCloudwatchEventConnectionState<Missing>, value: string) : DataAwsCloudwatchEventConnectionState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsCloudwatchEventConnectionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_event_connection#id-1">DataAwsCloudwatchEventConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudwatchEventConnectionState<'Name>, value: string) : DataAwsCloudwatchEventConnectionState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudwatchEventConnectionState<'Name>

        member _.Run(state: DataAwsCloudwatchEventConnectionState<Present>) : aws.DataAwsCloudwatchEventConnection.DataAwsCloudwatchEventConnection =
            let config = aws.DataAwsCloudwatchEventConnection.DataAwsCloudwatchEventConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudwatchEventConnection.DataAwsCloudwatchEventConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCloudwatchEventConnection: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCloudwatchEventConnectionState<_>) : aws.DataAwsCloudwatchEventConnection.DataAwsCloudwatchEventConnection =
            Unchecked.defaultof<aws.DataAwsCloudwatchEventConnection.DataAwsCloudwatchEventConnection>
