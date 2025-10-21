namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Sesv2EmailIdentityFeedbackAttributesState<'EmailIdentity> = { assignments: ResizeArray<aws.Sesv2EmailIdentityFeedbackAttributes.Sesv2EmailIdentityFeedbackAttributesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_feedback_attributes">aws_sesv2_email_identity_feedback_attributes</a>.
    /// </summary>
    type Sesv2EmailIdentityFeedbackAttributesBuilder(logicalId: string) =
        member _.Yield(_: unit) : Sesv2EmailIdentityFeedbackAttributesState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2EmailIdentityFeedbackAttributesState<Missing>)

        member _.Zero(()) : Sesv2EmailIdentityFeedbackAttributesState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2EmailIdentityFeedbackAttributesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_feedback_attributes#email_identity-1">Sesv2EmailIdentityFeedbackAttributes#email_identity</a>.
        /// </summary>
        [<CustomOperation "email_identity">]
        member _.EmailIdentity(state: Sesv2EmailIdentityFeedbackAttributesState<Missing>, value: string) : Sesv2EmailIdentityFeedbackAttributesState<Present> =
            state.assignments.Add(fun config -> config.EmailIdentity <- value)
            ({ assignments = state.assignments } : Sesv2EmailIdentityFeedbackAttributesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_feedback_attributes#email_forwarding_enabled-1">Sesv2EmailIdentityFeedbackAttributes#email_forwarding_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "email_forwarding_enabled">]
        member _.EmailForwardingEnabled(state: Sesv2EmailIdentityFeedbackAttributesState<'EmailIdentity>, value: bool) : Sesv2EmailIdentityFeedbackAttributesState<'EmailIdentity> =
            state.assignments.Add(fun config -> config.EmailForwardingEnabled <- value)
            state : Sesv2EmailIdentityFeedbackAttributesState<'EmailIdentity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_feedback_attributes#email_forwarding_enabled-1">Sesv2EmailIdentityFeedbackAttributes#email_forwarding_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "email_forwarding_enabled">]
        member _.EmailForwardingEnabled(state: Sesv2EmailIdentityFeedbackAttributesState<'EmailIdentity>, value: HashiCorp.Cdktf.IResolvable) : Sesv2EmailIdentityFeedbackAttributesState<'EmailIdentity> =
            state.assignments.Add(fun config -> config.EmailForwardingEnabled <- value)
            state : Sesv2EmailIdentityFeedbackAttributesState<'EmailIdentity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_feedback_attributes#id-1">Sesv2EmailIdentityFeedbackAttributes#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Sesv2EmailIdentityFeedbackAttributesState<'EmailIdentity>, value: string) : Sesv2EmailIdentityFeedbackAttributesState<'EmailIdentity> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Sesv2EmailIdentityFeedbackAttributesState<'EmailIdentity>

        member _.Run(state: Sesv2EmailIdentityFeedbackAttributesState<Present>) : aws.Sesv2EmailIdentityFeedbackAttributes.Sesv2EmailIdentityFeedbackAttributes =
            let config = aws.Sesv2EmailIdentityFeedbackAttributes.Sesv2EmailIdentityFeedbackAttributesConfig()
            for setter in state.assignments do
                setter config
            aws.Sesv2EmailIdentityFeedbackAttributes.Sesv2EmailIdentityFeedbackAttributes(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesv2EmailIdentityFeedbackAttributes: missing required arguments. Must call: email_identity.", 9999, IsError = true)>]
        member _.Run(_: Sesv2EmailIdentityFeedbackAttributesState<_>) : aws.Sesv2EmailIdentityFeedbackAttributes.Sesv2EmailIdentityFeedbackAttributes =
            Unchecked.defaultof<aws.Sesv2EmailIdentityFeedbackAttributes.Sesv2EmailIdentityFeedbackAttributes>
