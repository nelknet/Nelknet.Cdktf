namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsmcontactsContactChannelState<'Arn> = { assignments: ResizeArray<aws.DataAwsSsmcontactsContactChannel.DataAwsSsmcontactsContactChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmcontacts_contact_channel">aws_ssmcontacts_contact_channel</a>.
    /// </summary>
    type DataAwsSsmcontactsContactChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsmcontactsContactChannelState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmcontactsContactChannelState<Missing>)

        member _.Zero(()) : DataAwsSsmcontactsContactChannelState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmcontactsContactChannelState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmcontacts_contact_channel#arn-1">DataAwsSsmcontactsContactChannel#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsSsmcontactsContactChannelState<Missing>, value: string) : DataAwsSsmcontactsContactChannelState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsSsmcontactsContactChannelState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmcontacts_contact_channel#id-1">DataAwsSsmcontactsContactChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSsmcontactsContactChannelState<'Arn>, value: string) : DataAwsSsmcontactsContactChannelState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSsmcontactsContactChannelState<'Arn>

        member _.Run(state: DataAwsSsmcontactsContactChannelState<Present>) : aws.DataAwsSsmcontactsContactChannel.DataAwsSsmcontactsContactChannel =
            let config = aws.DataAwsSsmcontactsContactChannel.DataAwsSsmcontactsContactChannelConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsmcontactsContactChannel.DataAwsSsmcontactsContactChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSsmcontactsContactChannel: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSsmcontactsContactChannelState<_>) : aws.DataAwsSsmcontactsContactChannel.DataAwsSsmcontactsContactChannel =
            Unchecked.defaultof<aws.DataAwsSsmcontactsContactChannel.DataAwsSsmcontactsContactChannel>
