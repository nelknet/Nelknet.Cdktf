namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Sesv2EmailIdentityMailFromAttributesState<'EmailIdentity> = { assignments: ResizeArray<aws.Sesv2EmailIdentityMailFromAttributes.Sesv2EmailIdentityMailFromAttributesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_mail_from_attributes">aws_sesv2_email_identity_mail_from_attributes</a>.
    /// </summary>
    type Sesv2EmailIdentityMailFromAttributesBuilder(logicalId: string) =
        member _.Yield(_: unit) : Sesv2EmailIdentityMailFromAttributesState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2EmailIdentityMailFromAttributesState<Missing>)

        member _.Zero(()) : Sesv2EmailIdentityMailFromAttributesState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2EmailIdentityMailFromAttributesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_mail_from_attributes#email_identity-1">Sesv2EmailIdentityMailFromAttributes#email_identity</a>.
        /// </summary>
        [<CustomOperation "email_identity">]
        member _.EmailIdentity(state: Sesv2EmailIdentityMailFromAttributesState<Missing>, value: string) : Sesv2EmailIdentityMailFromAttributesState<Present> =
            state.assignments.Add(fun config -> config.EmailIdentity <- value)
            ({ assignments = state.assignments } : Sesv2EmailIdentityMailFromAttributesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_mail_from_attributes#behavior_on_mx_failure-1">Sesv2EmailIdentityMailFromAttributes#behavior_on_mx_failure</a>.
        /// </summary>
        [<CustomOperation "behavior_on_mx_failure">]
        member _.BehaviorOnMxFailure(state: Sesv2EmailIdentityMailFromAttributesState<'EmailIdentity>, value: string) : Sesv2EmailIdentityMailFromAttributesState<'EmailIdentity> =
            state.assignments.Add(fun config -> config.BehaviorOnMxFailure <- value)
            state : Sesv2EmailIdentityMailFromAttributesState<'EmailIdentity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_mail_from_attributes#id-1">Sesv2EmailIdentityMailFromAttributes#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Sesv2EmailIdentityMailFromAttributesState<'EmailIdentity>, value: string) : Sesv2EmailIdentityMailFromAttributesState<'EmailIdentity> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Sesv2EmailIdentityMailFromAttributesState<'EmailIdentity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_mail_from_attributes#mail_from_domain-1">Sesv2EmailIdentityMailFromAttributes#mail_from_domain</a>.
        /// </summary>
        [<CustomOperation "mail_from_domain">]
        member _.MailFromDomain(state: Sesv2EmailIdentityMailFromAttributesState<'EmailIdentity>, value: string) : Sesv2EmailIdentityMailFromAttributesState<'EmailIdentity> =
            state.assignments.Add(fun config -> config.MailFromDomain <- value)
            state : Sesv2EmailIdentityMailFromAttributesState<'EmailIdentity>

        member _.Run(state: Sesv2EmailIdentityMailFromAttributesState<Present>) : aws.Sesv2EmailIdentityMailFromAttributes.Sesv2EmailIdentityMailFromAttributes =
            let config = aws.Sesv2EmailIdentityMailFromAttributes.Sesv2EmailIdentityMailFromAttributesConfig()
            for setter in state.assignments do
                setter config
            aws.Sesv2EmailIdentityMailFromAttributes.Sesv2EmailIdentityMailFromAttributes(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesv2EmailIdentityMailFromAttributes: missing required arguments. Must call: email_identity.", 9999, IsError = true)>]
        member _.Run(_: Sesv2EmailIdentityMailFromAttributesState<_>) : aws.Sesv2EmailIdentityMailFromAttributes.Sesv2EmailIdentityMailFromAttributes =
            Unchecked.defaultof<aws.Sesv2EmailIdentityMailFromAttributes.Sesv2EmailIdentityMailFromAttributes>
