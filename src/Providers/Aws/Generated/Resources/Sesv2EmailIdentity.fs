namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Sesv2EmailIdentityState<'EmailIdentity> = { assignments: ResizeArray<aws.Sesv2EmailIdentity.Sesv2EmailIdentityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity">aws_sesv2_email_identity</a>.
    /// </summary>
    type Sesv2EmailIdentityBuilder(logicalId: string) =
        member _.Yield(_: unit) : Sesv2EmailIdentityState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2EmailIdentityState<Missing>)

        member _.Zero(()) : Sesv2EmailIdentityState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2EmailIdentityState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#email_identity-1">Sesv2EmailIdentity#email_identity</a>.
        /// </summary>
        [<CustomOperation "email_identity">]
        member _.EmailIdentity(state: Sesv2EmailIdentityState<Missing>, value: string) : Sesv2EmailIdentityState<Present> =
            state.assignments.Add(fun config -> config.EmailIdentity <- value)
            ({ assignments = state.assignments } : Sesv2EmailIdentityState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#configuration_set_name-1">Sesv2EmailIdentity#configuration_set_name</a>.
        /// </summary>
        [<CustomOperation "configuration_set_name">]
        member _.ConfigurationSetName(state: Sesv2EmailIdentityState<'EmailIdentity>, value: string) : Sesv2EmailIdentityState<'EmailIdentity> =
            state.assignments.Add(fun config -> config.ConfigurationSetName <- value)
            state : Sesv2EmailIdentityState<'EmailIdentity>

        /// <summary>
        /// dkim_signing_attributes block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#dkim_signing_attributes-1">Sesv2EmailIdentity#dkim_signing_attributes</a>
        /// </summary>
        [<CustomOperation "dkim_signing_attributes">]
        member _.DkimSigningAttributes(state: Sesv2EmailIdentityState<'EmailIdentity>, value: aws.Sesv2EmailIdentity.Sesv2EmailIdentityDkimSigningAttributes) : Sesv2EmailIdentityState<'EmailIdentity> =
            state.assignments.Add(fun config -> config.DkimSigningAttributes <- value)
            state : Sesv2EmailIdentityState<'EmailIdentity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#id-1">Sesv2EmailIdentity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Sesv2EmailIdentityState<'EmailIdentity>, value: string) : Sesv2EmailIdentityState<'EmailIdentity> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Sesv2EmailIdentityState<'EmailIdentity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#tags-1">Sesv2EmailIdentity#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Sesv2EmailIdentityState<'EmailIdentity>, value: seq<string * string>) : Sesv2EmailIdentityState<'EmailIdentity> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Sesv2EmailIdentityState<'EmailIdentity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#tags_all-1">Sesv2EmailIdentity#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Sesv2EmailIdentityState<'EmailIdentity>, value: seq<string * string>) : Sesv2EmailIdentityState<'EmailIdentity> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Sesv2EmailIdentityState<'EmailIdentity>

        member _.Run(state: Sesv2EmailIdentityState<Present>) : aws.Sesv2EmailIdentity.Sesv2EmailIdentity =
            let config = aws.Sesv2EmailIdentity.Sesv2EmailIdentityConfig()
            for setter in state.assignments do
                setter config
            aws.Sesv2EmailIdentity.Sesv2EmailIdentity(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesv2EmailIdentity: missing required arguments. Must call: email_identity.", 9999, IsError = true)>]
        member _.Run(_: Sesv2EmailIdentityState<_>) : aws.Sesv2EmailIdentity.Sesv2EmailIdentity =
            Unchecked.defaultof<aws.Sesv2EmailIdentity.Sesv2EmailIdentity>
