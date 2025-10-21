namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSesv2EmailIdentityState<'EmailIdentity> = { assignments: ResizeArray<aws.DataAwsSesv2EmailIdentity.DataAwsSesv2EmailIdentityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_email_identity">aws_sesv2_email_identity</a>.
    /// </summary>
    type DataAwsSesv2EmailIdentityBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSesv2EmailIdentityState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSesv2EmailIdentityState<Missing>)

        member _.Zero(()) : DataAwsSesv2EmailIdentityState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSesv2EmailIdentityState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_email_identity#email_identity-1">DataAwsSesv2EmailIdentity#email_identity</a>.
        /// </summary>
        [<CustomOperation "email_identity">]
        member _.EmailIdentity(state: DataAwsSesv2EmailIdentityState<Missing>, value: string) : DataAwsSesv2EmailIdentityState<Present> =
            state.assignments.Add(fun config -> config.EmailIdentity <- value)
            ({ assignments = state.assignments } : DataAwsSesv2EmailIdentityState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_email_identity#id-1">DataAwsSesv2EmailIdentity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSesv2EmailIdentityState<'EmailIdentity>, value: string) : DataAwsSesv2EmailIdentityState<'EmailIdentity> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSesv2EmailIdentityState<'EmailIdentity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_email_identity#tags-1">DataAwsSesv2EmailIdentity#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsSesv2EmailIdentityState<'EmailIdentity>, value: seq<string * string>) : DataAwsSesv2EmailIdentityState<'EmailIdentity> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsSesv2EmailIdentityState<'EmailIdentity>

        member _.Run(state: DataAwsSesv2EmailIdentityState<Present>) : aws.DataAwsSesv2EmailIdentity.DataAwsSesv2EmailIdentity =
            let config = aws.DataAwsSesv2EmailIdentity.DataAwsSesv2EmailIdentityConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSesv2EmailIdentity.DataAwsSesv2EmailIdentity(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSesv2EmailIdentity: missing required arguments. Must call: email_identity.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSesv2EmailIdentityState<_>) : aws.DataAwsSesv2EmailIdentity.DataAwsSesv2EmailIdentity =
            Unchecked.defaultof<aws.DataAwsSesv2EmailIdentity.DataAwsSesv2EmailIdentity>
