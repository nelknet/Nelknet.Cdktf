namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmcontactsContactChannelState<'ContactId, 'DeliveryAddress, 'Name, 'Type> = { assignments: ResizeArray<aws.SsmcontactsContactChannel.SsmcontactsContactChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_contact_channel">aws_ssmcontacts_contact_channel</a>.
    /// </summary>
    type SsmcontactsContactChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmcontactsContactChannelState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmcontactsContactChannelState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SsmcontactsContactChannelState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmcontactsContactChannelState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_contact_channel#contact_id-1">SsmcontactsContactChannel#contact_id</a>.
        /// </summary>
        [<CustomOperation "contact_id">]
        member _.ContactId(state: SsmcontactsContactChannelState<Missing, 'DeliveryAddress, 'Name, 'Type>, value: string) : SsmcontactsContactChannelState<Present, 'DeliveryAddress, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.ContactId <- value)
            ({ assignments = state.assignments } : SsmcontactsContactChannelState<Present, 'DeliveryAddress, 'Name, 'Type>)

        /// <summary>
        /// delivery_address block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_contact_channel#delivery_address-1">SsmcontactsContactChannel#delivery_address</a>
        /// </summary>
        [<CustomOperation "delivery_address">]
        member _.DeliveryAddress(state: SsmcontactsContactChannelState<'ContactId, Missing, 'Name, 'Type>, value: aws.SsmcontactsContactChannel.SsmcontactsContactChannelDeliveryAddress) : SsmcontactsContactChannelState<'ContactId, Present, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.DeliveryAddress <- value)
            ({ assignments = state.assignments } : SsmcontactsContactChannelState<'ContactId, Present, 'Name, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_contact_channel#name-1">SsmcontactsContactChannel#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsmcontactsContactChannelState<'ContactId, 'DeliveryAddress, Missing, 'Type>, value: string) : SsmcontactsContactChannelState<'ContactId, 'DeliveryAddress, Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SsmcontactsContactChannelState<'ContactId, 'DeliveryAddress, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_contact_channel#type-1">SsmcontactsContactChannel#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: SsmcontactsContactChannelState<'ContactId, 'DeliveryAddress, 'Name, Missing>, value: string) : SsmcontactsContactChannelState<'ContactId, 'DeliveryAddress, 'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : SsmcontactsContactChannelState<'ContactId, 'DeliveryAddress, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_contact_channel#id-1">SsmcontactsContactChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmcontactsContactChannelState<'ContactId, 'DeliveryAddress, 'Name, 'Type>, value: string) : SsmcontactsContactChannelState<'ContactId, 'DeliveryAddress, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmcontactsContactChannelState<'ContactId, 'DeliveryAddress, 'Name, 'Type>

        member _.Run(state: SsmcontactsContactChannelState<Present, Present, Present, Present>) : aws.SsmcontactsContactChannel.SsmcontactsContactChannel =
            let config = aws.SsmcontactsContactChannel.SsmcontactsContactChannelConfig()
            for setter in state.assignments do
                setter config
            aws.SsmcontactsContactChannel.SsmcontactsContactChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmcontactsContactChannel: missing required arguments. Must call: contact_id, delivery_address, name, type.", 9999, IsError = true)>]
        member _.Run(_: SsmcontactsContactChannelState<_, _, _, _>) : aws.SsmcontactsContactChannel.SsmcontactsContactChannel =
            Unchecked.defaultof<aws.SsmcontactsContactChannel.SsmcontactsContactChannel>
