namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSesEmailIdentityState<'Email> = { assignments: ResizeArray<aws.DataAwsSesEmailIdentity.DataAwsSesEmailIdentityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ses_email_identity">aws_ses_email_identity</a>.
    /// </summary>
    type DataAwsSesEmailIdentityBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSesEmailIdentityState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSesEmailIdentityState<Missing>)

        member _.Zero(()) : DataAwsSesEmailIdentityState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSesEmailIdentityState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ses_email_identity#email-1">DataAwsSesEmailIdentity#email</a>.
        /// </summary>
        [<CustomOperation "email">]
        member _.Email(state: DataAwsSesEmailIdentityState<Missing>, value: string) : DataAwsSesEmailIdentityState<Present> =
            state.assignments.Add(fun config -> config.Email <- value)
            ({ assignments = state.assignments } : DataAwsSesEmailIdentityState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ses_email_identity#id-1">DataAwsSesEmailIdentity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSesEmailIdentityState<'Email>, value: string) : DataAwsSesEmailIdentityState<'Email> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSesEmailIdentityState<'Email>

        member _.Run(state: DataAwsSesEmailIdentityState<Present>) : aws.DataAwsSesEmailIdentity.DataAwsSesEmailIdentity =
            let config = aws.DataAwsSesEmailIdentity.DataAwsSesEmailIdentityConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSesEmailIdentity.DataAwsSesEmailIdentity(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSesEmailIdentity: missing required arguments. Must call: email.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSesEmailIdentityState<_>) : aws.DataAwsSesEmailIdentity.DataAwsSesEmailIdentity =
            Unchecked.defaultof<aws.DataAwsSesEmailIdentity.DataAwsSesEmailIdentity>
