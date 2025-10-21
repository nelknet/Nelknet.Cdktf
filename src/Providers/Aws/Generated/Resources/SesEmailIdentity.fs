namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SesEmailIdentityState<'Email> = { assignments: ResizeArray<aws.SesEmailIdentity.SesEmailIdentityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_email_identity">aws_ses_email_identity</a>.
    /// </summary>
    type SesEmailIdentityBuilder(logicalId: string) =
        member _.Yield(_: unit) : SesEmailIdentityState<Missing> =
            ({ assignments = ResizeArray() } : SesEmailIdentityState<Missing>)

        member _.Zero(()) : SesEmailIdentityState<Missing> =
            ({ assignments = ResizeArray() } : SesEmailIdentityState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_email_identity#email-1">SesEmailIdentity#email</a>.
        /// </summary>
        [<CustomOperation "email">]
        member _.Email(state: SesEmailIdentityState<Missing>, value: string) : SesEmailIdentityState<Present> =
            state.assignments.Add(fun config -> config.Email <- value)
            ({ assignments = state.assignments } : SesEmailIdentityState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_email_identity#id-1">SesEmailIdentity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SesEmailIdentityState<'Email>, value: string) : SesEmailIdentityState<'Email> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SesEmailIdentityState<'Email>

        member _.Run(state: SesEmailIdentityState<Present>) : aws.SesEmailIdentity.SesEmailIdentity =
            let config = aws.SesEmailIdentity.SesEmailIdentityConfig()
            for setter in state.assignments do
                setter config
            aws.SesEmailIdentity.SesEmailIdentity(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesEmailIdentity: missing required arguments. Must call: email.", 9999, IsError = true)>]
        member _.Run(_: SesEmailIdentityState<_>) : aws.SesEmailIdentity.SesEmailIdentity =
            Unchecked.defaultof<aws.SesEmailIdentity.SesEmailIdentity>
