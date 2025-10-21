namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSesv2EmailIdentityMailFromAttributesState<'EmailIdentity> = { assignments: ResizeArray<aws.DataAwsSesv2EmailIdentityMailFromAttributes.DataAwsSesv2EmailIdentityMailFromAttributesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_email_identity_mail_from_attributes">aws_sesv2_email_identity_mail_from_attributes</a>.
    /// </summary>
    type DataAwsSesv2EmailIdentityMailFromAttributesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSesv2EmailIdentityMailFromAttributesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSesv2EmailIdentityMailFromAttributesState<Missing>)

        member _.Zero(()) : DataAwsSesv2EmailIdentityMailFromAttributesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSesv2EmailIdentityMailFromAttributesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_email_identity_mail_from_attributes#email_identity-1">DataAwsSesv2EmailIdentityMailFromAttributes#email_identity</a>.
        /// </summary>
        [<CustomOperation "email_identity">]
        member _.EmailIdentity(state: DataAwsSesv2EmailIdentityMailFromAttributesState<Missing>, value: string) : DataAwsSesv2EmailIdentityMailFromAttributesState<Present> =
            state.assignments.Add(fun config -> config.EmailIdentity <- value)
            ({ assignments = state.assignments } : DataAwsSesv2EmailIdentityMailFromAttributesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_email_identity_mail_from_attributes#id-1">DataAwsSesv2EmailIdentityMailFromAttributes#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSesv2EmailIdentityMailFromAttributesState<'EmailIdentity>, value: string) : DataAwsSesv2EmailIdentityMailFromAttributesState<'EmailIdentity> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSesv2EmailIdentityMailFromAttributesState<'EmailIdentity>

        member _.Run(state: DataAwsSesv2EmailIdentityMailFromAttributesState<Present>) : aws.DataAwsSesv2EmailIdentityMailFromAttributes.DataAwsSesv2EmailIdentityMailFromAttributes =
            let config = aws.DataAwsSesv2EmailIdentityMailFromAttributes.DataAwsSesv2EmailIdentityMailFromAttributesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSesv2EmailIdentityMailFromAttributes.DataAwsSesv2EmailIdentityMailFromAttributes(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSesv2EmailIdentityMailFromAttributes: missing required arguments. Must call: email_identity.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSesv2EmailIdentityMailFromAttributesState<_>) : aws.DataAwsSesv2EmailIdentityMailFromAttributes.DataAwsSesv2EmailIdentityMailFromAttributes =
            Unchecked.defaultof<aws.DataAwsSesv2EmailIdentityMailFromAttributes.DataAwsSesv2EmailIdentityMailFromAttributes>
