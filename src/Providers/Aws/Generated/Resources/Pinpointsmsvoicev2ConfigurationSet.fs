namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Pinpointsmsvoicev2ConfigurationSetState<'Name> = { assignments: ResizeArray<aws.Pinpointsmsvoicev2ConfigurationSet.Pinpointsmsvoicev2ConfigurationSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_configuration_set">aws_pinpointsmsvoicev2_configuration_set</a>.
    /// </summary>
    type Pinpointsmsvoicev2ConfigurationSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : Pinpointsmsvoicev2ConfigurationSetState<Missing> =
            ({ assignments = ResizeArray() } : Pinpointsmsvoicev2ConfigurationSetState<Missing>)

        member _.Zero(()) : Pinpointsmsvoicev2ConfigurationSetState<Missing> =
            ({ assignments = ResizeArray() } : Pinpointsmsvoicev2ConfigurationSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_configuration_set#name-1">Pinpointsmsvoicev2ConfigurationSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Pinpointsmsvoicev2ConfigurationSetState<Missing>, value: string) : Pinpointsmsvoicev2ConfigurationSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Pinpointsmsvoicev2ConfigurationSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_configuration_set#default_message_type-1">Pinpointsmsvoicev2ConfigurationSet#default_message_type</a>.
        /// </summary>
        [<CustomOperation "default_message_type">]
        member _.DefaultMessageType(state: Pinpointsmsvoicev2ConfigurationSetState<'Name>, value: string) : Pinpointsmsvoicev2ConfigurationSetState<'Name> =
            state.assignments.Add(fun config -> config.DefaultMessageType <- value)
            state : Pinpointsmsvoicev2ConfigurationSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_configuration_set#default_sender_id-1">Pinpointsmsvoicev2ConfigurationSet#default_sender_id</a>.
        /// </summary>
        [<CustomOperation "default_sender_id">]
        member _.DefaultSenderId(state: Pinpointsmsvoicev2ConfigurationSetState<'Name>, value: string) : Pinpointsmsvoicev2ConfigurationSetState<'Name> =
            state.assignments.Add(fun config -> config.DefaultSenderId <- value)
            state : Pinpointsmsvoicev2ConfigurationSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_configuration_set#tags-1">Pinpointsmsvoicev2ConfigurationSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Pinpointsmsvoicev2ConfigurationSetState<'Name>, value: seq<string * string>) : Pinpointsmsvoicev2ConfigurationSetState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Pinpointsmsvoicev2ConfigurationSetState<'Name>

        member _.Run(state: Pinpointsmsvoicev2ConfigurationSetState<Present>) : aws.Pinpointsmsvoicev2ConfigurationSet.Pinpointsmsvoicev2ConfigurationSet =
            let config = aws.Pinpointsmsvoicev2ConfigurationSet.Pinpointsmsvoicev2ConfigurationSetConfig()
            for setter in state.assignments do
                setter config
            aws.Pinpointsmsvoicev2ConfigurationSet.Pinpointsmsvoicev2ConfigurationSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pinpointsmsvoicev2ConfigurationSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: Pinpointsmsvoicev2ConfigurationSetState<_>) : aws.Pinpointsmsvoicev2ConfigurationSet.Pinpointsmsvoicev2ConfigurationSet =
            Unchecked.defaultof<aws.Pinpointsmsvoicev2ConfigurationSet.Pinpointsmsvoicev2ConfigurationSet>
