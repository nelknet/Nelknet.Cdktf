namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NotificationscontactsEmailContactState<'EmailAddress, 'Name> = { assignments: ResizeArray<aws.NotificationscontactsEmailContact.NotificationscontactsEmailContactConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notificationscontacts_email_contact">aws_notificationscontacts_email_contact</a>.
    /// </summary>
    type NotificationscontactsEmailContactBuilder(logicalId: string) =
        member _.Yield(_: unit) : NotificationscontactsEmailContactState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NotificationscontactsEmailContactState<Missing, Missing>)

        member _.Zero(()) : NotificationscontactsEmailContactState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NotificationscontactsEmailContactState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notificationscontacts_email_contact#email_address-1">NotificationscontactsEmailContact#email_address</a>.
        /// </summary>
        [<CustomOperation "email_address">]
        member _.EmailAddress(state: NotificationscontactsEmailContactState<Missing, 'Name>, value: string) : NotificationscontactsEmailContactState<Present, 'Name> =
            state.assignments.Add(fun config -> config.EmailAddress <- value)
            ({ assignments = state.assignments } : NotificationscontactsEmailContactState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notificationscontacts_email_contact#name-1">NotificationscontactsEmailContact#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NotificationscontactsEmailContactState<'EmailAddress, Missing>, value: string) : NotificationscontactsEmailContactState<'EmailAddress, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NotificationscontactsEmailContactState<'EmailAddress, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/notificationscontacts_email_contact#tags-1">NotificationscontactsEmailContact#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NotificationscontactsEmailContactState<'EmailAddress, 'Name>, value: seq<string * string>) : NotificationscontactsEmailContactState<'EmailAddress, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NotificationscontactsEmailContactState<'EmailAddress, 'Name>

        member _.Run(state: NotificationscontactsEmailContactState<Present, Present>) : aws.NotificationscontactsEmailContact.NotificationscontactsEmailContact =
            let config = aws.NotificationscontactsEmailContact.NotificationscontactsEmailContactConfig()
            for setter in state.assignments do
                setter config
            aws.NotificationscontactsEmailContact.NotificationscontactsEmailContact(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.notificationscontactsEmailContact: missing required arguments. Must call: email_address, name.", 9999, IsError = true)>]
        member _.Run(_: NotificationscontactsEmailContactState<_, _>) : aws.NotificationscontactsEmailContact.NotificationscontactsEmailContact =
            Unchecked.defaultof<aws.NotificationscontactsEmailContact.NotificationscontactsEmailContact>
