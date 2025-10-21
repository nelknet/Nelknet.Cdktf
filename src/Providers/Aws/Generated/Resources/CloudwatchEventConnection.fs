namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, 'Name> = { assignments: ResizeArray<aws.CloudwatchEventConnection.CloudwatchEventConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection">aws_cloudwatch_event_connection</a>.
    /// </summary>
    type CloudwatchEventConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchEventConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventConnectionState<Missing, Missing, Missing>)

        member _.Zero(()) : CloudwatchEventConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventConnectionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#authorization_type-1">CloudwatchEventConnection#authorization_type</a>.
        /// </summary>
        [<CustomOperation "authorization_type">]
        member _.AuthorizationType(state: CloudwatchEventConnectionState<Missing, 'AuthParameters, 'Name>, value: string) : CloudwatchEventConnectionState<Present, 'AuthParameters, 'Name> =
            state.assignments.Add(fun config -> config.AuthorizationType <- value)
            ({ assignments = state.assignments } : CloudwatchEventConnectionState<Present, 'AuthParameters, 'Name>)

        /// <summary>
        /// auth_parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#auth_parameters-1">CloudwatchEventConnection#auth_parameters</a>
        /// </summary>
        [<CustomOperation "auth_parameters">]
        member _.AuthParameters(state: CloudwatchEventConnectionState<'AuthorizationType, Missing, 'Name>, value: aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParameters) : CloudwatchEventConnectionState<'AuthorizationType, Present, 'Name> =
            state.assignments.Add(fun config -> config.AuthParameters <- value)
            ({ assignments = state.assignments } : CloudwatchEventConnectionState<'AuthorizationType, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#name-1">CloudwatchEventConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, Missing>, value: string) : CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#description-1">CloudwatchEventConnection#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, 'Name>, value: string) : CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#id-1">CloudwatchEventConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, 'Name>, value: string) : CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, 'Name>

        /// <summary>
        /// invocation_connectivity_parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#invocation_connectivity_parameters-1">CloudwatchEventConnection#invocation_connectivity_parameters</a>
        /// </summary>
        [<CustomOperation "invocation_connectivity_parameters">]
        member _.InvocationConnectivityParameters(state: CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, 'Name>, value: aws.CloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParameters) : CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, 'Name> =
            state.assignments.Add(fun config -> config.InvocationConnectivityParameters <- value)
            state : CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#kms_key_identifier-1">CloudwatchEventConnection#kms_key_identifier</a>.
        /// </summary>
        [<CustomOperation "kms_key_identifier">]
        member _.KmsKeyIdentifier(state: CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, 'Name>, value: string) : CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, 'Name> =
            state.assignments.Add(fun config -> config.KmsKeyIdentifier <- value)
            state : CloudwatchEventConnectionState<'AuthorizationType, 'AuthParameters, 'Name>

        member _.Run(state: CloudwatchEventConnectionState<Present, Present, Present>) : aws.CloudwatchEventConnection.CloudwatchEventConnection =
            let config = aws.CloudwatchEventConnection.CloudwatchEventConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchEventConnection.CloudwatchEventConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchEventConnection: missing required arguments. Must call: authorization_type, auth_parameters, name.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchEventConnectionState<_, _, _>) : aws.CloudwatchEventConnection.CloudwatchEventConnection =
            Unchecked.defaultof<aws.CloudwatchEventConnection.CloudwatchEventConnection>
